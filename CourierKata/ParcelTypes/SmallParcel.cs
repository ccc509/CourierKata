namespace CourierKata.ParcelTypes
{
    public class SmallParcel : ParcelType
    {
        public override int MaxDimension { get { return 10; } }

        public override int MaxWeight { get { return 1; }}

        public override int OverWeightPanalty { get { return 2; }}

        public override int BasePrice { get { return 3; }}

        public override string Label { get { return "Small Parcel"; } }
    }
}
