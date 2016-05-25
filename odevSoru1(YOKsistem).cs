using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_YOK_
{
    public class Program
    {
        class Student
        {
            public int ogrenciID { get; set; }
            public string ogrenciAd { get; set; }
            public string ogrenciSoyAd { get; set; }
            public int ogrenciBolumID { get; set; }
        }

        class Bolumler
        {
            public int bolumID { get; set; }
            public string bolumAd { get; set; }
            public int bolumFakulteID { get; set; }

        }

        class Dersler
        {
            public int dersID { get; set; }
            public string dersAd { get; set; }
            public int dersBolumID { get; set; }

        }

        class Fakulte
        {
            public int fakulteID { get; set; }
            public string fakulteAd { get; set; }
            public int fakulteBolumID { get; set; }

        }

        class Akademisyen
        {
            public int akademisyenID { get; set; }
            public string akademisyenAd { get; set; }
            public string akademisyenSoyad { get; set; }
            public int akademisyenBolumID { get; set; }

        }

        static Random rnd = new Random();
        public static char GetLetter()
        {
            int num = rnd.Next(0, 26);
            char let = (char)('a' + num);
            return let;
        }

        public static void iceriklerikOLusturma()
        {
            int sayac1 = 0;

            //string listede Fakulte isimleri oluşturuluyor...
            string[] fakulteisim = { "Muhendislik", "Tıp Fak.", "Fen Edebiyat", "Truzim FAk.", "Isletme Fak.", "Hukuk Fak.", "Saglık Bilimleri", "Mimarlik Fak.", "Ziraat Fak.", "Ilahiyat Fak." };
            string[] fakulte = new string[10];
            string fakulteolustur;

            // fakulte oluşturdaki string ifade fakulte[] dizisine altarılıyor...
            for (int i = 0; i < 10; i++)
            {
                fakulteolustur = i.ToString() + "," + fakulteisim[i];
                fakulte[i] = fakulteolustur;

            }

            //string listede Bolum isimleri oluşturuluyor...
            string[] bolumisim = { "Bilgisayar Muhendisligi", "Makina Muhendisligi", "Tıp", "Edebiyat", "Matematik", "Truzim", "Isletme Yonetimi", "Isletme", "Hukuk", "Hemsirelik", "Ic Mimarlik", "Peyzaj Mimarlık", "Mimarlık", "Ziraat Mühendisliği", "Ilahiyat" };
            string[] bolum = new string[15];
            string bolumolustur;

            // fakulte oluşturdaki string ifade bolum[] dizisine altarılıyor...
            for (int i = 0; i < 15; i++)
            {
                if (sayac1 == 10)
                    sayac1 = 0;
                bolumolustur = i.ToString() + "," + bolumisim[i] + "," + sayac1;
                bolum[i] = bolumolustur;
                sayac1++;
            }

            //string listede Bolum isimleri oluşturuluyor...
            string[] akademisyenisim = { "ali", "lutfullah", "hasan", "ersin", "pınar", "sema", "ayse", "emine", "rıfkı", "kadir", "riza", "canan", "adnan", "kamuran", "onur", "temel", "ahmet", "basri" };
            string[] akademisyensoyisim = { "cetin", "altindag", "kaynak", "boluk", "serap", "akdogan", "agaoglu", "agaoglu", "terzi", "terzioglu", "bilim", "kaya", "ortac", "gurses", "kara", "borsan", "yugi", "turk" };
            string[] akademisyen = new string[18];
            string akademisyenolustur;
            sayac1 = 0;
            // akademisyen oluşturdaki string ifade akademisyen[] dizisine altarılıyor...
            for (int i = 0; i < 18; i++)
            {
                if (sayac1 == 15)
                    sayac1 = 0;
                akademisyenolustur = i.ToString() + "," + akademisyenisim[i] + "," + akademisyensoyisim[i] + "," + sayac1;
                akademisyen[i] = akademisyenolustur;
                sayac1++;
            }

            //string listede Bolum isimleri oluşturuluyor...
            string[] ogrenciisim = { "ali", "veli", "hasan", "recep", "pınar", "sema", "ayse", "emine", "rıfkı", "serkan", "riza", "canan", "gülen", "kamuran", "aytac", "temel", "mehmet", "basri" };
            string[] ogrencisoyisim = { "yılmaz", "aksi", "yurt", "boluk", "serap", "akdogan", "agaoglu", "agaoglu", "terzi", "terzioglu", "bilim", "kaya", "ortac", "gurses", "kara", "borsan", "yugi", "turk" };
            string[] ogrenci = new string[36];
            string ogrenciolustur;
            sayac1 = 0;
            // akademisyen oluşturdaki string ifade akademisyen[] dizisine altarılıyor...
            for (int i = 0; i < 18; i++)
            {
                if (sayac1 == 15)
                    sayac1 = 0;
                ogrenciolustur = i.ToString() + "," + ogrencisoyisim[i] + "," + ogrenciisim[i] + "," + sayac1;
                ogrenci[i] = ogrenciolustur;
                sayac1++;
            }

            for (int i = 0; i < 18; i++)
            {
                if (sayac1 == 15)
                    sayac1 = 0;
                ogrenciolustur = (18 + i) + "," + ogrencisoyisim[17 - i] + "," + ogrenciisim[i] + "," + sayac1;
                ogrenci[i + 18] = ogrenciolustur;
                sayac1++;
            }

            string[] dersisim = { "Algoritma Analizi", "Bilgisayar Mimarisi", "Yapay Zeka", "Gorsel Programlama", "Matematik" };
            string[] ders = new string[135];
            string dersolustur;

            // fakulte oluşturdaki string ifade bolum[] dizisine altarılıyor...
            for (int i = 0; i < 100; i++)
            {
                if (sayac1 == 15)
                    sayac1 = 0;
                dersolustur = i.ToString() + "," + GetLetter() + GetLetter() + GetLetter() + "," + sayac1;
                ders[i] = dersolustur;
                sayac1++;
            }
            sayac1 = 0;
            int sayac2 = 0;
            for (int i = 0; i < 35; i++)
            {
                sayac2++;
                if (sayac2 == 5)
                    sayac2 = 0;
                if (sayac1 == 15)
                    sayac1 = 0;
                dersolustur = i + 100 + "," + dersisim[sayac2] + "," + sayac1;
                ders[i + 100] = dersolustur;
                sayac1++;
            }

            // txt dosyalarına oluşturlan string diziler yazılıyor....
            System.IO.File.WriteAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\ogrenciler.txt", ogrenci);
            System.IO.File.WriteAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\akademisyenler.txt", akademisyen);
            System.IO.File.WriteAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\fakulteler.txt", fakulte);
            System.IO.File.WriteAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\bolumler.txt", bolum);
            System.IO.File.WriteAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\dersler.txt", ders);
        }

        static void Main(string[] args)
        {
            iceriklerikOLusturma();


            //oluşturulan içerikleri dosyadan okuyup string dizilere aktarma...
            string[] ogrenciler = System.IO.File.ReadAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\ogrenciler.txt");
            string[] bolumler = System.IO.File.ReadAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\bolumler.txt");
            string[] dersler = System.IO.File.ReadAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\dersler.txt");
            string[] fakulteler = System.IO.File.ReadAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\fakulteler.txt");
            string[] akademisyenler = System.IO.File.ReadAllLines(@"C:\Users\PersonelComputer\Desktop\algoritmaAnalizi\akademisyenler.txt");

            IEnumerable<Student> ogrenciSorgu = from nameLine in ogrenciler
                                                let splitName = nameLine.Split(',')

                                                select new Student() { ogrenciID = Convert.ToInt32(splitName[0]), ogrenciAd = splitName[1], ogrenciSoyAd = splitName[2], ogrenciBolumID = Convert.ToInt32(splitName[3]) };

            IEnumerable<Bolumler> bolumSorgu = from nameLine in bolumler
                                               let splitName = nameLine.Split(',')

                                               select new Bolumler() { bolumID = Convert.ToInt32(splitName[0]), bolumAd = splitName[1], bolumFakulteID = Convert.ToInt32(splitName[2]) };

            IEnumerable<Dersler> dersSorgu = from nameLine in dersler
                                             let splitName = nameLine.Split(',')

                                             select new Dersler() { dersID = Convert.ToInt32(splitName[0]), dersAd = splitName[1], dersBolumID = Convert.ToInt32(splitName[2]) };

            IEnumerable<Fakulte> fakulteSorgu = from nameLine in fakulteler
                                                let splitName = nameLine.Split(',')

                                                select new Fakulte()
                                                { fakulteID = Convert.ToInt32(splitName[0]), fakulteAd = splitName[1], };

            IEnumerable<Akademisyen> akademisyenSorgu = from nameLine in akademisyenler
                                                        let splitName = nameLine.Split(',')

                                                        select new Akademisyen() { akademisyenID = Convert.ToInt32(splitName[0]), akademisyenAd = splitName[1], akademisyenSoyad = splitName[2], akademisyenBolumID = Convert.ToInt32(splitName[3]) };

            List<Student> student = ogrenciSorgu.ToList();
            List<Bolumler> departments = bolumSorgu.ToList();
            List<Dersler> lesson = dersSorgu.ToList();
            List<Fakulte> faculty = fakulteSorgu.ToList();
            List<Akademisyen> academician = akademisyenSorgu.ToList();

            var sorgu = (from OGRENCİ in student
                         from BOLUMLER in departments
                         from DERSLER in lesson
                         from FAKULTE in faculty
                         from AKADEMİSYEN in academician
                         where FAKULTE.fakulteID == BOLUMLER.bolumFakulteID && BOLUMLER.bolumID == OGRENCİ.ogrenciBolumID && BOLUMLER.bolumID == AKADEMİSYEN.akademisyenBolumID && BOLUMLER.bolumID == DERSLER.dersBolumID && DERSLER.dersAd == "Bilgisayar Mimarisi"
                         select new { Fakulte = FAKULTE.fakulteAd, Bolum = BOLUMLER.bolumAd, Ders = DERSLER.dersAd, AkademisyenAdı = AKADEMİSYEN.akademisyenAd, AkademiyenSoyadı = AKADEMİSYEN.akademisyenSoyad, OgrenciAd = OGRENCİ.ogrenciAd, OgrenciSoyad = OGRENCİ.ogrenciSoyAd }).Distinct();
            //konsol ekranına çıktı verir...
            Console.WriteLine("Fakulte İsmi-----------Bolum İsmi---------Ders Adı-------------Akademisyen AdSoyad----------Ogrenci AdSoyad");
            foreach (var item in sorgu)
            {
                Console.Write(item.Fakulte + " ---"); Console.Write(item.Bolum + " ---"); Console.Write(item.Ders + " ---"); Console.Write(item.AkademisyenAdı + " ");
                Console.Write(item.AkademiyenSoyadı + " ---"); Console.Write(item.OgrenciAd + " "); Console.Write(item.OgrenciSoyad + " ---"); Console.WriteLine(" ");
            }
        }
    }
}
