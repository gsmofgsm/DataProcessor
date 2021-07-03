using System;
using static System.Console;

namespace DataProcessor
{
    internal class FileProcessor
    {
        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        public string InputFilePath { get; }

        public void Process()
        {
            WriteLine($"Begin process of {InputFilePath}");
        }
    }
}