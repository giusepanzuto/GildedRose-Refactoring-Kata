using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class Plus5DexterityVestTest
    {
        [TestCase(2, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 50, 49)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var plus5DexterityVest = new Plus5DexterityVest(sellIn, quality);

            plus5DexterityVest.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), plus5DexterityVest.Quality);
        }
    }
}
