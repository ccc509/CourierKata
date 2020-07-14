using CourierKata;
using CourierKata.DiscountRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CourierKaraTests.DiscountRules
{
    [TestClass]
    public class SmallParcelDiscountRuleTests
    {
        private SmallParcelDiscountRule _smallParcelDiscountRule;

        [TestInitialize]
        public void SetUp()
        {
            _smallParcelDiscountRule = new SmallParcelDiscountRule();
        }

        [TestMethod]
        public void FourSmallParcel_CalculatePriceWithDiscount_CheapestFree()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 8));
            parcelList.Add(new Parcel("Small Parcel", 10));
            var priceWithDiscount = _smallParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(30, priceWithDiscount);
        }

        [TestMethod]
        public void ThreeSmallParcel_CalculatePriceWithDiscount_NoChange()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 8));
            var priceWithDiscount = _smallParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(28, priceWithDiscount);
        }

        [TestMethod]
        public void EightSmallParcel_CalculatePriceWithDiscount_TwoFree()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 8));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 6));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            var priceWithDiscount = _smallParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(60, priceWithDiscount);
        }

        [TestMethod]
        public void FourSmallParcelMixed_CalculatePriceWithDiscount_CheapestFree()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Large Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 10));
            parcelList.Add(new Parcel("Large Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 6));
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Large Parcel", 10));
            var priceWithDiscount = _smallParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(70, priceWithDiscount);
        }
    }
}
