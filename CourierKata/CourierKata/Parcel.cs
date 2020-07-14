using System;
using System.Collections.Generic;
using System.Text;

namespace CourierKata
{
    public class Parcel
    {
        public string Label { get; private set; }
        public int Price { get; private set; }

        public Parcel(string label, int price)
        {
            Label = label;
            Price = price;
        }
    }
}
