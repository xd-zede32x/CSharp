namespace FileCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users;

            if (File.Exists("Name.txt"))
            {
                Console.WriteLine(@"Хотите ли вы загрузить данный файл Name.txt Yes\No");

                if (Console.ReadLine() == "Yes")
                {
                    users = File.ReadAllLines("Name.txt");

                    Console.Clear();

                    foreach (var user in users)
                    {
                        Console.WriteLine(user);
                    }

                    Console.WriteLine("\nФайл прочитан!");
                    return;
                }

                else
                {
                    users = CreateNames();
                }
            }

            else
            {
                users = CreateNames();
            }

            Console.Clear();

            for (int index = 0; index < users.Length; index++)
            {
                Console.WriteLine(users[index]);
            }

            Console.Clear();

            Console.Write("\nХотите ли сохранить эти имена в файл: Yes\\No: ");

            if (Console.ReadLine() == "Yes")
            {
                File.WriteAllLines("Name.txt", users);
                Console.WriteLine("Данные сохранены!");
            }

            else
            {
                Console.WriteLine("Сохранения не будет засчитано!");
                return;
            }
        }

        private static string[] CreateNames()
        {
            Console.Write("Сколько имён вы хотите добавить в массив: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            string[] result = new string[sizeArray];

            for (int index = 0; index < result.Length; index++)
            {
                Console.Clear();
                Console.Write($"Введите значения для имени [{index}]: ");
                result[index] = Console.ReadLine();
            }

            return result;
        }
    }
}