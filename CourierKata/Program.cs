using System;

namespace CourierKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var parcelPriceCalculator = new ParcelPriceCalculator();
            var parcelPrice = parcelPriceCalculator.CreateParcelPrice(args[0]);
            Console.WriteLine(parcelPrice.ToString());
        }
    }
}
