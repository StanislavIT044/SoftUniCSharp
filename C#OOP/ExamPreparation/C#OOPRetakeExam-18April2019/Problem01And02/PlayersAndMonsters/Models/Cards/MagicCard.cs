namespace PlayersAndMonsters.Models.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public class MagicCard : Card
    {
        public MagicCard(string name) 
            : base(name, 5, 80)
        {
        }
    }
}
