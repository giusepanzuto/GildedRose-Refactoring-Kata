using csharp.Items;
using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class AgedBrieTest
    {
        [TestCase(2, 0, 1)]
        [TestCase(0, 0, 2)]
        [TestCase(2, 50, 50)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var itemStatus = new ItemStatus(quality, sellIn);
            var agedBrie = new AgedBrie(itemStatus);

            agedBrie.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), itemStatus.Quality);
        }
    }
}
