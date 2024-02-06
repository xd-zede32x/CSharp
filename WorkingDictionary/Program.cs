using System;
using System.Collections.Generic;

namespace RomanCSharp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var userData = GetUserData();
            Console.WriteLine($"Здравствуйте: {userData["Name"]}, Ваш возраст: {userData["Age"]}, Ваш пол: {userData["Sex"]}");

            Console.ReadKey();
        }

        private static Dictionary<string, string> GetUserData()
        {
            var outDictionary = new Dictionary<string, string>();
            Console.WriteLine("Введите свои данные: ");

            outDictionary.Add("Name", Console.ReadLine());
            outDictionary.Add("Age", Console.ReadLine());
            outDictionary.Add("Sex", Console.ReadLine());

            return outDictionary;
        }
    }
}