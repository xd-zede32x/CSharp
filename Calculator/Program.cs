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

            int result = 0;

            result = Operation(_firstNumber, _secondNumber, result, userOperation);

            Console.Clear();

            Console.WriteLine($"Ваш ответ: {result}");
            Console.ReadKey();
        }

        private static int Operation(int firstNumber, int secondNumber, int result, string symbol)
        {
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
                    Console.WriteLine("Не распознанная операция");
                    break;
            }

            return result;
        }
    }
}