namespace PromedioPesosNiños
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de personas a muestrear:");
            int N = Convert.ToInt32(Console.ReadLine());

            int acumuladorNiño = 0;
            int acumuladorJoven = 0;
            int acumuladorAdulto = 0;
            int acumuladorViejo = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona:");
                int edad = Convert.ToInt32(Console.ReadLine());

                if (edad > 0 && edad <= 12)
                {
                    Console.WriteLine("Ingrese el peso del niño:");
                    int pesoNiño = Convert.ToInt32(Console.ReadLine());
                    acumuladorNiño += pesoNiño;
                }
                else if (edad >= 13 && edad <= 29)
                {
                    Console.WriteLine("Ingrese el peso del joven:");
                    int pesoJoven = Convert.ToInt32(Console.ReadLine());
                    acumuladorJoven += pesoJoven;
                }
                else if (edad > 30 && edad <= 59)
                {
                    Console.WriteLine("Ingrese el peso del adulto:");
                    int pesoAdulto = Convert.ToInt32(Console.ReadLine());
                    acumuladorAdulto += pesoAdulto;
                }
                else if (edad > 60)
                {
                    Console.WriteLine("Ingrese el peso del viejo:");
                    int pesoViejo = Convert.ToInt32(Console.ReadLine());
                    acumuladorViejo += pesoViejo;
                }
                else
                {
                    Console.WriteLine("Error: Edad no válida");
                    i--;
                }
            }

            Console.WriteLine("Resultados:");
            Console.WriteLine("Promedio de peso de niños: " + (acumuladorNiño / (double)N));
            Console.WriteLine("Promedio de peso de jóvenes: " + (acumuladorJoven / (double)N));
            Console.WriteLine("Promedio de peso de adultos: " + (acumuladorAdulto / (double)N));
            Console.WriteLine("Promedio de peso de viejos: " + (acumuladorViejo / (double)N));
        }
    }
}