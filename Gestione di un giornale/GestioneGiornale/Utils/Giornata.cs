using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestioneGiornale.Utils
{
    public class Giornata
    {
        public DateTime Data { get; set; }
        public Articolo Articolo { get; set; }

        public Giornata(DateTime date, Articolo articolo)
        {
            Data = date;
            Articolo = articolo;
        }

        public virtual void StampaInfo()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine($"Giornata del {Data.ToShortDateString()}");
            Articolo.Stampa();
        }
    }
    
    public class GiornataVendita : Giornata
    {
        public int CopieStampate { get; set; }
        public int CopieVendute { get; set; }

        public GiornataVendita(DateTime date, Articolo articolo, int copieStampate, int copieVendute) : base(date, articolo)
        {
            CopieStampate = copieStampate;
            CopieVendute = (copieVendute > copieStampate) ? copieStampate : copieVendute;
        }

        public double PercentualeVendita()
        {
            return (double)CopieVendute / CopieStampate * 100;
        }

        public double PercentuleNonVendute()
        {
            return 100 - PercentualeVendita();
        }

        public override void StampaInfo()
        {
            base.StampaInfo();
            Console.WriteLine($"Copie stampate: {CopieStampate}");
            Console.WriteLine($"Copie vendute: {CopieVendute}");
            Console.WriteLine($"Copie non vendute: {CopieStampate - CopieVendute}");
            Console.WriteLine("===================================================");
        }
    }
}