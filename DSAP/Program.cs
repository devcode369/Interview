using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = ArraysMaths.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            var result1 = ArraysMaths.Trap2(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
