using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMatrisCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Rastgele olusturulacak matrisin satir sayisini griniz   :"); n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rastgele olusturulacak matrisin sutun sayisini giriniz  :"); m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[m,n];
            Random rnd = new Random();

            for (int i = 0; i < m ; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(10, 100);
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine("|");
            }
        }
    }
}
