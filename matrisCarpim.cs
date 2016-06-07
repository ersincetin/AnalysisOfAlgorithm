using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrisCarpimi
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int  m,n,p,r;
            Console.Write("Birinci matrisin satir sayisini giriniz      :"); m = Convert.ToInt32(Console.ReadLine());//1.matrisin satir sayisi
            Console.Write("Birinci matrisin sutun sayisini giriniz      :"); n = Convert.ToInt32(Console.ReadLine());//1.matrisin sutun sayisi

            Console.WriteLine();

            Console.Write("ikinci matrisin satır sayisini giriniz       :"); p = Convert.ToInt32(Console.ReadLine());//2.matrisin satir sayisi
            Console.Write("İkinci matrisin sutun sayisini giriniz       :"); r = Convert.ToInt32(Console.ReadLine());//2.matrisin satir sayisi

            Console.WriteLine();



            if (n != p)
            {
                Console.WriteLine("Bu iki matrisi carpamazsiniz...!!!");
            }
            else
            {
                Random rnd = new Random();
                int[,] arr1 = new int[m,n];

                int toplam = 0;
                //1.matris olusturma
                for (int i = 0; i < m; i++)
                {
                    Console.Write("| ");
                    for (int j = 0; j < n; j++)
                    {
                        arr1[i,j] = rnd.Next(0, 5);
                        Console.Write(arr1[i,j]+" ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine();

                int[,] arr2 = new int[p,r];
                //2.matris olusturma
                for (int i = 0; i < p; i++)
                {
                    Console.Write("| ");
                    for (int j = 0; j < r; j++)
                    {
                        arr2[i, j] = rnd.Next(0, 5);
                        Console.Write(arr2[i,j]+" ");
                    } 
                    Console.WriteLine("|");
                }
                Console.WriteLine();

                int[,] arr3 = new int[m,r];
                //3.matris olusturma
                for (int i = 0; i < m; i++)
                {
                    Console.Write("| ");
                    for (int j = 0; j < r; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            toplam += arr1[i, k] * arr2[k, j];
                        }
                        arr3[i, j] = toplam ;
                        Console.Write(arr3[i,j] + " ");
                        toplam = 0;
                    }
                    Console.WriteLine("|");
                }

                
            }

        }
    }
}
