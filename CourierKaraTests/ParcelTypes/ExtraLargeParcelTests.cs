using CourierKata.ParcelTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierKaraTests.ParcelTypes
{
    [TestClass]
    public class ExtraLargeParcelTests
    {
        private ExtraLargeParcel _extraLargeParcel;

        [TestInitialize]
        public void SetUp()
        {
            _extraLargeParcel = new ExtraLargeParcel();
        }

        [TestMethod]
        public void WithinWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _extraLargeParcel.GetPrice(10);
            Assert.AreEqual(25, price);
        }

        [TestMethod]
        public void AboveWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _extraLargeParcel.GetPrice(11);
            Assert.AreEqual(27, price);
        }
    }
}
