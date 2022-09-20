using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson08_02
{
    public struct Palme
    {
        public int Amzius { get; set; }
        public int VaisiuKiekis { get; set; }    

        public Palme(int amzius, int vaisuKiekis)
        {
            Amzius = amzius;    
            VaisiuKiekis = amzius<5? 0 : vaisuKiekis;
        }

        public void Prideti1MenAmziaus()
        {
            Console.WriteLine($"pridedam prie amziaus viena menesi");
            if (Amzius < 12)
            {
                Amzius++;
                VaisiuKiekis = Amzius * 3;
            }
            else
            {
                Amzius = 0;
                VaisiuKiekis = 0;
            }
            
        }
    }
}
