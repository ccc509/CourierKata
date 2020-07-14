using System.Collections.Generic;
using System.Text;

namespace CourierKata
{
    public class ParcelPrice
    {
        private readonly List<Parcel> _parcelList;

        public int Price { get; set; }

        public int SpeedyPrice { get
            {
                return Price * 2;
            } 
        }
        public ParcelPrice(List<Parcel> parcelList, int price)
        {
            _parcelList = parcelList;
            Price = price;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var parcel in _parcelList)
            {
                sb.AppendLine(parcel.Label + ": $" + parcel.Price);
            }
            sb.AppendLine("Total Price: $" + Price);
            sb.AppendLine("Speedy Price: $" + SpeedyPrice);

            return sb.ToString();
        }
    }
}
