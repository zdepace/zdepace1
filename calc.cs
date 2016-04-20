using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool keepLooping = true;
            bool exit = true;

            while (exit)
            {
                keepLooping = true;
                Console.WriteLine("What would you like to do?\n1) Add\n2) Subtract\n3) Multiply\n4) Divide\n5) Quit");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    while (keepLooping)
                    {
                        Console.WriteLine("Please enter your first number.");
                        int add1;
                        string addition1 = Console.ReadLine();
                        if (int.TryParse(addition1, out add1))
                        {
                            Console.WriteLine("Please enter your second number.");
                            int add2;
                            string addition2 = Console.ReadLine();
                            if (int.TryParse(addition2, out add2))
                            {
                                Console.WriteLine("The  answer to " + add1 + " and " + add2 + " is " + (add1 + add2));
                                keepLooping = false;
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                }

                else if (answer == "2")
                {
                    while (keepLooping)
                    {
                        Console.WriteLine("Please enter your first number.");
                        int sub1;
                        string subtraction1 = Console.ReadLine();
                        if (int.TryParse(subtraction1, out sub1))
                        {
                            Console.WriteLine("Please enter your second number.");
                            int sub2;
                            string subtraction2 = Console.ReadLine();
                            if (int.TryParse(subtraction2, out sub2))
                            {
                                Console.WriteLine("The answer to " + sub1 + " and " + sub2 + " is " + (sub1 - sub2));
                                keepLooping = false;
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                }

                else if (answer == "3")
                {
                    while (keepLooping)
                    {
                        Console.WriteLine("Please enter your first number.");
                        int mul1;
                        string multi1 = Console.ReadLine();
                        if (int.TryParse(multi1, out mul1))
                        {
                            Console.WriteLine("Please enter your second number.");
                            int mul2;
                            string multi2 = Console.ReadLine();
                            if (int.TryParse(multi2, out mul2))
                            {
                                Console.WriteLine("The answer to " + mul1 + " and " + mul2 + " is " + (mul1 * mul2));
                                keepLooping = false;
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                }

                else if (answer == "4")
                {
                    while (keepLooping)
                    {
                        Console.WriteLine("Please enter your first number.");
                        int div1;
                        string divide1 = Console.ReadLine();
                        if (int.TryParse(divide1, out div1))
                        {
                            Console.WriteLine("Please enter your second number.");
                            int div2;
                            string divide2 = Console.ReadLine();
                            if (int.TryParse(divide2, out div2))
                            {
                                Console.WriteLine("The answer to " + div1 + " and " + div2 + " is " + (div1 / div2));
                                keepLooping = false;
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                }
                else if (answer == "5")
                {
                    Console.WriteLine("Goodbye!\nPress enter to exit...");
                    exit = false;
                    Console.ReadLine();
                    Console.Clear();
                }


                else
                {
                    Console.WriteLine("Invalid answer, please try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }     
                
        }
    }
}
