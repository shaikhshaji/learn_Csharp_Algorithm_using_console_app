using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shzLearn
{
    public class PractiseSimplePrograms
    {
        public void MultiplicationTable()
        {
            Console.WriteLine("\n\tWrite a C# Sharp program that prints the multiplication table of a number as input." +
                "\n\tTest Data:" +
                "\n\tEnter the number: 5" +
                "\n\tExpected Output:" +
                "\n\t5 * 0 = 0" +
                "\n\t5 * 1 = 5" +
                "\n\t5 * 2 = 10" +
                "\n\t5 * 3 = 15....5 * 10 = 50\n\n\n");
            Console.WriteLine("----- [ Enter the number for the multiplication table: ]  ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t" + num + " X " + i + " = " + (num * i));
            }
        }

        public void AverageOfFourNumbers()
        {

            Console.WriteLine("\n\tWrite a C# Sharp program that takes four numbers as input to calculate and print the average." +
              "\n\tTest Data:" +
              "\n\tEnter the First number: 10" +
              "\n\tEnter the Second number: 15" +
              "\n\tEnter the third number: 20" +
              "\n\tEnter the four number: 30" +
              "\n\t" +
              "\n\tExpected Output:" +
              "\n\tThe average of 10 , 15 , 20 , 30 is: 18\n\n\n");

            int num1, num2, num3, num4;
            Console.Write("  Enter the First number :  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Enter the Second number :  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Enter the Third number :  ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Enter the Fourth number :  ");
            num4 = Convert.ToInt32(Console.ReadLine());

            float avg = (float)((num1 + num2 + num3 + num4) / 4.00);

            Console.WriteLine("\n Average of the Numbers is : " + avg);
        }

        public void DesiredCalcOfGivenNumbers()
        {

            Console.WriteLine("\n\tWrite a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z." +
              "\n\tTest Data:" +
              "\n\tEnter the First number: 5" +
              "\n\tEnter the Second number: 6" +
              "\n\tEnter the third number: 7" +
              "\n\t" +
              "\n\tExpected Output:" +
              "\n\tResult of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72\n\n\n");

            int num1, num2, num3, num4;
            Console.Write("  Enter the First number :  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Enter the Second number :  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Enter the Third number :  ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int FirstOutput = (num1 + num2) * num3;
            int SecondOutput = (num1 * num2 + num2 * num3);

            Console.WriteLine("\n (X + Y).Z is : " + FirstOutput);
            Console.WriteLine("\n (X.Y + Y.Z) is : " + SecondOutput);
        }





    }
}
