using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAP
{
    public static class Arrays
    {

        public static void Ge2DArrays()
        {

            int[,] theArray = new int[5, 10];
            Console.WriteLine("The array has {0} dimensions.", theArray.Rank);
        }
    }
}
