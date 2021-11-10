using System;

namespace Arreglos
{
    class Program
    {
        private int[,] filas;
        private int[,] columnas;
        private int[,] acum;
        public void Cargar()
        {
            //filas = new int[10, 10];
            //columnas = new int[10, 10];
            acum = new int[10, 10];

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("Ingrese el tamaño del arreglo: ");
                    string linea;
                    linea = Console.ReadLine();
                    int filas = int.Parse(linea);
                    linea = Console.ReadLine();
                    int columnas = int.Parse(linea);
                }
            }

            //Sumamos la matrizA y la MatrizB
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    acum[i, j] = filas[i, j] + columnas[i, j];
                }
            }
        }
        // visualizamos la suma de las matrices
        public void visualizar()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(acum[i, j] + "  ");
                }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.visualizar();
        }
    }
}
