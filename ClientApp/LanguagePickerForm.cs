using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using DAL.Model;

namespace ClientApp
{
    public partial class LanguagePickerForm : MetroSetForm
    {
        private HttpClient client;
        private const string langPath = @"../../lang/lang.txt";
        
        public LanguagePickerForm(HttpClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void btnLangEN_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("../../lang");
            //File.Create(langPath);
            File.WriteAllText(langPath, Language.English.ToString());

            Hide();
            OpenMainForm(Language.English);
            Close();
        }

        private void btnLangHR_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("../../lang");
            //File.Create(langPath);
            
            File.WriteAllText(langPath, Language.Hrvatski.ToString());

            Hide();
            OpenMainForm(Language.Hrvatski);
            Close();
        }

        private void OpenMainForm(Language lang)
        {
            new MainForm(lang, client).ShowDialog();
            this.ShowInTaskbar = true;
        }
    }
}
