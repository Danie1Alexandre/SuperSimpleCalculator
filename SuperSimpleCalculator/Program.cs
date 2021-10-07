//Made by Daniel Alexandre 2021
using System;

namespace SuperSimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, switchNumber;
            while(true)
            {
                Console.WriteLine("\nSuper Simple Calculator");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Choose option between 1-5 and press enter");
                Console.WriteLine("\t1 - Add");
                Console.WriteLine("\t2 - Subtract");
                Console.WriteLine("\t3 - Multiply");
                Console.WriteLine("\t4 - Divide");
                Console.WriteLine("\t5 - Quit");
                while (true)//testing valid option!=)
                {
                    switchNumber = GetNumber();
                    if ((switchNumber <= 5) && (switchNumber >= 1))
                    {
                        break;
                    }
                    Console.WriteLine("not a valid option, use number 1-4 to calculate or 5 to quit");
                }
                if (switchNumber == 5)//Shut down program
                {
                    break;
                }
                //Calculation begins
                Console.WriteLine("Type first number of calculation and press enter ");
                num1 = GetNumber();
                Console.WriteLine("Type next number and press enter to calculate");
                num2 = GetNumber();
                switch (switchNumber)
                {

                    case 1: //add
                        Console.WriteLine($"Resultat: {num1} + {num2} = " + (add(num1, num2)));
                        break;
                    case 2: //sub
                        Console.WriteLine($"Resultat: {num1} - {num2} = " + (sub(num1, num2)));
                        break;
                    case 3: //multiply
                        Console.WriteLine($"Resultat: {num1} * {num2} = " + (multiply(num1, num2)));
                        break;
                    case 4://Divide
                        while (num2 == 0)
                        {
                            Console.WriteLine("Can not divide by zero, Enter a non-zero divisor: ");
                            num2 = GetNumber();
                        }
                        Console.WriteLine($"Resultat: {num1} / {num2} = " + (Divide(num1, num2)));
                        break;
                    default:
                        Console.WriteLine("Not a vaild option try again");
                        break;
                }

            }


        }
        //Test user input
        static double GetNumber()
        {
            double num1 = 0;
            bool inputTest = false;
            while (!inputTest)
            {
                inputTest = double.TryParse(Console.ReadLine(), out num1);
                if (!inputTest)
                    Console.WriteLine("Not valid input, use numbers");
            }
            return num1;
        }
        public static double add (double arg1, double arg2)
        {
            return arg1 + arg2;
        }
        public static double sub (double arg1, double arg2)
        {
            return arg1 - arg2;
        }
        public static double multiply (double arg1, double arg2)
        {
            return arg1 * arg2;
        }
        public static double Divide (double arg1, double arg2)
        {
            return arg1 / arg2;
        }
    }
}

   