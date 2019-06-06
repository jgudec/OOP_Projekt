using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using DAL.Repository;


namespace ClientApp
{
    static class Program
    {
        private const string langPath = @"../../lang/lang.txt";
        private const string favTeamFile = @"../../fav_team/fav.txt";

        [STAThread]
        static void Main()
        {
            HttpClient client = new HttpClient();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (client)
            {
                try
                {
                    if (Repo.LanguageExists(langPath) )
                    {
                        if (Repo.FavTeamFileExists(favTeamFile))
                        {
                            Application.Run(new MainForm(Repo.GrabLanguage(langPath), client ,Repo.GetFavoriteTeam()));
                        }
                        else {
                            Application.Run(new MainForm(Repo.GrabLanguage(langPath), client));
                        }
                    }
                    else
                    {
                        Application.Run(new LanguagePickerForm(client));
                    }
                }
                catch (Exception )
                {
                    Application.Run(new LanguagePickerForm(client));
                }
            }
        }
    }
}
