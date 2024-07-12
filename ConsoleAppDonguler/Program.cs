


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
            //Soru10();
            //Soru11();
            //Soru12();
            //Soru13();
            //Soru14();
            //Soru15();
            //Soru16();
            //RastgeleSayı();
            Oyun();
        }

        private static void Oyun()
        {
            int sayi,tutulanSayi,denemeSayisi = 0;
            tutulanSayi = new Random().Next(1, 21);
            bool kazandiMi = false;
            Console.WriteLine("Sayı Tahmini Oyunu! Hoşgeldiniz");
            Console.WriteLine("10 tane tahmin hakkınız vardır");

            for (int tahminAdimi = 1; tahminAdimi <= 10; tahminAdimi++)
            {
                denemeSayisi++;
                Console.WriteLine($"{tahminAdimi} . tahmin hakkınızı yazınız :");
                sayi = Convert.ToInt32(Console.ReadLine());
                while (sayi < 1 || sayi > 20)
                {
                    Console.WriteLine("Lütfen [1-20] arasında giriniz");
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                if (sayi == tutulanSayi)
                {
                    kazandiMi = true;
                    Console.WriteLine($"Tebrikler {denemeSayisi} . denemede bildiniz");
                    break;
                
                }
                else if (sayi < tutulanSayi)
                {
                    Console.WriteLine("Yukarı");
                }
                else
                    Console.WriteLine("Aşağı");
            }
            if(!kazandiMi)
                Console.WriteLine($"Kaybettiniz Sayı : {tutulanSayi} idi");
        }

        private static void RastgeleSayı()
        {
            Random rastgele = new Random();
            Console.WriteLine(rastgele.Next(1,10));
            Console.WriteLine(rastgele.Next(int.MaxValue));
        }

        private static void Soru16()
        {
            int sayi,sayac = 1;

            do
            {
                Console.WriteLine("Sayıyı giriniz:");
                sayi =Convert.ToInt32(Console.ReadLine());

                if((sayi >= 100 && sayi <= 999) || (sayi >= -999 && sayi <= -100))
                    Console.WriteLine($"Kurala uyan sayı : {sayi}");

                sayac++;

            } while (sayac <= 10);
        }

        private static void Soru15()
        {
            string kelime;
            
            do
            {
                Console.WriteLine("Kelimeyi giriniz:");
                kelime = Console.ReadLine();
            } while (kelime != "ANK18");

            Console.WriteLine("Bitti");
        }

        private static void Soru14()
        {
            int sayi,sayac = 1;
            int sadece5 = 0, sadece3 = 0, ikisinede = 0;
            

            while (sayac <= 10)
            {
                Console.WriteLine("Sayıyı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 3 == 0 && sayi % 5 != 0)
                    sadece3++;
                else if (sayi % 3 != 0 && sayi % 5 == 0)
                    sadece5++;
                else if (sayi % 3 == 0 && sayi % 5 == 0)
                    ikisinede++;

                sayac++;


            }
            Console.WriteLine($"Sadece3 : {sadece3}");
            Console.WriteLine($"Sadece5 : {sadece5}");
            Console.WriteLine($"İkisinede : {ikisinede}");
        }

        private static void Soru13()
        {
            uint s1, s2,sayac,sonuc = 0;

            sayac = 1;

            Console.WriteLine("Sayıları giriniz:");
            s1 =Convert.ToUInt32(Console.ReadLine());
            s2 = Convert.ToUInt32(Console.ReadLine());

            while (sayac<=s1)
            {
                sonuc += s2;
                sayac++;
            }
            Console.WriteLine($"Sonuç : {sonuc}");
        }

        private static void Soru12()
        {
            int sayi1, sayi2;
            Console.WriteLine("Sayı 1 giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 2 giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            if (sayi1 == sayi2)
            {
                Console.WriteLine("Sayılar birbirine eşittir");
                return;
            }

            //if (sayi1 > sayi2)
            //{
            //    while (sayi1>=sayi2)
            //    {
            //        toplam += sayi2;
            //        sayi2++;
            //    }

            //}
            //else
            //{
            //    while (sayi1 <= sayi2)
            //    {
            //        toplam += sayi1;
            //        sayi1++;
            //    }
            //}

            //Console.WriteLine($"Sonuç : {toplam}");

            int yedek;

            if(sayi2 > sayi1)
            {
                yedek = sayi2;
                sayi2 = sayi1;
                sayi1 = yedek;
            }

            while (sayi1 >= sayi2)
            {
                    toplam += sayi2;
                    sayi2++;
            }
            Console.WriteLine($"Sonuç : {toplam}");
        }

        private static void Soru11()
        {
            //For

            //double sayi, carp = 1;
            //Console.WriteLine("Faktöriyel değerini istediğiniz sayıyı giriniz:");
            //sayi = Convert.ToDouble(Console.ReadLine());

            //if(sayi < 0)
            //{
            //    Console.WriteLine("Negatif sayıların değeri alınamaz");
            //}
            //else
            //{
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        carp *= i;
            //    }
            //    Console.WriteLine($"Girdiğiniz sayının faktöriyel değeri : {carp}");
            //}

            //While

            //int i = 1, carp = 1, sayi;

            //Console.WriteLine("Faktöriyel değerini istediğiniz sayıyı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //while (sayi < 0)
            //{
            //    Console.WriteLine("Negatif sayıların değeri alınamaz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //while (i <= sayi)
            //{
            //    carp *= i;
            //    i++;
            //}
            //Console.WriteLine($"Girdiğiniz sayının faktöriyel değeri : {carp}");

            //Do While

            //int i = 1, carp = 1, sayi;
            //Console.WriteLine("Faktöriyel değerini istediğiniz sayıyı giriniz:");
            //sayi =Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    carp *= i;
            //    i++;

            //} while (i <= sayi);
            //Console.WriteLine($"Girdiğiniz sayının faktöriyel değeri : {carp}");
        }

        private static void Soru10()
        {
            int sayi = 1;
            int toplam = 0;
            while (sayi <= 100)
            {
                toplam += sayi;
                sayi++;
            }
            Console.WriteLine($"Sayıların toplamı : {toplam}");
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
