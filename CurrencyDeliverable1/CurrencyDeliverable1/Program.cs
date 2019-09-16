using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System.Globalization
{
    class Program
    {
        static void Main(string[] args)
        { 
        double number1, number2, number3, total, average  ;
            Console.WriteLine("Please enter your first value");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your second positive value :");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your third positive value :");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            total = Convert.ToDouble(number1 + number2 + number3);
            average = Convert.ToDouble((number1 + number2 + number3) / 3);
            
            
            Console.WriteLine("The average of your values is : " );
            Console.WriteLine(average.ToString("C"));

            Console.WriteLine("");


            {

                if (number1 > number3 && number3 > number2)
                {


                    Console.WriteLine("The first value is the greatest amount  ");

                    Console.WriteLine("The second value is the smallest  ");

                }
                if (number1 > number2 && number2> number3)
                {
                    Console.WriteLine("The first value is the greatest amount  ");

                    Console.WriteLine("The third value is the smallest amount  ");

                }

                if (number2 > number1 && number1 > number3)
                {
                    Console.WriteLine("The second value is the greatest amount  ");
                    Console.WriteLine("The third value is the smallest");


                }
                if(number2>number3 &&number3>number1)
                { Console.WriteLine("The second value is the greatest amount  ");
                    Console.WriteLine("The first value is the smallest");
                }
                if (number3>number1&&number1>number2)
                {
                    Console.WriteLine("The third value is the greatest amount ");
                    Console.WriteLine("The second value is the smallest amount");
                }
                if (number3 > number2 && number2 > number1)
                {
                    Console.WriteLine("The third value is the greatest amount");
                    Console.WriteLine("The first value is the lowest amount");
                }
                {
                    Console.WriteLine("");
                }


                Console.WriteLine("");
                Console.WriteLine("Your total value in USD is:");
                Console.WriteLine(total.ToString("C", CultureInfo.CurrentCulture));
                Console.WriteLine("");
                Console.WriteLine("Your total value in Japanese yen is:");
                Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
                Console.WriteLine("");
                Console.WriteLine("Your total value in the Swedish krona is:");
                Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
                Console.WriteLine("");
                Console.WriteLine("Your total in the Thailand baht is:");
                Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));
                Console.ReadKey();

            }
        }
    }
}
