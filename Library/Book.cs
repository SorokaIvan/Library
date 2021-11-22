using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace Library
{
    public class Book
    {
        public string Author;
        public string NameBook;
        public bool IsTaked;
        public string StudentName;

        public void TakeBook(Book book)
        {
            NpgsqlConnection connection = new NpgsqlConnection("User ID=user1;Password=changeme;Host=178.154.198.196;Port=5432;Database=tododb;");
            try
            {
                connection.Query($"update \"LibraryBooks\" set \"IsTaked\" = '{true}', \"StudentName\" = '{book.StudentName}' where \"Author\" = '{book.Author}' and \"NameBook\" = '{book.NameBook}'"); ;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public void ReturnBook(Book book)
        {
            NpgsqlConnection connection = new NpgsqlConnection("User ID=user1;Password=changeme;Host=178.154.198.196;Port=5432;Database=tododb;");
            try
            {
                connection.Query($"update \"LibraryBooks\" set \"IsTaked\" = '{false}', \"StudentName\" = '{null}' where \"Author\" = '{book.Author}' and \"NameBook\" = '{book.NameBook}'"); ;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public void AddBook(Book book)
        {
            NpgsqlConnection connection = new NpgsqlConnection("User ID=user1;Password=changeme;Host=178.154.198.196;Port=5432;Database=tododb;");
            try
            {
                connection.Query($"insert into \"LibraryBooks\" (\"Author\", \"NameBook\", \"IsTaked\", \"StudentName\") values ('{book.Author}', '{book.NameBook}', '{false}', '{null}')");
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
