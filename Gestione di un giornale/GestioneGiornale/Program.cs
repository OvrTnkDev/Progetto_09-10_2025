using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main(string[] args)
    {
// Updated upstream
        Random random = new Random();
        for( int day =1; day<=5; day++)
        {
            Console.WriteLine($"\n--- Day {day} ---");
            int totalCopies = random.Next(800, 1201); // Random copies between 800 and 1200
            Journal giornale = new Journal("Daily News", totalCopies);
            giornale.StampaInfo();
            giornale.PublishSection();
            Header header = new Header("Today's Highlights");
            header.StampaInfo();
            header.PublishSection();
            Center center = new Center("Breaking News", "Important event happening now.");
            center.StampaInfo();
            center.PublishSection();
        }


        
// Stashed changes
    }
}
