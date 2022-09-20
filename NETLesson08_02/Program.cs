using System;

/* Sukurti struktūrą Palmė. 
 * Publiclaukai: amziusir vaisiuKiekis. Abu tik skaitymui. 
 * Sukurti publicmetodą Prideti1MenAmziaus(). Palmė duoda vaisius nuo 5 iki 12 menėsio, paskui miršta, 
 * t.y. amžius tampa 0. VaisiuKiekis= amžius*3; */

namespace NETLesson08_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palme nauja = new Palme(12,12);
            Console.WriteLine(nauja.Amzius);
            Console.WriteLine(nauja.VaisiuKiekis);
            nauja.Prideti1MenAmziaus();
            Console.WriteLine(nauja.Amzius);
            Console.WriteLine(nauja.VaisiuKiekis);
        }
    }
}
