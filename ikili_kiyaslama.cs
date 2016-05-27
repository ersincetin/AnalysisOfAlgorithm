using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_0_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m =0 , rant =0 , maxRant = 0;
            int yedek1 = 0, yedek2 = 0;
            string yedek3 = null;

            Console.Write("Musteri Sayisini Giriniz        : "); n = Convert.ToInt32(Console.ReadLine()); // satır sayısı
            Console.Write("Urun Çeşit Miktarını Giriniz    : "); m = Convert.ToInt32(Console.ReadLine()); //sutun sayısı

            int[,] array = new int[n, m];
            Random rnd = new Random();

            //Girilen satır ve sutun sayısına göre diziyi olusturma
            Console.Write("|");
            for (int j = 0; j < m+1; j++) { Console.Write("----|"); }Console.WriteLine();
            Console.Write("|");
            for (int i = 0; i < m; i++){ if (i == 0) Console.Write("*__*|"); if (i > 8) { Console.Write("u" + (i + 1) + " |"); } else { Console.Write(" u" + (i + 1) + " |"); } }Console.WriteLine();
            Console.Write("|");
            for (int j = 0; j < m+1; j++) { Console.Write("----|"); }Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i<9) { Console.Write("|m" + (i + 1) + "  |"); } else { Console.Write("|m" + (i + 1) + " |"); }
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(0,2);
                    Console.Write(" "+array[i,j]+"  |");
                    
                }
                Console.WriteLine();
                Console.Write("|"); for (int j = 0; j < m+1; j++) { Console.Write("----|"); }Console.WriteLine();
            }
            //olusturulan diziyi tablo.txt dosyasina aktarma
            FileStream fs = new FileStream(@"C:\Users\PersonelComputer\Desktop\tablo.txt", FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sw.Write(array[i,j]);
                }
                sw.WriteLine();
                sw.Flush();
            }
            sw.Close();fs.Close();

            //tablo.txt dosyasındaki veriler tekrar diziye aktarılıyor...

            FileStream fs1 = new FileStream(@"C:\Users\PersonelComputer\Desktop\tablo.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            int[,] array_ = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                yedek3 = sr.ReadLine();
                
                for (int j = 0; j < yedek3.Length; j++)
                {
                    array_[i, j] = Convert.ToInt32(yedek3[j]);
                }Console.WriteLine();
                yedek3 = null;
            }
            fs1.Close();sr.Close();

            //en cok satinalinan 2 ürünü buluyor...
            for (int i = 0; i < m-1; i++)
            {
                for (int j = i+1; j < m; j++)
                {
                    for (int k = 0; k < n; k++){if (array[k, i] == array[k, j] && array[k,i]==1 ) rant++;}
                    if (maxRant < rant) { maxRant = rant; yedek1 =i ;yedek2 =j; }rant = 0;
                }
            }

            
            Console.WriteLine((yedek1+1)+". urun ve "+(yedek2+1)+". urun en cok birlikte satın alinan urunlerdir.");Console.WriteLine("Satin alinma sayisi : " + maxRant+" dir.");
            System.IO.File.Delete(@"C:\Users\PersonelComputer\Desktop\tablo.txt");//iş bittikten tablo.txt dosyasını silmeye yarıyor...
        }
    }
}
