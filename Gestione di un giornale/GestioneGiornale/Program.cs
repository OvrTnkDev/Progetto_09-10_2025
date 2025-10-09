using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main(string[] args)
    {
        // Updated upstream

        Random random = new Random();
        Journal[] sections = new Journal[]
        {
            new Header("Breaking News"),
            new Center()
            new footer()
        };
        for (int day = 1; day <= 7; day++)
        {
            Console.WriteLine($"\n--- Day {day} ---");
            foreach (var section in sections)
            {
                section.PublishSection();
                section.StampaInfo();
            }
            int soldCopies = random.Next(sections[0].CopieTotali);
            double percentageSold = (double)soldCopies / sections[0].CopieTotali * 100;
            double percentageUnsold = 100 - percentageSold;
            Console.WriteLine($"Sold Copies: {soldCopies} ({percentageSold:F2}%)");
            Console.WriteLine($"Unsold Copies: {sections[0].CopieTotali - soldCopies} ({percentageUnsold:F2}%)");


        }


        // Stashed changes
    }
}
