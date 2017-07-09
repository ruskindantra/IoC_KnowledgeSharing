using System;
using System.Text;

namespace TraditionalMenuApp
{
    class Program
    {
        private static bool nameEntered = false;
        private static bool dobEntered = false;
        private static bool heightEntered = false;
        private static bool weightEntered = false;
        
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    string selectedMenu = ShowMenu();
                    if (selectedMenu == "1")
                    {
                        Console.Write("Name: ");
                        Console.ReadLine();
                        nameEntered = true;
                    }
                    else if (selectedMenu == "2")
                    {
                        Console.Write("DOB: ");
                        DateTime.Parse(Console.ReadLine());
                        dobEntered = true;
                    }
                    else if (selectedMenu == "3")
                    {
                        Console.Write("Height: ");
                        Convert.ToInt32(Console.ReadLine());
                        heightEntered = true;
                    }
                    else if (selectedMenu == "4")
                    {
                        Console.Write("Weight: ");
                        Convert.ToDouble(Console.ReadLine());
                        weightEntered = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection, try again");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Data entered was in an invalid format, please try again");
                }

                if (nameEntered && dobEntered && heightEntered && weightEntered)
                    break;
            } while (true);
            
            Console.WriteLine("Thank you for all your data");
            Console.ReadLine();
        }

        private static string ShowMenu()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("1 - Enter your name" + (nameEntered ? "-Done" : string.Empty));
            builder.AppendLine("2 - Enter your DOB" + (dobEntered ? "-Done" : string.Empty));
            builder.AppendLine("3 - Enter your height" + (heightEntered ? "-Done" : string.Empty));
            builder.AppendLine("4 - Enter your weight" + (weightEntered ? "-Done" : string.Empty));
            
            Console.WriteLine(builder.ToString());
            Console.Write("Make your selection: ");
            return Console.ReadLine();
        }
    }
}
