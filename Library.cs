using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Refresh
{
    public class Library
    {
        public Book Checkout(string title, string author)
        {
            var random = new Random();
            return new Book
            {
                Title = title,
                ISBN = random.Next().ToString(),
                Author = author,
                Pages = random.Next(10, 1000)
            };
        }

        public void CheckIn(Computing computing)
        {
            Thread.Sleep(10);
            Console.WriteLine("Computing was checked back in");
        }
    }
}