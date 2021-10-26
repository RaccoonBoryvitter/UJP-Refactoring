using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public abstract class ItemWrapper
    {
        public Item Item { get; set; }
        public ItemWrapper(Item item)
        {
            Item = item;
        }

        public abstract void UpdateState();
    }
}
