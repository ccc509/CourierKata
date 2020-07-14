namespace CourierKata.ParcelTypes
{
    public class MediumParcel : ParcelType
    {
        public override int MaxDimension { get { return 50; } }

        public override int MaxWeight { get { return 3; } }

        public override int OverWeightPanalty { get { return 2; } }

        public override int BasePrice { get { return 8; } }

        public override string Label { get { return "Medium Parcel"; } }
    }
}
