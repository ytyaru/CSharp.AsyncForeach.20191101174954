using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncForeach
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await AsyncForeach(GenerateAsync());
        }
        static async Task AsyncForeach(IAsyncEnumerable<int> items)
        {
            await foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        static async IAsyncEnumerable<int> GenerateAsync()
        {
            for (int i = 0; i<10; i++)
            {
                yield return i;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}
