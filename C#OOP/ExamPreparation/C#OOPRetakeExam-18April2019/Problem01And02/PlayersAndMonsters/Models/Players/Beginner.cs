namespace PlayersAndMonsters.Models.Players
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using PlayersAndMonsters.Repositories.Contracts;

    public class Beginner : Player
    {
        public Beginner(string username, ICardRepository cardRepository)
            : base(username, 50, cardRepository)
        {
        }
    }
}
