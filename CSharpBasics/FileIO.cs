using System;
using System.IO;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText("Test.txt");
            Console.WriteLine(fileContent);
        }

        public void LearnFileWritting()
        {
            File.WriteAllText("A.html", "I am new file just created.");
        }
        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"File size: {x} bytes");
            Console.WriteLine($"Created: {y} ");
            Console.WriteLine($"Directory: {z}");
        }

        public void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\susan.shrestha", "This is my own file.");
        }

        public void LearnDirectoryInfo()
        {
            string folderPath = @"D:\Study\.net practice\CSharpBasics";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine($"File count: {files}");
        }
      
    }
}