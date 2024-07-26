using System.Threading.Channels;

namespace ConsoleAppMetodRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Soru 1

            //int sayi;
            //sayi = Convert.ToInt32(Console.ReadLine());
            //F(sayi);
            //Console.WriteLine(sayi);


            //// Soru 2

            //sayi = Convert.ToInt32(Console.ReadLine());
            //H(sayi);

            //// Soru 3

            //sayi = Convert.ToInt32(Console.ReadLine());
            //H(ref sayi);
            //Console.WriteLine(sayi);

            //// Soru 4 

            //sayi= Convert.ToInt32(Console.ReadLine());
            //U(sayi);

            //// Soru 5

            //sayi = Convert.ToInt32(Console.ReadLine());
            //U(out sayi);
            //Console.WriteLine(sayi);




            // Alan
            double x;
            double y;

            Console.WriteLine("İki adet kenar giriniz :");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Alan(x,y,out double hipotenus));
            Console.WriteLine($"Hipotenus : {hipotenus}");

        }

        static double Alan(double x, double y,out double hipotenus)
        {
            hipotenus = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine(hipotenus);
            return (x * y) / 2;
        }

        

        

        static void F(int x)
        {
            x++;
        }

        static void H(ref int x)
        {
            x++;
        }

        static void U(out int x)
        {
            x = 2;
            x = 9 * x;
        }
    }

}
