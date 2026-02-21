# WDBX Editor

### About
This is a program made with C# .NET Framework 4.6.1 used to edit World of Warcraft DBC files.

# Features:
    Full support of release versions of DBC, DB2, WDB, ADB and DBCache (WCH3 and WCH4 are not supported as I deem them depreciated)
    Supports being the default file assocation
    Opening and having open multiple files regardless of type and build
    Open DBC/DB2 files from both MPQ archives and CASC directories
    Save single (to file) and save all (to folder)
    Standard CRUD operations as well as go to, copy row, paste row, undo and redo
    Hide, show, hide empty and sort columns
    A relatively powerful column filter system (similar to boolean search)
    Displaying and editing columns in hex (numeric columns only)
    Exporting to a SQL database, SQL file, CSV file and MPQ archives
    Importing from a SQL database and a CSV file
    An Excel style Find and Replace
    Shortcuts for common tasks using common shortcut key combinations
    A help file to try and cover off some of the pitfalls and caveats of the program (needs some work)
    A simple memory reader to get player's co-ordinates from the client
    A colour picker for LightData and LightIntBand

# Tools:
    Definition editor for maintaining the definitions
    WotLK Item Import to remove the dreaded red question mark from custom items
    Legion Parser which is an attempt to automatically parse the structure of WDB5 and WDB6 files



Latest build is located in "WDBXEditor\bin\Debug" folder.
The definition file for build 12340 is in "WDBXEditor\bin\Debug\Definitions\WotLK 3.3.5 (12340).xml".



# What was done previously:
& "C:\Users\Antares\Documents\Github\WDBXEditor\WDBXEditor\bin\Debug\WDBX Editor.exe" -import -f "C:\Users\Antares\Desktop\Mounts Work\DBC Azerothcore\SpellIcon.dbc" -b 12340 -c "C:\Users\Antares\Desktop\Mounts Work\DBC Azerothcore\SpellIcon.csv" -h true -u Update -i FixIds

Using the command above to import a CSV data into a DBC file does not work, even though the program is supposed to have feature.
Opening the SpellIcon.dbc in the GUI and importing the CSV manually works perfectly.

the files responsible for this are:
WDBXEditor\ConsoleHandler\ConsoleCommands.cs
WDBXEditor\ConsoleHandler\ConsoleManager.cs













