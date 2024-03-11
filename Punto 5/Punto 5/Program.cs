namespace edadesAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el tipo de animal a estudiar:");
            Console.WriteLine("1. Elefantes");
            Console.WriteLine("2. Jirafas");
            Console.WriteLine("3. Chimpancés");

            int opcion = int.Parse(Console.ReadLine());

            int cantidadMuestras = 0;
            string tipoAnimal = "";

            switch (opcion)
            {
                case 1:
                    cantidadMuestras = 20;
                    tipoAnimal = "Elefantes";
                    break;
                case 2:
                    cantidadMuestras = 15;
                    tipoAnimal = "Jirafas";
                    break;
                case 3:
                    cantidadMuestras = 40;
                    tipoAnimal = "Chimpancés";
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    return;
            }

            Console.WriteLine($"Se tomarán {cantidadMuestras} muestras de {tipoAnimal}");

            Console.WriteLine("Ingrese la cantidad de animales de 0 a 1 año:");
            int categoria1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de animales de más de 1 año y menos de 3:");
            int categoria2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de animales de 3 o más años:");
            int categoria3 = int.Parse(Console.ReadLine());

            int totalAnimales = categoria1 + categoria2 + categoria3;

            double porcentajeCategoria1 = ((double)categoria1 / totalAnimales) * 100;
            double porcentajeCategoria2 = ((double)categoria2 / totalAnimales) * 100;
            double porcentajeCategoria3 = ((double)categoria3 / totalAnimales) * 100;

            Console.WriteLine($"Porcentaje de animales de 0 a 1 año: {porcentajeCategoria1}%");
            Console.WriteLine($"Porcentaje de animales de más de 1 año y menos de 3: {porcentajeCategoria2}%");
            Console.WriteLine($"Porcentaje de animales de 3 o más años: {porcentajeCategoria3}%");
        }
    }
}

