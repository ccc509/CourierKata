using System;

namespace CourierKata.ParcelTypes
{
    public class HeavyParcel : ParcelType
    {
        public override int MaxDimension { get { return Int32.MaxValue; } }

        public override int MaxWeight { get { return 50; } }

        public override int OverWeightPanalty { get { return 1; } }

        public override int BasePrice { get { return 50; } }

        public override string Label { get { return "Heavy Parcel"; } }
    }
}
