using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerHank01 {
    internal class Program {
        private static int simpleArraySum(int n, int[] ar) {
            int resultado = 0;
            foreach (int x in ar) {
                resultado += x;
                Console.WriteLine("Resultado=" + x);
            }
            return resultado;
        } 

        private static void Main(String[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

