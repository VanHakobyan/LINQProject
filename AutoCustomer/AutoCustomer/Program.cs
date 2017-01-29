using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Catalog auto in sale

            List<Auto> catalogAuto = new List<Auto>
            {
                new Auto("Mersedes","E","Blue",2006,3.2f,false),
                new Auto("Infiniti","FX35","Black",2006,3.5f,true),
                new Auto("BMW","X5","Red",2004,4.4f,true),
                new Auto("Toyota","Land Cruiser","White",2008,4.7f,true)
            };
            foreach (var auto in catalogAuto)
            {
                Console.WriteLine(auto.ToString());
            }


            Console.WriteLine(new string('-', 25));
            //--------------------------------------------------------------


            // Buyers list NOT to politicize
            List<Customer> listCustomer = new List<Customer>
            {
                new Customer("Zaruhi Postanjyan","Mersedes","055105510"),
                new Customer("Arshak Sadoyan","Vaz 21 06","093101010"),
                new Customer("Karen Karapetyan","BMW","077777777"),
                new Customer("Galust Sahakyan","Toyota","041765149")

            };

            foreach (var Customer in listCustomer)
            {
                Console.WriteLine(Customer.ToString());
            }

            Console.WriteLine(new string('-', 25));
            //--------------------------------------------------------------------


            var queryFirst = from Auto in catalogAuto
                             select new { Car = Auto.Car, Color = Auto.Color };


            foreach (var item in queryFirst)
            {
                Console.WriteLine($"Auto Marka and color: {item.Car} , {item.Color}");
            }


            //---------------------------------------------------------------------
            Console.WriteLine(new string('-', 25));

            var querySecond = from customer in listCustomer
                              join auto in catalogAuto on customer.Model equals auto.Car
                              select new
                              {
                                  NameCustomer = customer.NameCustomer,
                                  Phone = customer.PhoneNumber,
                                  Model = customer.Model,
                                  Color = auto.Color,
                                  Marka = auto.Model,
                                  Year = auto.Year,
                                  Motor = auto.Motor,
                                  Autmaticly = auto.IsAutomaticTransmission,
                              };

            foreach (var item in querySecond)
            {
                Console.WriteLine($"{item.NameCustomer}  {item.Phone}  {item.Model}  {item.Color}  {item.Marka}  {item.Year}  {item.Motor}  {item.Autmaticly}");
            }
        }
    }
}
