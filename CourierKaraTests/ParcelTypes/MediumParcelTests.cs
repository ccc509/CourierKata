using CourierKata.ParcelTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierKaraTests.ParcelTypes
{
    [TestClass]
    public class MediumParcelTests
    {
        private MediumParcel _mediumParcel;

        [TestInitialize]
        public void SetUp()
        {
            _mediumParcel = new MediumParcel();
        }

        [TestMethod]
        public void FitSize_DoesSizeFit_True()
        {
            var doesSizeFit = _mediumParcel.DoesSizeFit(49, 49, 49);
            Assert.IsTrue(doesSizeFit);
        }

        [TestMethod]
        public void TooLong_DoesSizeFit_False()
        {
            var doesSizeFit = _mediumParcel.DoesSizeFit(50, 9, 9);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void TooHigh_DoesSizeFit_False()
        {
            var doesSizeFit = _mediumParcel.DoesSizeFit(9, 50, 9);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void TooWide_DoesSizeFit_False()
        {
            var doesSizeFit = _mediumParcel.DoesSizeFit(9, 9, 50);
            Assert.IsFalse(doesSizeFit);
        }

        [TestMethod]
        public void WithinWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _mediumParcel.GetPrice(3);
            Assert.AreEqual(8, price);
        }

        [TestMethod]
        public void AboveWeightLimit_CalculatePrice_CorrectAnswer()
        {
            var price = _mediumParcel.GetPrice(5);
            Assert.AreEqual(12, price);
        }
    }
}
