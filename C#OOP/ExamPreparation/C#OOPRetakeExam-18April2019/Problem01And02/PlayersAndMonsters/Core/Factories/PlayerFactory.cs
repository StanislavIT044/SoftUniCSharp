namespace PlayersAndMonsters.Core
{
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            Player player = null;

            if (type == "Beginner")
            {
                player = new Beginner(username, new CardRepository());
            }
            else if (type == "Advanced")
            {
                player = new Advanced(username, new CardRepository());
            }

            return player;
        }
    }
}
