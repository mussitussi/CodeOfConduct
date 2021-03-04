namespace ImmutableDemo
{
    public class Bond
    {
        public string Isin { get; }
        public double Price { get; }
        public Bond(string isin, double price) => (Isin, Price) = (isin, price);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var b = new Bond("DK123", 100.5);
        }
    }
}
