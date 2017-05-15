using ConcordanceLibrary.Classes;
using System;
namespace ConcordanceLibrary.Extensions
{
    public static class Extension
    {
        public static void Print(this Concordance concordance)
        {
            Console.WriteLine("Concordance:");
            foreach (char mainLetter in concordance.Items.Keys)
            {
                if (concordance[mainLetter].Values.Count != 0)
                {
                    Console.WriteLine(mainLetter);
                    foreach (var items in concordance[mainLetter])
                    {
                        Console.WriteLine("{0}..........{1}: {2}",
                            items.Key, items.Value.Count, items.Value.PageNumbersToString());
                    }
                }
            }
        }
    }
}
