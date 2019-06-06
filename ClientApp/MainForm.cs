using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.Net;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Net;
using System.Globalization;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;
using DAL.Model;
using DAL.Repository;

namespace ClientApp
{
    public partial class MainForm : MetroSetForm
    {
        private const string favTeamFile = @"../../fav_team/fav.txt";
        private const string favTeamFolder = @"../../fav_team";
        private HttpClient client;
        private Language lang;
        private Team team;
        //private int id;
        //
        private List<Match> matches = null;
        //
        private List<Player> players = null;


        public MainForm(Language lang, HttpClient client, Team team)
        {
            this.lang = lang;
            this.client = client;
            this.team = team;
            InitializeComponent();
        }

        public MainForm(Language lang, HttpClient client)
        {
            this.lang = lang;
            this.client = client;
            InitializeComponent();
            
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (lang == Language.English)
            {
                ChangeLang("en");
            }
            else
            {
                ChangeLang("hr");
            }

            cbTeams.DisplayMember = "StockNameFormat";
            cbTeams.DataSource = Repo.LoadTeams(client).Result;
            team = new Team();
            //strga se jer id reprezentacije kod muskaraca nije isti kao cbTeams index
            //if (Repo.FavTeamFileExists(favTeamFile))
            //{
            //    team.id = Repo.GetFavoriteTeam();
            //    cbTeams.SelectedIndex = team.id-1;
            //}

            //if (Repo.FavTeamFileExists(favTeamFile))
            //{
            //    team = Repo.GetFavoriteTeam();
            //    cbTeams.SelectedIndex = cbTeams.Items.IndexOf(team.StockNameFormat);// ovo vraca nulu umjesto da ucita "Drzava ( FIFA_KOD ) "
            //}
        }

        private void ChangeLang(string lang)
        {
            foreach (Control control in Controls)
            {
                ComponentResourceManager crm = new ComponentResourceManager(typeof(MainForm));
                crm.ApplyResources(control, control.Name, new CultureInfo(lang));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnConfirmFavTeam_Click(object sender, EventArgs e)
        {
            team = (Team)cbTeams.SelectedItem;
            Repo.SaveFavoriteTeam(favTeamFolder,favTeamFile,team);
            if (lang == Language.English)
            {
                MetroSetMessageBox.Show(this, "Favorite Team saved");
            }

            if (lang == Language.Hrvatski)
            {
                MetroSetMessageBox.Show(this, "Omiljena reprezentacija spremljena");
            }

            ListPlayers(team);
            //FillPlayerList(team);
        }

        private void ListPlayers(Team team)
        {
            matches = Repo.LoadMatches(client,team).Result;
            players = Repo.LoadPlayers(matches[0],team);
            PlayerCtrl playerCtrl = new PlayerCtrl();
            playerCtrl.
            
            foreach (Player player in players)
            {
                
                pnlPlayers.Controls.Add(playerCtrl);
            }
        }

        
        
        private void AddPlayers(MetroSetPanel pnlPlayers)
        {
            //players=Repo.LoadPlayers()
            //pnlPlayers.Controls.Add(NewUserControl(play);
        }

        // FILIPOV KOD KOJI NE ZNAS KORISTIT, NADJI SVOJ NACIN!
        private void FillPlayerList(Team tim)
        {
            matches = Repo.LoadMatches(client, tim).Result;
            players = Repo.LoadPlayers(matches[0], tim);
            players.Sort((x, y) => y.shirt_number.CompareTo(x.shirt_number));
            foreach (Player player in players)
            {
                pnlPlayers.Controls.Add(NewPlayerControl(player));
            }
        }

        private static Control NewPlayerControl(Player player)
        {
            Panel dynamicPanel = new Panel
            {
                Dock = DockStyle.Top,
                Location = new System.Drawing.Point(),
                Size = new System.Drawing.Size(258, 50),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle
            };

            Panel _playerPanel = new Panel
            {
                Location = new Point(5, 4),
                Size = new Size(230, 40),
                BackColor = Color.Violet,
                Enabled = false
            };

            //nekada odreze dio teksta ako je predugacko ime ¯\_(ツ)_/¯
            Label _playerLabel = new Label
            {
                Location = new Point(5, 5),
                Text = player.ToString(),
                Size = new Size(195, 30),
                BackColor = Color.Transparent,
                Enabled = true,
                ForeColor = Color.Black
            };
            _playerLabel.Paint += _playerLabel_Paint;
            _playerLabel.Font = new Font(_playerLabel.Font.FontFamily, 12);
            // _playerLabel.MouseClick += _playerLabel_MouseClick;

            _playerPanel.Controls.Add(_playerLabel);
            dynamicPanel.Controls.Add(_playerPanel);
            //foreach (Control c in dynamicPanel.Controls)
            //{
            //    c.MouseDown += c_MouseDown;
            //}

            return dynamicPanel;
        }
        private static void _playerLabel_Paint(object sender, PaintEventArgs e)
        {
            Control c = sender as Control;
            SolidBrush drawBrush = new SolidBrush(c.ForeColor);
            e.Graphics.DrawString(c.Text, c.Font, drawBrush, 0f, 0f);
        }

        
    }   
}
