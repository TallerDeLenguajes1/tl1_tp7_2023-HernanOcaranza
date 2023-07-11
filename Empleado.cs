using Helpers;
namespace SistemaAdministracion
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public char Genero { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Double SueldoBasico { get; set; }
        public Cargos Cargo { get; set; }

        public Empleado() { }
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            Genero = genero;
            FechaIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }

        public int antiguedad()
        {
            return Helper.calcularAñosRestandoFechas(FechaIngreso, DateTime.Today);
        }

        public int edad()
        {
            return Helper.calcularAñosRestandoFechas(FechaNacimiento, DateTime.Today);
        }

        public int cantidadAniosParaJubilarse()
        {
            int anios = (Genero == 'M') ? 65 - edad() : 60 - edad();
            return (anios < 0) ? 0 : anios;
        }

        public double salario()
        {
            return SueldoBasico + adicional();
        }

        private double adicional()
        {
            var añosAntiguedad = antiguedad();
            var suma = (añosAntiguedad < 20) ? SueldoBasico * añosAntiguedad / 100 : SueldoBasico * 0.25;
            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                suma *= 1.5;
            if (EstadoCivil == 'C')
                suma += 15000;
            return suma;
        }

        public void MostrarDatos()
        {
            System.Console.WriteLine("----------------------------------------------------------------");
            System.Console.WriteLine($"Empleado: {Apellido}, {Nombre}");
            System.Console.WriteLine($"Estado civil: {EstadoCivil}");
            System.Console.WriteLine($"Genero: {Genero}");
            System.Console.WriteLine($"Edad: {edad()}");
            System.Console.WriteLine($"Antiguedad: {antiguedad()}");
            System.Console.WriteLine($"Cantidad de años que faltan para jubilarse: {cantidadAniosParaJubilarse()}");
            System.Console.WriteLine($"Cargo: {Cargo.ToString()}");
            System.Console.WriteLine($"Salario: {salario()}");
        }
    }
}