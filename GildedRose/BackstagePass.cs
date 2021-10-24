﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class BackstagePass : ItemWrapper
    {
        public BackstagePass(Item item) : base(item) { }

        protected override void IncreaseQuality()
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

        protected override void DecreaseQuality() 
        {
            Quality = 0;
        }

        public override void UpdateState()
        {
            IncreaseQuality();
            AgeTheSellIn();
            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }


    }
}