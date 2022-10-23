using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ElixirOfTheMongooseTest
    {
        [TestCase(2, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 50, 49)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var elixirOfTheMongoose = new ElixirOfTheMongoose(sellIn, quality);

            elixirOfTheMongoose.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), elixirOfTheMongoose.Quality);
        }
    }
}
