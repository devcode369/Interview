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

            string[,] theArray = new string[5, 10];
            string[,,,] theArrayMulti = new string[5,5,5,5];

            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    theArray[i, j] = "sathish" + i + "," + j;
                }
            }

            foreach (var row in theArray)
            {
                foreach (var colm in row)
                {
                    Console.WriteLine(String.Format("{0} ", colm));
                
                }
                Console.Write("\n");
            }
            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", theArray[i, j]));
                }
                Console.Write("\n");
            }
            // Console.WriteLine("The array has {0} dimensions.", theArray.Rank);




        
           

        }


    }
}
