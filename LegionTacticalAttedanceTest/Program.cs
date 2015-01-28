using System;
using System.IO;
using System.Security.Permissions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

// OpenOfficeXML for stuff.
namespace LegionTacticalAttendance
{
    public class Tracker
    {        
        public static System.Collections.Generic.Dictionary<string, Member> attendees;        

        public static void Main()
        {
            StartTracker();
        }

        public static void StartTracker()
        {
            string[] args = System.Environment.GetCommandLineArgs();
            
            System.Console.WriteLine("--------------------------------------------------------");
            System.Console.ForegroundColor = ConsoleColor.Red;            
            System.Console.WriteLine("Legion Tactical Attendance Tracker\n");
            System.Console.ResetColor();
            System.Console.WriteLine("The Legion Tactical Attendance Tracker is used to read \nNetLog files form Arma 3 to determine player attendance.\n");
            System.Console.WriteLine("Developed by: Justin 'Imperator' Kirkwood");
            System.Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Press \"q\" to quit the sample.");
            
            while (Console.ReadKey().KeyChar != 'q') ;
        }

        private static void getLogFiles() 
        {
         
        }

        /* 
         * Planning the Project
         * ----------------
         * 
         * Parse the Log File
         * Array of Arrays [ [UID, Name, etc], [UID, Name, etc] ]
         * Helper Functions to write to .txt, .xlsx, and .csv
         * 
         * Nice To Have
         * -------------
         * Update a file every time this is run rather than keeping a bunch of different sources.
         * /
    }
}
/*
public class Watcher
{
    public static void Main()
    {
        Run();
    }

    [PermissionSet(SecurityAction.Demand, Name="FullTrust")]

    public static void Run()
    {
        string[] args = System.Environment.GetCommandLineArgs();

        // If a directory is not specified, exit program.        

        if(args.Length != 2)
        {
            // Display the proper way to call the program.
            Console.WriteLine("Usage: Watcher.exe (directory)");
            return;
        }       

        // Create a new FileSystemWatcher and set its Properties.
        FileSystemWatcher watcher = new FileSystemWatcher();
        watcher.Path = args[1];
        // Watch for changes in LastAccess and LastWrite times, and the renaming of files or directories
        watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
        // Only watch text files
        watcher.Filter = "*.txt";

        // Add Event Handlers
        watcher.Changed += new FileSystemEventHandler(OnChanged);
        //watcher.Created += new FileSystemEventHandler(OnChanged);
        //watcher.Deleted += new FileSystemEventHandler(OnChanged);
        watcher.Renamed += new RenamedEventHandler(OnRenamed);

        // Begin Watching
        watcher.EnableRaisingEvents = true;

        // Wait for the user to quit the program
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press \"q\" to quit the sample.");
        Console.ResetColor();
        while(Console.Read() != 'q');
    }

    // Define the Event Handlers 
    private static void OnChanged(object source, FileSystemEventArgs e)
    {
        // Specify what is done when a file is changed created or deleted.
        Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType + " " + e.Name);                
        string LastFileLine = File.ReadLines(e.FullPath).Last().ToString();        
        Console.WriteLine("Change: " + LastFileLine);
    }

    private static void OnRenamed(object source, RenamedEventArgs e)
    {
        // Specify what is done when a file is renamed
        Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
    }  
} */