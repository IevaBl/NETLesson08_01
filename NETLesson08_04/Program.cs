using System;
using System.Collections.Generic;

/* Sukurti struktūrą Miskas, su publiclauku medžiai List<int> tipo. 
 * Struktūroje yra metodas publicvoidPasodintiMedį(). Jis prideda medį į sąrašą. */

namespace NETLesson08_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> medziai = new List<int>();
            Miskas liepos = new Miskas(medziai);
            liepos.PasodintiMedzius(15);
        }
    }
}
