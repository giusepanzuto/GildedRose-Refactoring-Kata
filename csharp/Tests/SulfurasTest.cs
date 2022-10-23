using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class SulfurasTest
    {
        [TestCase(2, 0)]
        [TestCase(0, 0)]
        [TestCase(2, 50)]
        public void UpdateQuality(int sellIn, int quality)
        {
            var sulfuras = new Sulfuras(sellIn, quality);

            sulfuras.UpdateQuality();

            Assert.AreEqual(new ItemQuality(quality), sulfuras.Quality);
        }
    }

}
