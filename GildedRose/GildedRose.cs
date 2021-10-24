using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public IList<ItemWrapper> Items { get; } 
        public GildedRose(IList<Item> items)
        {
            Items = items.Select(i => ItemFactory.CreateNewItem(i)).ToList();
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
                item.UpdateState();
        }
    }
}
