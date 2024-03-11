namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calificaciones = 5;
            double porcentajeRepro = 0;
            double porcentajeApro = 0;
            int reprobados = 0;
            int aprobados = 0;

            for (int i = 0; i < calificaciones; i++)
            {
                Console.WriteLine("Ingresa la calificacion, \n ten en cuenta que la nota minima para aprobar es 70: ");
                double calificacion = Convert.ToDouble(Console.ReadLine());

                if (calificacion < 70)
                {
                    reprobados++;
                }
                else
                {
                    aprobados++;
                }

            }
            porcentajeRepro = (double)reprobados / calificaciones * 100;
            porcentajeApro = (double)aprobados / calificaciones * 100;

            Console.WriteLine("el total en % de reporbados es: " + porcentajeRepro + "%");
            Console.WriteLine("el total en % de aprobados es: " + porcentajeApro + "%");


        }
    }
}
