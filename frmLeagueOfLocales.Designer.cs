namespace league_of_locales_form
{
    partial class league_of_locales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(league_of_locales));
            this.language_list = new System.Windows.Forms.ComboBox();
            this.set_locale = new System.Windows.Forms.Button();
            this.league_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.league_path_label = new System.Windows.Forms.Label();
            this.browse_LOL = new System.Windows.Forms.Button();
            this.pbe_directory_label = new System.Windows.Forms.Label();
            this.browse_PBE = new System.Windows.Forms.Button();
            this.pbe_checkbox = new System.Windows.Forms.CheckBox();
            this.github = new System.Windows.Forms.LinkLabel();
            this.discord = new System.Windows.Forms.LinkLabel();
            this.status = new System.Windows.Forms.Label();
            this.pbe_path = new System.Windows.Forms.RichTextBox();
            this.league_path = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // language_list
            // 
            this.language_list.AllowDrop = true;
            this.language_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.language_list.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.language_list.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_list.FormattingEnabled = true;
            this.language_list.Items.AddRange(new object[] {
            "English",
            "Portuguese",
            "Turkish",
            "Dutch",
            "French",
            "Italian",
            "Czech",
            "Greek",
            "Hungarian",
            "Polish",
            "Romainian",
            "Russian",
            "Spanish",
            "Japanese",
            "Chinese",
            "Korean",
            "Indonesian"});
            this.language_list.Location = new System.Drawing.Point(110, 69);
            this.language_list.Name = "language_list";
            this.language_list.Size = new System.Drawing.Size(210, 24);
            this.language_list.TabIndex = 2;
            this.language_list.Text = "Choose Locale";
            // 
            // set_locale
            // 
            this.set_locale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.set_locale.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_locale.ForeColor = System.Drawing.Color.DodgerBlue;
            this.set_locale.Location = new System.Drawing.Point(326, 67);
            this.set_locale.Name = "set_locale";
            this.set_locale.Size = new System.Drawing.Size(95, 26);
            this.set_locale.TabIndex = 3;
            this.set_locale.Text = "Set Locale!";
            this.set_locale.UseVisualStyleBackColor = true;
            this.set_locale.Click += new System.EventHandler(this.set_locale_Click);
            // 
            // league_folder
            // 
            this.league_folder.SelectedPath = "C:\\Riot Games\\League of Legends";
            this.league_folder.ShowNewFolderButton = false;
            // 
            // league_path_label
            // 
            this.league_path_label.AutoSize = true;
            this.league_path_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.league_path_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.league_path_label.Location = new System.Drawing.Point(11, 11);
            this.league_path_label.Name = "league_path_label";
            this.league_path_label.Size = new System.Drawing.Size(92, 16);
            this.league_path_label.TabIndex = 6;
            this.league_path_label.Text = "LOL Directory :";
            // 
            // browse_LOL
            // 
            this.browse_LOL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_LOL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.browse_LOL.Location = new System.Drawing.Point(326, 8);
            this.browse_LOL.Name = "browse_LOL";
            this.browse_LOL.Size = new System.Drawing.Size(95, 23);
            this.browse_LOL.TabIndex = 7;
            this.browse_LOL.Text = "Browse";
            this.browse_LOL.UseVisualStyleBackColor = true;
            this.browse_LOL.Click += new System.EventHandler(this.browse_LOL_Click);
            // 
            // pbe_directory_label
            // 
            this.pbe_directory_label.AutoSize = true;
            this.pbe_directory_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbe_directory_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pbe_directory_label.Location = new System.Drawing.Point(9, 42);
            this.pbe_directory_label.Name = "pbe_directory_label";
            this.pbe_directory_label.Size = new System.Drawing.Size(94, 16);
            this.pbe_directory_label.TabIndex = 8;
            this.pbe_directory_label.Text = "PBE Directory :";
            // 
            // browse_PBE
            // 
            this.browse_PBE.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_PBE.ForeColor = System.Drawing.Color.DodgerBlue;
            this.browse_PBE.Location = new System.Drawing.Point(326, 38);
            this.browse_PBE.Name = "browse_PBE";
            this.browse_PBE.Size = new System.Drawing.Size(95, 23);
            this.browse_PBE.TabIndex = 9;
            this.browse_PBE.Text = "Browse";
            this.browse_PBE.UseVisualStyleBackColor = true;
            this.browse_PBE.Click += new System.EventHandler(this.browse_PBE_Click);
            // 
            // pbe_checkbox
            // 
            this.pbe_checkbox.AutoSize = true;
            this.pbe_checkbox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbe_checkbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pbe_checkbox.Location = new System.Drawing.Point(14, 71);
            this.pbe_checkbox.Name = "pbe_checkbox";
            this.pbe_checkbox.Size = new System.Drawing.Size(86, 20);
            this.pbe_checkbox.TabIndex = 13;
            this.pbe_checkbox.Text = "PBE Client";
            this.pbe_checkbox.UseVisualStyleBackColor = true;
            // 
            // github
            // 
            this.github.AutoSize = true;
            this.github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.github.Location = new System.Drawing.Point(330, 109);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(39, 13);
            this.github.TabIndex = 0;
            this.github.TabStop = true;
            this.github.Text = "Github";
            this.github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // discord
            // 
            this.discord.AutoSize = true;
            this.discord.BackColor = System.Drawing.SystemColors.Control;
            this.discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discord.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discord.Location = new System.Drawing.Point(375, 109);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(47, 13);
            this.discord.TabIndex = 1;
            this.discord.TabStop = true;
            this.discord.Text = "Support";
            this.discord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discord_LinkClicked);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.DodgerBlue;
            this.status.Location = new System.Drawing.Point(6, 10);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(61, 16);
            this.status.TabIndex = 4;
            this.status.Text = "Loading...";
            // 
            // pbe_path
            // 
            this.pbe_path.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbe_path.Location = new System.Drawing.Point(110, 39);
            this.pbe_path.Name = "pbe_path";
            this.pbe_path.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.pbe_path.Size = new System.Drawing.Size(210, 21);
            this.pbe_path.TabIndex = 12;
            this.pbe_path.Text = "C:\\Riot Games\\PBE";
            this.pbe_path.TextChanged += new System.EventHandler(this.pbe_path_TextChanged);
            // 
            // league_path
            // 
            this.league_path.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.league_path.ForeColor = System.Drawing.Color.Black;
            this.league_path.Location = new System.Drawing.Point(110, 9);
            this.league_path.Name = "league_path";
            this.league_path.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.league_path.Size = new System.Drawing.Size(210, 20);
            this.league_path.TabIndex = 11;
            this.league_path.Text = "C:\\Riot Games\\League of Legends";
            this.league_path.TextChanged += new System.EventHandler(this.league_path_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 32);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // league_of_locales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 131);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.github);
            this.Controls.Add(this.pbe_checkbox);
            this.Controls.Add(this.pbe_path);
            this.Controls.Add(this.league_path);
            this.Controls.Add(this.browse_PBE);
            this.Controls.Add(this.pbe_directory_label);
            this.Controls.Add(this.browse_LOL);
            this.Controls.Add(this.league_path_label);
            this.Controls.Add(this.set_locale);
            this.Controls.Add(this.language_list);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 170);
            this.MinimumSize = new System.Drawing.Size(450, 170);
            this.Name = "league_of_locales";
            this.Text = "League of Locales by Doomlad";
            this.Load += new System.EventHandler(this.frmLeagueOfLocales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox language_list;
        private System.Windows.Forms.Button set_locale;
        private System.Windows.Forms.FolderBrowserDialog league_folder;
        private System.Windows.Forms.Label league_path_label;
        private System.Windows.Forms.Button browse_LOL;
        private System.Windows.Forms.Label pbe_directory_label;
        private System.Windows.Forms.Button browse_PBE;
        private System.Windows.Forms.CheckBox pbe_checkbox;
        private System.Windows.Forms.LinkLabel github;
        private System.Windows.Forms.LinkLabel discord;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.RichTextBox pbe_path;
        private System.Windows.Forms.RichTextBox league_path;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

