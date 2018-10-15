using System;


namespace Language_Integrated_Query_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int WithForegroundColor = 1;
            string s = "";
            BusinessLogic businessLogic = new BusinessLogic();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Список пользователей: ");
            foreach (var user in businessLogic.users)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("---------------------------------------------------------------------");


            Console.WriteLine("Список реплик: ");
            foreach (var record in businessLogic.records)
            {
                Console.WriteLine(record);
            }
            Console.WriteLine("---------------------------------------------------------------------");


            PrintTasks(WithForegroundColor);

            do
            {
                s = Console.ReadLine();
                if (s == "0")
                {
                    Console.WriteLine("Введите фамилию: ");
                    foreach (var user in businessLogic.GetUsersBySurname(Console.ReadLine()))
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "1")
                {
                    Console.WriteLine("Введите ID: ");
                    Console.WriteLine(businessLogic.GetUserByID(Int32.Parse(Console.ReadLine())));
                    Console.WriteLine();
                }

                else if (s == "2")
                {
                    Console.WriteLine("Введите подстроку: ");
                    foreach (var user in businessLogic.GetUsersBySubstring(Console.ReadLine()))
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "3")
                {
                    foreach (var user in businessLogic.GetAllUniqueNames())
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "4")
                {
                    foreach (var user in businessLogic.GetAllAuthors())
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "5")
                {
                    foreach (var elem in businessLogic.GetUsersDictionary())
                    {
                        Console.WriteLine(elem);
                    }
                    Console.WriteLine();
                }

                else if (s == "6")
                {
                    Console.WriteLine(businessLogic.GetMaxID());
                    Console.WriteLine();
                }

                else if (s == "7")
                {
                    foreach (var user in businessLogic.GetOrderedUsers())
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "8")
                {
                    foreach (var user in businessLogic.GetDescendingOrderedUsers())
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "9")
                {
                    foreach (var user in businessLogic.GetReversedUsers())
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "10")
                {
                    Console.WriteLine("Номер страницы:");
                    int pageIndex = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Размер страницы:");
                    int pageSize = Int32.Parse(Console.ReadLine());

                    foreach (var user in businessLogic.GetUsersPage(pageSize, pageIndex))
                    {
                        Console.WriteLine(user);
                    }
                    Console.WriteLine();
                }

                else if (s == "11")
                {
                    WithForegroundColor++;
                    Console.WriteLine();
                }

                else if (s == "12")
                    break;

                PrintTasks(WithForegroundColor);
            } while (true);

            Console.ReadLine();
        }

        public static void PrintTasks(int color)
        {
            if (color % 2 == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("0: Получение пользователя по фамилии");
            Console.WriteLine("1: Получение пользователя по ID");
            Console.WriteLine("2: Получение пользователей по подстроке");
            Console.WriteLine("3: Получение пользователей по уникальным именам");
            Console.WriteLine("4: Получение пользователей, у которых есть сообщения");
            Console.WriteLine("5: Сделать словарь пользователей");
            Console.WriteLine("6: Максимальное значение ID");
            Console.WriteLine("7: Отсортированный список пользователей по имени");
            Console.WriteLine("8: Обратно отсортированный список пользователей по имени");
            Console.WriteLine("9: Отсортированный и реверсный список пользователей по имени");
            Console.WriteLine("10: Пейджинг");
            Console.WriteLine("11: Сменить цвет меню на голубой/зеленый");
            Console.WriteLine("12: Выйти из программы");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
