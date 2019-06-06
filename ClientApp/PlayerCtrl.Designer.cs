namespace ClientApp
{
    partial class PlayerCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerName = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblPlayerPosition = new MetroSet_UI.Controls.MetroSetLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AccessibleName = "lblPlayerName";
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlayerName.Location = new System.Drawing.Point(87, 18);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerName.Style = MetroSet_UI.Design.Style.Light;
            this.lblPlayerName.StyleManager = null;
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Name";
            this.lblPlayerName.ThemeAuthor = "Narwin";
            this.lblPlayerName.ThemeName = "MetroLite";
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlayerPosition.Location = new System.Drawing.Point(87, 49);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerPosition.Style = MetroSet_UI.Design.Style.Light;
            this.lblPlayerPosition.StyleManager = null;
            this.lblPlayerPosition.TabIndex = 1;
            this.lblPlayerPosition.Text = "Position";
            this.lblPlayerPosition.ThemeAuthor = "Narwin";
            this.lblPlayerPosition.ThemeName = "MetroLite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 51);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClientApp.Properties.Resources.PlayerPhoto;
            this.pictureBox2.Location = new System.Drawing.Point(12, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // PlayerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "PlayerCtrl";
            this.Size = new System.Drawing.Size(275, 91);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lblPlayerName;
        private MetroSet_UI.Controls.MetroSetLabel lblPlayerPosition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
