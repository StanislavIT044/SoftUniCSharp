﻿namespace PlayersAndMonsters.Core
{
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.Cards;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            Card card = null;

            if (type == "Trap")
            {
                card = new TrapCard(name);
            }
            else if (type == "Magic")
            {
                card = new MagicCard(name);
            }

            return card;
        }
    }
}
