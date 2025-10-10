using System;
using System.Collections.Generic;
using GestioneGiornale.Utils;
using Utils;
//using Utils;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random(); //utilizzato per generare in modo casuale le copie stampate e le copie vendute

        /// <summary>
        /// creazione degli oggetti Articolo con i relativi parametri (header, body, footer) e l'oggetto giornale con il suo nome
        /// </summary>
        Articolo articolo1 = new Articolo("Hanno ucciso l'uomo ragno?", "Chi sia stato non si sa.", "Redatto da Daily Bugle");
        Articolo articolo2 = new Articolo("Ritrovato Batman in stato di ebrezza", "È stato fermata un auto con all'interno un passeggero di nome Batman in stato di ebrezza. PS: l'auto era stata rubata", "Redatto da Joker");
        Articolo articolo3 = new Articolo("Joker è morto?", "No.", "Redatto da Joker");
        Journal giornale = new Journal("Il Quotidiano");

        /// <summary>
        /// aggiunta delle vendite delle giornate di pubblicazione. i parametri sono: data, articolo (preso dall'oggetto Articolo), copie stampate, copie vendute
        /// </summary>
        giornale.AggiungiGiornataVendita(new GiornataVendita(DateTime.Now, articolo1, rnd.Next(800, 2000), rnd.Next(500, 2000)));
        giornale.AggiungiGiornataVendita(new GiornataVendita(DateTime.Now.AddDays(+1), articolo2, rnd.Next(800, 2000), rnd.Next(500, 2000)));
        giornale.AggiungiGiornataVendita(new GiornataVendita(DateTime.Now.AddDays(+2), articolo3, rnd.Next(800, 2000), rnd.Next(500, 2000)));

        /// <summary>
        /// stampa il giornale con l'articolo completo e le copie stampate, vendute e non vendute del singolo articolo
        /// </summary>
        giornale.Pubblica();

        /// <summary>
        /// stampa le statistiche del giornale. stampa il totale delle copie stampate, vendute e non vendute, 
        /// a percentuale di copie vendute, la percentuale di copie non vendute e la media delle copie vendute
        /// </summary>
        giornale.Statistiche();
    }
}
