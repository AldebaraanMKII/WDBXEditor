using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WDBXEditor.Storage;

namespace WDBXEditor.ConsoleHandler
{
    public static class ConsoleManager
    {
        public static bool ConsoleMode { get; set; } = false;

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        public static Dictionary<string, HandleCommand> CommandHandlers = new Dictionary<string, HandleCommand>();
        public delegate void HandleCommand(string[] args);

        public static void ConsoleMain(string[] args)
        {
            if (AttachConsole(-1))
            {
                // Redirect stdout to console
                var standardOutput = new System.IO.StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);

                var standardError = new System.IO.StreamWriter(Console.OpenStandardError());
                standardError.AutoFlush = true;
                Console.SetError(standardError);
            }

            Console.WriteLine("Loading definitions...");
            Database.LoadDefinitions().Wait();

            if (CommandHandlers.ContainsKey(args[0].ToLower()))
                InvokeHandler(args[0], args.Skip(1).ToArray());
        }

        public static bool InvokeHandler(string command, params string[] args)
        {
            try
            {
                command = command.ToLower();
                if (CommandHandlers.ContainsKey(command))
                {
                    CommandHandlers[command].Invoke(args);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex is AggregateException age)
                {
                    foreach (var inner in age.InnerExceptions)
                        Console.WriteLine("   " + inner.Message);
                }
                else if (ex.InnerException != null)
                {
                    Console.WriteLine("   " + ex.InnerException.Message);
                }

                Console.WriteLine("");
                return false;
            }
        }

        public static void LoadCommandDefinitions()
        {
            //Argument commands
            //DefineCommand("-console", ConsoleManager.LoadConsoleMode);
            DefineCommand("-export", ConsoleCommands.ExportArgCommand);
            DefineCommand("-sqldump", ConsoleCommands.SqlDumpArgCommand);
            DefineCommand("-extract", ConsoleCommands.ExtractCommand);
            DefineCommand("-import", ConsoleCommands.ImportArgCommand);
        }

        /// <summary>
        /// Converts args into keyvalue pair
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ParseCommand(string[] args)
        {
            Dictionary<string, string> keyvalues = new Dictionary<string, string>();
            for (int i = 0; i < args.Length; i++)
            {
                string key = args[i].ToLower();
                if (!key.StartsWith("-")) continue;

                string value = string.Empty;
                if (i + 1 < args.Length && !args[i + 1].StartsWith("-"))
                {
                    value = args[++i];
                    if (value.Length >= 2 && value[0] == '"' && value[value.Length - 1] == '"')
                        value = value.Substring(1, value.Length - 2);
                }

                keyvalues[key] = value;
            }

            return keyvalues;
        }

        private static void DefineCommand(string command, HandleCommand handler)
        {
            CommandHandlers[command.ToLower()] = handler;
        }
    }
}
