// Utils/Journal.cs
using System;
using System.Collections.Generic;

namespace Utils
{
    public class Journal
    {
        public DateTime Data { get; set; } = DateTime.Today;
        public List<string> Articoli { get; set; } = new List<string>();

        public virtual void StampaBase()
        {
            Console.WriteLine($"Giornale del {Data:dd/MM/yyyy}");
        }
    }
}
