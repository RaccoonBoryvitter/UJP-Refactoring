using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class AgedBrie : ItemWrapper
    {
        public AgedBrie(Item item) : base(item) { }

        protected override void IncreaseQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }

        protected override void DecreaseQuality() { }

        public override void UpdateState()
        {
            IncreaseQuality();
            AgeTheSellIn();
            if (SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
