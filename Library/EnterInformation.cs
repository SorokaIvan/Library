using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class EnterInformation
    {
        public void EnterBookTake(List<Book> books)
        {
            bool value = false;

            while (value == false)
            {
                Console.WriteLine();
                Console.Write("Введите свое имя:");
                string studentName = Console.ReadLine();
                Console.Write("Введите автора книги:");
                string author = Console.ReadLine();
                Console.Write("Введите название книги:");
                string nameBook = Console.ReadLine();
                

                foreach (var i in books)
                {
                    if (author == i.Author && nameBook == i.NameBook)
                    {
                        i.StudentName = studentName;
                        i.TakeBook(i);
                        value = true;
                    }
                }
                if (value == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Такой книги нет в библиотеке, либо вы совершили синтаксическую ошибку!");
                    Console.WriteLine("Нажмите Enter, что бы попробовать еще раз...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Книга удачна выдана студенту - {studentName}");
                    Console.WriteLine("Нажмите Enter, что бы продолжить...");
                    Console.ReadKey();
                }
            }
        }

        public void EnterBookReturn(List<Book> books)
        {
            bool value = false;

            while (value == false)
            {
                Console.WriteLine();
                Console.Write("Введите автора книги:");
                string author = Console.ReadLine();
                Console.Write("Введите название книги:");
                string nameBook = Console.ReadLine();

                foreach (var i in books)
                {
                    if (author == i.Author && nameBook == i.NameBook)
                    {
                        i.ReturnBook(i);
                        value = true;
                    }
                }
                if (value == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Такой книги нет в библиотеке, либо вы совершили синтаксическую ошибку!");
                    Console.WriteLine("Нажмите Enter, что бы попробовать еще раз...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Книга возвращена в библиотеку.");
                    Console.WriteLine("Нажмите Enter, что бы продолжить...");
                    Console.ReadKey();
                }
            }

        }

        public void EnterBookAdd()
        {
            Book book = new Book();
            Console.WriteLine();
            Console.Write("Введите автора книги:");
            book.Author = Console.ReadLine();
            Console.Write("Введите название книги:");
            book.NameBook = Console.ReadLine();

            book.AddBook(book);

            Console.WriteLine();
            Console.WriteLine("Вы удачно добавили книгу в нашу библиотеку.");
            Console.WriteLine("Нажмите Enter, что бы продолжить...");
            Console.ReadKey();
        }


    }
}
