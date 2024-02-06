using System;
using System.Collections.Generic;

namespace RomanCSharp
{
    public class Program
    {
        public static List<User> usersDataBase = new List<User>();

        private static void Main(string[] args)
        {

            bool isRun = true;

            while (isRun)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Список команд: (1 - Exit) (2 - CreateUser) (3 - ShowUsers) (4 - Login)");

                Console.Write("\nВведите команду: ");
                string userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case "Exit":
                        isRun = false;
                        break;

                    case "CreateUser":
                        Console.Clear();
                        usersDataBase.Add(CreateUserDialog());
                        break;

                    case "ShowUsers":
                        Console.Clear();
                        foreach (var users in usersDataBase)
                        {
                            Console.WriteLine(users.Name);
                        }
                        break;

                    case "Login":
                        Console.Clear();
                        LoginUserDialog();
                        break;

                    default:
                        Console.WriteLine("Введена неверная информация");
                        break;
                }

                Console.ResetColor();
                Console.ReadKey();
            }
        }

        private static User CreateUserDialog()
        {
            User newUser = new User();
            Console.Write("Введите имя: ");
            newUser.Name = Console.ReadLine();

            Console.Write("Введите пароль: ");
            newUser.Password = Console.ReadLine();

            Console.Write("Введите возраст: ");
            newUser.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВаш аккаунт успешно создан " + newUser.Name);

            return newUser;
        }

        private static User LoginUserDialog()
        {
            User loginUser = new User();

            Console.Write("Введите имя: ");
            loginUser.Name = Console.ReadLine();

            Console.Write("Введите пароль: ");
            loginUser.Password = Console.ReadLine();

            for (int index = 0; index < usersDataBase.Count; index++)
            {
                if (loginUser.Name == usersDataBase[index].Name)
                {
                    if (loginUser.Password == usersDataBase[index].Password)
                    {
                        Console.WriteLine("Да такой аккаунт найден");
                        Console.WriteLine("С именем " + loginUser.Name);
                        break;
                    }

                    else
                        Console.WriteLine("Такого пароля не существует");
                }

                else
                    Console.WriteLine("Нет такого имени не существует");
            }

            return loginUser;
        }
    }
}