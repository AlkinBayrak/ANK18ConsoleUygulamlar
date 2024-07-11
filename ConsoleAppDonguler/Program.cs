


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
            //Soru5();
            //Soru6();
            //Soru7();
            //Soru8();
            //Soru9();
            Soru10();
        }

        private static void Soru10()
        {
            int sayi = 1;
            int toplam = 0;
            while (sayi < 100)
            {
                toplam += sayi;
                sayi++;
            }
            Console.WriteLine($"Sayıların toplamı : {toplam += sayi}");
        }

        private static void Soru9()
        {
            int sayi;
            Console.WriteLine("Sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi != 0)
            {
                Console.WriteLine($"Sayı : {sayi} Karesi : {sayi*sayi}");

                Console.WriteLine("Sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void Soru8()
        {
            int sayi = 1;
            while (sayi <= 10)
            {
                Console.WriteLine($"Çarpımları : 7 * {sayi} = {sayi*7}");
                sayi++;
            }
        }

        private static void Soru7()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {

                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine("-------------");
            }
            
        }

        private static void Soru6()
        {
            int not;
            int toplam = 0;
            int Min = 100;
            int Max = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Not giriniz : ");
                not = Convert.ToInt32(Console.ReadLine());

                while (not < 0 || not > 100)
                {
                    Console.WriteLine("Geçersiz not girdiniz tekrar giriniz : ");
                    not = Convert.ToInt32(Console.ReadLine());
                }

                toplam += not;

                if (not < Min) 
                        Min = not;
                if (not > Max)
                        Max = not;
                
                
            }
            Console.WriteLine($"Min : {Min}");
            Console.WriteLine($"Max : {Max}");
            Console.WriteLine($"Ortalama : {toplam/10.0}");
            Console.WriteLine($"Toplam : {toplam}");

        }

        private static void Soru5()
        {
            //int en;
            //int boy;

            //Console.WriteLine("En uzunluğunu giriniz:");
            //en = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Boy uzunluğunu giriniz :");
            //boy = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("--------------");
            
            //for (int i = 1; i <= boy; i++)
            //{
            //    for (int j = 1; j <= en; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}



            int en;
            int boy;

            Console.WriteLine("En uzunluğunu giriniz:");
            en = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boy uzunluğunu giriniz :");
            boy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------");

            for (int i = 1; i <= en; i++)
            {
                for (int j = 1; j <= boy; j++)
                {
                    if(i == 1 || i == en)
                        Console.Write("*");
                    else

                    if(j == 1 || j == boy)
                        Console.Write("*");
                    else
                        Console.Write(" ");
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
