using System;
using System.IO;

namespace RomanCSharp
{
    public class Program
    {
        private static void Main(string[] _)
        {
            string path = "C:\\Users\\Роман\\Desktop\\Learning\\Visual Studio 2022\\RomanCSharp\\RomanCSharp\\bin\\Debug\\Test.txt";
            FileRead(path);
        }

        private static void FileRead(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string convert = File.ReadAllText(path);
                    Console.WriteLine("Содержимое файла");
                    Console.WriteLine(convert);
                }

                catch (IOException exception)
                {
                    Console.WriteLine($"Ошибка при чтении файла: {exception.Message}");
                }
            }

            else
            {
                Console.WriteLine("Файла не существует!!!");
                return;
            }
        }
    }
}