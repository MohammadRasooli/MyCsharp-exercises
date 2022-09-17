using System;
using System.Linq;
namespace BestPokerHand
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranks = new int[] { 3, 3, 6, 6, 6 };
            var suits = new char[] { 'a', 'a', 'a', 'a', 'a' };
            Console.WriteLine(bestHandPoker(ranks, suits));
        }
        static string bestHandPoker(int[] ranks, char[] suits)
        {
            if (suits.Count(a => a == suits[0]) == 5)
                return "Flush";

            for (int i = 0; i < ranks.Length; i++)
            {
                if (ranks.Count(a => a == ranks[i]) >= 3)
                    return "Three of a Kind";
            }

            for (int i = 0; i < ranks.Length; i++)
            {
                if (ranks.Count(a => a == ranks[i]) == 2)
                    return "Pair";
            }

            return "High Card";
        }
    }
}
