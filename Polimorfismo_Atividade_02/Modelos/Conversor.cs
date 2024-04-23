namespace Temperatura.Modelos;

internal class Conversor
{
    // public string Temperatura { get; set; }


    //de Celsius para fahrenheit
    public double ConverterTemperatura(double tempC)
    {
        return (tempC * 9 / 5) +32;
    }

    //de fahrenheit para Celsius
    public float ConverterTemperatura(float tempF)
    {
        return (tempF - 32) * 5 / 9;
    }
}