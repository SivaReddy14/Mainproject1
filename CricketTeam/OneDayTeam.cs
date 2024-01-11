using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketTeam
{
   public class OneDayTeam : ITeam
    {
        private List<Player> players = new List<Player>();

        public void AddPlayer(Player player)
        {
            if (players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine($"Player {player.Name} added to the team.");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }
        }

        public void RemovePlayer(int playerId)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.Name} removed from the team.");
            }


            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public List<Player> GetPlayersByName(string playerName)
        {
            return players.Where(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Player> GetAllPlayers()
        {
            return players;
        }
    }
}
