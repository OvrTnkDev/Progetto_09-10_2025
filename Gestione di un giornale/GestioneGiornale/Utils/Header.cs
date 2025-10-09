namespace Utils
{
    // Classe specializzata per gestire emergenze
    public class Header : Journal
    {
        public string Title { get; set; }
        public Header(string title) : base("Daily news", 1000)
        {
            Title = title;
        }

        public override void PublishSection()
        {
            Console.WriteLine("Header section: Highlights ");
        }
    }
}
