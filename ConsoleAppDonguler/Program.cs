

namespace ConsoleAppDonguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            Soru2();
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
