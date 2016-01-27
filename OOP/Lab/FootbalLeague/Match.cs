using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;
        

        public Match(Team homeTeam, Team awayTeam, int id, Score score)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team AwayTeam
        {
            get
            {
                return this.awayTeam;
            }

            set
            {
                if (value.Equals(this.HomeTeam))
                {
                    throw new ArgumentException("Away team");
                }
                this.awayTeam = value;
            }
        }

        public Team HomeTeam
        {
            get
            {
                return this.homeTeam;
            }

            set
            {
                if (value.Equals(this.AwayTeam))
                {
                    throw new ArgumentException("\nThe two teams should be different!");
                }

                this.homeTeam = value;
            }
        }

        public Score Score
        {
            get
            {
                return this.score;
            }

            set
            {
                this.score = value;
            }
        }

        public  int Id
        {
            get
            {
                return Id;
            }

            set
            {
                Validate.CheckForNegativValue(value, "ID!\n");
                this.id = value;
            }
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals ? this.HomeTeam : this.AwayTeam;
        }

        public override string ToString()
        {
            return this.homeTeam.Name + " " + this.Score.HomeTeamGoals + " : " + this.Score.AwayTeamGoals + " " + this.awayTeam.Name;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }
    }
}
