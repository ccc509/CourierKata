using CourierKata.ParcelTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierKaraTests.ParcelTypes
{
    [TestClass]
    public class SmallParcelTests
    {
        private SmallParcel _smallParcel;

        [TestInitialize]
        public void SetUp()
        {
            _smallParcel = new SmallParcel();
        }

        [TestMethod]
        public void FitSize_DoesSizeFit_True()
        {
            var doesSizeFit = _smallParcel.DoesSizeFit(9, 9, 9);
            Assert.IsTrue(doesSizeFit);
        }

        [TestMethod]
        public void TooLong_DoesSizeFit_False()
        {
            var doesSizeFit = _smallParcel.DoesSizeFit(10, 9, 9);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void TooHigh_DoesSizeFit_False()
        {
            var doesSizeFit = _smallParcel.DoesSizeFit(9, 10, 9);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void TooWide_DoesSizeFit_False()
        {
            var doesSizeFit = _smallParcel.DoesSizeFit(9, 9, 10);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void WithinWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _smallParcel.GetPrice(1);
            Assert.AreEqual(3, price);
        }

        [TestMethod]
        public void AboveWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _smallParcel.GetPrice(3);
            Assert.AreEqual(7, price);
        }
    }
}
