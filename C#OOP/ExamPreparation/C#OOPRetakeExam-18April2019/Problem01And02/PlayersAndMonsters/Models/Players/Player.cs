namespace PlayersAndMonsters.Models.Players
{
    using PlayersAndMonsters.Models.Cards;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;
    using System;
    using System.Collections.Generic;

    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private bool isDead;

        protected Player(string username, int health, ICardRepository cardRepository)
        {
            this.Username = username;
            this.Health = health;
            this.CardRepository = cardRepository;
        }

        public ICardRepository CardRepository { get; }

        public string Username
        {
            get
            {
                return username;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string. ");
                }

                username = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero. ");
                }

                health = value;
            }
        }

        public bool IsDead
        {
            get { return isDead; }
            set
            {
                isDead = this.Health <= 0;
            }
        }

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            if (this.Health - damagePoints < 0)
            {
                this.Health = 0;
            }
            else
            {
                this.Health -= damagePoints;
            }
        }
    }
}
