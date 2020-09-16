using System;

namespace VectorDistanceCalculation
{
    public class Program
    {
        

       public static double FirstPart(Random rand)
        {
            double x1 = rand.Next(1, 100);
            double y1 = rand.Next(1, 100);

            double x2 = rand.Next(1, 100);
            double y2 = rand.Next(1, 100);

            double answer = Math.Abs(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine($"The answer for part 1 is: { answer}");
            return answer;
        }


        public static double SecondPart(int[][] jaggArr)
        {
            double answer = 0;
            double temp = 0;
            double small = 60;
            for (int i = 0; i < jaggArr.Length; i++)
            {
                for (int j = 0; j < jaggArr.Length; j++)
                {
                    if (i != j) 
                    {
                       temp = Math.Abs(Math.Sqrt(Math.Pow(jaggArr[i][0] - jaggArr[j][0], 2) + Math.Pow(jaggArr[i][1] - jaggArr[j][1], 2)));
                    }
                    if (temp < small && temp != 0)
                    {
                        answer = temp;
                    }
                }
            }
            Console.WriteLine($"The answer for part 2 is: { answer}");
            return answer;
        }



        static double Part3And4(int[][] jagg)
        {
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;
            int z1 = 0; 
            int z2 = 0;
            int firstPoint = 0;
            int secondPoint = 0;
            double answer = 0;
            double temp = 0;
            double small = 50;
           
            for (int i = 0; i < jagg.Length; i++)
            {
                for (int j = 0; j < jagg.Length; j++)
                {
                    if (i != j)
                    {
                        temp = Math.Abs(Math.Sqrt(Math.Pow(jagg[i][0] - jagg[j][0], 2) + Math.Pow(jagg[i][1] - jagg[j][1], 2) + Math.Pow(jagg[i][2] - jagg[j][2], 2)));
                    }
                    if (temp < small && temp != 0)
                    {
                        x1 = jagg[i][0];
                        y1 = jagg[i][1];
                        z1 = jagg[i][2];

                        x2 = jagg[j][0];
                        y2 = jagg[j][1];
                        z2 = jagg[j][2];

                        firstPoint = j;
                        secondPoint = i;
                        answer = temp;
                    }
                }
            }
            Console.WriteLine($"The answer for part 3 is: {answer}");
            Console.WriteLine($"Part 4: Shortest Array Elements: |{firstPoint}| {x1}, {y1}, {z1} Sencond Array Element: |{secondPoint}| {x2}, {y2}, {z2}");
            return answer;
        }


        public static void Main(string[] args)
        {
            Random rand = new Random();



            //Part 1 and 2
            FirstPart(rand);

            MyVector vector = new MyVector(rand);
            
            SecondPart(vector.Get2DimensionalVector());


            //Part 3 and 4
            Part3And4(vector.Part3And4());
        }
    }
}
