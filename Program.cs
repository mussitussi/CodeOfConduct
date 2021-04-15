using static System.Console;
using System.Text.Json;
using ImmutableDemo2;

namespace ImmutableDemo
{
    // C# 9.0 (record: class som per default er en "value" type)
    public record BondRecord(string InstrumentId, double Coupon);

    public sealed class Bond
    {
        public double Coupon { get; }
        public string Isin { get; }

        public Bond(string isin, double coupon)
        {
            Isin = isin;
            Coupon = coupon; 
        }

        public Bond With(string Isin = null, double? Coupon = null)
            => new Bond(Isin ?? this.Isin, Coupon ?? this.Coupon);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Bond("ID1", 1.0);
            var b2 = b1.With(Isin: "ID2");
            var b3 = b1.With(Isin: "ID3", Coupon: 2.0);
            var b4 = b3.With(x => x.Coupon, 4.0);  // using extention method
            show(b1);
            show(b2);
            show(b3);
            show(b4);
        }

        private static void show(object o)
        {
            WriteLine(JsonSerializer.Serialize(o));
        }
    }
}
