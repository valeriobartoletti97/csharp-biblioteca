using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace csharp_biblioteca
{
    public class Library
    {

    }
    public class User : Library
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        private string Password { get;  set; }
        public uint Telephone { get; private set; }

        public User(string name, string surname, string email, string password, uint telephone)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Telephone = telephone;
            Console.WriteLine($"Utente: {this.Name} {this.Surname}");
        }
    }
    public class Document : Library
    {
        public int Code { get; private set; }
        public string Title { get;  set; }
        public int Year { get; set; }   
        public string Theme { get; set; }
        public string Section { get; set; }
        public string Author { get; set; }

        public Document(string title, int year, string theme, string section, string author)
        {
            Thread.Sleep(1);
            System.Random rand = new System.Random();
            this.Code = rand.Next(0,100000);
            this.Title = title;
            this.Year = year;
            this.Theme = theme;
            this.Section = section;
            this.Author = author;
        }
    }
    public class Book : Document
    {
        public Book(string title, int year, string theme, string section, string author, int pages) : base(title, year, theme, section, author)
        {
            this.Pages = pages;
            Console.WriteLine($"Libro: {this.Title}");
        }

        public int Pages { get; set; }
    }

    public class Dvd : Document
    {
        public decimal DurationInHours { get; set; }
        public Dvd(string title, int year, string theme, string section, string author, decimal duration) : base(title, year, theme, section, author)
        {
            this.DurationInHours = (decimal)duration;
            Console.WriteLine($"DVD: {this.Title}");
        }
    }
}
