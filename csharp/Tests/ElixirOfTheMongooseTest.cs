using csharp.Items;
using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class ElixirOfTheMongooseTest
    {
        [TestCase(2, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 50, 49)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var itemStatus = new ItemStatus(quality, sellIn);
            var elixirOfTheMongoose = new ElixirOfTheMongoose(itemStatus);

            elixirOfTheMongoose.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), itemStatus.Quality);
        }
    }
}
