namespace Contaminantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vehiculo = 25;
            double sumaPuntos = 0;
            double promedio = 0;
            double maximoPuntos = 0;
            double mininoPuntos = 0;
            double[] Puntos = new double[vehiculo];


            for (int i = 0; i < vehiculo; i++)
            {

                Console.WriteLine("Ingrese los puntos contaminantes");
                Puntos[i] = double.Parse(Console.ReadLine());

                sumaPuntos += Puntos[i];
                promedio = sumaPuntos / vehiculo;


            }
            maximoPuntos = Puntos.Max();
            mininoPuntos = Puntos.Min();
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Carro que más contamino: " + maximoPuntos);
            Console.WriteLine("Carro que menos contamino: " + mininoPuntos);



        }
    }
}