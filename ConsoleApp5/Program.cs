using System;
using System.Collections.Generic;
namespace ConsoleApp4
{
    class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        private bool isAvailable = true;
        public void BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine(Title + " kitabı götürüldü.");
            }
            else
            {
                Console.WriteLine(Title + " kitabı artıq götürülüb.");
            }
        }
        public void ReturnBook()
        {
            isAvailable = true;
            Console.WriteLine(Title + " kitabı qaytarıldı.");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Kitab: " + Title);
            Console.WriteLine("Muellif: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Mövcuddur: " + isAvailable);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> kitabxana = new List<Book>();

            kitabxana.Add(new Book
            {
                Title = "Tutunamayanlar",
                Author = "Oğuz Atay",
                ISBN = "1111111111"
            });

            kitabxana.Add(new Book
            {
                Title = "Huzur",
                Author = "Ahmet Hamdi Tanpınar",
                ISBN = "2222222222"
            });

            kitabxana.Add(new Book
            {
                Title = "Sefiller",
                Author = "Victor Hugo",
                ISBN = "3333333333"
            });

            kitabxana.Add(new Book
            {
                Title = "İblis",
                Author = "Hüseyn Cavid",
                ISBN = "4444444444"
            });

            kitabxana.Add(new Book
            {
                Title = "Qetl günü",
                Author = "Yusif Semedoglu",
                ISBN = "5555555555"
            });
            kitabxana[0].BorrowBook();
            kitabxana[1].BorrowBook();

            Console.WriteLine("\nKitabxananın veziyyeti:");

            foreach (Book kitab in kitabxana)
            {
                kitab.ShowInfo();
            }
        }
    }
}