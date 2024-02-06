using System;

namespace RomanSharp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Калькулятор";

            string userInputExit = string.Empty;

            while (!userInputExit.ToLower().Contains("exit"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Доступные операции: (-) || (+) || (/) || (*)");

                Console.Write("Выберете операцию над числами: ");
                string userOperation = Console.ReadLine();

                Console.Clear();

                Console.Write("Введите первое число: ");
                string firstNumber = Console.ReadLine();

                if (int.TryParse(firstNumber, out int operationNumberOne))
                    _ = operationNumberOne.ToString();

                else
                    Error();

                Console.Write("Введите второе число: ");
                string secondNumber = Console.ReadLine();

                if (int.TryParse(secondNumber, out int operationNumberTwo))
                    _ = operationNumberTwo.ToString();

                else
                    Error();

                Console.Clear();

                Operation(operationNumberOne, operationNumberTwo, userOperation);

                Console.WriteLine(@"Хотите ли вы повторить программу: ({ yes || exit })");
                userInputExit = Console.ReadLine();

                Console.Clear();
            }
        }

        private static int Operation(int firstNumber, int secondNumber, string symbol)
        {
            int result;

            switch (symbol)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    result = firstNumber / secondNumber;
                    break;

                default:
                    Console.WriteLine("Перезагрузите программу");
                    result = 0;
                    break;
            }

            Console.WriteLine($"Ваш ответ: {result}");
            return result;
        }

        private static void Error()
        {
            Console.WriteLine("Введена неверная строка. Повторите попытку");
            return;
        }
    }
}