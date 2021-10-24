using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class Sulfuras : ItemWrapper
    {
        public Sulfuras(Item item) : base(item) { }

        protected override void IncreaseQuality() { }

        protected override void DecreaseQuality() { }

        public override void UpdateState() { }
    }
}
