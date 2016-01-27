using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    public class Team
    {
        private string name;
        private string nickName;
        private DateTime dateOfFounding;
        private List<Player> players;

        public Team(string name, string nickName, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickName;
            this.DateOfFounding = dateFounded;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validate.CheckForStringLength(value, "Name!\n", 5);
                this.name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return this.nickName;
            }

            set
            {
                Validate.CheckForStringLength(value, "Nickname!\n", 5);
                this.nickName = value;
            }
        }

        public DateTime DateOfFounding
        {
            get
            {
                return this.dateOfFounding;
            }

            set
            {
                if (value.Year.CompareTo(1850) <= 0)
                {
                    throw new ArgumentOutOfRangeException("The year chould be after 1850!");
                }
                this.dateOfFounding = value;
            }
        }

        public IEnumerable<Player>Players
        {
            get
            {
                return this.players;
            }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player alredy exists for that team!");
            }

            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName &&
                                         p.LastName == player.LastName);
        }

        public override string ToString()
        {
            return this.name + "(" + this.nickName + ") - " + "Founded: " + this.dateOfFounding.ToShortDateString() +
                   "\nPlayers:\n" + String.Join("\n", this.Players);
        }
    }
}