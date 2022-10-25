namespace csharp
{
    public class ElixirOfTheMongoose: Item
    {
        public ElixirOfTheMongoose(ItemStatus itemStatus): base("Elixir of the Mongoose", itemStatus)
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
