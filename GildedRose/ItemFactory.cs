namespace GildedRoseKata
{
    public class ItemFactory
    {
        public static ItemWrapper CreateNewItem(Item item)
        {
            if (item.Name.Contains("Conjured"))
                return new ConjuredItem(item);

            return item.Name switch
            {
                "Aged Brie" => new AgedBrie(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePass(item),
                "Sulfuras, Hand of Ragnaros" => new Sulfuras(item),
                _ => new DefaultItem(item),
            };
        }
    }
}
