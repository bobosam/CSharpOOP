using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int awayTeamGoals, int homeTeamGoals)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public int HomeTeamGoals
        {
            get
            {
                return this.homeTeamGoals;
            }

            set
            {
                Validate.CheckForNegativValue(value, "Score!\n");
                this.homeTeamGoals = value;
            }
        }

        public int AwayTeamGoals
        {
            get
            {
                return this.awayTeamGoals;
            }

            set
            {
                Validate.CheckForNegativValue(value, "Score!\n");
                this.awayTeamGoals = value;
            }
        }
    }
}
