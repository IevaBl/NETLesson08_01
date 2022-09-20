using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson08_04
{
    public struct Miskas
    {
        public List<int> Medziai { get; set; }

        public Miskas(List<int> medziai)
        {
            Medziai = medziai;
        }

        public void PasodintiMedzius(int kiekis)
        {
            Medziai.Add(kiekis);
        }
    }
}
