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
            var itemStatus = new ItemStatus(quality, sellIn);
            var backstage = new Backstage(itemStatus);

            backstage.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), itemStatus.Quality);
        }
    }

}
