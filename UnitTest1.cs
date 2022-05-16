using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab5;
namespace testLab5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WholePriceInATS()
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

           
            int[] expected = { 100, 300, 600, 1000 };
            for(int i = 0; i < ats.calls.Count - 1;++i )
            {
                ats.registration(ats.customers[i], ats.customers[0], ats.tarifs[i]);
                Assert.AreEqual(expected[i], ats.totalPriceInATS());
            }

        }

        [TestMethod]

        public void WholeCallsToCustomer()
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

            int[] expected = { 100, 300, 600, 1000 };
            for (int i = 0; i < ats.calls.Count - 1; ++i)
            {
                ats.registration(ats.customers[0], ats.customers[i + 1], ats.tarifs[i]);
                Assert.AreEqual(expected[i], ats.totalPriceInATS());
            }

        }


    }
}
