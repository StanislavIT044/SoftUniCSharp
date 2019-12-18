namespace PlayersAndMonsters.Models.Players
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using PlayersAndMonsters.Repositories.Contracts;

    public class Advanced : Player
    {
        public Advanced(string username, ICardRepository cardRepository) :
            base(username, 250, cardRepository)
        {
        }
    }
}
