using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class AgedBrieTest
    {
        [TestCase(2, 0, 1)]
        [TestCase(0, 0, 2)]
        [TestCase(2, 50, 50)]
        public void UpdateQuality(int sellIn, int quality, int expectedQuality)
        {
            var agedBrie = new AgedBrie(sellIn, quality);

            agedBrie.UpdateQuality();

            Assert.AreEqual(new ItemQuality(expectedQuality), agedBrie.Quality);
        }
    }
}
