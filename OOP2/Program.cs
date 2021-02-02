using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fatma AKKAYA
            Individual customer1= new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "13241";
            customer1.FirstName = "Fatma";
            customer1.LastName = "AKKAYA";
            customer1.TCNumber = "156435864748";
            //Muboys Group
            Coorporate customer2 = new Coorporate();
            customer2.Id = 1;
            customer2.CustomerNumber = "416872";
            customer2.CompanyName = "Muboys Group";
            customer2.TaxNumber = "1867435121";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);





        }
    }
}
