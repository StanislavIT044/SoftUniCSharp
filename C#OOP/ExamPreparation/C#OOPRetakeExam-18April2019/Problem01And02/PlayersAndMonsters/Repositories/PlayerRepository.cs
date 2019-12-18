namespace PlayersAndMonsters.Repositories
{
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PlayerRepository : IPlayerRepository
    {
        private List<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }

        public int Count => players.Count;

        public IReadOnlyCollection<IPlayer> Players => players;

        public void Add(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null!");
            }

            foreach (var p in Players)
            {
                if (player.Username == p.Username)
                {
                    throw new ArgumentException($"Player {p.Username} already exists!");
                }
            }

            players.Add(player);
        }

        public IPlayer Find(string name)
        {
            foreach (var player in players)
            {
                if (player.Username == name)
                {
                    return player;
                }
            }

            return null;
        }

        public bool Remove(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }

            return players.Remove(player);
        }
    }
}
