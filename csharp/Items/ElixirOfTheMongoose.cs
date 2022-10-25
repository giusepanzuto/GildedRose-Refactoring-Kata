namespace csharp
{
    public class ElixirOfTheMongoose: Item
    {
        public ElixirOfTheMongoose(ItemStatus itemStatus): base("Elixir of the Mongoose", itemStatus, new QualityUpdater2())
        {
        }
    }
}
