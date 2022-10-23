namespace csharp
{
    public class ElixirOfTheMongoose: Item
    {
        public ElixirOfTheMongoose(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Elixir of the Mongoose";
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
