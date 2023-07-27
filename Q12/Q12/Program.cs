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

            //inner Join
            var result = (from lineup in lineups
                          join stats in bowlingStats
                          on lineup.PlayerId equals stats.PlayerId
                          orderby stats.Wickets descending
                          select new
                          {
                              PlayerName = lineup.PlayerName,
                              Wickets = stats.Wickets,
                          }).ToList();

            //left Outer Join
            var result2 = (from lineup in lineups
                         join stats in bowlingStats
                         on lineup.PlayerId equals stats.PlayerId into statsGroup
                         from stats in statsGroup.DefaultIfEmpty()
                         select new
                         {
                             PlayerName = lineup.PlayerName,
                             Wickets = (stats == null ? 0 : stats.Wickets)
                         }).ToList();

            //Group Join  and we can also  Applying Filters at grouping level

            var result3 = (from lineup in lineups
                           join stats in bowlingStats
                           on lineup.PlayerId equals stats.PlayerId into statsGroup
                           select new
                           {
                               PlayerName = lineup.PlayerName,
                               g = statsGroup
                           }).ToList()
                           .Select(item => new
                           {
                               PlayerName = item.PlayerName,
                               g = item.g.Where(stat => stat.Wickets > 1)
                           }).ToList();

            var result4  = (from lineup in lineups
                            join stats in bowlingStats
                            on lineup.PlayerId equals stats.PlayerId into statsGroup
                            select new
                            {
                                PlayerName = lineup.PlayerName,
                                g = statsGroup.Select(stat => new BowlingStats
                                {
                                    PlayerId = stat.PlayerId,
                                    Wickets = (stat.Wickets == null ? 0 : stat.Wickets) // Update wicket value to 0 if it's null
                                })
                            }).ToList();



            foreach (var item in result)
            {
                Console.WriteLine($"Player Name: {item.PlayerName} \t Wickets: {item.Wickets}");
            }
            Console.WriteLine("--------------");
            foreach (var item in result2)
            {
                Console.WriteLine($"Player Name: {item.PlayerName} \t Wickets: {item.Wickets}");
            }
            Console.WriteLine("--------------");
            foreach (var item in result3)
            {
                Console.WriteLine($"Player Name: {item.PlayerName} ");
                foreach(var group in item.g)
                {
                    Console.WriteLine(group.Wickets);
                }
            }
            Console.WriteLine("--------------");
            foreach (var item in result4)
            {
                Console.WriteLine($"Player Name: {item.PlayerName}" );
                foreach (var group in item.g)
                {
                    Console.WriteLine(group.Wickets);
                }
            }
            Console.ReadLine();
        }
    }
}
