namespace csharp
{
    public interface IItem
    {
        string Name { get; }
        int SellIn { get; set; }
        ItemQuality Quality { get; }
        string ToString();
        void UpdateQuality();
    }
}