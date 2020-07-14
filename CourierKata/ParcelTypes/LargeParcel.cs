namespace CourierKata.ParcelTypes
{
    public class LargeParcel : ParcelType
    {
        public override int MaxDimension { get { return 100; } }

        public override int MaxWeight { get { return 6; } }

        public override int OverWeightPanalty { get { return 2; } }

        public override int BasePrice { get { return 15; } }

        public override string Label { get { return "Large Parcel"; } }
    }
}
