using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GemiClasses
{
    public class Sefer
    {
        public string KalkisLiman { get; set; }

        public string AraLiman { get; set; }

        public string VarisLiman { get; set; }

        public DateTime KalkisTarihi { get; set; }
        public DateTime AraTarihi { get; set; }
        public DateTime VarisTarihi { get; set; }

        public Gemi SeferGemi { get; set; }
        public Urun SeferUrun { get; set; }


    }
}
