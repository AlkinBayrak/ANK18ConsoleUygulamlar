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
            Soru9();

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
