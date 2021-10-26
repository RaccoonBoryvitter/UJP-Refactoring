using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConjuredItem : ItemWrapper
    {
        public ConjuredItem(Item item) : base(item) { }

        public override void UpdateState()
        {
            DecreaseQuality();
            AgeTheSellIn();
            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }

        private void AgeTheSellIn()
        {
            SellIn--;
        }

        private void DecreaseQuality()
        {
            if (Quality > 0)
            {
                Quality -= 2;
            }

            if (Quality < 0)
            {
                Quality = 0;
            }
        }
    }
}
