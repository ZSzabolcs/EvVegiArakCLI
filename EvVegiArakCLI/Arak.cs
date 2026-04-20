using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvVegiArakCLI
{
    public class Arak
    {
        public int December { get; private set; }
        public int Kod { get; private set; }
        public string Megnevezes { get; private set; }
        public int November { get; private set; }
        public int Oktober { get; private set; }
        public int Szeptember { get; private set; }

        public Arak(string sor)
        {
            string[] temp = sor.Split(';');
            Kod = int.Parse(temp[0]);
            Megnevezes = temp[1].Split(',')[0];
            Szeptember = int.Parse(temp[2]);
            Oktober = int.Parse(temp[3]);
            November = int.Parse(temp[4]);
            December = int.Parse(temp[5]);
        }

        public int MinHonapSorszam()
        {
            List<int> honapAr = new List<int>() { Szeptember, Oktober, November, December };
            return honapAr.IndexOf(honapAr.Min())+9;
        }
    }
}
