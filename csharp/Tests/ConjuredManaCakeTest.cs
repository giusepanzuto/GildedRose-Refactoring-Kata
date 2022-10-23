using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ConjuredManaCakeTest
    {
        [TestCase(2, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 50, 49)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var agedBrie = new ConjuredManaCake(sellIn, quality);

            agedBrie.UpdateQuality();

            Assert.AreEqual(expectedQuality, agedBrie.Quality);
        }
    }
}
