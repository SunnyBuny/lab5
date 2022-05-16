using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Customers
    {
        private string name;
        private string phoneNumber;

        public Customers(string nam, string num)
        {
            name = nam;
            phoneNumber = num;
            
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        
    }

        

}
