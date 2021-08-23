using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            // C is biggest number always, so has to be between 2 and 100
            int C = rnd.Next(2, 101);
            int B = 100;
            int A = 100;
            // B is bigger than A, so it has to be at least 1
            // A is the smallest, so it can be 0
            while (B >= C || A >= B){
                B = rnd.Next(1, 101);
                if (A >= B)
                {
                    A = rnd.Next(0, 101);
                }
            }

            Console.WriteLine("A = {0}, B = {1}, C = {2}", A, B, C);

            Console.WriteLine("Input A, B, and C with no spaces in the order you would like displayed");

            while (true) {

                string order = Console.ReadLine();

                if (order == "ABC" || order == "abc")
                {
                    calculateOrder(A, B, C);
                    break;
                } else if (order == "ACB" || order == "acb")
                {
                    calculateOrder(A, C, B);
                    break;
                }
                else if (order == "BAC" || order == "bac")
                {
                    calculateOrder(B, A, C);
                    break;
                }
                else if (order == "BCA" || order == "bca")
                {
                    calculateOrder(B, C, A);
                    break;
                }
                else if (order == "CAB" || order == "cab")
                {
                    calculateOrder(C, A, B);
                    break;
                }
                else if (order == "CBA" || order == "cba")
                {
                    calculateOrder(C, B, A);
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }


            int calculateOrder(int a, int b, int c)
            {

                Console.WriteLine("\n{0}, {1}, {2}", a, b, c);

                return 0;
            }

        }
    }
}
