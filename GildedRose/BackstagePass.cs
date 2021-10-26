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
            if (Quality < 50)
            {
                Quality++;
                
                if (SellIn <= 10)
                    Quality++;

                if (SellIn <= 5)
                    Quality++;
            }
        }

        private void DecreaseQualityToZero() 
        {
            Quality = 0;
        }

        public override void UpdateState()
        {
            IncreaseQuality();
            AgeTheSellIn();
            if (SellIn < 0)
            {
                DecreaseQualityToZero();
            }
        }


    }
}
