using System;

namespace Section1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempConvert();
            fuelEUtoUS();
            fuelUStoEU();
        }

        private static void TempConvert()
        {
            Console.WriteLine("Please enter temperature in Farenheit:");
            double FarenheitTemp = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter temperature in Celsius:");
            double CelsiusTemp = double.Parse(Console.ReadLine());
            double tempToCompare = (FarenheitTemp - 32) * 5/9;
            double FarenheitToCelsius = (FarenheitTemp - 32) * 0.5556;
            double CelsiusToFarenheit = (CelsiusTemp * 1.8 + 32);

            if (CelsiusTemp > tempToCompare)
            {
                Console.WriteLine("Temperature in Celsius is bigger.");
                Console.WriteLine($"Temperature defference in Celsius is: {CelsiusTemp - FarenheitToCelsius:0.00}");
                Console.WriteLine($"Temperature defference in Farenheit is: {CelsiusToFarenheit - FarenheitTemp:0.00}");
            }
            else if (CelsiusTemp < tempToCompare)
            {
                Console.WriteLine("Temperature in Farenheit is bigger.");
                Console.WriteLine($"Temperature defference in Celsius is: {FarenheitToCelsius - CelsiusTemp:0.00}");
                Console.WriteLine($"Temperature defference in Farenheit is: {FarenheitTemp - CelsiusToFarenheit:0.00}");
            }
            else
            {
                Console.WriteLine("Both temperatures are equal.");
            }
        }

        private static void fuelEUtoUS()
        {
            double consumptionEU = double.Parse(Console.ReadLine());
            double milesPer1KM = 0.621371192;
            double gallonsPer1Litre = 0.264172052;
            double milesPer100KM = milesPer1KM * 100;
            double result = milesPer100KM / gallonsPer1Litre;
            double finalResult = result / consumptionEU;
            Console.WriteLine(result);
        }

        private static void fuelUStoEU()
        {
            double consumptionUS = double.Parse(Console.ReadLine());
            double kmPer1Mile = 1.609;
            double litresPer1Gallon = 3.78;
            double hundredKMPer1Mile = kmPer1Mile / 100;
            double result = hundredKMPer1Mile / litresPer1Gallon;
            double finalResult = result * consumptionUS;
        }
    }
}
