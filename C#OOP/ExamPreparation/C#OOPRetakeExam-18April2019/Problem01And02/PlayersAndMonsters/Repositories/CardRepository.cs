namespace PlayersAndMonsters.Repositories
{
    using PlayersAndMonsters.Models.Cards;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CardRepository : ICardRepository
    {
        private List<ICard> cards;

        public CardRepository()
        {
            this.cards = new List<ICard>();
        }

        public int Count => cards.Count;

        public IReadOnlyCollection<ICard> Cards => cards;

        public void Add(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }

            foreach (var c in Cards)
            {
                if (card.Name == c.Name )
                {
                    throw new ArgumentException($"Card {c.Name} already exists!");
                }
            }

            cards.Add(card);
        }

        public ICard Find(string name)
        {
            foreach (var card in cards)
            {
                if (card.Name == name)
                {
                    return card;
                }
            }

            return null;
        }

        public bool Remove(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null");
            }

            return cards.Remove(card);
        }
    }
}
