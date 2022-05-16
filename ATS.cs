using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class ATS
    {
        private string title;
        public List<Customers> customers = new List<Customers>();
        public List<Calls> calls = new List<Calls>();
        public List<Tarif> tarifs = new List<Tarif>();

        public ATS()
        {
            title = "";
        }
        public void addCustomer(string name, string number)
        {
            Customers cust = new Customers(name, number);
            customers.Add(cust);
        }

        public void addTarif(string title,int price)
        {
            Tarif tarif = new Tarif(title, price);
            tarifs.Add(tarif);
        }

        public void registration (Customers cust1,Customers cust2, Tarif tarif)
        {
            Calls call = new Calls(cust1, cust2, tarif);
            calls.Add(call);
        }


        public int wholePrice(string name)
        {
            int totalPrice = 0;
            for(int i = 0; i < calls.Count;++i)
            {
                if(name == calls[i].Customer1)
                {
                    totalPrice += calls[i].Tarif;
                }
            }

            return totalPrice;
        }

        public int totalPriceInATS()
        {
            int totalPrice = 0;

            for(int i = 0; i < calls.Count;++i)
            {
                totalPrice += calls[i].Tarif; 
            }
            return totalPrice;
        }
    }
}
