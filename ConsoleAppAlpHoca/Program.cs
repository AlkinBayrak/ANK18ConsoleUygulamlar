namespace ConsoleAppAlpHoca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string isim;
            //int yas = 88;
            //double s1;
            //float s2;


            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("isim");
            //Console.WriteLine("İsmi giriniz:");
            //isim = Console.ReadLine();  //input



            //Console.WriteLine("Yaşı giriniz:");
            //yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Merhaba {isim}");
            //Console.WriteLine($"Yaşınız: {yas}");

            //Console.WriteLine("Sayıyı giriniz:");
            //s1 = Convert.ToDouble(Console.ReadLine());  //input
            //Console.WriteLine($"Yaşınız: {yas}  sayi: {s1}");


            int s1, s2, s3, s4, s5;

            Console.WriteLine("5 adet sayıyı giriniz");

            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            s3 = Convert.ToInt32(Console.ReadLine());
            s4 = Convert.ToInt32(Console.ReadLine());
            s5 = Convert.ToInt32(Console.ReadLine());

            double islem = (s1+s2+s3+s4+s5)/5.0;
            
            Console.WriteLine($"Aritmetik ortalaması: {islem}");



        }
    }
}
