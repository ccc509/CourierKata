using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourierKata.DiscountRules
{
    public class SmallParcelDiscountRule : IDiscountRule
    {
        public int GetDiscountedPrice(IList<Parcel> parcelList)
        {
            int sum = 0;
            var totalNumOfMediunParcels = 0;
            var priceList = new List<int>();

            foreach (var parcel in parcelList)
            {
                if (parcel.Label.Equals("Small Parcel"))
                {
                    priceList.Add(parcel.Price);
                    totalNumOfMediunParcels++;
                }
                sum += parcel.Price;
            }
            var numOfTimesRuleCanBeApplied = totalNumOfMediunParcels / 4;

            var orderedPriceList = priceList.OrderBy(p => p).ToList();

            for (var i = 0; i < numOfTimesRuleCanBeApplied; i++)
            {
                sum -= orderedPriceList[i];
            }

            return sum;
        }
    }
}
