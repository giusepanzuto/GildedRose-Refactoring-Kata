using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class AgedBrieTest
    {
        [Test]
        public void UpdateQuality()
        {
            var agedBrie = new AgedBrie();

            agedBrie.UpdateQuality();

            Assert.AreEqual(1, agedBrie.Quality);
        }

        [Test]
        public void UpdateQualityTwoTimes()
        {
            var agedBrie = new AgedBrie();

            agedBrie.UpdateQuality();
            agedBrie.UpdateQuality();

            Assert.AreEqual(2, agedBrie.Quality);
        }

        [Test]
        public void UpdateQualityThreeTimes()
        {
            var agedBrie = new AgedBrie();

            agedBrie.UpdateQuality();
            agedBrie.UpdateQuality();
            agedBrie.UpdateQuality();

            Assert.AreEqual(4, agedBrie.Quality);
        }

    }

}
