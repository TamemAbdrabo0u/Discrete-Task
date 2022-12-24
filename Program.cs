using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first No");
            int x=int.Parse(Console.ReadLine());

            Console.WriteLine("enter the seconde No");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("the perfect numbers here is : ");
            Console.WriteLine("___________________________");
           

            for (int m = x; m <= y; m++)
            {

                int sum = 0;

                for (int n = 1; n < m; n++)
                {

                    if (m % n == 0)
                        sum += n;

                }

                if (sum == m)
                    Console.WriteLine(m);

            }





        }
    }
}
