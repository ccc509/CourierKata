using CourierKata.DiscountRules;
using CourierKata.ParcelTypes;
using System;
using System.Collections.Generic;

namespace CourierKata
{
    public class ParcelPriceCalculator
    {
        private readonly IList<ParcelType> _parcelTypes;

        private readonly IList<IDiscountRule> _discountRules;
        public ParcelPriceCalculator()
        {
            _parcelTypes = new List<ParcelType>
            {
                new SmallParcel(),
                new MediumParcel(),
                new LargeParcel(),
                new ExtraLargeParcel(),
                new HeavyParcel()
            };

            _discountRules = new List<IDiscountRule>
            {
                new SmallParcelDiscountRule(),
                new MediumParcelDiscountRule(),
                new MixedParcelDiscountRule()
            };
        }

        public ParcelPrice CreateParcelPrice(string customerRequests)
        {
            var parcelList = new List<Parcel>();
            var requests = customerRequests.Split(' ');
            foreach (var request in requests)
            {
                var dimensions = request.Split(',');
                var height = int.Parse(dimensions[0]);
                var width = int.Parse(dimensions[1]);
                var depth = int.Parse(dimensions[2]);
                var weight = decimal.Parse(dimensions[3]);
                parcelList.Add(GetCheapestParcel(width, height, depth, weight));
            }

            int cheapestPriceWithDiscount = GetCheapestPriceWithDiscount(parcelList);
            return new ParcelPrice(parcelList, cheapestPriceWithDiscount);
        }

        private Parcel GetCheapestParcel(int width, int height, int depth, decimal weight)
        {
            string cheapestParcel = null;
            int cheapestPrice = Int32.MaxValue;

            foreach (var parcelTpye in _parcelTypes)
            {
                if (parcelTpye.DoesSizeFit(height, width, depth))
                {
                    var price = parcelTpye.GetPrice(weight);
                    if (price < cheapestPrice)
                    {
                        cheapestPrice = price;
                        cheapestParcel = parcelTpye.Label;
                    }
                }
            }

            return new Parcel(cheapestParcel, cheapestPrice);
        }

        private int GetCheapestPriceWithDiscount(List<Parcel> parcelList)
        {
            int cheapestPriceWithDiscount = Int32.MaxValue;
            foreach (var discountRule in _discountRules)
            {
                var priceWithDiscount = discountRule.GetDiscountedPrice(parcelList);
                if (priceWithDiscount < cheapestPriceWithDiscount)
                {
                    cheapestPriceWithDiscount = priceWithDiscount;
                }
            }

            return cheapestPriceWithDiscount;
        }
    }
}
