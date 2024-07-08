namespace ConsoleAppSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = -5;
            int sayi2 = -20;


            switch (sayi, sayi2)
            {
                case ( < 100 or < 0, not -20) when sayi == 45 && sayi2 != 55:
                    Console.WriteLine("Negatif");
                    break;

                case (1, not 3):
                    Console.WriteLine("Uno");
                    break;

                default:
                    Console.WriteLine("Otro numero");
                    break;
            }

            int u = 88;
            int c = 9;


            switch (sayi)
            {
                case 7:
                case 17:
                case 27:

                case var x when sayi != 7:
                    Console.WriteLine("1.Koşul");
                    break;




                default:
                    break;
            }
        }
    }
}

