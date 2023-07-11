namespace EspacioCalculadora
{
    public class Program
    {
        static void Main()
        {
            var calc = new Calculadora();
            calc.Sumar(20);
            calc.Dividir(4);
            calc.Multiplicar(2);
            calc.Restar(4);
            System.Console.WriteLine($"El resultado es: {calc.Resultado}");
        }
    }
}