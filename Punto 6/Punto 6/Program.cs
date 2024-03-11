namespace Placas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos autos van a entrar a la ciudad?: ");
            int autos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < autos; i++)
            {
                Console.WriteLine("Ingresa la placa del Auto \n (Ejemplo: HMN230)");
                String placa = Convert.ToString(Console.ReadLine());


                int ultimoDigito = int.Parse(placa[placa.Length - 1].ToString());

                switch (ultimoDigito)
                {

                    case 1:
                    case 2:
                        Console.WriteLine("Coche con calcomania de color amarilla");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Coche con calcomania de color rosa");
                        break;
                    case 5:
                    case 6:
                        Console.WriteLine("Coche con calcomania de color roja");
                        break;
                    case 7:
                    case 8:
                        Console.WriteLine("Coche con calcomania de color verde");
                        break;
                    case 9:
                    case 0:
                        Console.WriteLine("Coche con calcomania de color azul");
                        break;
                    default:
                        Console.WriteLine("No se puede determinar el color");
                        break;

                }
            }
        }
    }
}
