using System;

namespace Utils
{
    // Classe generica di un operatore
    public class Journal
    {
        public string Titolo { get; set; }
        public int CopieTotali { get; set; }
        public void journal(string Titolo, int CopieTotali)
        {
            this.Titolo = Titolo;
            this.CopieTotali = CopieTotali;
        }
        public virtual void StampaInfo()
        {
            Console.WriteLine($"Titolo: {Titolo}, Copie Totali: {CopieTotali}");
        }
    }
}
