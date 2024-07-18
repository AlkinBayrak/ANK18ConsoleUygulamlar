namespace MathStringDateMethods
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
            //Soru17();
            //Soru18();
            //Soru19();
            //Soru20();
            Soru21();

            //int x;

            //try
            //{
            //    //x = Convert.ToInt32(Console.ReadLine());
            //    throw new NullReferenceException();
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Sıfıra bölme hatası {ex.Message}");

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Format hatası {ex.Message}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Geriye kalanları ben yakalarım hatası {ex.Message}");

            //}
            //finally
            //{
            //    Console.WriteLine("Her durumda çalışacak olan kod ");
            //}



            //bool sonuc = int.TryParse("123a", out int sayi);
            //Console.WriteLine($"{sonuc} {sayi}");

            //if(int.TryParse("123a",out int sayi))
            //    Console.WriteLine("Sayı çevrildi");
            //else
            //    Console.WriteLine("Sayı girilmedi");


            //Console.WriteLine("Sayı yazınız");

            //string sayiAdayi = Console.ReadLine();
            //int sayi;

            ////if (int.TryParse(sayiAdayi, out int sayi))
            ////    Console.WriteLine($"Sayı çevrildi {sayi*2}");
            ////else
            ////    Console.WriteLine("Sayı çevrilmedi");

            //while (!int.TryParse(sayiAdayi, out sayi))
            //{
            //    Console.WriteLine("Lütfen sayı giriniz:");
            //    sayiAdayi = Console.ReadLine();
            //}

        }

        private static void Soru21()
        {
            DateTime tarih;
            DateTime tarih2;

            Console.WriteLine("Bir tarih giriniz:");
            tarih = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Bir tarih giriniz:");
            tarih2 = Convert.ToDateTime(Console.ReadLine());

            TimeSpan fark = (tarih - tarih2);
            Console.WriteLine(fark.TotalDays);
            

        }

        private static void Soru20()
        {
            DateTime now = DateTime.Now;

            DateTime dogumTarihi;

            Console.WriteLine("Doğum tarihini giriniz:");
            dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Yaşınız : {now.Year - dogumTarihi.Year}");

        }

        private static void Soru19()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now.ToLongDateString()}  {now.ToShortTimeString()}");
        }

        private static void Soru18()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now.ToShortDateString()}");
        }

        private static void Soru17()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine($"{now.ToLongDateString()}  {now.ToLongTimeString()}");
            Console.WriteLine($"{now.ToShortDateString()}  {now.ToShortTimeString()}");

        }

        private static void Soru16()
        {
            string metin;
            Console.WriteLine("Bir cümle giriniz:");
            metin = Console.ReadLine();
            string metin2;
            Console.WriteLine("Lütfen değiştirmek istediğiniz kelimeyi giriniz:");
            metin2 = Console.ReadLine();
            string metin3;
            Console.WriteLine("Yerine hangi kelimeyi yazıcaksınız");
            metin3 = Console.ReadLine();

            Console.WriteLine(metin.Replace(metin2,metin3));
        }

        private static void Soru15()
        {
            string metin = "mErhHAba";

            Console.WriteLine(metin.ToUpper());
            Console.WriteLine(metin.ToLower());
        }

        private static void Soru14()
        {
            string metin,metin2,metin3;

            Console.WriteLine("Adınızı giriniz:");
            metin = Console.ReadLine();

            Console.WriteLine("Soyadınızı giriniz:");
            metin2 = Console.ReadLine();


            Console.WriteLine("Yaşınızı giriniz:");
            metin3 = Console.ReadLine();

            Console.WriteLine(String.Concat($"Benim adım {metin} , Benim soyadım {metin2}, Benim yaşım {metin3}"));
            
        }

        private static void Soru13()
        {
            string metin = "merhabaa nasılsıın ahahaha";
            Console.WriteLine(metin.IndexOf('a'));
        }

        private static void Soru12()
        {
            string m1;
            Console.WriteLine("Lütfen bir kelime giriniz:");
            m1 = Console.ReadLine();

            Console.WriteLine("*" +m1.Trim()+"*");
            Console.WriteLine("*"+m1+"*");

        }

        private static void Soru11()
        {
            string m1;
            string m2;

            Console.WriteLine("Lütfen bir kelime giriniz:");
            m1 = Console.ReadLine();

            Console.WriteLine("Lütfen bir kelime giriniz:");
            m2 = Console.ReadLine();

            Console.WriteLine(String.Compare(m1, m2)); 

        }

        private static void Soru10()
        {
            string metin;
            Console.WriteLine("Cümleyi giriniz:");
            metin = Console.ReadLine();

            if(metin.Contains("hava"))
                Console.WriteLine("Var");
            else
                Console.WriteLine("Yok");

        }

        private static void Soru9()
        {
            try
            {

                Console.WriteLine(Math.PI);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }

        private static void Soru8()
        {
            try
            {
                
                Console.WriteLine(Math.E);
            }
            catch (Exception ex )
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }

        private static void Soru7()
        {
            try
            {
                int s1, s2;
                Console.WriteLine("İlk sayıyı giriniz:");
                s1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz:");
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Math.Min(s1, s2));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }

        private static void Soru6()
        {
            try
            {
                int s1, s2;
                Console.WriteLine("İlk sayıyı giriniz:");
                s1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz:");
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Math.Max(s1,s2));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }

        private static void Soru5()
        {
            try
            {
                int sayi;
                Console.WriteLine("Bir sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Pow(sayi,1/3.0));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }

        private static void Soru4()
        {
            try
            {
                int sayi;
                Console.WriteLine("Bir sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(sayi));
            }
            catch (Exception ex )
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }

        private static void Soru3()
        {
            try
            {
                int sayi;
                Console.WriteLine("Bir sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Abs(sayi));
            }
            catch (Exception ex )
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }

        private static void Soru2()
        {
            try
            {
                double sayi;
                Console.Write("Kilo değerini giriniz:");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Floor(sayi));
                Console.WriteLine(Math.Ceiling(sayi));
                Console.WriteLine(Math.Round(sayi));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
            
        }

        private static void Soru1()
        {
            try
            {
                int s1, s2;

                Console.Write("Bir sayı giriniz: ");
                s1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Üs giriniz: ");
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Sonuç : {Math.Pow(s1, s2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata {ex.Message}");

            }
        }
    }
}
