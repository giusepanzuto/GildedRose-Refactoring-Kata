namespace csharp
{
    public class Plus5DexterityVest : Item
    {
        public Plus5DexterityVest(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "+5 Dexterity Vest";
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
