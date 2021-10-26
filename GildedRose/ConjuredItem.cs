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
            if (Item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }

        private void AgeTheSellIn()
        {
            Item.SellIn--;
        }

        private void DecreaseQuality()
        {
            if (Item.Quality > Quality.MinValue)
            {
                Item.Quality -= 2;
            }

            if (Item.Quality < Quality.MinValue)
            {
                Item.Quality = Quality.MinValue;
            }
        }
    }
}
