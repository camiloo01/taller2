using System;

class Program
{
    static void Main(string[] args)
    {
        int candidato1 = 0;
        int candidato2 = 0;
        int candidato3 = 0;

        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine("Ingrese los votos de los candidatos (candidato #1, #2, #3): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                candidato1++;
            }
            else if (opcion == 2)
            {
                candidato2++;
            }
            else if (opcion == 3)
            {
                candidato3++;
            }
            else
            {
                Console.WriteLine("Voto no contado");
            }
        }

        // Calcular porcentajes
        int totalVotos = candidato1 + candidato2 + candidato3;
        double porcentajeCandidato1 = (double)candidato1 / totalVotos * 100;
        double porcentajeCandidato2 = (double)candidato2 / totalVotos * 100;
        double porcentajeCandidato3 = (double)candidato3 / totalVotos * 100;

        // Determinar ganador o empate
        int ganador = 0;
        int maxVotos = Math.Max(candidato1, Math.Max(candidato2, candidato3));

        if (maxVotos == candidato1 && candidato1 != candidato2 && candidato1 != candidato3)
        {
            ganador = 1;
        }
        else if (maxVotos == candidato2 && candidato2 != candidato1 && candidato2 != candidato3)
        {
            ganador = 2;
        }
        else if (maxVotos == candidato3 && candidato3 != candidato1 && candidato3 != candidato2)
        {
            ganador = 3;
        }
        else
        {
            Console.WriteLine("Hubo un empate, inicia otra vez las votaciones");
            return;
        }

        // Imprimir resultados
        Console.WriteLine("Resultados:");
        Console.WriteLine("Votos para candidato 1: " + candidato1 + " (" + porcentajeCandidato1 + "%)");
        Console.WriteLine("Votos para candidato 2: " + candidato2 + " (" + porcentajeCandidato2 + "%)");
        Console.WriteLine("Votos para candidato 3: " + candidato3 + " (" + porcentajeCandidato3 + "%)");
        Console.WriteLine("El ganador es el candidato " + ganador + " con " + maxVotos + " votos.");
    }
}
