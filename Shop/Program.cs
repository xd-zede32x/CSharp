using System;

namespace Vending_machine_with_foods
{
    public class Program
    {
        private static int _userMoneyCards = 89;
        private static int _userMoneyCash = 48;
        private static int _userAnswerProduct = 0;

        private static ProductInfo[] _productsInfo = new ProductInfo[]
        {
               new ProductInfo("Яблоко", 10),
               new ProductInfo("Батончик", 5),
               new ProductInfo("Кофе", 7),
               new ProductInfo("Шоколад", 8),
               new ProductInfo("Рис", 2),
               new ProductInfo("Презервативы", 20),
               new ProductInfo("Духи", 25),
        };

        private static void Main(string[] args)
        {
            Console.Title = "Автомат с продуктами";
            Console.ForegroundColor = ConsoleColor.Yellow;

            DisplayBalance();

            Console.Write("\n\tВы подошли к аппарату вы что то хотите приобрести да/нет: ");

            if (Console.ReadLine().ToLower() != "да")
                return;

            DisplayProducts(_productsInfo);

            Console.Write("\n\tВыберете номер продукта который хотите купить: ");

            while (!int.TryParse(Console.ReadLine(), out _userAnswerProduct) || _userAnswerProduct < 1 || _userAnswerProduct > _productsInfo.Length)
            {
                Console.WriteLine("\nНекорректный ввод.Попробуйте снова");
                Console.Write("Выберете номер: ");
            }

            _userAnswerProduct -= 1;

            Console.WriteLine($"\nВы выбрали продукт: {_productsInfo[_userAnswerProduct].Name}");

            PaymentOperation();
            DisplayBalance();

            Console.ReadKey();
            Console.Clear();
        }

        private static void DisplayBalance()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Ваш баланс карты составляет: {_userMoneyCards}$\tВаш баланс налички составляет: {_userMoneyCash}$");
        }

        private static void DisplayProducts(ProductInfo[] productInfo)
        {
            Console.WriteLine("\nСписок продуктов:\n");

            for (int index = 0; index < productInfo.Length; index++)
                Console.WriteLine($"{index + 1} - {productInfo[index].Name}, Цена: {productInfo[index].Price}$");
        }

        private static void PaymentOperation()
        {
            Console.Write("Оплата Картой или Наличкой: ");

            PaymentType paymentType;

            while (!Enum.TryParse(Console.ReadLine(), true, out paymentType))
            {
                Console.WriteLine("\nНекорректный ввод.Попробуйте снова.Введите 'Картой' или 'Наличкой'");
                Console.WriteLine("Оплата картой или наличкой: ");
            }

            int price = _productsInfo[_userAnswerProduct].Price;

            switch (paymentType)
            {
                case PaymentType.Картой:
                    _userMoneyCards -= price;
                    break;

                case PaymentType.Наличной:
                    _userMoneyCash -= price;
                    break;

                default:
                    Console.WriteLine("\nНекорректный ввод.Попробуйте снова.");
                    break;
            }
        }
    }
}