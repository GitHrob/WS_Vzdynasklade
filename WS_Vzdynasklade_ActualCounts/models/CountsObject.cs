using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WS_Vzdynasklade_ActualCounts
{
    public class CountsObject
    {
        public int Objednano { get; set; }
        public int Vyrizeno { get; set; }
        public int Zabaleno { get; set; }
        public int Doplneni { get; set; }
        public int StatRychlostVyrizeniZaS { get; set; }
        public int StatOcekavanoObjednavekZaS { get; set; }
        private int _status { get; set; }
        private int _id { get; set; }
        private DateTime _datum { get; set; }

        internal void RandomData()
        {
            Random rn = new Random();
            Objednano = rn.Next(20,100);
            Vyrizeno = rn.Next(50, 100);
            Zabaleno = rn.Next(50, 100);
            Doplneni = rn.Next(90, 100);
            StatRychlostVyrizeniZaS = rn.Next(20,40);
            StatOcekavanoObjednavekZaS = rn.Next(0, 1);
        }

        public CountsObject()
        {

        }

        public void TestData()
        {
            Objednano = 20;
            Vyrizeno = 30;
            Zabaleno = 40;
            Doplneni = 50;
            StatRychlostVyrizeniZaS = 50;
            StatOcekavanoObjednavekZaS = 60;
            _status = 27;
            return ;
        }

        public int[] GetValues()
        {
            _datum = DateTime.Now;
            return new int[] { this.Objednano, this.Vyrizeno, this.Zabaleno, this.Doplneni, this.StatOcekavanoObjednavekZaS, this.StatOcekavanoObjednavekZaS };
        }

        
    }
}
