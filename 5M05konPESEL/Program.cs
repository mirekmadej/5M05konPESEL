using System.Runtime.CompilerServices;

namespace _5M05konPESEL
{
    class PESEL
    {
        private static int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        private static int[] pesel = new int[11];

        public static char podajPlec(string Pesel)
        {
            zamienPesel(Pesel);
            if (pesel[9] % 2 == 0)
                return 'K';
            else
                return 'M';
        }
        public static bool czyPoprawnyPESEL(string Pesel)
        {
            int suma = 0;
            for (int i = 0; i < 10; i++)
                suma += pesel[i] * wagi[i];
            int M = suma % 10;
            int R;
            if (M == 0)
                R = 0;
            else
                R = 10 - M;

            return R == pesel[10];
        }
        private static void zamienPesel(string Pesel)
        {
            for(int i = 0; i<Pesel.Length; i++)
                pesel[i] = int.Parse(Pesel[i].ToString());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sprawdzenie numeru PESEL");
            Console.Write("podaj numer PESEL: ");
            //string pesel = Console.ReadLine();
            string pesel = "55030101193";
            if (PESEL.podajPlec(pesel) == 'K')
                Console.WriteLine("płeć: Kobieta");
            else
                Console.WriteLine("Płeć: Mężczyzna");
            if (PESEL.czyPoprawnyPESEL(pesel))
                Console.WriteLine("numer PESEL ma zgodną sumę kontrolnę (poprawny)");
            else
                Console.WriteLine("numer PESEL ma niezgodną sumę kontrolnę (niepoprawny)");

        }
    }
}
