using System;

namespace Utils
{
    
    public class Center : Header
    {
        public string SottoTitolo { get; set; }
        public string Corpo { get; set; }

        public Center(string sottoTitolo, string corpo) : base(string title)
        {
            SottoTitolo = sottoTitolo;
            Corpo = corpo;
        }

        public override void StampaInfo()
        {
            Console.WriteLine($"SottoTitolo: {SottoTitolo}, Corpo: {Corpo}");
        }
    }
}
