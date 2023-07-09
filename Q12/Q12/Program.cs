using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Q12
{
    public class Lineups
    {
        public int PlayerId { get; set; }   
        public string PlayerName { get; set; }  

    }
    public class BowlingStats
    {
        public int PlayerId { get; set; }
        public int Wickets { get; set; }    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonLineups = @"[  
                                    {""PlayerId"" : 21, ""PlayerName"" : ""Y. Chahal""},
                                    {""PlayerId"" : 22, ""PlayerName"" : ""Bhuvneshwar Kumar""},
                                    {""PlayerId"" : 23, ""PlayerName"" : ""Jasprit  Bumrah""},
                                    {""PlayerId"" : 24, ""PlayerName"" : ""Hardik Pandya""},
                                    {""PlayerId"" : 25, ""PlayerName"" : ""Ravindra Jadeja""},
                                    {""PlayerId"" : 26, ""PlayerName"" : ""Mohammed Shami""}
                                    ]";
            string jsonbowlingStats = @"[
                                            {""PlayerId"" : 21, ""Wickets"" : 2},
                                            {""PlayerId"" : 22, ""Wickets"" : 1},
                                            {""PlayerId"" : 23, ""Wickets"" : 3},
                                            {""PlayerId"" : 26, ""Wickets"" : 1}
                                        ]";
            var lineups= JsonSerializer.Deserialize<IEnumerable<Lineups>>(jsonLineups);
            var bowlingStats = JsonSerializer.Deserialize<IEnumerable<BowlingStats>>(jsonbowlingStats);

            var result = from lineup in lineups
                         join stats in bowlingStats
                         on lineup.PlayerId equals stats.PlayerId into statsGroup
                         from stats in statsGroup.DefaultIfEmpty()
                         select new
                         {
                             PlayerName = lineup.PlayerName,
                             Wickets = (stats == null ? 0 : stats.Wickets)
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"Player Name: {item.PlayerName} \t Wickets: {item.Wickets}");
            }
            Console.ReadLine();
        }
    }
}
