using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    public class Book : IBook
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            base.ToString();
            return $"\n\n``````````````````````````````````````\n\n " +
                $"Book Info: \n" +
                $"\tISBN = {ISBN}\n" +
                $"\tTitle = {Title}\n" +
                $"\tPages = {Pages}\n" +
                $"\tAuthor = {Author}\n" +
                $"\n```````````````````````````````````````````````\n";
        }
    }
}