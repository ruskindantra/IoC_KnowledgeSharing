using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            DateTime dob;
            int height;
            double weight;

            do
            {
                try
                {
                    Console.Write("Please enter your name: ");
                    name = Console.ReadLine();

                    Console.Write("Please enter your DOB: ");
                    dob = DateTime.Parse(Console.ReadLine());

                    Console.Write("Please enter your height: ");
                    height = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter your weight: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Data entered was in an invalid format, please try again");
                }
            } while (true);
            
            Console.WriteLine("Thank you for all your data");
            Console.ReadLine();
        }
    }
}
