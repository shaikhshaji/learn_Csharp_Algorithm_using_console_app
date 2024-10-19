using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shzLearn
{
    public class Menu
    {
        public void MainMenu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n\tEnter the Option:");
                Console.WriteLine("\t[1] Practise Programs");
                Console.WriteLine("\t[2] Algorithm");
                Console.WriteLine("\t[0] Exit");
                Console.WriteLine("\t[x] Clear Screen");

                var inputUserOption = Console.ReadLine();

                switch (inputUserOption)
                {
                    case "x":
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        flag = false;
                        return;
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
            PractiseSimplePrograms practiseSimplePrograms = new PractiseSimplePrograms();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n\tEnter the Program that you want to run and test:");
                Console.WriteLine("\t[1] Multiplication Table");
                Console.WriteLine("\t[2] Average of Four Numbers");
                Console.WriteLine("\t[3] Calculate 3 number and give output (X+Y).Z and (X.Y + Y.Z)");
                Console.WriteLine("\t[4] Calculate Math basic operator by using 2 numbers");
                Console.WriteLine("\t[0] Back to Main Menu");
                Console.WriteLine("\t[x] Clear Screen");

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
                        practiseSimplePrograms.MultiplicationTable();
                        break;
                    case "2":
                        Console.Clear();
                        practiseSimplePrograms.AverageOfFourNumbers();
                        break;
                    case "3":
                        Console.Clear();
                        practiseSimplePrograms.DesiredCalcOfGivenNumbers();
                        break;
                    case "4":
                        Console.Clear();
                        practiseSimplePrograms.MathCalcOfGivenNumbers();
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
            PractiseSimplePrograms practiseSimplePrograms = new PractiseSimplePrograms();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n\tEnter the Algoritham Program that you want to run and test:");
                Console.WriteLine("\t[1] ");
                Console.WriteLine("\t[2] ");
                Console.WriteLine("\t[0] Back to Main Menu");
                Console.WriteLine("\t[x] Clear Screen");

                string inputUserOption = Console.ReadLine();

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
                        practiseSimplePrograms.MultiplicationTable();
                        break;
                    case "2":
                        Console.Clear();
                        practiseSimplePrograms.AverageOfFourNumbers();
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
