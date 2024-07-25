using System.Collections;

namespace ConsoleAppMetodlarDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SayiCozumle();


            //int s1, s2;
            //Console.WriteLine("İki adet sayı giriniz :");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //s2 = Convert.ToInt32(Console.ReadLine());

            //for (int i = s1; i < s2; i++)
            //{
            //    if (Asal(i))
            //        Console.WriteLine($"{i} Asaldır");
            //    else
            //        Console.WriteLine($"{i} Asal değildir");
            //}

            //Console.WriteLine("Öğrenci numaranızı giriniz :");
            //string no = Console.ReadLine();
            //OgrenciNo(no);

            //if (yanit)
            //{
            //    //doğru ike yapilacaklar
            //}
            //else 
            //{ 
            //    // yanlış iken yapılacaklar
            //}

            //if (OgrenciNo(no))
            //{
            //    Console.WriteLine("Öğrenci numarası doğru");
            //}
            //else
            //    Console.WriteLine("Öğrenci numarası doğru değil");



            Console.WriteLine("Bir dizi sayı giriniz:");

            int[] monotonDizi = new int[3];

            for (int i = 0; i < monotonDizi.Length; i++)
            {
                monotonDizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (Monoton(monotonDizi))
            {
                Console.WriteLine("dizi doğru");
            }
            else
                Console.WriteLine("Dizi doğru değil");


        }

        static bool Monoton(int[] monotonDizi)
        {
            
            for (int i = 0; i < monotonDizi.Length - 1; i++)
            {
                if(monotonDizi[i] >= monotonDizi[i+1])
                     return false;
            }
            return true;

           
            
        }

        static bool OgrenciNo(string no)
        {
           
            if (no.Length != 8)
                return false;
            if (!(Convert.ToInt32(no.Substring(0, 2)) <= 24 && Convert.ToInt32(no.Substring(0, 2)) >= 20))
                return false;
            if (!(no.ToUpper()[2] == 'L' || no.ToUpper()[2] == 'Y' || no.ToUpper()[2] == 'D'))
                return false;
            if (!(Convert.ToInt32(no.Substring(3,5)) <= 10000 || Convert.ToInt32(no.Substring(3, 5)) >= 1))
                return false;
            
                return true;
        }
        static bool Asal(int sayi)
        {
            
            int sayac = 0;
            
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    sayac++;
                break;

            }
            if (sayac == 0)
                return true;
            else
                return false;
        }
        static void SayiCozumle()
        {
            string klavyedenAlinan;
            int hakikiSayi;
            int us = 0;
            Console.WriteLine("Sayıyı giriniz :");
            klavyedenAlinan = Console.ReadLine();

            while (true)
            {
                if (klavyedenAlinan.ToUpper() == "EXIT")
                    return;
                else if (int.TryParse(klavyedenAlinan, out hakikiSayi))
                {
                    while (hakikiSayi != 0)
                    {
                        Console.WriteLine((hakikiSayi % 10) * Math.Pow(10, us));
                        us++;
                        hakikiSayi /= 10;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı girdiniz");
                }
                Console.WriteLine("Sayıyı giriniz :");
                klavyedenAlinan = Console.ReadLine();
                us = 0;
            }
        }           
    }
}
