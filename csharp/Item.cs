using System.Xml.Linq;

namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public virtual void UpdateQuality()
        {
            if (Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Name != "Sulfuras, Hand of Ragnaros")
                {
                    DecreaseQuality();
                }
            }

            if (Name == "Aged Brie" || Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Quality < 50)
                {
                    IncreaseQuality();

                    if (Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (SellIn < 11)
                        {
                            IncreaseQuality();
                        }

                        if (SellIn < 6)
                        {
                            IncreaseQuality();
                        }
                    }
                }
            }

            if (Name != "Sulfuras, Hand of Ragnaros")
            {
                SellIn = SellIn - 1;
            }

            if (SellIn < 0)
            {
                if (Name != "Aged Brie")
                {
                    if (Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Name != "Sulfuras, Hand of Ragnaros")
                        {
                            DecreaseQuality();
                        }
                    }
                    else
                    {
                        ResetQuality();
                    }
                }
                else
                {
                    IncreaseQuality();
                }
            }
        }

        protected void DecreaseQuality()
        {
            if (Quality > 0)
            {
                Quality = Quality - 1;
            }
        }

        protected void ResetQuality()
        {
            Quality = 0;
        }

        protected void IncreaseQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;
            }
        }
    }
}
