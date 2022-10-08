using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_concept_Restaurnats_Console_Project
{
    internal class Program
    {
        public class Restaurants
        {    //Instance Variable
            private string name;
            private string address;
            private double gratuityRate;

            //properties 
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Address
            {
                get { return address; }
                set { address = value; }
            }
          public double GratuityRate
            {
                get { return gratuityRate; }
                set { 
                    if(value >= 0)
                    gratuityRate = value; 
                }
            }
            //End properties 
            // Constructor 
        public Restaurants(string name  , string address , double gratuityRate)
            {
                Name = name;
                Address = address;
                GratuityRate = gratuityRate;
                    
            }// end of constructor
             public void GenerateReceipt()
            {
                double price =0;
                double subtotal=0;
                double gratuityAmount = 0;
                double grandTotal = 0;
                int people;
                while (price != -1)
                {
                    subtotal += price;
                    Console.WriteLine("Enter price of food item:[-1 to quit]");
                    price = Convert.ToDouble(Console.ReadLine());
                  
                }
                Console.WriteLine("How many people in party :");
                people =Convert.ToInt32( Console.ReadLine());

                if (people >= 6)
                {
                    gratuityAmount = subtotal * gratuityRate;
                }
                grandTotal = subtotal + gratuityAmount;
                Console.WriteLine("subtotal :{0}", subtotal);
                Console.WriteLine("{0} Gratuity:{1}",gratuityRate,gratuityAmount);
                Console.WriteLine("Grand Total {0}",grandTotal);
            }
        }
       
    }
}
