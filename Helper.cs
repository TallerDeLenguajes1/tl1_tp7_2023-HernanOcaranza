namespace Helpers
{
    public static class Helper
    {
        public static int calcularAñosRestandoFechas(DateTime Fecha1, DateTime Fecha2)
        {
            int anios = Fecha2.Year - Fecha1.Year;

            if (Fecha2.Month < Fecha1.Month || (Fecha2.Month == Fecha1.Month && Fecha2.Day < Fecha1.Day))
            {
                anios--;
            }
            return anios;
        }
    }
}