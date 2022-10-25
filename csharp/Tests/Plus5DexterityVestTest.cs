using csharp.Items;
using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class Plus5DexterityVestTest
    {
        [TestCase(2, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 50, 49)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var itemStatus = new ItemStatus(quality, sellIn);
            var plus5DexterityVest = new Plus5DexterityVest(itemStatus);

            plus5DexterityVest.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), itemStatus.Quality);
        }
    }
}
