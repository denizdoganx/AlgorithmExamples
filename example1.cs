using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018510019_deniz_dogan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("******    ALGORITHM HOMEWORK    ******\n");
            Console.WriteLine("Student Name : DENİZ ");
            Console.WriteLine("Student Surname : DOĞAN");
            Console.WriteLine("Student Number : 2018510019\n");
            while (true)
            {
                try
                {



                    double x;
                    Console.WriteLine("------------------------------------");
                    Console.Write("Please enter a number between [0,25] = ");
                    x = Convert.ToDouble(Console.ReadLine());
                    



                    char mark;
                    Console.Write("Please choose multiplication(*) or division(/) : ");
                    mark = Convert.ToChar(Console.ReadLine());
                    if ((mark != '*') || (mark != '/'))
                    {
                        Console.WriteLine("ERROR!!!!!");
                        Console.WriteLine("Please select the operator whether it is multiplication or division...");
                    }

                    // result2 Retained the negative part of the 30-term process
                    double result2 = 0;
                    //result1 Retained the positive part of the 30-term process
                    double result1 = 0;
                    // f the number of factorials in each step
                    int f = 4;
                    // coefficient of x at each step
                    int coefficient = 3;
                    // pow1 kept the exponent of x
                    int pow1 = 2;
                    // pow2 variable exponent for base values
                    int pow2 = 2;
                    //  y the value divided or multiplied by the minimum value at each step
                    int y = 2;
                    // maintotal Total of 30 steps
                    double maintotal;
                    if ((x < 0) || (x > 25))
                    {
                        Console.WriteLine("ERROR!!!!!");
                        Console.WriteLine("Please choose the number between 0 and 25");
                    }



                    else if ((0<=x)&&(x<=25)&&(mark == '*'))
                    {

                        for (int i = 1; i <= 30; i++)
                        {
                            // factorial value of factorial at each step
                            // factorial loop
                            double factorial = 1;
                            for (int k = 1; k <= f; k++)
                            {
                                factorial = factorial * k;
                            }

                            //result is the result of operations with the number x in each step
                            double result = 1;
                            // Loop for calculation of x
                            for (int j = 1; j <= pow1; j++)
                            {
                                result = result * x;
                            }
                            result = result * coefficient;

                            // floor starts the base value of the denominator values ​​at each step 
                            int floor = 2 * i;

                            // floorsum base sum of each step
                            double floorsum = 0;
                            // The loop that calculates the sum of the values ​​in the denominator
                            for (int l = 1; l <= i + 1; l++)
                            {
                                // floorvariablesum keeps the sum of each number as different numbers are added up constantly in the denominator
                                double floorvariablesum = 1;
                                for (int m = 1; m <= pow2; m++)
                                {
                                    floorvariablesum = floorvariablesum * floor;
                                }
                                floor = floor + 2;
                                floorsum = floorsum + floorvariablesum;
                            }

                            // total Transfers the herb of the process in 30 steps to result1 and result2 respectively
                            double total = 0; 

                            //  the section where the main calculation is made according to the minimum value
                            if (result < factorial)
                            {

                                total = (result * y) / floorsum;
                                // The if condition will decide it to be negative when the value i is odd when it is positive even
                                if (i % 2 == 1)
                                {
                                    result1 = result1 + total;
                                }
                                else
                                {
                                    result2 = result2 + total;
                                }
                            }
                            else if (factorial < result)
                            {
                                total = (factorial * y) / floorsum;
                                if (i % 2 == 1)
                                {
                                    result1 = result1 + total;
                                }
                                else
                                {
                                    result2 = result2 + total;
                                }
                            }
                            else
                            {
                                total = (result * y) / floorsum;
                                if (i % 2 == 1)
                                {
                                    result1 = result1 + total;
                                }
                                else
                                {
                                    result2 = result2 + total;
                                }
                            }
                            //  regularly changing values ​​at each step were changed at the end of the 30 step loop
                            y = y + 5;
                            pow1 = pow1 + 3;
                            pow2 = pow2 + 1;
                            coefficient = coefficient + 4;
                            f = f + 2;
                        }
                       
                        maintotal = result1 - result2;
                        Console.WriteLine("The result  = " + maintotal);


                    }
                    else if ((0 <= x) && (x <= 25) && (mark == '/'))
                    {

                        for (int i = 1; i <= 30; i++)
                        {

                            double factorial = 1;
                            for (int k = 1; k <= f; k++)
                            {
                                factorial = factorial * k;
                            }
                            double result = 1;
                            for (int j = 1; j <= pow1; j++)
                            {
                                result = result * x;
                            }
                            result = result * coefficient;
                            int floor = 2 * i;
                            double floorsum = 0;
                            for (int l = 1; l <= i + 1; l++)
                            {
                                double floorvariablesum = 1;
                                for (int m = 1; m <= pow2; m++)
                                {
                                    floorvariablesum = floorvariablesum * floor;
                                }
                                floor = floor + 2;
                                floorsum = floorsum + floorvariablesum;
                            }
                            double total = 0;
                            if (result < factorial)
                            {

                                total = (result / y) / floorsum;
                                if (i % 2 == 1)
                                {
                                    result1 = result1 + total;
                                }
                                else
                                {
                                    result2 = result2 + total;
                                }
                            }
                            else if (factorial < result)
                            {
                                total = (factorial / y) / floorsum;
                                if (i % 2 == 1)
                                {
                                    result1 = result1 + total;
                                }
                                else
                                {
                                    result2 = result2 + total;
                                }
                            }
                            else
                            {
                                total = (result / y) / floorsum;
                                if (i % 2 == 1)
                                {
                                    result1 = result1 + total;
                                }
                                else
                                {
                                    result2 = result2 + total;
                                }
                            }
                            y = y + 5;
                            pow1 = pow1 + 3;
                            pow2 = pow2 + 1;
                            coefficient = coefficient + 4;
                            f = f + 2;
                        }
                        
                        maintotal = result1 - result2;
                        Console.WriteLine("The result  = " + maintotal);

                    }
                    
                   
                }
                catch(Exception )
                {
                    Console.WriteLine("ERROR!!!!!");
                    
                }
                
               
                    Console.WriteLine("Press any key to continue....");
                    Console.ReadLine();
            }     


        }

    }

}
