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

          //  var result3 = ArraysMaths.MaxAbsValExpr(new[] {1, 2, 3, 4 }, new[] { -1, 4, 5, 6 } );
            var result3 = ArraysMaths.MaxAbsValExpr(new[] { 1, -2, -5, 0, 10 }, new[] { 0, -2, -1, -7, -4 });
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result3);
            Console.ReadKey();
        }
    }
}
