using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Calls
    {
        private Tarif tarif;
        private Customers customer1;
        private Customers customer2;

        public Calls(Customers cust1, Customers cust2, Tarif tar)
        {
            tarif = tar;
            customer1 = cust1;
            customer2 = cust2;
        }

        public string Customer1
        {
            get
            {
                return customer1.Name;
            }

        }

        public int Tarif
        {
            get
            {
                return tarif.Price;
            }
        }

        
        
    }
}
