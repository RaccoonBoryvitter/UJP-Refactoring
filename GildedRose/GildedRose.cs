using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public IList<Item> Items { get; set; } 
        public GildedRose(IList<Item> items)
        {
            // Items = items.Select(i => ItemFactory.CreateNewItem(i)).ToList();
            Items = items;
        }

        public void UpdateQuality()
        {
            IList<ItemWrapper> items = Items.Select(i => ItemFactory.CreateNewItem(i)).ToList();
            foreach (var item in items)
                item.UpdateState();
            Items = items.Select(w => w.Item).ToList();
        }
    }
}
