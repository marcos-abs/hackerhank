using System;

namespace HackerHank02 {
    class Program {
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2) {
            int a = 0, b = 0;
            int[] resultado = new int[2];
            if (a0 > b0) {
                a += 1;
            } else if (b0 > a0) {
                b += 1;
            }
            if (a1 > b1) {
                a += 1;
            } else if (b1 > a1) {
                b += 1;
            }
            if (a2 > b2) {
                a += 1;
            } else if (b2 > a2) {
                b += 1;
            }

            resultado[0] = a;
            resultado[1] = b;

            return resultado;
        }

        static void Main(String[] args) {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();
        }
    }
}
