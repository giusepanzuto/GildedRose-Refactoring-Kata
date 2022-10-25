using System;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var runner = RunnerFactory.Create();

            runner.Run();
        }
    }
}