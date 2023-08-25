using System;

namespace GeneracionDeVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del vector: ");
            int longitud = int.Parse(Console.ReadLine());

            int[] vector = GenerarVectorAleatorio(longitud);

            Console.WriteLine("\nVector generado:");
            ImprimirVector(vector);

            Console.ReadKey();
        }

        static int[] GenerarVectorAleatorio(int longitud)
        {
            Random random = new Random();
            int[] vector = new int[longitud];

            for (int i = 0; i < longitud; i++)
            {
                vector[i] = random.Next(1, 101); // Números aleatorios entre 1 y 100
            }

            return vector;
        }

        static void ImprimirVector(int[] vector)
        {
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
