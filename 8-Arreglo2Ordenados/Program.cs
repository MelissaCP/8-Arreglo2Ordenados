using System;
using C = System.Console;

namespace _8_Arreglo2Ordenados
{
    class Program
    {
        /// Practica 8
        /// 8.- Generar un arreglo a partir de 2 arreglos ordenados.
        /// 
                   /* //Arreglo unidimensional 

            int[] valores1;                       //sin inicializar
            int[] valores2 = new int[50];



            //Arreglos multidimensionales
            int[,] valores1;                    //sin inicializar
            int[,] valores2 = new int[3, 7];
            int[,,] valores3 = new int[3, 4, 2]; //Arreglo de tres dimensiones


            //Arreglo de arreglos
            int[][] matriz;                   //sin inicializar
                                              //Los arreglos de arreglos se inicializan de manera diferente
            int[][] matriz = new int[3][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[4];
            }
           */

        /// Chávez Pérez Melissa
        /// #M21210035
        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            // Matriz bidimensional.

            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // La misma matriz con las dimensiones especificadas.

            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // Una matriz similar con elementos de cadena.
            string[,] array2Db = new string[3, 2] { { "uno", "dos" }, { "tres", "cuatro" },
                                        { "cinto", "seis" } };

            // Matriz tridimensional.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };

            // La misma matriz con las dimensiones especificadas.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            // Elementos necesarios
            C.WriteLine(array2D[0, 0]);
            C.WriteLine(array2D[0, 1]);
            C.WriteLine(array2D[1, 0]);
            C.WriteLine(array2D[1, 1]);
            C.WriteLine(array2D[3, 0]);
            C.WriteLine(array2Db[1, 0]);
            C.WriteLine(array3Da[1, 0, 1]);
            C.WriteLine(array3D[1, 1, 2]);

            // Accediendo a elementos de la matriz.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            C.WriteLine("{0} es igual a {1}", allLength, total);
            C.ReadLine();
        }
    }
}
