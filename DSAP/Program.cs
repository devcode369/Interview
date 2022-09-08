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

            var result4 = ArraysMaths.MaximumGap(new int[] { 3, 6, 9, 1 });
            var result5 = ArraysMaths.GenerateMatrix(3);

            var result6 = ArraysMaths.FizzBuzz(3);
            Arrays.Ge2DArrays();
            var result7 = ArraysMaths.MostWordsFound(new string[] { "please wait", "continue to fight", "continue to win" });
            //  var result7 = ArraysMaths.DiagonalSum();
            var result8 = ArraysMaths.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);


            //  Console.WriteLine(result7);


            Console.ReadKey();
        }
    }
}
