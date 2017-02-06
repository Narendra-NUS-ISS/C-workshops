using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author : Narendra Kandregula
// Workshop1 
namespace Workshop1
{
    class Program
    {
        static void Main(string[] args)
        {
            programB11();
                }
        /**
 * Write a program that will print out your detail in the following format:
 *  Line 1: Name Line 2: Email 
 **/
        public static void program1()
        {
            String name = "Narendra";
            String email = "narendravsk@gmail.com";
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Email :" + email);
        }

        /**
         * Write a program that would request for your name and print a greeting like this: 
         **/
        public static void program2()
        {
            Console.WriteLine("Please enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Entered name is " + name);

        }

        //Write a program that takes an integer as input and prints the square of that number. 
        static void program3(int input) 
        {
            Console.WriteLine("Square of give number is" + input*input);
        }

        //Write a program that takes a double precision number as input and prints the number with 2 decimal points in the output.
        static void program4(double input)
        {
            //double output = Math.Round(input, 2);
            Console.WriteLine("Given num with 2 precision" + String.Format("{0:0.00}", input));
        }
        //Write a program that takes a double precision number as input and prints the square root of the number. 
        static void programB1(double input)
        {
            Console.WriteLine("Square of given num" + Math.Sqrt(input));
        }
        // Write a program that takes a double precision number as input and prints the square root of the number.  The square root should be rounded to 3 decimal places. 
        static void programB2(double input)
        {
            double result = Math.Sqrt(input);
            Console.WriteLine("Square of given num with precision upto 3 : " + String.Format("{0:0.000}", result));
        }
        //The ABC Company pays its employees salary plus benefits.  The benefits are calculated as a percentage of the salary.  The company pays every employee 10% housing allowance and 3% transport allowance.  Write a program that takes the salary as input and prints the total income (salary + housing allowance + transport allowance) as output.  Format the output in currency format. 
        static void programB3(double salary)
        {
            double tallowance = 0.03 * salary;
            double hallowance = 0.10 * salary;
            salary = salary + tallowance + hallowance;
            Console.WriteLine(" Total salary of employee  :  $" + String.Format("{0:0.00}",salary));
        }
        /** Write a program that would convert temperature given in Centigrade scale to Fahrenheit – 
         * the number can be integer or real.  Use the formula:      F = 1.8C  + 32 
        **/
        static void programB4(double centigradeTemp)
        {
            double farenheit = (float)(1.8 * centigradeTemp) + 32;
            Console.WriteLine("Farenheit temp is  : " + farenheit);
        }
        /** Write a program that would take as input the value of x and calculate &
         *  output the value of y using the formula:   y = 5 x2 – 4 x + 3 
         **/
         static void programB5(int input)
        {
            int result = (5 *input * input) - (4 * input) + 3;
            Console.WriteLine(" Output value of y  : " + result);
        }
        /** Write a program that reads the (x,y) coordinates of two points.  Compute the distance between the two points using the formula: 
          * Distance = Square Root of [( x2 – x1 ) 2 + ( y2 – y1 ) 2 ] 
          **/
        static void programB6(int x1,int y1, int x2, int y2)
        {
            int result = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
            Console.WriteLine("Result of the expression is  : " + Math.Sqrt(result));
        }

        /** ABC Taxi Company has the following meter charges based on the kilometres travelled. 
        *Minimum fixed charge:  $2.40   In addition the fare would be computed at 40 cents per kilometer.  
        *E.g. If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4 **/
        static void programB7(double distance)
        {
            double resultFare = 2.40 + (distance * 0.40);
            Console.WriteLine("Total fare is  : " + resultFare);
        }
        //In the ABC Taxi Company problem above, print the output so that the fare is the output is
        //printed always rounded to nearest 10 cents and printed to two decimal places. 
        static void programB8(double distance)
        {
            double resultFare = 2.40 + (distance * 0.40);
            double midresult = Math.Round(resultFare, 1, MidpointRounding.AwayFromZero);
            resultFare = System.Convert.ToDouble(String.Format("{0:0.00}", midresult));
            Console.WriteLine("Total fare is  : " +String.Format("{0:0.00}",resultFare));
        }
        //In the ABC Taxi Company problem above, calculate the fare so that the fare is always rounded
        //upwards to the nearest 10 cents. This is harder than the previous problem and requires your ingenuity 
        static void programB9(double distance)
        {
            double resultFare = 2.40 + (distance * 0.40);
            resultFare = Math.Round(resultFare, 2);
            double postVal = (resultFare * 100) % 10;
            if (postVal > 0 && postVal <5)
            {
                resultFare = Math.Round(resultFare, 1) + 0.1;
            }
            Console.WriteLine("Total fare is : " + Math.Round(resultFare, 1));
        }
       /** Consider the simple Geometric example of determining the area of a triangle, given the lengths of its three sides a, b and c.
        *Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)] where s = (a+b+c) / 2 
        *Does your program always work? What is the condition when the program will not work and return a real number? Think about a condition to detect the situation where the area cannot be computed.
        **/
        static void programB10(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double sVal = s * ((s - a) * (s - b) * (s - c));
            if (sVal > 0)
            {
                double area = (int)Math.Sqrt(sVal);
                Console.WriteLine("--Area----" + area);
            } else
            {
                Console.WriteLine("NAN");
            }
        }
    }
}

