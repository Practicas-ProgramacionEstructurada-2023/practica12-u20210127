using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo bidimensional
            int[,] matrizBidimensional = new int[3, 4];

            // Inicialización del arreglo bidimensional
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    matrizBidimensional[fila, columna] = fila * 4 + columna + 1;
                }
            }

            // Imprimir el arreglo bidimensional
            Console.WriteLine("\nArreglo Bidimensional:");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.Write(matrizBidimensional[fila, columna] + "\t");
                }
                Console.WriteLine();
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Arreglo tridimensional
            int[,,] matrizTridimensional = new int[3, 3, 4];

            // Inicialización del arreglo tridimensional
            for (int caja = 0; caja < 3; caja++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 4; columna++)
                    {
                        matrizTridimensional[caja, fila, columna] = caja * 12 + fila * 4 + columna + 1;
                    }
                }
            }

            // Imprimir el arreglo tridimensional
            Console.WriteLine("\nArreglo Tridimensional:");
            for (int caja = 0; caja < 3; caja++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 4; columna++)
                    {
                        Console.Write(matrizTridimensional[caja, fila, columna] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}