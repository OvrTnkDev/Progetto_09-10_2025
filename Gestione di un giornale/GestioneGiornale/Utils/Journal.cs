using System;
using GestioneGiornale.Utils;

namespace Utils
{

    public class Journal
    {
        public string Nome { get; set; }
        public List<GiornataVendita> Giornate { get; set; }

        public Journal(string nome)
        {
            Nome = nome;
            Giornate = new List<GiornataVendita>();
        }

        public void AggiungiGiornataVendita(GiornataVendita giornataVendita)
        {
            Giornate.Add(giornataVendita);
        }

        public void Pubblica()
        {
            Console.WriteLine($"Pubblicazione del giornale {Nome}");

            foreach (GiornataVendita giornataVendita in Giornate)
            {
                giornataVendita.StampaInfo();
            }
        }

        public void Statistiche()
        {
            int totaleCopieStampate = 0;
            int totaleCopieVendute = 0;

            foreach (var g in Giornate)
            {
                totaleCopieStampate += g.CopieStampate;
                totaleCopieVendute += g.CopieVendute;
            }

            double  percentualeCopieVendute = (double)totaleCopieVendute / totaleCopieStampate * 100;
            double  percentualeCopieNonVendute = 100 - percentualeCopieVendute;
            double  mediaCopieVendute = (double)totaleCopieVendute / Giornate.Count;

            Console.WriteLine($"Statistiche giornale {Nome}:");
            Console.WriteLine("===================================================");
            Console.WriteLine($"Totale copie stampate: {totaleCopieStampate}");
            Console.WriteLine($"Totale copie vendute: {totaleCopieVendute}");
            Console.WriteLine($"Totale copie non vendute: {totaleCopieStampate - totaleCopieVendute}");
            Console.WriteLine($"Percentuale copie vendute: {percentualeCopieVendute:F2}%");
            Console.WriteLine($"Percentuale copie non vendute: {percentualeCopieNonVendute:F2}%");
            Console.WriteLine($"Media copie vendute: {mediaCopieVendute:F2}");
        }
    }
    
    
}
