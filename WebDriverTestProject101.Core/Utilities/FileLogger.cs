using System;
using System.IO;
using System.Reflection;

namespace WebDriverTestProject101.Core.Utilities
{
    public class FileLogger: ILogger
    {
        private static readonly string AssemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private readonly string _filePath;
        private readonly string WORKSPACE_DIRECTORY = Path.GetFullPath(".");

        public void CreateLogEntry(string errorMessage)
        {
            File.WriteAllText(@"D:exceptions.txt", errorMessage);
        }

        public FileLogger(string testName, string filePath)
        {
            _filePath = filePath;

            using var log = File.CreateText(_filePath);
            log.WriteLine($"Starting timestamp: {DateTime.Now.ToLocalTime()}");
            log.WriteLine($"Running Test: {testName}");
            log.WriteLine($"------------------------------------------------");
        }

        public void Info(string message) => WriteLine($"[INFO] {message}");
        public void Action(string message)
        {
            WriteLine($"    [ACTION] {message}");
            WriteLine($"    --------------------------------------------");
        }
        public void Step(string message) => WriteLine($"        [STEP] {message}");
        public void Command(string message) => WriteLine($"         [COMMAND] {message}");
        public void Warning(string message) => WriteLine($"[WARNING] {message}");
        public void Error(string message) => WriteLine($"[ERROR] {message}");
        public void Fatal(string message) => WriteLine($"[FATAL] {message}");

        private void WriteLine(string text)
        {
            using var log = File.AppendText(_filePath);
            Console.WriteLine(text);
            log.WriteLine(text);
        }


    }
}
