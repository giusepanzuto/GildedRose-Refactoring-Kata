using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ItemQualityTest
    {
        [Test]
        public void EqualsTest()
        {
            Assert.AreEqual(new ItemQuality(2), new ItemQuality(2));
        }

        [TestCase(0, 1)]
        [TestCase(49, 50)]
        [TestCase(50, 50)]
        public void Increase(int initial, int expected)
        {
            var itemQuality = new ItemQuality(initial);

            itemQuality.Increase();

            Assert.AreEqual(new ItemQuality(expected), itemQuality);
        }

        [TestCase(0, 0)]
        [TestCase(50, 49)]
        public void Decrease(int initial, int expected)
        {
            var itemQuality = new ItemQuality(initial);

            itemQuality.Decrease();

            Assert.AreEqual(new ItemQuality(expected), itemQuality);
        }

        [TestCase(0)]
        [TestCase(50)]
        public void Reset(int initial)
        {
            var itemQuality = new ItemQuality(initial);

            itemQuality.Reset();

            Assert.AreEqual(new ItemQuality(0), itemQuality);
        }

    }
}
