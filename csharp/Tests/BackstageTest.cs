using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class BackstageTest
    {
        [TestCase(2, 0, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 50, 50)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var backstage = new Backstage(sellIn, quality);

            backstage.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), backstage.Quality);
        }
    }

}
