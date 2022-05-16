using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Tarif
    {
        private string title;
        private int price;

        public Tarif(string title, int price)
        {
            this.title = title;
            this.price = price;
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        
    }
}
