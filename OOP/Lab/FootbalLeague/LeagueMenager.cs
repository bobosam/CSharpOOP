using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace FootballLeague
{
    public class LeagueMenager
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while(line != "End")
            {
                try
                {
                    LeagueMenager.HandleInput(line);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }
        }

        private static void HandleInput(string input)
        {
            var inputArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(new Team(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3])));
                    break;
                case "AddMatch":
                    AddMatch(inputArgs[1], inputArgs[2], inputArgs[3], inputArgs[4], inputArgs[5]);
                    break;
                case "AddPlayerToTeam":
                    AddPlayer(inputArgs[1], inputArgs[2], inputArgs[3], inputArgs[4], inputArgs[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;

            }
        }
       
        private static void AddTeam(Team newTeam)
        {
            League.AddTeam(newTeam);
            Console.WriteLine("The " + newTeam.Name + " team has been added succesfully");
        }

        private static void AddMatch(string homeTeamName, string awayTeamName, string idStr, string homeTeamGoals, string awayTeamGoals)
        {
            if (League.Teams.All(t => t.Name != homeTeamName))
            {
                throw new InvalidOperationException("Team name");
            }

            if (League.Teams.All(t => t.Name != awayTeamName))
            {
                throw new InvalidOperationException("Team name");
            }

            var homeTeam = League.Teams.First(t => t.Name == homeTeamName);
            var awayTeam = League.Teams.First(t => t.Name == awayTeamName);
            var id = int.Parse(idStr);
            var score = new Score(int.Parse(homeTeamGoals), int.Parse(awayTeamGoals));
            var match = new Match(homeTeam, awayTeam, id, score);
            League.AddMatches(match);
            Console.WriteLine("Match with ID: " + idStr + " has been added succesfully");
        }

        private static void AddPlayer(string firstName, string lastName, string dayB, string salaryStr, string teamName)
        {
            if (League.Teams.All(t => t.Name != teamName))
            {
                throw new InvalidOperationException("Team name");
            }

            var day = DateTime.Parse(dayB);
            var salary = decimal.Parse(salaryStr);
            var team = League.Teams.First(t => t.Name == teamName);
            var player = new Player(firstName, lastName, salary, day, team);
            team.AddPlayer(player);
        }

        public static void ListTeams()
        {
            foreach (var team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        public static void ListMatches()
        {
            foreach (var match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
