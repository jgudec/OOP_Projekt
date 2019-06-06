namespace ClientApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConfirmFavTeam = new MetroSet_UI.Controls.MetroSetButton();
            this.cbTeams = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblFavRep = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblFavPlayers = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblPlayers = new MetroSet_UI.Controls.MetroSetLabel();
            this.pnlFavPlayers = new MetroSet_UI.Controls.MetroSetPanel();
            this.pnlPlayers = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.SuspendLayout();
            // 
            // btnConfirmFavTeam
            // 
            this.btnConfirmFavTeam.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirmFavTeam.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirmFavTeam.DisabledForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnConfirmFavTeam, "btnConfirmFavTeam");
            this.btnConfirmFavTeam.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirmFavTeam.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirmFavTeam.HoverTextColor = System.Drawing.Color.White;
            this.btnConfirmFavTeam.Name = "btnConfirmFavTeam";
            this.btnConfirmFavTeam.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirmFavTeam.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirmFavTeam.NormalTextColor = System.Drawing.Color.White;
            this.btnConfirmFavTeam.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirmFavTeam.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirmFavTeam.PressTextColor = System.Drawing.Color.White;
            this.btnConfirmFavTeam.Style = MetroSet_UI.Design.Style.Light;
            this.btnConfirmFavTeam.StyleManager = null;
            this.btnConfirmFavTeam.ThemeAuthor = "Narwin";
            this.btnConfirmFavTeam.ThemeName = "MetroLite";
            this.btnConfirmFavTeam.Click += new System.EventHandler(this.btnConfirmFavTeam_Click);
            // 
            // cbTeams
            // 
            this.cbTeams.AllowDrop = true;
            this.cbTeams.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbTeams.BackColor = System.Drawing.Color.Transparent;
            this.cbTeams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbTeams.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbTeams.CausesValidation = false;
            this.cbTeams.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbTeams.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbTeams.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbTeams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbTeams.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbTeams.Style = MetroSet_UI.Design.Style.Light;
            this.cbTeams.StyleManager = null;
            this.cbTeams.ThemeAuthor = "Narwin";
            this.cbTeams.ThemeName = "MetroLite";
            // 
            // lblFavRep
            // 
            resources.ApplyResources(this.lblFavRep, "lblFavRep");
            this.lblFavRep.Name = "lblFavRep";
            this.lblFavRep.Style = MetroSet_UI.Design.Style.Light;
            this.lblFavRep.StyleManager = null;
            this.lblFavRep.ThemeAuthor = "Narwin";
            this.lblFavRep.ThemeName = "MetroLite";
            // 
            // lblFavPlayers
            // 
            resources.ApplyResources(this.lblFavPlayers, "lblFavPlayers");
            this.lblFavPlayers.Name = "lblFavPlayers";
            this.lblFavPlayers.Style = MetroSet_UI.Design.Style.Light;
            this.lblFavPlayers.StyleManager = null;
            this.lblFavPlayers.ThemeAuthor = "Narwin";
            this.lblFavPlayers.ThemeName = "MetroLite";
            // 
            // lblPlayers
            // 
            resources.ApplyResources(this.lblPlayers, "lblPlayers");
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Style = MetroSet_UI.Design.Style.Light;
            this.lblPlayers.StyleManager = null;
            this.lblPlayers.ThemeAuthor = "Narwin";
            this.lblPlayers.ThemeName = "MetroLite";
            // 
            // pnlFavPlayers
            // 
            this.pnlFavPlayers.BackgroundColor = System.Drawing.Color.White;
            this.pnlFavPlayers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlFavPlayers.BorderThickness = 1;
            resources.ApplyResources(this.pnlFavPlayers, "pnlFavPlayers");
            this.pnlFavPlayers.Name = "pnlFavPlayers";
            this.pnlFavPlayers.Style = MetroSet_UI.Design.Style.Light;
            this.pnlFavPlayers.StyleManager = null;
            this.pnlFavPlayers.ThemeAuthor = "Narwin";
            this.pnlFavPlayers.ThemeName = "MetroLite";
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.BackgroundColor = System.Drawing.Color.White;
            this.pnlPlayers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlPlayers.BorderThickness = 1;
            resources.ApplyResources(this.pnlPlayers, "pnlPlayers");
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Style = MetroSet_UI.Design.Style.Light;
            this.pnlPlayers.StyleManager = null;
            this.pnlPlayers.ThemeAuthor = "Narwin";
            this.pnlPlayers.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            resources.ApplyResources(this.metroSetLabel1, "metroSetLabel1");
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            resources.ApplyResources(this.metroSetControlBox1, "metroSetControlBox1");
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.pnlFavPlayers);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblFavPlayers);
            this.Controls.Add(this.lblFavRep);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.btnConfirmFavTeam);
            this.Name = "MainForm";
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.UseSlideAnimation = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetButton btnConfirmFavTeam;
        private MetroSet_UI.Controls.MetroSetComboBox cbTeams;
        private MetroSet_UI.Controls.MetroSetLabel lblFavRep;
        private MetroSet_UI.Controls.MetroSetLabel lblFavPlayers;
        private MetroSet_UI.Controls.MetroSetLabel lblPlayers;
        private MetroSet_UI.Controls.MetroSetPanel pnlFavPlayers;
        private MetroSet_UI.Controls.MetroSetPanel pnlPlayers;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}

