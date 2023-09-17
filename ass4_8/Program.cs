using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_8
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Season currentSeason = Season.Summer;

            switch (currentSeason)
            {
                case Season.Spring:
                    Console.WriteLine("It's spring! Flowers are blooming.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer! Enjoy the sunshine.");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's autumn! The leaves are falling.");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's winter! Time for snow and hot cocoa.");
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    break;
            }
        }
    }
}