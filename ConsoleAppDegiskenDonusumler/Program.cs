
namespace ConsoleAppDegiskenDonusumler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            //Soru3();
            //Soru4();
            //Soru5();
        }

        private static void Soru5()
        {
            int[] sayilar = new int[10];
            int rastgeleSayi;
            Random rastgele = new Random();

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    rastgeleSayi = rastgele.Next(1, 11);

                } while (sayilar.Contains(rastgeleSayi));

                sayilar[i] = rastgeleSayi;
            }
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);

        }

        private static void Soru4()
        {
            int[] dizi = new int[10];
            int toplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Notları giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                dizi[i] = sayi;
                toplam += dizi[i];
            }
            Console.WriteLine($"Toplamları : {toplam} Ortalama: {toplam/10}");
        }

        private static void Soru3()
        {
            int[] dizi = new int[10];
            int toplam = 0;
            int adet = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
               dizi[i] =  new Random().Next(1,1001);
                Console.WriteLine(dizi[i]);
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] <= 501 && dizi[i] <= 600)
                    toplam += dizi[i];
            }
            Console.WriteLine($"Toplamları : {toplam}");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] >= 100 && dizi[i] <= 500)
                    adet++;
            }
            Console.WriteLine($"Adetleri : {adet}");
        }

        private static void Soru2()
        {
            int[] dizi = new int[5];
            int toplam = 0;

            for (int i = 0; i < dizi.Length ; i++)
            {
                Console.WriteLine("Sayı giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine()); 
            }
           
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 10 == 0)
                    toplam++;
            }
            Console.WriteLine($"Son rakamı 0 olan sayılar : {toplam}");
        }

        private static void Soru1()
        {
            int[] dizi = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                dizi[i] = sayi;
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            int eb = dizi[0];
            int ek = dizi[0];

            for (int i = 0; i < 6; i++)
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                }
            }
            Console.WriteLine($"En büyük : {eb} En küçük : {ek}");
        }
    }
}
