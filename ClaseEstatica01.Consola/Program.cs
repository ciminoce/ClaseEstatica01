using ClaseEstatica01.Entidades;

namespace ClaseEstatica01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Statics Classes");
            float celsius=20.5f;
            float fahrenheit=ConversorDeTemperaturas.ConvertirDeCelsiusAFahrenheit(celsius);
            Console.WriteLine(fahrenheit);
            float fahrenheit2 = 68.5f;
            float celsius2 = ConversorDeTemperaturas.ConvertirDeFahrenheitACelsius(fahrenheit2);
            Console.WriteLine(celsius2);
            float kelvin = ConversorDeTemperaturas.ConvertirDeCelsiusAKelvin(celsius);
            Console.WriteLine(kelvin);
            float celsius3 = 25f;
            float fah = ConversorDeTemperaturas.ConvertirDeCelsiusAFahrenheit(celsius3);
            Console.WriteLine(fah);
        }
    }
}