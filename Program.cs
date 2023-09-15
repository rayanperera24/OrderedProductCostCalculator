//B D I R Perera
//COCSE234F-031

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_8
{
    class product
    {
        protected int rawmaterialcost;
        protected int productioncost;

        public  void setdetails()
        {
            Console.WriteLine("Enter Raw Material Cost :");
            rawmaterialcost=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Prodcution Cost");
            productioncost =Convert.ToInt32(Console.ReadLine());

        }

        public virtual void findtotalcost()
        {

            int totalcost = rawmaterialcost + productioncost;
            Console.WriteLine("your total cost : " + totalcost);


        }

    }

    class OrderedProduct:product
    {
        private int deliverycost;

        public  void setdeliverycost()
        {
            Console.WriteLine("enter the delivery cost");
            deliverycost = Convert.ToInt32(Console.ReadLine());
        }

        public override void findtotalcost()
        {
            
            int totalcost = rawmaterialcost + productioncost + deliverycost;
            Console.WriteLine("Total Cost (including delivery cost) : " + totalcost);

        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------WELCOME-------");
            Console.WriteLine();
            product product = new product();
            OrderedProduct orderedProduct1 = new OrderedProduct();
            orderedProduct1.setdetails();
            orderedProduct1.setdeliverycost();
            Console.WriteLine("---------------------------------------");
            orderedProduct1.findtotalcost();



            Console.ReadKey();


        }
    }
}
