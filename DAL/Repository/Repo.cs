using Json.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using DAL.Model;



namespace DAL.Repository
{
     public class Repo
    {
        private const string langPath = @"../../lang/lang.txt";
        private const string teamUrl = "https://world-cup-json-2018.herokuapp.com/teams/";
        private const string matchUrl = "https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string favTeamFile = @"../../fav_team/fav.txt";
        List<Player> players = new List<Player>();
        //

        

        public async static Task<List<Team>> LoadTeams(HttpClient client)
        {
            var request = await client.GetAsync(teamUrl).ConfigureAwait(false);
            return new JavaScriptSerializer().Deserialize<List<Team>>(await request.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        public async static Task<List<Match>> LoadMatches(HttpClient client,Team team)
        {
            var request = await client.GetAsync($"{matchUrl}{team.fifa_code}").ConfigureAwait(false);
            return new JavaScriptSerializer().Deserialize<List<Match>>(await request.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        public static List<Player> LoadPlayers(Match match,Team team)
        {
            List<Player> players = new List<Player>();

            if (match.away_team.code != team.fifa_code)
            {
                foreach (var player in match.away_team_statistics.starting_eleven)
                {
                    players.Add(player);
                }
                foreach (var player in match.away_team_statistics.substitutes)
                {
                    players.Add(player);
                }
            }
            else
            {
                foreach (var player in match.home_team_statistics.starting_eleven)
                {
                    players.Add(player);
                }
                foreach (var player in match.home_team_statistics.substitutes)
                {
                    players.Add(player);
                }
            }
            return players;
        }

        public static bool LanguageExists(string langPath)
        {
            if (!Directory.Exists("../../lang"))
            {
                Directory.CreateDirectory("../../lang");
            }

            if (File.Exists(langPath)) { 
                if ( File.ReadAllText(langPath) == "English" || File.ReadAllText(langPath) == "Hrvatski")
                {
                    return true;
                }
            }
            return false;
        }

        public static Language GrabLanguage(string path)
        {
            if (File.ReadAllText(langPath)=="English")
            {
                return Language.English;
            }
            else if(File.ReadAllText(langPath)=="Hrvatski")
            {
                return Language.Hrvatski;
            }
            else
            {
                throw new FileLoadException();
            }
        }

        public static void SaveFavoriteTeam(string favTeamFolder, string favTeamFile, Team team)
        {
            string x = team.FileFormat();

            if (!Directory.Exists(favTeamFolder))
            {
                Directory.CreateDirectory(favTeamFolder);

            }
            if (!File.Exists(favTeamFile))
            {
                File.Create(favTeamFile);
            }
            File.WriteAllText(favTeamFile, x);
        }
        
        public static Team GetFavoriteTeam()
        {
            //int id =int.Parse( File.ReadAllText(favTeamFile)) ;
            string[] teamString = File.ReadAllText(favTeamFile).Split(',');

            return new Team{
                id=int.Parse(teamString[0]),
                country=teamString[1],
                alternate_name=teamString[2],
                fifa_code = teamString[3],
                group_id=teamString[4],
                group_letter=teamString[5]
            };

            //return id;

        }

        public static bool FavTeamFileExists(string path)
        {
            if (File.Exists(favTeamFile))
            {
                return true;
            }
            return false;
        }

        
    }
}
