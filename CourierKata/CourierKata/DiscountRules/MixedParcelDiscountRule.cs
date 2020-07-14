using CourierKata.ParcelTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourierKata.DiscountRules
{
    public class MixedParcelDiscountRule : IDiscountRule
    {
        public int GetDiscountedPrice(IList<Parcel> parcelList)
        {
            int sum = 0;
            var numOfTimesRuleCanBeApplied = parcelList.Count / 5;
            var priceList = new List<int>();

            foreach (var parcel in parcelList)
            {
                priceList.Add(parcel.Price);
                sum += parcel.Price;
            }

            var orderedPriceList = priceList.OrderBy(p => p).ToList();

            for (var i = 0; i < numOfTimesRuleCanBeApplied; i++)
            {
                sum -= orderedPriceList[i];
            }

            return sum;
        }
    }
}
