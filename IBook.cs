using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    public interface IBook
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}