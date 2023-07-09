//if batting momentum = runs scored* strike rate, write a program that will return the batsman with the
//best batting momentum from the below object[ {"Batsman" :  "Virat kholi", "RunsScored" : 50, "StrikeRate" : 78.30},
//{ "Batsman" :  "M.S. Dhoni", "RunsScored" : 61, "StrikeRate" : 58.90},
//{ "Batsman" :  "Rohit Sharma", "RunsScored" : 13, "StrikeRate" : 124}]

using System;
using System.Collections.Generic;

namespace Q9
{
    public class Batsman
    {
        public string Name { get; set; }    
        public int RunsScored { get; set; } 
        public double StrikeRate { get; set; }
        public double Momentum
        {
            get { return RunsScored * StrikeRate;  }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Batsman> batsmen = new List<Batsman>
            {
                new Batsman { Name = "Virat Kohli", RunsScored = 50, StrikeRate = 78.30 },
                new Batsman { Name = "M.S. Dhoni", RunsScored = 61, StrikeRate = 58.90 },
                new Batsman { Name = "Rohit Sharma", RunsScored = 13, StrikeRate = 124 }

            };
            Batsman bestBatsman = null;
            double bestMomentum = 0;

            foreach (Batsman batsman in batsmen)
            {
                if (batsman.Momentum > bestMomentum)
                {
                    bestBatsman = batsman;
                    bestMomentum = batsman.Momentum;
                }
            }
            Console.WriteLine("Batsman with best batting momentum:");
            Console.WriteLine("{0} (Momentum: {1})", bestBatsman.Name, bestBatsman.Momentum);
            Console.ReadLine();
        }
    }
}
