using System;

namespace Utils
{
    
    public class Journal
    {
        public string Nome { get; set; }
        public int CopieTotali { get; set; }
        public Journal(string Nome, int CopieTotali)
        {
            this.Nome = Nome;
            this.CopieTotali = CopieTotali;
        }
        public virtual void StampaInfo()
        {
            Console.WriteLine($"Nome del giornale: {Nome}, Copie Totali: {CopieTotali}");
        }

        public virtual void PublishSection()
        {
            Console.WriteLine("publishing Juornal");
        }
    }
}
