using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБ_Герасимова_Мария
{
    class Program
    {
        static void Main(string[] args)
            
        {
            sbyte a = 100;
            sbyte b = Math.Abs(a);
            Console.WriteLine(a);

            sbyte d = 90;
            sbyte f = 91;
            sbyte maximum = Math.Max(d, f);
            Console.WriteLine(d);
            Console.WriteLine(f);

            double x = 9;
            double koren = Math.Sqrt(x);
            Console.WriteLine(x);

            double y = 3.5;
            double tselaya_chast = Math.Truncate(y);
            Console.WriteLine(y);
            

            double num1 = Int32.Parse(Console.ReadLine());
            double num2 = 8;

            var formula =num1 / num2 ;

            Console.WriteLine(formula);



            int value1= Int32.Parse(Console.ReadLine());
            int value2 = 8;

            int result2 = Math.DivRem(value1, value2, out int result);
            (Console.WriteLine(result2, result);






            //double value = Int32.Parse(Console.ReadLine());


            Console.ReadKey();

        }


        //foreach (int dividend in dividends)
        // {
        //    int remainder;
        //int quotient = Math.DivRem(dividend, divisor, out remainder);
        //Console.WriteLine(dividend, divisor, quotient, remainder);
        // }
    }
}
