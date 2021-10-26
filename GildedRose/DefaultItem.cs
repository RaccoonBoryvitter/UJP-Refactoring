using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class DefaultItem : ItemWrapper
    {
        public DefaultItem(Item item) : base(item) { }

        private void DecreaseQuality()
        {
            if (Item.Quality > Quality.MinValue)
            {
                Item.Quality--;
            }

            if (Item.Quality < Quality.MinValue)
            {
                Item.Quality = Quality.MinValue;
            }
        }

        private void AgeTheSellIn()
        {
            Item.SellIn--;
        }

        public override void UpdateState()
        {
            DecreaseQuality();
            AgeTheSellIn();
            if (Item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }


    }
}
