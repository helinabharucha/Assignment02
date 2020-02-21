using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int side1, side2, side3;
            int choice;
            
            bool c1 = true;

            do
            {
                try
                {
                    Console.WriteLine("---Menu---");
                    Console.WriteLine("1.Enter Triangle Dimensions");
                    Console.WriteLine("2.Exit");
                    Console.WriteLine("Please enter an option:");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter value of side 1:");
                            side1 = GetInput();
                            Console.WriteLine("Enter value of side 2:");
                            side2 = GetInput();
                            Console.WriteLine("Enter value of side 3:");
                            side3 = GetInput();
                     
                            string output = TriangleSolver.Analyze(side1,side2,side3);
                            Console.WriteLine(output);
                            c1 = true;
                            break;
                        case 2:
                            Environment.Exit(0);
                            c1 = false;
                            break;
                        default:
                            c1 = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    c1 = true;
                }
            } while (c1 == true);
           
            Console.ReadKey();
        }

        public static int GetInput()
        {
            int value = 0;
            string input = "";
            do
            {
                input = Console.ReadLine();

            } while (!int.TryParse(input,out value) || value < 0);
            return value;
        }
    }

    
}
