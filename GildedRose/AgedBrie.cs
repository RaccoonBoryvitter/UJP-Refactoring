using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class AgedBrie : ItemWrapper
    {
        public AgedBrie(Item item) : base(item) { }

        private void IncreaseQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }

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
