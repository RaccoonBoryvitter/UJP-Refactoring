using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class BackstagePass : ItemWrapper
    {
        public BackstagePass(Item item) : base(item) { }

        private void IncreaseQuality()
        {
            if (Item.Quality < Quality.MaxValue)
            {
                Item.Quality++;
                
                if (Item.SellIn <= 10)
                    Item.Quality++;

                if (Item.SellIn <= 5)
                    Item.Quality++;
            }
            if (Item.Quality > Quality.MaxValue)
            {
                Item.Quality = Quality.MaxValue;
            }
        }

        private void DecreaseQualityToZero() 
        {
            Item.Quality = Quality.MinValue;
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
                DecreaseQualityToZero();
            }
        }


    }
}
