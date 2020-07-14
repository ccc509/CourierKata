using System.Collections.Generic;

namespace CourierKata.DiscountRules
{
    public interface IDiscountRule
    {
        public int GetDiscountedPrice(IList<Parcel> parcelList);
    }
}
