using System;

namespace Calculator_Lexicon
{
    class Program
    {
        static void Main(string[] args)
        {

            bool calculation = true;

            while (calculation)
            {

                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 - Add");
                Console.WriteLine("\t2 - Subtract");
                Console.WriteLine("\t3 - Multiply");
                Console.WriteLine("\t4 - Divide");
                Console.WriteLine("\t0 - To stop ");
                int.TryParse(Console.ReadLine(), out int selection);
                double result = 0;
                //Declare variables and then initialize to zero.
                double num1 = 0; double num2 = 0;
                //Ask the user to type the first number.
                Console.WriteLine("Type first number, and then press Enter");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Type second number, and then press Enter");
                num2 = Convert.ToDouble(Console.ReadLine());
                // Use a switch statement to do the math.
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        result = Addition(num1, num2);
                        Console.WriteLine("press any key to continue ");
                        break;
                    case 2:
                        Console.Clear();
                        result = Subtraction(num1, num2);
                        Console.WriteLine("press any key to continue ");
                        break;
                    case 3:
                        Console.Clear();
                        result = Multiplication(num1, num2);
                        Console.WriteLine("press any key to continue ");
                        break;
                    case 4:
                        Console.Clear();
                        result = Division(num1, num2);
                        Console.WriteLine("press any key to continue ");
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine(" Thank you for using the program.. exiting program...");
                        Environment.Exit(0);
                        calculation = false;
                        
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("The result is {0}", result);
               // Console.WriteLine("press any key to continue calculation or ");
                Console.ReadKey();

            }
            //functions start
       
        }
        //Addition  
        public static double Addition(double input_1, double input_2)
        {
            double result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static double Subtraction(double input_1, double input_2)
        {
            double result = input_1 - input_2;
            return result;
        }
        //Multiplication  
        public static double Multiplication(double input_1, double input_2)
        {
            double result = input_1 * input_2;
            return result;
        }
        //Division  
        public static double Division(double input_1, double input_2)
        {
            bool validnumber = false;
            while (validnumber == false)
            {

                //if  it  a valid integer number i.e . validnuber==true break out of the loop 
                if (input_2!=0)
                {

                    break;
                }
                else
                {
                    //promp re enter age in the right format if the age is still invalid integer i.e validnumber == false 
                    Console.WriteLine("you are trying to divide by 0 ...exiting  ");
                    Environment.Exit(0);
                 
                }
            }
                double result = input_1 / input_2;
            return result;
        }
    }
}
