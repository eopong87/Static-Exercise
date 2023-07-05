namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double fahrenheit = 77;
            double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);


            double celsius1 = 15;
            double fahrenheit1 = TempConverter.CelsiusToFahrenheit(celsius1);

            Console.WriteLine(celsius);
            Console.WriteLine(fahrenheit1);
        }
          

        
    }
}
