using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    public class Computing : Book, IBook //Computing "implements" IBook
    {
        public Computing()
        {
            ISBN = "955894489";
            Title = "Computing";
            Author = "Dr. Smarty Pants";
            Pages = 9848;
        }
    }
}