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
            var agedBrie = new Backstage(sellIn, quality);

            agedBrie.UpdateQuality();

            Assert.AreEqual(expectedQuality, agedBrie.Quality);
        }
    }
}
