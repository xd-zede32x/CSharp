using System;

namespace RomanSharp
{
    public class Program
    {
        private static int _firstNumber = 0;
        private static int _secondNumber = 0;

        private static void Main(string[] args)
        {
            Console.Title = "Калькулятор";
            Console.WriteLine("Доступные операции: (-) || (+) || (/) || (*)");

            Console.Write("Выберете операцию над числами: ");
            string userOperation = Console.ReadLine();

            Console.Clear();

            Console.Write("Введите первое число: ");
            string firstNumber = Console.ReadLine();

            if (int.TryParse(firstNumber, out int operationNumberOne))
                _firstNumber = operationNumberOne;

            else
            {
                Console.WriteLine("Введена неверная строка. Повторите попытку");
                return;
            }
            
            Console.Write("Введите второе число: ");
            string secondNumber = Console.ReadLine();

            if (int.TryParse(secondNumber, out int operationNumberTwo))
                _secondNumber = operationNumberTwo;

            else
            {
                Console.WriteLine("Введена неверная строка. Повторите попытку");
                return;
            }

            Console.Clear();

            Operation(_firstNumber, _secondNumber, userOperation);

            Console.ReadKey();
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
                    result = 0;
                    Console.WriteLine("Не распознанная операция");
                    break;
            }

            Console.WriteLine($"Ваш ответ: {result}");
            return result;
        }
    }
}