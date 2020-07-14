using CourierKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierKaraTests
{
    [TestClass]
    public class ParcelPriceCalculatorTests
    {
        [TestMethod]
        public void MixedRequests_CalculatePrice_CorrectResult()
        {
            var parcelPriceCalculator = new ParcelPriceCalculator();
            var parcelPrice = parcelPriceCalculator.CreateParcelPrice("8,8,8,1 25,25,25,3 88,88,88,6 111,111,111,10 33,33,33,50");
            var result = parcelPrice.ToString();
            Assert.AreEqual(98, parcelPrice.Price);
            Assert.AreEqual(196, parcelPrice.SpeedyPrice);
            Assert.AreEqual(result, "Small Parcel: $3\r\nMedium Parcel: $8\r\nLarge Parcel: $15\r\nExtra Large Parcel: $25\r\nHeavy Parcel: $50\r\nTotal Price: $98\r\nSpeedy Price: $196\r\n");

        }
    }
}
