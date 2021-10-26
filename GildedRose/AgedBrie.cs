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
            if (Item.Quality < Quality.MaxValue)
            {
                Item.Quality++;
            }
            if (Item.Quality > Quality.MaxValue)
            {
                Item.Quality = Quality.MaxValue;
            }
        }

        private void AgeTheSellIn()
        {
            Item.SellIn--;
        }

        public override void UpdateState()
        {
            IncreaseQuality();
            AgeTheSellIn();
            if (Item.SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
