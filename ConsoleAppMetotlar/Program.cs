using System.Text;

namespace ConsoleAppMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tekrar();
            //StringMetot();
            //MetodOlusturma();
            //MetodCagirma();
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(Toplama(x, y));
            // Console.WriteLine(Carpma(x, y));

            //KareAl();

            //BirdenYuz();

            //BirdenBir(31);

            //Console.WriteLine(Kup()); 

            //TekCift();

            //BuyukKucuk();
        }

       private static void BuyukKucuk()
        {
            int a;
            int b;
            Console.WriteLine("İki sayı giriniz :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[] {a,b};

            Console.WriteLine(sayilar.Max());
        }

        private static void TekCift()
        {
            int sayi;
            Console.WriteLine("Bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine("Çift");
            else
                Console.WriteLine("Tek");
        }

        private static double Kup()
        {
            int a;
            int b;
            double toplam = 0;
            Console.WriteLine("iki sayı giriniz : ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            toplam = a + b;

            return Math.Pow(toplam, 3);
        }

        private static void BirdenBir(int x)
        {
            for (int i = 1; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void BirdenYuz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void KareAl()
        {
            int x;

            Console.WriteLine("Bir sayı giriniz:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(x,2));
        }

        private static void MetodCagirma()
        {
            BilgeAdam();
        }
        private static int Toplama(int x,int y)
        {
            Console.WriteLine(Carpma(x, y)); 
            return x + y;
        }
        private static int Carpma(int x, int y)
        {
            
            return x * y;
        }
        static void BilgeAdam()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("BilgeAdam");
            }

        }
        private static void MetodOlusturma()
        {
            // donustipi MetodAdi (parametre/ler)
            // {
            //   yapılacaklar
            // }
        }

        private static void StringMetot()
        {
            //string kelime = "ahtapot";

            //Console.WriteLine(kelime.Length);

            int[] sayilar = { 55, 95, 105, 115, -5, 201, -66 };
            //Array.Sort(sayilar);
            //Array.Reverse(sayilar);
            //Array.Resize(ref sayilar, 1);

            Console.WriteLine(sayilar.Sum()); // Toplamı
            Console.WriteLine(sayilar.Average()); // Aritmetik ortalaması
            Console.WriteLine(sayilar.Min()); // Minimum
            Console.WriteLine(sayilar.Max()); // Maximum

            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]); // 95
            Console.WriteLine(sayilar.GetValue(1)); // 95

            Console.WriteLine(sayilar.First());
            Console.WriteLine(sayilar[sayilar.Length -1]);
            Console.WriteLine(sayilar.Last());

            Console.WriteLine(Math.Min(1,2));
            Console.WriteLine(Math.Max(3, 2));

            //Array.Clear(sayilar);

            //int[] kopya = new int[7];

            //Array.Copy(sayilar,2,kopya,3,1);

            //Array.Resize(ref kopya,20);

            //foreach (int i in sayilar)
            //    Console.WriteLine(i);


        }

        private static void Tekrar()
        {
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 4)
            //        break;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------");
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 4)
            //        continue;
            //    Console.WriteLine(i);

            //}

            //string kelime = "Merhab.a";
            //Console.WriteLine(kelime[3]);
            ////kelime = kelime.Substring(4);
            //Console.WriteLine(kelime.Substring(4)); // ab.a
            //Console.WriteLine(kelime.Substring(4,2));// ab
            //Console.WriteLine(kelime.Substring(kelime.IndexOf("."), 2)); // .a
            //Console.WriteLine(kelime);


            //string kelime;

            //Console.WriteLine("Kelime yazınız :");
            //kelime = Console.ReadLine();

            //if (kelime.EndsWith('y'))
            //    //Console.WriteLine($"{kelime.Substring(0, kelime.Length - 1)}ies");
            //    Console.WriteLine($"{kelime.Substring(0, kelime.IndexOf('y'))}ies");
            //else if(kelime.EndsWith('s') || kelime.EndsWith('o'))
            //    Console.WriteLine($"{kelime}es");
            //else
            //    Console.WriteLine($"{kelime}s");

            //Console.WriteLine(kelime.Replace("a","b"));
            //Console.WriteLine(kelime);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("abc");
            //Console.WriteLine(sb);
            ////sb.Remove(0, 3);
            //sb.Append("def");
            //Console.WriteLine(sb);

        }
    }
}
