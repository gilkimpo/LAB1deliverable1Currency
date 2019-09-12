using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        { 
        double number1, number2, number3, average, swedish, japanese, thai ;
            Console.WriteLine("Input your first positive value :");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your second positive value :");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your third positive value :");
            number3 = Convert.ToDouble(Console.ReadLine());
            average = Convert.ToDouble((number1 + number2 + number3) / 3);
            swedish = (Convert.ToDouble((9.68 * number1)));//FIX THIS!!!!!
            japanese = (Convert.ToDouble(107.78*number2));///FIX THIS!!!
            thai = (Convert.ToDouble(30.58*number3));///FIXTHIS

            Console.WriteLine("The average of your values is : " + average);
            {

                if (number1 > number2)
                {
                    if (number1 > number3)
                    {
                        Console.WriteLine("The first value is the greatest amount " + number1);
                    }
                    else
                    {
                        Console.WriteLine("The third value is the greatest amount " + number3);
                    }
                }
                else if (number2 > number3)
                {
                    Console.WriteLine("The second value is the greatest amount " + number2);
                }
                if (number1 < number2)
                {
                    if (number1 < number3)
                    {
                        Console.WriteLine("The first value is the smallest amount " + number1);
                    }
                    else
                    {
                        Console.WriteLine("The third value is the smallest amount" + number3);
                    }
                }
                else if (number2 < number3)
                {
                    Console.WriteLine("The second value is the smallest amount" + number2);
                }

                }
                Console.ReadKey();

            
        }
    }
}
