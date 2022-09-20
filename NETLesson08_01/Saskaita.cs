using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson08_01
{
    public struct Saskaita
    {
        public string Gavejas { get; set; }
        public string Siuntejas { get; set; }
        public int MoketiVios { get; set; }
        public string SaskaitosNr { get; set; }

        public Saskaita(string gavejas, string siuntejas, int moketiViso)
        {
            Gavejas = gavejas;
            Siuntejas = siuntejas;
            MoketiVios = moketiViso;
            SaskaitosNr = $"NR_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{01}";  
        }


    }
}
