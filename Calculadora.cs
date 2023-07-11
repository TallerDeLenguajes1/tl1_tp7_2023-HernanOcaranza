namespace EspacioCalculadora
{
    public class Calculadora
    {
        public double Dato { get; set; }
        public double Resultado { get; private set; }
        public void Sumar(double termino)
        {
            Dato += termino;
            Resultado = Dato;
        }
        public void Restar(double termino)
        {
            Dato -= termino;
            Resultado = Dato;
        }
        public void Multiplicar(double termino)
        {
            Dato *= termino;
            Resultado = Dato;
        }
        public void Dividir(double termino)
        {
            Dato = termino != 0 ? Dato / termino : Dato;
            Resultado = Dato;
        }
        public void Limpiar()
        {
            Dato = 0;
            Resultado = Dato;
        }
    }
}