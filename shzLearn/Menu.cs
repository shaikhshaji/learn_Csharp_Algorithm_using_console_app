using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shzLearn
{
    public class Menu
    {
        private bool flag = true;
        public void MainMenu()
        {
            while (flag)
            {
                Console.WriteLine("\n\tEnter the Option:");
                Console.WriteLine("\t[1] Practise Programs");
                Console.WriteLine("\t[2] Algorithm");
                Console.WriteLine("\t[0] Exit");
                Console.WriteLine("\t[x] Clear Screen");
                Console.Write("\n\n\tEnter your Input Here.... \t");


                var inputUserOption = Console.ReadLine();

                switch (inputUserOption)
                {
                    case "x":
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        flag = false;
                        break;
                    case "1":
                        Console.Clear();
                        PractiseProgram();
                        break;
                    case "2":
                        Console.Clear();
                        AlgorithmProgram();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\txxxxxxxx Invalid Input, please enter proper option. xxxxxxxx\n");
                        break;
                }
            }
        }

        public void PractiseProgram()
        {
            while (flag)
            {
                Console.WriteLine("\n\tEnter the Program that you want to run and test:");
                Console.WriteLine("\t[1] Multiplication Table");
                Console.WriteLine("\t[2] Average of Four Numbers");
                Console.WriteLine("\t[3] Calculate 3 number and give output (X+Y).Z and (X.Y + Y.Z)");
                Console.WriteLine("\t[4] Calculate Math basic operator by using 2 numbers");
                Console.WriteLine("\t[5] Display the entered number 4 lines with space and without space. wierd , ryt?");
                Console.WriteLine("\t[6] Convert Celsius degrees to Kelvin and Fahrenheit.");
                Console.WriteLine("\t[0] Back to Main Menu");
                Console.WriteLine("\t[x] Clear Screen");
                Console.Write("\n\n\tEnter your Input Here.... \t");


                var inputUserOption = Console.ReadLine();

                switch (inputUserOption)
                {
                    case "x":
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        MainMenu();
                        break;
                    case "1":
                        Console.Clear();
                        PractiseSimplePrograms.MultiplicationTable();
                        break;
                    case "2":
                        Console.Clear();
                        PractiseSimplePrograms.AverageOfFourNumbers();
                        break;
                    case "3":
                        Console.Clear();
                        PractiseSimplePrograms.DesiredCalcOfGivenNumbers();
                        break;
                    case "4":
                        Console.Clear();
                        PractiseSimplePrograms.MathCalcOfGivenNumbers();
                        break;
                    case "5":
                        Console.Clear();
                        PractiseSimplePrograms.FourLineNumberWithSpaceOrWitoutSpace();
                        break;                   
                    case "6":
                        Console.Clear();
                        PractiseSimplePrograms.ConvertCelsiusToKelvinAndFahrenheit();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\txxxxxxxx Invalid Input, please enter proper option. xxxxxxxx\n");
                        break;
                }


            }
            MainMenu();
        }
        public void AlgorithmProgram()
        {
            while (flag)
            {
                Console.WriteLine("\n\tEnter the Algoritham Program that you want to run and test:");
                Console.WriteLine("\t[1] ");
                Console.WriteLine("\t[2] ");
                Console.WriteLine("\t[0] Back to Main Menu");
                Console.WriteLine("\t[x] Clear Screen");
                Console.Write("\n\n\tEnter your Input Here.... \t");
                var inputUserOption = Console.ReadLine();

                switch (inputUserOption)
                {
                    case "x":
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        MainMenu();
                        break;
                    case "1":
                        Console.Clear();
                        //       practiseSimplePrograms.MultiplicationTable();
                        break;
                    case "2":
                        Console.Clear();
                        //        practiseSimplePrograms.AverageOfFourNumbers();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n\txxxxxxxx Invalid Input, please enter proper option. xxxxxxxx\n");
                        break;
                }


            }
            MainMenu();
        }
    }


}
