using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next();
            int temp;
            int[] dizi = new int[100];
            // rastgele dizi oluşturuyoruz
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(0, 100);
            }
            //diziyi bouble sort ile sıralıyoruz
            for (int i = 1; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length - i; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        temp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = temp;
                    }
                }
            }
            int t;
            int baslangic = 0;
            int son = dizi.Length - 1;
            int aranan = rastgele.Next(0, 100);
            int kontrol = 0, e = 0;
            /* for (int i = 0; i < dizi.Length; i++)
            {
            System.Console.WriteLine(dizi[i]);
            }*/
            //binary search ile elemanı arama
            while (baslangic <= son)
            {
                t = (baslangic + son) / 2;
                if (dizi[t] == aranan)
                {
                    System.Console.WriteLine("indis: {0}", t);
                    kontrol = 0;
                    break;
                }
                else if (dizi[t] > aranan)
                    son = t - 1;
                else
                    baslangic = t + 1;

                kontrol = 1;
                e++;
            }
            if (kontrol == 1)
            {
                System.Console.WriteLine("aranılan eleman bulunamadı");
            }
            System.Console.WriteLine(e);

        }
    }
}