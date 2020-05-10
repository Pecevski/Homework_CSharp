using System;
using TeamSource.Helpers;
using TeamSource.Enteties;
using System.Linq;
using System.Collections.Generic;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CLASS WORKSHOP
            var teams = TeamsDataBase.GetAllTeams();

            //Find all Teams with name starting with LA
            var allTeamsLA = teams.Where(team => team.Name.StartsWith("LA")).ToList();
            allTeamsLA.ForEach(team => Console.WriteLine(team.Name));


            Console.WriteLine("----------------------------------------------------------");
            //Find all team NAMES which are playing in "Steples Center"
            var allTeamsNamesSC = teams.Where(team => team.Arena.Equals("Staples Center")).Select(team => team.Name).ToList();
            allTeamsNamesSC.ForEach(team => Console.WriteLine(team));

            Console.WriteLine("----------------------------------------------------------");
            //Find all teams coaches
            var allTeamCoatch = teams.Select(team => team.Coach).ToList();
            allTeamCoatch.ForEach(coach => Console.WriteLine(coach.FullName));

            Console.WriteLine("----------------------------------------------------------");
            //Find 3 oldest coaches NAMES and AGE
            var oldest3Coatches = allTeamCoatch.OrderByDescending(coach => coach.Age).Take(3).Select(coach => new { coach.FullName, coach.Age }). ToList();
            oldest3Coatches.ForEach(coach => Console.WriteLine(coach));

            Console.WriteLine("----------------------------------------------------------");
            //Group all teams by their Arena
            var groupAllTeamsByArena = teams.GroupBy(team => team.Arena).ToList();
            foreach (var group in groupAllTeamsByArena)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var team in group)
                {
                    Console.WriteLine($"-------{team.Name}");
                }
            }

            Console.WriteLine("----------------------------------------------------------");
            //Find all players in one LIST
            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            allPlayers.ForEach(player => Console.WriteLine(player.FullName));

            Console.WriteLine("----------------------------------------------------------");
            //Find player ranked by points with best avg Points
            var playerBestAvgPoints = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"]).FirstOrDefault();
            Console.WriteLine(playerBestAvgPoints.FullName);

            Console.WriteLine("----------------------------------------------------------");
            #endregion

            Console.ForegroundColor = ConsoleColor.Green;
            #region HOMEWORK
            // Find all coaches NAMES with Age > 50
            var findCoachesNameAbove50 = allTeamCoatch.FindAll(coach => coach.Age > 50).ToList();
            findCoachesNameAbove50.ForEach(coach => Console.WriteLine(coach.FullName));

            Console.WriteLine("----------------------------------------------------------");

            // Order players by AGE - DESC
            var playersOrderByAge = allPlayers.OrderByDescending(players => players.Age).Select(players =>new { players.FullName, players.Age }).ToList();
            playersOrderByAge.ForEach(player => Console.WriteLine(player));

            Console.WriteLine("----------------------------------------------------------");
            // Find player with highest RebPerGame
            var playerWithHighRebPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"]).FirstOrDefault();
            Console.WriteLine(playerWithHighRebPerGame.FullName);

            Console.WriteLine("----------------------------------------------------------");
            // Find all players with PtsPerGame > 20
            var allPlayerPtsPerGame20Higher = allPlayers.Where(player => player.PlayerStatistic["PtsPerGame"] > 20).Select(player => player.FullName).ToList();
            allPlayerPtsPerGame20Higher.ForEach(player => Console.WriteLine(player));

            Console.WriteLine("----------------------------------------------------------");
            // Find all players NAMES older then 30 years
            var playerNamesOlder30 = allPlayers.Where(player => player.Age > 30).Select(player => player.FullName).ToList();
            playerNamesOlder30.ForEach(player => Console.WriteLine(player));

            Console.WriteLine("----------------------------------------------------------");
            // Group players by age
            var groupPlayerByAge = allPlayers.GroupBy(player => player.Age).ToList();

            foreach (var playerAge in groupPlayerByAge)
            {
                Console.WriteLine(playerAge.Key);
                foreach (var player in playerAge)
                {
                    Console.WriteLine(player.FullName);
                }
            }
;
            Console.WriteLine("----------------------------------------------------------");
            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0
             var playerNamesPtsIfRebPerGame7High = (from player in allPlayers
                                                   where player.PlayerStatistic["RebPerGame"] > 7
                                                   select player).Select(player => new { Name = player.FullName, Points = player.PlayerStatistic["PtsPerGame"]}).ToList();

            playerNamesPtsIfRebPerGame7High.ForEach(player => Console.WriteLine(player));

            Console.WriteLine("----------------------------------------------------------");
            // Find first 3 players with highest PtsPerGame
            var player3HighestPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"]).Take(3).ToList();
            player3HighestPtsPerGame.ForEach(player => Console.WriteLine(player.FullName));

            Console.WriteLine("----------------------------------------------------------");
            // Find the team which has the player with highest PtsPerGame
            var teamHasPlayerHighestPoints = teams.SingleOrDefault(team => team.Players.Contains(playerBestAvgPoints));
            Console.WriteLine(teamHasPlayerHighestPoints.Name);

            Console.WriteLine("----------------------------------------------------------");
            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC
            var first4PlayersHighestReb = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                                    .Take(4).OrderBy(player => player.PlayerStatistic["PtsPerGame"]).ToList();

            first4PlayersHighestReb.ForEach(player => Console.WriteLine(player.FullName));

            #endregion
            Console.ReadLine();
        }
    }
}
