using System;
using System.Collections.Generic;
using System.Text;

namespace CourierKata.ParcelTypes
{
    public class ExtraLargeParcel : ParcelType
    {
        public override int MaxDimension { get { return Int32.MaxValue; } }

        public override int MaxWeight { get { return 10; } }

        public override int OverWeightPanalty { get { return 2; } }

        public override int BasePrice { get { return 25; } }

        public override string Label { get { return "Extra Large Parcel"; } }
    }
}
