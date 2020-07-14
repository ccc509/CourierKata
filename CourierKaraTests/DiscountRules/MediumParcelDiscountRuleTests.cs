using CourierKata;
using CourierKata.DiscountRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourierKaraTests.DiscountRules
{
    [TestClass]
    public class MediumParcelDiscountRuleTests
    {
        private MediumParcelDiscountRule _mediumParcelDiscountRule;

        [TestInitialize]
        public void SetUp()
        {
            _mediumParcelDiscountRule = new MediumParcelDiscountRule();
        }

        [TestMethod]
        public void ThreeMediumParcel_CalculatePriceWithDiscount_CheapestFree()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 8));
            var priceWithDiscount = _mediumParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(20, priceWithDiscount);
        }

        [TestMethod]
        public void TwoMedianParcel_CalculatePriceWithDiscount_NoChange()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 8));
            var priceWithDiscount = _mediumParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(18, priceWithDiscount);
        }

        [TestMethod]
        public void SixMediumParcel_CalculatePriceWithDiscount_TwoFree()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 8));
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 6));
            var priceWithDiscount = _mediumParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(40, priceWithDiscount);
        }

        [TestMethod]
        public void ThreeSmallParcelMixed_CalculatePriceWithDiscount_CheapestFree()
        {
            var parcelList = new List<Parcel>();
            parcelList.Add(new Parcel("Large Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 10));
            parcelList.Add(new Parcel("Medium Parcel", 20));
            parcelList.Add(new Parcel("Medium Parcel", 20));
            parcelList.Add(new Parcel("Large Parcel", 10));
            parcelList.Add(new Parcel("Small Parcel", 6));
            parcelList.Add(new Parcel("Small Parcel", 5));
            parcelList.Add(new Parcel("Large Parcel", 10));
            var priceWithDiscount = _mediumParcelDiscountRule.GetDiscountedPrice(parcelList);
            Assert.AreEqual(81, priceWithDiscount);
        }
    }
}
