using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    public static class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get
            {
                return teams;
            }
        }

        public static IEnumerable<Match> Matches
        {
            get
            {
                return matches;
            }
        }

        public static void AddMatches(Match match)
        {
            if (CheckMatchExists(match))
            {
                matches.Add(match);
            }
        }

        public static void AddTeam(Team team)
        {
            if (CheckTeamsExists(team))
            {
                teams.Add(team);
            }
        }

        private static bool CheckTeamsExists(Team team)
        {
            if (teams.Any(t => t.Name == team.Name))
            {
                return false;
            }

            return true;
        }

        private static bool CheckMatchExists(Match match)
        {
            if (matches.Any(m => m.Id == match.Id))
            {
                return false;
            }

            return true;
        }
    }
}
