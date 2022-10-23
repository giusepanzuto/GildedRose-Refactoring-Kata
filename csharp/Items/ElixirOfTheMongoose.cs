namespace csharp
{
    public class ElixirOfTheMongoose: Item
    {
        public ElixirOfTheMongoose(int sellIn, ItemQuality quality): base("Elixir of the Mongoose", sellIn, quality)
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
