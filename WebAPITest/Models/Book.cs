using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITest.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public int page { get; set; }
    }
}
