using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace Library
{
    public class PrintInformation
    {

        public void PrintBooksAvailable(List<Book> books)
        {
            Console.WriteLine();
            Console.WriteLine("Доступные книги в нашей библиотеке:");
            Console.WriteLine();
            foreach (var i in books)
            {
                if (i.IsTaked == false)
                {
                    Console.Write($"Автор: {i.Author}\t Название: {i.NameBook}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter, что бы продолжить...");
            Console.ReadKey();
        }

        public void PrintBooksBusy(List<Book> books)
        {
            Console.WriteLine();
            Console.WriteLine("Книги, которые взяли студенты:");
            Console.WriteLine();
            foreach (var i in books)
            {
                if (i.IsTaked == true)
                {
                    Console.Write($"Автор: {i.Author}\t Название: {i.NameBook}\t Студент: {i.StudentName}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter, что бы продолжить...");
            Console.ReadKey();
        }
    }
}
