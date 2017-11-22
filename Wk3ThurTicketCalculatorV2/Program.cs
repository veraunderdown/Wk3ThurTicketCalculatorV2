using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3ThurTicketCalculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
             //variables

            int numAdults; 
            int numChildren;
            int numSeniors;
            int numFamily;
            int totalPrice;

            //input

            Console.Write("Enter the number of Adults: ");
            numAdults = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Children: ");
            numChildren = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Seniors: ");
            numSeniors = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Family Tickets: ");
            numFamily = int.Parse(Console.ReadLine());

            //process

            totalPrice = numAdults * 1490 + numChildren * 990 + numSeniors * 990;

            //output

            Console.WriteLine("Total Price:" + totalPrice.ToString());

            Console.ReadKey();


        }
    }
}
