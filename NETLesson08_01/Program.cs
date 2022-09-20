using System;

/* Sukurti struktūrą Saskaita. Publiclaukai gavejas, siuntejas, moketiViso, saskaitosNumeris.
 * Visi laukai tik skaitymui, perduodami per konstruktorių išskyrus saskaitosNumeris,
 * jis generuojasi automatiškai konstruktoriuje (NR_metai_menuo_diena_01) */

namespace NETLesson08_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saskaita saskaita = new Saskaita("", "", 200);
            Console.WriteLine(saskaita.SaskaitosNr);
        }
    }
}
