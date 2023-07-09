using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Q11
{
    public class Player
    {
        public string Position { get; set; }

        [JsonPropertyName("Name_Full")]
        public string NameFull { get; set; }

        [JsonPropertyName("IsCaptain")]
        public Boolean IsCaptain { get; set; }

    }
    public class Team
    {
        [JsonPropertyName("Name_Full")]
        public string NameFull { get; set; }

        [JsonPropertyName("Name_Short")]
        public string NameShort { get; set; }

        [JsonPropertyName("Players")]
        public Dictionary<int,Player> Players { get; set; } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new Team
            {
                NameFull = "Sunrisers Hyderabad",
                NameShort = "SRH",
                Players = new Dictionary<int, Player>
                {
                    { 5380, new Player { Position = "1", NameFull = "David Warner", IsCaptain = true } },
                    { 3722, new Player { Position = "2", NameFull = "Shikhar Dhawan", IsCaptain = false } }

                }
            };
        }
    }
}
