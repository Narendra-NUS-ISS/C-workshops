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
            programD1();
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

            //Methodlogy 2 - Multiply by 100 & use ceil
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

        //Write a program that would request for your name and gender (M or F assume capital letter) 
       //and print a greeting like this: 
        //Good Morning Mr. Venkat  where you entered Venkat for name and M for gender. 
        public static void programC1()
        {
             Console.WriteLine("Enter you Name : ");
             String name = Console.ReadLine();
            Console.WriteLine("Gender(M/F) : ");
            String gender = Console.ReadLine();

            if (gender.Equals("M"))
                {
                Console.Write("Good Morning Mr.");
            } else
            {
                Console.Write("Good Morning Ms.");
            }
            Console.WriteLine(name);
        }

        //Write a program that would request for your name, gender and age and would 
        //print a greeting like this:     Good morning Uncle Sam( if Sam, M, 45 is entered) 
        //(any gentlemen 40 years or more is Uncle any lady 40 years or more is Aunty, 
        //if less than forty they become just Mr or Ms. as the case may be.)
        public static void ProgramC2()
        {
            Console.WriteLine("Enter your Name : ");
            String name = Console.ReadLine();
            Console.WriteLine("Gender M/F : ");
            String gender = Console.ReadLine();
            Console.WriteLine("Age :");
            String age = Console.ReadLine();
            int ageVal = System.Convert.ToInt32(age);
            if(gender.Equals("M") && ageVal > 40)
            {
                Console.WriteLine("Good Morning Uncle "+name);
            } else if(gender.Equals("F")&& ageVal >40)
            {
                Console.WriteLine("Good morning aunty"+name);
            } else if (gender.Equals("M"))
            {
                Console.Write("Good Morning Mr."+name);
            }
            else
            {
                Console.Write("Good Morning Ms."+name);
            }


        }
        //Write a program that would compute the grade for a mark that the student gets.
        //The program should take an integer number between 0 and 100 and print the following:  
        //You scored 73 marks which is B grade.   where 73 is the input and B is calculated by the program.
        //Use the following table for computing the grades: 
        public static void ProgramC3()
        {
            Console.WriteLine("Enter Marks  : ");
            String marksVal = Console.ReadLine();
            int marks = System.Convert.ToInt32(marksVal);

            if(marks >= 80 && marks <= 100)
            {
                Console.WriteLine("You scored {0} marks which is A Grade", marks);
            } else if (marks >= 60  && marks <= 79)
            {
                Console.WriteLine("You scored {0} marks which is B Grade", marks);
            }
            else if (marks >= 40 && marks <= 59)
            {
                Console.WriteLine("You scored {0} marks which is C Grade", marks);
            }
            else if (marks >= 0 && marks < 40)
            {
                Console.WriteLine("You scored {0} marks which is F Grade", marks);
            }
            else if (marks <0)
            {
                Console.WriteLine("** Error**");
            }
            else if(marks > 100)
            {
                Console.WriteLine("** Error**");
            }
        }


      /**  ABC Taxi Company has the following meter charges based on the kilometres travelled.
Minimum charge:  $2.40  (first 0.5 km no additional charges apply) 
        For the next 8.5 kms the rate is 4 cents for every 100 meters After that:   5 cents for evey 100 meters
In the above example you should assume that the meter falls every 100 meters.
 So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be: 
$ 2.40 (first 0.5 km) + $ 85 * 0.04 (next 8.5 km) + $ (122 -90) * 0.05 (for distance over 9.0 km) 
=  $7.40 
 
 **/
        public static void ProgramC4()
        {
            Console.WriteLine("Enter distance  : ");
            String distVal = Console.ReadLine();
            double distance = System.Convert.ToDouble(distVal);
            distance = Math.Round(distance, 2);
            distance = Math.Round((Math.Ceiling((distance * 10))) / 10,2)*10;
            Console.WriteLine("Distance value is :  " + distance);
            double fare = 2.40;
            if((distance - 90) > 0)
            {
                fare = fare + (distance - 90) * 0.05;
            }
            if ((distance - 5) > 0)
            {
                if ((distance - 90) > 0)
                {
                    fare = fare + ((distance - (distance - 85))) * 0.04;
                } else
                {
                    fare = fare + (distance - 5) * 0.04;                }
            }
            Console.WriteLine("Fare is : " + fare);
        }
        /** Given a three-digit integer as input write a C# program to determine whether the number is an Armstrong number. 

        An Armstrong number is one for which the sum of each digit raised to the power of number of digits results in the number itself.

        For a three digit number 153 =  13 + 53 + 33   
 
         Confine the input to 3 digit examples only ie., number values 100…999.  **/
        public static void ProgramC5()
        {
            Console.WriteLine("Enter NUmber : ");
            String inputVal = Console.ReadLine();
            int n = System.Convert.ToInt32(inputVal);
            int input = System.Convert.ToInt32(inputVal); ;
            int result =0;
            while( n != 0)
            {
               int i = n % 10;
                result = result + (i * i * i);
                n = n / 10;
            }
           // Console.WriteLine("Result is  --- :input :{0}, result {1} " , input,result);
            Console.WriteLine("Result is  --- : " + (input == result));
            
        }

        // Electrifying Electronics Pte Ltd. manufactures three audio-visual electronic products named as TV, DVD, and MP3.  The table below gives the unit price for each of these products: 
        public static void ProgramC6()
        {
            Console.WriteLine("Quantity of TV : ");
            String tv = Console.ReadLine();
            Console.WriteLine("Quantity of DVD : ");
            String dvd = Console.ReadLine();
            Console.WriteLine("Quantity of MP3 : ");
            String mp3 = Console.ReadLine();

            int quantity_tv = System.Convert.ToInt32(tv);
            int quantity_dvd = System.Convert.ToInt32(dvd);
            int quantity_mp3 = System.Convert.ToInt32(mp3);

            int price_tv = quantity_tv * 900;
            int price_dvd = quantity_dvd * 500;
            int price_mp3 = quantity_mp3 * 700;

            int totalprice = price_tv + price_dvd + price_mp3;
            double discPrice = price_tv + price_dvd;
            double finalprice;
            finalprice = totalprice;
            if( totalprice > 5000)
            {
                finalprice = (discPrice - (discPrice * 0.10)) + price_mp3;
            }
            if(totalprice > 10000)
            {
                finalprice = (discPrice - (discPrice * 0.15)) + price_mp3;
            }
            Console.WriteLine("Final Fare is : " + finalprice);


        }

        // Write a C# program that would keep prompting you to enter an integer number over and over again until you enter the number 88. If you enter 88 the computer should say:      “Lucky you…”  and exit the program. 
         public static void programD1()
        {
           
            bool condition = false;
            while (!condition)
            {
                Console.WriteLine("Enter number : ");
                String inputVal = Console.ReadLine();
                Double input;
                bool inputValiddation = Double.TryParse(inputVal, out input);
                if (inputValiddation && input == 88)
                {
                    Console.WriteLine("Lucky you....");
                    condition = true;
                }
            }
            {

            }

        }


    }
}

