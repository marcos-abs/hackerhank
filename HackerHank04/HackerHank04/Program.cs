using System;

namespace HackerHank04 {
    class Program {
        static int diagonalDifference(int[][] a) {
            int diagonal1 = 0, diagonal2 = 0, x = 0, y = 0;
            int tamanho = a[0].Length;
            for (x = 0; x < tamanho; x++) {
                diagonal1 += a[x][x];
                Console.WriteLine("Resultado diag1 de X,Y=(" + x + "," + x + ")=" + diagonal1);
            }
            x = 0;
            for (y = tamanho - 1; y >= 0; y--) {
                diagonal2 += a[x][y];
                Console.WriteLine("Resultado diag2 de X,Y=(" + x + "," + y + ")=" + diagonal2);
                x++;
            }
            if (diagonal1 > diagonal2) {
                return diagonal1 - diagonal2;
            }
            return diagonal2 - diagonal1;
        }

        static void Main(String[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++) {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int result = diagonalDifference(a);
            Console.WriteLine(result);

            Console.Write("\nPressione ENTER para finalizar:");
            Console.ReadLine();
        }
    }
}
