using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private static bool _colorSupported = false;

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, ushort wAttributes);

        const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;
        const ushort ATTR_GREEN = 10;
        const ushort ATTR_RED = 12;
        const ushort ATTR_DEFAULT = 7;
        const uint GENERIC_READ = 0x80000000;
        const uint GENERIC_WRITE = 0x40000000;
        const uint FILE_SHARE_WRITE = 0x00000002;
        const uint OPEN_EXISTING = 3;

        public static Dictionary<string, HandleCommand> CommandHandlers = new Dictionary<string, HandleCommand>();
        public delegate void HandleCommand(string[] args);

        public static void ConsoleMain(string[] args)
        {
            if (AttachConsole(-1))
            {
                var standardOutput = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
                Console.SetOut(standardOutput);

                var standardError = new StreamWriter(Console.OpenStandardError()) { AutoFlush = true };
                Console.SetError(standardError);

                var conHandle = CreateFile("CONOUT$", GENERIC_READ | GENERIC_WRITE,
                    FILE_SHARE_WRITE, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                if (conHandle != IntPtr.Zero && conHandle != new IntPtr(-1))
                {
                    if (GetConsoleMode(conHandle, out uint mode))
                    {
                        SetConsoleMode(conHandle, mode | ENABLE_VIRTUAL_TERMINAL_PROCESSING);
                        _colorSupported = true;
                    }
                    CloseHandle(conHandle);
                }
            }

            Console.WriteLine("Loading definitions...");
            Database.LoadDefinitions().Wait();

            if (CommandHandlers.ContainsKey(args[0].ToLower()))
                InvokeHandler(args[0], args.Skip(1).ToArray());
        }

        public static void WriteSuccess(string message)
        {
            if (_colorSupported)
            {
                Console.Out.Write($"\x1b[32m{message}\x1b[0m\n");
            }
            else
            {
                var conHandle = CreateFile("CONOUT$", GENERIC_WRITE, FILE_SHARE_WRITE,
                    IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                if (conHandle != IntPtr.Zero && conHandle != new IntPtr(-1))
                {
                    SetConsoleTextAttribute(conHandle, ATTR_GREEN);
                    Console.Out.WriteLine(message);
                    Console.Out.Flush();
                    SetConsoleTextAttribute(conHandle, ATTR_DEFAULT);
                    CloseHandle(conHandle);
                    return;
                }
                Console.Out.WriteLine(message);
            }
            Console.Out.Flush();
        }

        public static void WriteError(string message)
        {
            if (_colorSupported)
            {
                Console.Error.Write($"\x1b[31m{message}\x1b[0m\n");
            }
            else
            {
                var conHandle = CreateFile("CONOUT$", GENERIC_WRITE, FILE_SHARE_WRITE,
                    IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                if (conHandle != IntPtr.Zero && conHandle != new IntPtr(-1))
                {
                    SetConsoleTextAttribute(conHandle, ATTR_RED);
                    Console.Error.WriteLine(message);
                    Console.Error.Flush();
                    SetConsoleTextAttribute(conHandle, ATTR_DEFAULT);
                    CloseHandle(conHandle);
                    return;
                }
                Console.Error.WriteLine(message);
            }
            Console.Error.Flush();
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
                WriteError(ex.Message);
                if (ex is AggregateException age)
                {
                    foreach (var inner in age.InnerExceptions)
                        WriteError("   " + inner.Message);
                }
                else if (ex.InnerException != null)
                {
                    WriteError("   " + ex.InnerException.Message);
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
