using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF6
{
    internal class Purchase
    {
        public int Issue {  get; set; }
        public decimal Price { get; set; }

        public static IEnumerable<Purchase> FindPurchases()
        {
            return new List<Purchase>()
            {
                new Purchase{ Price = 225M, Issue = 68 },
                new Purchase{ Price = 375M, Issue = 19 },
                new Purchase{ Price = 3600M, Issue = 6 },
                new Purchase{ Price = 13215M, Issue = 57 },
                new Purchase{ Price = 660M, Issue = 36 }
            };
        }
    }
}
