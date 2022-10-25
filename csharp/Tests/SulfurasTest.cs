using csharp.Items;
using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class SulfurasTest
    {
        [TestCase(2, 0)]
        [TestCase(0, 0)]
        [TestCase(2, 50)]
        public void UpdateQuality(int sellIn, int quality)
        {
            var itemStatus = new ItemStatus(quality, sellIn);
            var sulfuras = new Sulfuras(itemStatus);

            sulfuras.UpdateQuality();

            Assert.AreEqual(new ItemQuality(quality), itemStatus.Quality);
        }
    }

}
