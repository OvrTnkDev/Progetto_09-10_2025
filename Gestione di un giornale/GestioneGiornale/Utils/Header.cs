namespace Utils
{
    // Classe specializzata per gestire emergenze
    public class Header : Journal
    {
     public Header() : base("Daily news", 1000){}
        public override void PublishSection()
        {
            Console.WriteLine("Header section: Highlights ");
        }
    }
}
