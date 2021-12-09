using System;

namespace ConsoleAppBook
{
    class Book
    {
        private string title; // назва (заголовок) книги
        private string author; // прізвище й ім'я автора
        private double price; // вартість книги

        public Book(string _title, string _author, double _price)
        {
            title = _title;
            author = _author;

            // корегування вартості книги
            if (price < 0) price = 0.0;
            else price = _price;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Title - 01", "Author - 01", 122.25);
        }
    }
}
