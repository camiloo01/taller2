
namespace Naranjas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double acumPagoTotal = 0;
            double totalapagar;
            double precioPorKilo = 1.5;


            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Cliente #" + (i + 1));

                Console.WriteLine("Ingresa la cantidad de kilos a pagar");
                double kilos = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();


                if (kilos > 10)
                {


                    totalapagar = (precioPorKilo * kilos) * 0.85;
                    acumPagoTotal += totalapagar;


                }
                else
                {
                    totalapagar = precioPorKilo * kilos;
                    acumPagoTotal += totalapagar;
                }
                Console.WriteLine("Total a pagar del cliente #" + (i + 1) + " es: " + totalapagar);
            }
            Console.WriteLine();
            Console.WriteLine("el total que recibira la tienda en pagos es: " + acumPagoTotal);
        }
    }
}
