using CourierKata;
using CourierKata.DiscountRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourierKaraTests.DiscountRules
{
    [TestClass]
    public class MixedParcelDiscountRuleTests
    {
        private MixedParcelDiscountRule _mixedParcelDiscountRule;

        [TestInitialize]
        public void SetUp()
        {
            _mixedParcelDiscountRule = new MixedParcelDiscountRule();
        }

        [TestMethod]
        public void FiveMixedParcel_CalculatePriceWithDiscount_CheapestFree()
        {
            var parcelList = new List<Parcel>
            {
                new Parcel("Medium Parcel", 10),
                new Parcel("Small Parcel", 10),
                new Parcel("Large Parcel", 8),
                new Parcel("Small Parcel", 10),
                new Parcel("Heavy Parcel", 10)
            };
            var priceWithDiscount = _mixedParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(40, priceWithDiscount);
        }

        [TestMethod]
        public void ThreeMixedParcel_CalculatePriceWithDiscount_NoChange()
        {
            var parcelList = new List<Parcel>
            {
                new Parcel("Small Parcel", 10),
                new Parcel("Big Parcel", 10),
                new Parcel("Medium Parcel", 8)
            };
            var priceWithDiscount = _mixedParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(28, priceWithDiscount);
        }

        [TestMethod]
        public void TenMixedParcel_CalculatePriceWithDiscount_TwoFree()
        {
            var parcelList = new List<Parcel>
            {
                new Parcel("Small Parcel", 10),
                new Parcel("Small Parcel", 10),
                new Parcel("Small Parcel", 8),
                new Parcel("Small Parcel", 10),
                new Parcel("Big Parcel", 10),
                new Parcel("Small Parcel", 6),
                new Parcel("Small Parcel", 10),
                new Parcel("Heavy Parcel", 10),
                new Parcel("Small Parcel", 10),
                new Parcel("Small Parcel", 10)
            };
            var priceWithDiscount = _mixedParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(80, priceWithDiscount);
        }
    }
}
