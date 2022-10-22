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

        public void UpdateQuality()
        {
            if (Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                DecreaseQuality();
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
                        DecreaseQuality();
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

        private void ResetQuality()
        {
            Quality = 0;
        }

        private void DecreaseQuality()
        {
            if (Quality > 0)
            {
                if (Name != "Sulfuras, Hand of Ragnaros")
                {
                    Quality = Quality - 1;
                }
            }
        }

        private void IncreaseQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;
            }
        }
    }
}
