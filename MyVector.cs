using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDistanceCalculation
{
    public class MyVector
    {
        private Random random;
        public MyVector(Random rand)
        {
            random = rand;
        }
        public int[][] Get2DimensionalVector()
        {
            int[][] array = new int[100][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[] { random.Next(1, 100), random.Next(1, 100) };
            }
            return array;
        }



        public int[][] Part3And4()
        {
            int[][] array = new int[1000][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[] { random.Next(1, 1000), random.Next(1, 1000), random.Next(1, 1000)};
            }
            return array;
        }

    }
  }
