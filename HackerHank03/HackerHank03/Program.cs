using System;

namespace HackerHank03 {
    class Program {
        static long aVeryBigSum(int n, long[] ar) {
            long resultado = 0;
            for (int x = 0; x < n; x++) {
                resultado += ar[x];
            }
            return resultado;
        }

        static void Main(String[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);

            Console.Write("\nPressione ENTER para finalizar:");
            Console.ReadLine();
        }
    }
}
