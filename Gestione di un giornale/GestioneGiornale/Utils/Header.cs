namespace Utils
{
    // Classe specializzata per gestire emergenze
    public class Header : Journal
    {
        public string Title { get; set; }
        public Header(string nome, int copieTotali, string title) : base(nome, copieTotali)
        {
            Title = title;
        }

        public override void PublishSection()
        {
            Console.WriteLine("Header section: Highlights ");
        }
    }
}
