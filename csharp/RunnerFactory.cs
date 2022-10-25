namespace csharp
{
    public class RunnerFactory
    {
        public static GildedRoseRunner Create()
        {
            return new GildedRoseRunner(new ConsoleItemsPresenter(), new GildedRose(), new ItemSource());
        }
    }
}