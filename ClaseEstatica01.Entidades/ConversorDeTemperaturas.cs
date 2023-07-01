namespace ClaseEstatica01.Entidades
{
    /// <summary>
    /// Clase estática para convertir temperaturas de una 
    /// escala a otra
    /// </summary>
    public static class ConversorDeTemperaturas
    {
        private const float CeroAbsoluto= 273.15f;
        /// <summary>
        /// Método estático para convertir de celsius a Fah
        /// </summary>
        /// <param name="celsius">Valor de la Temperatura a Convertir</param>
        /// <returns>El resultado de la conversión en grados Fah</returns>
        public static float ConvertirDeCelsiusAFahrenheit(float celsius)
        {
            return 1.8f * celsius + 32;
        }
        public static float ConvertirDeFahrenheitACelsius(float fahrenheit)
        {
            return  (fahrenheit - 32)/1.8f;
        }
        public static float ConvertirDeCelsiusAKelvin(float celsius) => celsius + CeroAbsoluto;
        public static float ConvertirDeKelvinACelsius(float kelvin) => kelvin - CeroAbsoluto;
    }
}