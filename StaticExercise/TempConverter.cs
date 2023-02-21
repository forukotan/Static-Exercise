using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double F )
        {
            return (F - 32 )/ 1.8;
        }

        public static double CelsiusToFahrenheit(double C)
        {
            return (C * (5 / 9))+32; 
        }
    }

}
