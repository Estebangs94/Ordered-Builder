using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalBuilderDesignPattern
{
    public class DemonSlayer
    {
        public string Name { get; set; }
        public Ranks Rank { get; set; }
        public int Level { get; set; }
        public int Katanas { get; set; }

        public Dictionary<int, string> Entries { get; set; }

        public DemonSlayer()
        {
            Entries = new Dictionary<int, string>();
        }
    }

    public enum Ranks
    {
        Mizunoto,
        Mizunoe,
        Kanoto,
        Kanoe,
        Tsuchinoto,
        Tsuchinoe,
        Hinoto,
        Hinoe,
        Kinoto,
        Kinoe,
        Hashira
    }
}
