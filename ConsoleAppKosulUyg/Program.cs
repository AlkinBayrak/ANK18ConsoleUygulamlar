
namespace ConsoleAppKosulUyg
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
            


            

        }

        private static void Soru6()
        {
            int yas;
            char ogrenci;
            Console.WriteLine("Yaşınızı giriniz:");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrenci grubunu giriniz:");
            ogrenci = Convert.ToChar(Console.ReadLine());

            if (yas >= 18 && ogrenci == 'B')
                Console.WriteLine("Şartları sağlıyorsunuz");
            else if (yas < 18 && ogrenci == 'B')
                Console.WriteLine("Yaş şartını sağlamıyorsunuz");
            else if (yas >= 18 && ogrenci == 'A')
                Console.WriteLine("B grubunda olmanız gerekiyor");
            else
                Console.WriteLine("Şartları sağlamıyorsunuz");
        }

        private static void Soru5()
        {
            double s1, s2,ort;

            Console.WriteLine("Vize notunuzu giriniz:");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunuzu giriniz:");
            s2 = Convert.ToInt32(Console.ReadLine());

            ort = s1 * 0.40 + s2 * 0.60;

            if(s1 < 0 || s1 > 100 &&  s2 < 0 || s2 > 100)
                Console.WriteLine("Geçersiz not");

            switch (ort)
            {
                case var x when ort >= 90 && ort <= 100:
                    Console.WriteLine("A");
                    break;
                case var x when ort >= 80 && ort <= 89:
                    Console.WriteLine("B");
                    break;
                case var x when ort >= 70 && ort <= 79:
                    Console.WriteLine("C");
                    break;
                case var x when ort >= 60 && ort <= 69:
                    Console.WriteLine("D");
                    break;
                case var x when ort >= 0 && ort <= 59:
                    Console.WriteLine("F");
                    break;
                

                
            }
        }

        private static void Soru4()
        {
            int sayi;
            Console.WriteLine("Bir sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    break;
            }
        }

        private static void Soru3()
        {
            int sayi;

            Console.WriteLine("Alışveriş tutarını giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi >= 300 && sayi < 500)
                Console.WriteLine($"Ödenecek tutar: {sayi*0.90}");
            else if (sayi >=500 && sayi < 600)
                Console.WriteLine($"Ödenecek tutar: {sayi*0.85}");
            else if (sayi >= 600)
                Console.WriteLine($"Ödenecek tutar: {sayi*0.80}");
        }

        private static void Soru2()
        {
            int maas, cocuk;

            Console.WriteLine("Maaşınızı girin:");

            maas = Convert.ToInt32(Console.ReadLine());

            char medeni;

            Console.WriteLine("Medeni durumunuzu giriniz:");
            medeni = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Çocuk sayınızı giriniz:");

            cocuk = Convert.ToInt32(Console.ReadLine());

            if(cocuk < 0)
                Console.WriteLine("Çocuk eksi girilemez");
            else if (medeni == 'B')
                Console.WriteLine(maas);
            else if (medeni == 'E' && cocuk == 0)
                Console.WriteLine(maas * 1.03);
            else if (medeni == 'E' && cocuk == 1)
                Console.WriteLine(maas * 1.05);
            else if (medeni == 'E' && cocuk == 2)
                Console.WriteLine(maas * 1.10);
            else if (medeni == 'E' && cocuk >= 3)
                Console.WriteLine(maas * 1.15);
        }

        private static void Soru1()
        {
            float s1, s2;


            Console.WriteLine("İki adet sayı giriniz :");

            s1 = Convert.ToSingle(Console.ReadLine());
            s2 = Convert.ToSingle(Console.ReadLine());

            char islem;
            Console.WriteLine("İşlem giriniz:");
            islem = Convert.ToChar(Console.ReadLine());

            if (islem == 'T' || islem == 't')
                Console.WriteLine(s1 + s2);
            else if (islem == 'C' || islem == 'c')
                Console.WriteLine(s1 - s2);
            else if (islem == 'X' || islem == 'x')
                Console.WriteLine(s1 * s2);
            else if (islem == 'B' || islem == 'b')
            {
                if (s2 != 0)
                    Console.WriteLine(s1 / s2);
                else
                    Console.WriteLine("Sayı2 0 olamaz");
            }

            else if (islem == 'M' || islem == 'm')
                Console.WriteLine(s1 % s2);
        }
    }
}
