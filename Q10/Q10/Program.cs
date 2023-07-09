using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml;

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = @"[
            {""PlayerName"": ""Virat Kholi"", ""IsRetired"": 0},
            {""PlayerName"": ""M.S. Dhoni"", ""IsRetired"": 0},
            {""PlayerName"": ""Hardik Pandya"", ""IsRetired"": 0},
            {""PlayerName"": ""Rohit Sharma"", ""IsRetired"": 0},
            {""PlayerName"": ""Sachin Tendulkar"", ""IsRetired"": 1},
            {""PlayerName"": ""Rahul Dravid"", ""IsRetired"": 1},
            {""PlayerName"": ""Sourav Ganguly"", ""IsRetired"": 1},
            {""PlayerName"": ""VVS Laxman"", ""IsRetired"": 1}
        ]";

            List<Player> players = JsonSerializer.Deserialize<List<Player>>(json);

            foreach (var player in players)
            {
                player.IsRetired = (player.IsRetired == 0) ? 1 : 0;
            }
            //players.ForEach(p => p.IsRetired = (p.IsRetired == 0) ? 1 : 0);

            Console.WriteLine(JsonSerializer.Serialize(players));
            Console.ReadLine();
        }
    }
    public class Player
    {
        public string PlayerName { get; set; }
        public int IsRetired { get; set; }
    }
}
