using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Npgsql;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
           
            NpgsqlConnection connection = new NpgsqlConnection("User ID=user1;Password=changeme;Host=178.154.198.196;Port=5432;Database=tododb;");

            try
            {
                
                Console.WriteLine("Добро пожаловать в нашу консольную библиотеку!");
                
                
                while (true)
                {
                    List<Book> books = new List<Book>();
                    books = connection.Query<Book>($"SELECT * FROM \"LibraryBooks\"").ToList();

                    Console.WriteLine();
                    Console.WriteLine("Выберете вариант дейстивй:");
                    Console.WriteLine();
                    Console.WriteLine("1. Посмотреть доступные книги в библиотеке.");
                    Console.WriteLine("2. Посмотреть какие книги на руках у студентов.");
                    Console.WriteLine("3. Взять книгу.");
                    Console.WriteLine("4. Вернуть книгу.");
                    Console.WriteLine("5. Добавить книгу в нашу библиотеку.");
                    Console.WriteLine("6. Выйти.");

                    int value = Convert.ToInt32(Console.ReadLine());
                    PrintInformation print = new PrintInformation();
                    EnterInformation enter = new EnterInformation();

                    if (value == 1)
                    {
                        print.PrintBooksAvailable(books);
                    }
                    if (value == 2)
                    {
                        print.PrintBooksBusy(books);
                    }
                    if (value == 3)
                    {
                        enter.EnterBookTake(books);
                    }
                    if (value == 4)
                    {
                        enter.EnterBookReturn(books);
                    }
                    if (value == 5)
                    {
                        enter.EnterBookAdd();
                    }
                    if (value == 6)
                    {
                        break;
                    }
                    if(value > 6)
                    {
                        Console.WriteLine("Вы ввели неправильное число!");
                        Console.WriteLine("Нажмите Enter, что бы попробовать еще раз...");
                        Console.ReadKey();
                    }
                }
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
