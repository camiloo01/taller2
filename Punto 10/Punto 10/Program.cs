namespace Carta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opc;
            double valorTotal;
            int corriente = 0;
            int recomendado = 0;
            double acumLocal = 0;
            double acumNacional = 0;
            double acumInternacional = 0;

            do
            {

                Console.WriteLine("\n");
                Console.WriteLine("Se calculará el valor del envio de la carta, \n" +
                    "¿Deseas Cotinuar? (si-no): ");
                opc = Convert.ToString(Console.ReadLine().ToLower());

                if (opc != "si" && opc != "no")
                {
                    Console.WriteLine("Opción no válida. Por favor, ingresa 'si' o 'no'.");
                    continue;
                }

                if (opc == "no")
                {
                    break;
                }

                Console.WriteLine("Ingresa el peso de la carta en gramos: ");
                double pesocarta = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el tipo de envio: (Corriente o Recomendado)");
                string tipoenvio = Convert.ToString(Console.ReadLine().ToLower());
                Console.WriteLine("Ingresa el destino: (Local,Nacional o Internacional)");
                string destino = Convert.ToString(Console.ReadLine().ToLower());

                if (tipoenvio == "corriente" && destino == "local")
                {
                    valorTotal = pesocarta * 100 * 1.16;
                    corriente++;
                    acumLocal += valorTotal;
                    Console.WriteLine($"el valor de la carta con peso {pesocarta} gramos, tipo de envio {tipoenvio}, con destino {destino}, su total sería de: {valorTotal}");
                }
                else if (tipoenvio == "corriente" && destino == "nacional")
                {
                    valorTotal = pesocarta * 150 * 1.16;
                    acumNacional += valorTotal;
                    corriente++;

                    Console.WriteLine($"el valor de la carta con peso {pesocarta} gramos, tipo de envio {tipoenvio}, con destino {destino}, su total sería de: {valorTotal}");
                }
                else if (tipoenvio == "corriente" && destino == "internacional")
                {
                    valorTotal = pesocarta * 200 * 1.16;
                    corriente++;
                    acumInternacional += valorTotal;
                    Console.WriteLine($"el valor de la carta con peso {pesocarta} gramos, tipo de envio {tipoenvio}, con destino {destino}, su total sería de: {valorTotal}");


                }
                else if (tipoenvio == "recomendado" && destino == "local")
                {
                    valorTotal = pesocarta * 200 * 1.16;
                    recomendado++;
                    acumLocal += valorTotal;
                    Console.WriteLine($"el valor de la carta con peso {pesocarta} gramos, tipo de envio {tipoenvio}, con destino {destino}, su total sería de: {valorTotal}");


                }
                else if (tipoenvio == "recomendado" && destino == "nacional")
                {
                    valorTotal = pesocarta * 300 * 1.16;
                    recomendado++;
                    acumNacional += valorTotal;
                    Console.WriteLine($"el valor de la carta con peso {pesocarta} gramos, tipo de envio {tipoenvio}, con destino {destino}, su total sería de: {valorTotal}");


                }
                else if (tipoenvio == "recomendado" && destino == "internacional")
                {
                    valorTotal = pesocarta * 400 * 1.16;
                    recomendado++;
                    acumInternacional += valorTotal;
                    Console.WriteLine($"el valor de la carta con peso {pesocarta} gramos, tipo de envio {tipoenvio}, con destino {destino}, su total sería de: {valorTotal}");

                }
                else
                {
                    Console.WriteLine("Error al calcular");
                }


            }
            while (opc == "si");

            Console.WriteLine("la cantidad de envios corriente fueron: " + corriente);
            Console.WriteLine("la cantidad de envios recomendados fueron: " + recomendado);
            Console.WriteLine("De envios locales, Se recogio un total de: " + acumLocal);
            Console.WriteLine("De envios nacionales, Se recogio un total de: " + acumNacional);
            Console.WriteLine("De envios internacionales, Se recogio un total de: " + acumInternacional);


        }
    }
}
