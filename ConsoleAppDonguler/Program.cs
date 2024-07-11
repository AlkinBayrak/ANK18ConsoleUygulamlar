


namespace ConsoleAppDonguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            //Soru3();
            //Soru4();
            Soru5();
        }

        private static void Soru5()
        {
            int en = 0;
            int boy = 0;

            Console.WriteLine("En uzunluğunu giriniz:");
            en = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boy uzunluğunu giriniz :");
            boy = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("--------------");
            
            for (int i = 1; i <= en; i++)
            {
                for (int j = 1; j <= boy; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            
        }

        private static void Soru4()
        {
            int adet = 0;
            int i;
            int toplam = 0;
            for ( i = 1; i < 1000; i++)
            {
                if (i % 5 == 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                    adet++;
                    toplam = toplam + i;
                }
                
                
            }
            Console.WriteLine($"Sayıların adeti : {adet}");
            Console.WriteLine($"Sayıların toplamı : {toplam}");
        }

        private static void Soru3()
        {
            int sayi;

            double toplam = 0;

            double ort = 0;

            Console.WriteLine("Sayıları giriniz:");

            for (int i = 1; i <= 12; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                ort = toplam / sayi;
            }
            Console.WriteLine($"Sayıların toplamı : {toplam}");
            Console.WriteLine($"Sayıların ortalaması : {ort}");

        }

        private static void Soru2()
        {
            //int toplamcift = 0;
            //int toplamtek = 0;

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //        toplamcift = toplamcift + i;

            //    else if (i % 2 == 1)
            //        toplamtek = toplamtek + i;

            //}
            //Console.WriteLine($"Çiftlerin toplamı : {toplamcift}");
            //Console.WriteLine($"Teklerin toplamı : {toplamtek}");


            Console.WriteLine("-----------");

            //int toplamcift = 0;
            //int toplamtek = 0;
            //int i = 0;

            //while (i <= 20)
            //{
            //    if (i % 2 == 0)
            //        toplamcift = toplamcift + i;

            //    else if (i % 2 == 1)
            //      toplamtek = toplamtek + i;
            //    i++;
            //}

            //Console.WriteLine($"Çiftlerin toplamı : {toplamcift}");
            //Console.WriteLine($"Teklerin toplamı : {toplamtek}");

            int toplamcift = 0;
            int toplamtek = 0;

            int i= 0;

            do
            {
                if (i % 2 == 0)
                   toplamcift = toplamcift + i;

                else if (i % 2 == 1)
                  toplamtek = toplamtek + i;
                i++;


            } while (i <=20);

            Console.WriteLine($"Çiftlerin toplamı : {toplamcift}");
            Console.WriteLine($"Teklerin toplamı : {toplamtek}");
        }

        private static void Soru1()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("BilgeAdam");
            //}

            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine("BilgeAdam");
            //    i++;
            //}

            int i = 0;

            do
            {
                Console.WriteLine("BilgeAdam");
                i++;

            } while (i < 10);
        }
    }
}
