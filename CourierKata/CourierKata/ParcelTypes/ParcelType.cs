using System;

namespace CourierKata.ParcelTypes
{
    public abstract class ParcelType
    {
        public abstract int MaxDimension { get; }
        public abstract int MaxWeight { get; }
        public abstract int OverWeightPanalty { get; }
        public abstract int BasePrice { get; }
        public abstract string Label { get; }
        public bool DoesSizeFit(int height, int width, int depth)
        {
            return height < MaxDimension && width < MaxDimension && depth < MaxDimension;
        }

        public int GetPrice(decimal weight)
        {
            var overWeight = weight < MaxWeight ? 0 : Math.Ceiling(weight - MaxWeight);
            return (int)(BasePrice + overWeight * OverWeightPanalty);
        }
    }
}
