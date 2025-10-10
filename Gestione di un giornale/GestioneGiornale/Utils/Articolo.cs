using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestioneGiornale.Utils
{
    public class Articolo
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public string? Footer { get; set; }

        public Articolo(string? header, string? body, string? footer)
        {
            Header = header;
            Body = body;
            Footer = footer;
        }

        public void Stampa()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"====================================");
            Console.WriteLine($"{Body}");
            Console.WriteLine($"====================================");
            Console.WriteLine($"{Footer}");
            Console.WriteLine("===================================================");
        }
    }
}