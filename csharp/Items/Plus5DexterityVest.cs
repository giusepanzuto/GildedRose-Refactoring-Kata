namespace csharp
{
    public class Plus5DexterityVest : Item
    {
        public Plus5DexterityVest(int sellIn, ItemQuality quality):base("+5 Dexterity Vest", sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            DecreaseQuality();
            
            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }

    }
}
