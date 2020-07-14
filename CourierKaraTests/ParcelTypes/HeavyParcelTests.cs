using CourierKata.ParcelTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierKaraTests.ParcelTypes
{
    [TestClass]
    public class HeavyParcelTests
    {
        private HeavyParcel _heavyParcel;

        [TestInitialize]
        public void SetUp()
        {
            _heavyParcel = new HeavyParcel();
        }

        [TestMethod]
        public void WithinWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _heavyParcel.GetPrice(49);
            Assert.AreEqual(50, price);
        }

        [TestMethod]
        public void AboveWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _heavyParcel.GetPrice(55);
            Assert.AreEqual(55, price);
        }
    }
}
