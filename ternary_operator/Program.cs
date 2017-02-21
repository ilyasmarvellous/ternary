using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0 ? true : false)
            Console.WriteLine("Entered number"+num+"is even ");
            else
            Console.WriteLine("Entered number" + num + "is odd ");
            Console.ReadLine();

        }
    }
}
