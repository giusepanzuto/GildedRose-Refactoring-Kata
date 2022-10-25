using csharp.Items.QualityUpdater;

namespace csharp.Items
{
    public class AgedBrie : Item
    {
        public AgedBrie(ItemStatus itemStatus): 
            base("Aged Brie", itemStatus, new QualityUpdaterIncrease())
        {
        }
    }

    public class ConjuredManaCake : Item
    {
        public ConjuredManaCake(ItemStatus itemStatus) : 
            base("Conjured Mana Cake", itemStatus, new QualityUpdaterDecrease())
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
            base("Elixir of the Mongoose", itemStatus, new QualityUpdaterDecrease())
        {
        }
    }

    public class Plus5DexterityVest : Item
    {
        public Plus5DexterityVest(ItemStatus itemStatus) : 
            base("+5 Dexterity Vest", itemStatus, new QualityUpdaterDecrease())
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
