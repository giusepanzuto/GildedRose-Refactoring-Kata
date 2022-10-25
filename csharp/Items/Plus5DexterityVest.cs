namespace csharp
{
    public class Plus5DexterityVest : Item
    {
        public Plus5DexterityVest(ItemStatus itemStatus):base("+5 Dexterity Vest", itemStatus)
        {
        }

        public override void UpdateQuality()
        {
            Quality.Decrease();

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                Quality.Decrease();
            }
        }

    }
}
