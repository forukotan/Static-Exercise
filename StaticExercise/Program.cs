namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           var celsius = TempConverter.CelsiusToFahrenheit(0);
           var fahrenheit = TempConverter.FahrenheitToCelsius(32);

            Console.WriteLine($" celsius is {celsius} and farenheit is {fahrenheit}");
        }
    }
}
