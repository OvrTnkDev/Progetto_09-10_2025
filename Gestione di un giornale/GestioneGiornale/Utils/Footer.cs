using System;

namespace Utils
{
    // Classe specializzata per gestire la sicurezza
    public class Footer : Center
    {
        public string Redazione { get; set; }
        // valore default
        private string _direttore = "Non specificato";
        public string Direttore
        {
            get => _direttore;
            set
            {
                if (!string.IsNullOrEmpty(value)) { _direttore = value; }
                else { Console.WriteLine($"Non hai inserito il Direttore"); }
            }
        }
        public string Copyright { get; set; }

        public Footer(string title, string sottotitolo, string corpo, string redazione, string direttore, string copyright)
                     : base(title, sottotitolo, corpo)
        {
            Redazione = redazione;
            Direttore = direttore;
            Copyright = copyright;
        }

        public override void StampaInfo()
        {
            base.StampaInfo();
            //Console.WriteLine($"Titolo: {Titolo}, Copie Totali: {CopieTotali}");
            Console.WriteLine($"Redazione: {Redazione}\t" +
                              $"Direttore: {Direttore}\t" +
                              $"Copyright: {Copyright}");
            Console.WriteLine();
        }

    }
}
