using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            ATS ats = new ATS();
            
            ats.addCustomer("Oleg", "+375291242010");
            ats.addCustomer("Timofey", "+375291141223");
            ats.addCustomer("Alexcandra", "+375291306675");
            ats.addCustomer("Jon", "+375297777777");
            ats.addCustomer("Travolta", "+375291111111");

            ats.addTarif("Lemon", 100);
            ats.addTarif("Apple", 200);
            ats.addTarif("Potato", 300);
            ats.addTarif("Orange", 400);
            ats.addTarif("Banana", 500);

            Console.WriteLine("Звонки на ATS");

            for(int i = 0; i < 4 ;++i)
            {
                ats.registration(ats.customers[0], ats.customers[i + 1], ats.tarifs[i]);
            }

            for (int i = 0; i < ats.calls.Count; ++i)
            {
                Console.WriteLine($" исходящий:{ ats.calls[i].Customer1} входящий:{ ats.calls[i].Customer2} тариф:{ ats.calls[i].Tarif}");
            }


        }
    }
}
