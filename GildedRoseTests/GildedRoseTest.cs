using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using System;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            Random rnd = new Random();
            int sellIn = rnd.Next(1, 20);
            int quality = rnd.Next(0, 51);
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(sellIn - 1, Items[0].SellIn);
            Assert.Equal(quality - 1, Items[0].Quality);
        }
    }
}
