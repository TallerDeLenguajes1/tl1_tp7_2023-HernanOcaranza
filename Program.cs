using SistemaAdministracion;
namespace EspacioCalculadora
{
    public class Program
    {
        static void Main()
        {
            double montoTotal = 0;
            int menor = 9999999;
            int indMasViejo = 0;
            var empleado1 = new Empleado(
                "Maria",
                "Villagra",
                new DateTime(1997, 5, 31),
                'S',
                'F',
                new DateTime(2020, 8, 12),
                300000,
                Cargos.Ingeniero
            );

            var empleado2 = new Empleado(
                "Luis",
                "Ocaranza",
                new DateTime(1963, 2, 28),
                'C',
                'M',
                new DateTime(1980, 8, 12),
                450000,
                Cargos.Auxiliar
            );

            var empleado3 = new Empleado(
                "Gustavo",
                "Medina",
                new DateTime(1987, 5, 31),
                'C',
                'M',
                new DateTime(2008, 6, 12),
                65000,
                Cargos.Especialista
            );

            var listaEmpleados = new Empleado[3] { empleado1, empleado2, empleado3 };

            for (int i = 0; i < 3; i++)
            {
                montoTotal += listaEmpleados[i].salario();
                if (menor > listaEmpleados[i].cantidadAniosParaJubilarse())
                {
                    menor = listaEmpleados[i].cantidadAniosParaJubilarse();
                    indMasViejo = i;
                }
            }

            System.Console.WriteLine($"El monto total en concepto de salarios es de: {montoTotal}");
            listaEmpleados[indMasViejo].MostrarDatos();
        }
    }
}