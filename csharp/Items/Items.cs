using csharp.Items.QualityUpdater;

namespace csharp.Items
{
    public class AgedBrie : Item
    {
        public AgedBrie(ItemStatus itemStatus): 
            base("Aged Brie", itemStatus, new QualityUpdater1())
        {
        }
    }

    public class ConjuredManaCake : Item
    {
        public ConjuredManaCake(ItemStatus itemStatus) : 
            base("Conjured Mana Cake", itemStatus, new QualityUpdater2())
        {
        }
    }

    public class Backstage : Item
    {
        public Backstage(ItemStatus itemStatus) :
            base("Backstage passes to a TAFKAL80ETC concert", itemStatus, new QualityUpdaterBackstage())
        {
        }
    }

    public class ElixirOfTheMongoose : Item
    {
        public ElixirOfTheMongoose(ItemStatus itemStatus) : 
            base("Elixir of the Mongoose", itemStatus, new QualityUpdater2())
        {
        }
    }

    public class Plus5DexterityVest : Item
    {
        public Plus5DexterityVest(ItemStatus itemStatus) : 
            base("+5 Dexterity Vest", itemStatus, new QualityUpdater2())
        {
        }
    }

    public class Sulfuras : Item
    {
        public Sulfuras(ItemStatus itemStatus) : 
            base("Sulfuras, Hand of Ragnaros", itemStatus, new QualityUpdaterNope())
        {
        }
    }
}
