using CourierKata.ParcelTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierKaraTests.ParcelTypes
{
    [TestClass]
    public class LargeParcelTests
    {
        private LargeParcel _largeParcel;

        [TestInitialize]
        public void SetUp()
        {
            _largeParcel = new LargeParcel();
        }

        [TestMethod]
        public void FitSize_DoesSizeFit_True()
        {
            var doesSizeFit = _largeParcel.DoesSizeFit(99, 99, 99);
            Assert.IsTrue(doesSizeFit);
        }

        [TestMethod]
        public void TooLong_DoesSizeFit_False()
        {
            var doesSizeFit = _largeParcel.DoesSizeFit(105, 99, 99);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void TooHigh_DoesSizeFit_False()
        {
            var doesSizeFit = _largeParcel.DoesSizeFit(99, 150, 99);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void TooWide_DoesSizeFit_False()
        {
            var doesSizeFit = _largeParcel.DoesSizeFit(99, 99, 950);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void WithinWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _largeParcel.GetPrice(6);
            Assert.AreEqual(15, price);
        }

        [TestMethod]
        public void AboveWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _largeParcel.GetPrice(8);
            Assert.AreEqual(19, price);
        }
    }
}
