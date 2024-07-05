namespace ConsoleAppAritmetikOpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 105;
            //int sayi2 = 2;
            //int toplam = sayi1 + sayi2;


            //Console.WriteLine($"Sonuç: {toplam}");
            //Console.WriteLine("Sonuç:" + sayi1 + sayi2);
            //Console.WriteLine("Sonuç:" + (sayi1 + sayi2));


            //int fark = sayi1 - sayi2;
            //Console.WriteLine($"Sonuç: {fark}");
            ////Console.WriteLine("Sonuç:" + sayi1 - sayi2);
            //Console.WriteLine("Sonuç:" + (sayi1 - sayi2));


            //int carpim = sayi1 * sayi2;
            //Console.WriteLine($"Sonuç: {carpim}");
            //Console.WriteLine("Sonuç:" + sayi1 * sayi2);
            //Console.WriteLine("Sonuç:" + (sayi1 * sayi2));

            //int bolum = sayi1 / sayi2;
            //Console.WriteLine($"Sonuç: {bolum}");
            //Console.WriteLine("Sonuç:" + sayi1 / sayi2);
            //Console.WriteLine("Sonuç:" + (Convert.ToDouble(sayi1) / sayi2));

            //int kalan = sayi1 % sayi2;
            //Console.WriteLine($"Sonuç: {kalan}");
            //Console.WriteLine("Sonuç:" + sayi1 % sayi2);
            //Console.WriteLine("Sonuç:" + (sayi1 % sayi2));

            //++ ==> 1 arttırma 
            //-- ==> 1 azaltma

            //sayi1++; önce kullan sonra 1 arttır

            //++sayi1; önce 1 arttır sonra kullan 

            //sayi1--; önce kullan sonra 1 azalt

            //--sayi1; önce azalt sonra kullan

            //int x = 9;
            //int y = 10;

            //x++;
            //Console.WriteLine(x);

            //++y;
            //Console.WriteLine(y);

            //Console.WriteLine(x++ + ++y + 8 + ++x);
            //Console.WriteLine($"X :{x}");
            //Console.WriteLine($"Y :{y}");

            //Console.WriteLine(x++ + 7);
            //Console.WriteLine(x);
            //Console.WriteLine(++y + 7);
            //Console.WriteLine(y);

            //x = 2;
            //y = 3;
            //int z = 4;
            ////Console.WriteLine(x*= 8 + 9);
            //Console.WriteLine("x: {0} y: {1} z: {2}",x,y,z);

            //x += 7; x = x + 7;
            //x += y; x = x + y;
            //x -= 2; x = x - 2;
            //x *= 3; x = x * 3;
            //x /= 2; x = x / 2;
            //x %= 3; x = x % 3;

            //else if hiçbir zaman tek başlarına başlamaz

            //else içine koşul yazılamaz

            //int sayi;

            //Console.WriteLine($"Lütfen bir sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if( sayi % 2== 0)

            //    Console.WriteLine("Sayı çifttir");

            //else
            //    Console.WriteLine("Sayı tektir");

            int sayi;

            Console.WriteLine($"Lütfen bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            int u;
            Console.WriteLine(sayi%2==0?"ÇİFT":"TEK");

            u = sayi % 2 == 0 ? 1 : 0;

            

            

            if (sayi % 2 == 0)
                u = 1;
            else
                u = 0;
        }
    }
}
