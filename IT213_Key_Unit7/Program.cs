using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Key_Unit7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp1 = 35.5;
            double tempF = fahrenheit(temp1);
            weatherStatement(tempF);

            double temp2 = 30.5;
            tempF = fahrenheit(temp2);
            weatherStatement(tempF);

            double temp3 = 22.2;
            tempF = fahrenheit(temp3);
            weatherStatement(tempF);

            double temp4 = 16.1;
            tempF = fahrenheit(temp4);
            weatherStatement(tempF);

            double temp5 = 7.3;
            tempF = fahrenheit(temp5);
            weatherStatement(tempF);

            double temp6 = -1;
            tempF = fahrenheit(temp6);
            weatherStatement(tempF);

            Console.Read();
        }

        public static double fahrenheit(double myTemp)
        {
            Console.Write("The temperature is " + myTemp + "C or ");
            double tempF = (9.0 / 5.0 * myTemp + 32);
            tempF = Math.Round(tempF, 1);
            Console.WriteLine(tempF + " F. ");
            return tempF;
        }

        public static void weatherStatement(double tempF)
        {
            if (tempF >= 95)
            {
                Console.WriteLine("A heat advisory has been issued.");
            }
            else if (tempF >= 85)
            {
                Console.WriteLine("Pleasant but warm.");
            }
            else if (tempF >= 70)
            {
                Console.WriteLine("Very pleasant weather today.");
            }
            else if (tempF >= 50)
            {
                Console.WriteLine("Pleasant but cool");
            }
            else if (tempF >= 33)
            {
                Console.WriteLine("Cold weather.");
            }
            else
            {
                Console.WriteLine("A freeze warning has been issued.");
            }
        }
    }
}
