using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Documents;

namespace league_of_locales_form
{
    public partial class league_of_locales : Form
    {
        private readonly System.Windows.Forms.Timer _timerLeague = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer _timerClient = new System.Windows.Forms.Timer();

        public league_of_locales()
        {
            InitializeComponent();
            language_list.SelectedIndex = Properties.Settings.Default.SelectedIndex;
            Globals.LEAGUE_PATH_CLIENT = Properties.Settings.Default.league_path;
            this.Closing += frmLeagueOfLocales_Closing;

            _timerLeague.Interval = 2000;
            _timerLeague.Tick += CheckForLeague;
            _timerLeague.Enabled = true;

            _timerClient.Interval = 750;
            _timerClient.Tick += CheckForClient;
            _timerClient.Enabled = true;
        }

        private void frmLeagueOfLocales_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("League of Locales {0} by Doomlad", Application.ProductVersion.ToString());
            league_path.Text = Properties.Settings.Default.league_path;
            pbe_path.Text = Properties.Settings.Default.pbe_path;
        }

        public void CheckForLeague(object sender, EventArgs e)
        {
            MethodInvoker mi = delegate ()
            {
                try
                {
                    DirectoryInfo leagueNormDir = new DirectoryInfo(league_path.Text);
                    FileInfo[] LOLFiles = leagueNormDir.GetFiles("LeagueClient.exe");

                    if (pbe_directory_label.ForeColor == Color.Red)
                    {
                        pbe_directory_label.ForeColor = Color.DodgerBlue;
                        browse_PBE.ForeColor = Color.DodgerBlue;
                        pbe_path.ForeColor = Color.Black;
                    }
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    league_path_label.ForeColor = Color.Red;
                    browse_LOL.ForeColor = Color.Red;
                    league_path.ForeColor = Color.Red;
                }

                try
                {
                    DirectoryInfo leaguePbeDir = new DirectoryInfo(pbe_path.Text);
                    FileInfo[] PBEFiles = leaguePbeDir.GetFiles("LeagueClient.exe");

                    if (pbe_directory_label.ForeColor == Color.Red)
                    {
                        pbe_directory_label.ForeColor = Color.DodgerBlue;
                        browse_PBE.ForeColor = Color.DodgerBlue;
                        pbe_path.ForeColor = Color.Black;
                    }
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    pbe_directory_label.ForeColor = Color.Red;
                    browse_PBE.ForeColor = Color.Red;
                    pbe_path.ForeColor = Color.Red;
                }

            };
            this.Invoke(mi);
            
        }

        public void CheckForClient(object sender, EventArgs e)
        {
            MethodInvoker mi = delegate ()
            {
                Process[] leagueClient = Process.GetProcessesByName(Path.GetFileNameWithoutExtension("LeagueClient.exe"));

                if (leagueClient.Length == 0)
                {
                    if (pbe_checkbox.Checked == true)
                    {
                        status.Text = "[Status PBE] The client is currently not running...";
                        status.Refresh();
                    }
                    else
                    {
                        status.Text = "[Status] The client is currently not running...";
                        status.Refresh();
                    }
                }

                else
                {
                    if (pbe_checkbox.Checked == true)
                    {
                        status.Text = "[Status PBE] The client is currently running...";
                        status.Refresh();
                    }
                    else
                    {
                        status.Text = "[Status] The client is currently running...";
                        status.Refresh();
                    }
                }
            };
            this.Invoke(mi);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = Process.Start("https://github.com/ShoobyDoo/League-of-Locales-GUI");
        }

        public static class Globals
        {
            public static string LEAGUE_PATH_CLIENT = "";
            public const string ENGLISH = "en_US";
            public const string PORTUGEUESE = "pt_BR";
            public const string TURKISH = "tr_TR";
            public const string GERMAN = "de_DE";
            public const string FRENCH = "fr_FR";
            public const string ITALIAN = "it_IT";
            public const string CZECH = "cs_CZ";
            public const string GREEK = "el_GR";
            public const string HUNGARIAN = "hu_HU";
            public const string POLISH = "pl_PL";
            public const string ROMANIAN = "ro_RO";
            public const string RUSSIAN = "ru_RU";
            public const string SPANISH = "es_MX";
            public const string JAPANESE = "ja_JP";
            public const string CHINESE = "zh_CH";
            public const string KOREAN = "ko_KR";
            public const string INDONESIAN = "id_ID";

        }

        private void set_locale_Click(object sender, EventArgs e)
        {
            // Check if Pbe button is checked
            if (pbe_checkbox.Checked == true)
            {
                Globals.LEAGUE_PATH_CLIENT = pbe_path.Text;
            }
            else
            {
                Globals.LEAGUE_PATH_CLIENT = league_path.Text;
            }

            try
            {
                // Set the working directory to League folder
                Directory.SetCurrentDirectory(Globals.LEAGUE_PATH_CLIENT);
                ProcessStartInfo leagueClient = new ProcessStartInfo(Globals.LEAGUE_PATH_CLIENT);
                leagueClient.FileName = "LeagueClient.exe";

                // Selected English
                if (language_list.SelectedIndex == 0)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.ENGLISH;
                    Process.Start(leagueClient);
                }

                // Selected Portuguese
                else if (language_list.SelectedIndex == 1)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.PORTUGEUESE;
                    Process.Start(leagueClient);
                }

                // Selected Turkish
                else if (language_list.SelectedIndex == 2)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.TURKISH;
                    Process.Start(leagueClient);
                }

                // Selected Dutch
                else if (language_list.SelectedIndex == 3)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.GERMAN;
                    Process.Start(leagueClient);
                }

                // Selected French
                else if (language_list.SelectedIndex == 4)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.FRENCH;
                    Process.Start(leagueClient);
                }

                // Selected Italian
                else if (language_list.SelectedIndex == 5)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.ITALIAN;
                    Process.Start(leagueClient);
                }

                // Selected Czech
                else if (language_list.SelectedIndex == 6)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.CZECH;
                    Process.Start(leagueClient);
                }

                // Selected Greek
                else if (language_list.SelectedIndex == 7)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.GREEK;
                    Process.Start(leagueClient);
                }

                // Selected Hungarian
                else if (language_list.SelectedIndex == 8)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.HUNGARIAN;
                    Process.Start(leagueClient);
                }

                // Selected Polish
                else if (language_list.SelectedIndex == 9)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.POLISH;
                    Process.Start(leagueClient);
                }

                // Selected Romanian
                else if (language_list.SelectedIndex == 10)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.ROMANIAN;
                    Process.Start(leagueClient);
                }

                // Selected Russian
                else if (language_list.SelectedIndex == 11)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.RUSSIAN;
                    Process.Start(leagueClient);
                }

                // Selected Spanish
                else if (language_list.SelectedIndex == 12)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.SPANISH;
                    Process.Start(leagueClient);
                }

                // Selected Japanese
                else if (language_list.SelectedIndex == 13)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.JAPANESE;
                    Process.Start(leagueClient);
                }

                // Selected Chinese
                else if (language_list.SelectedIndex == 14)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.CHINESE;
                    Process.Start(leagueClient);
                }

                // Selected Korean
                else if (language_list.SelectedIndex == 15)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.KOREAN;
                    Process.Start(leagueClient);
                }

                // Selected Indonesian
                else if (language_list.SelectedIndex == 16)
                {
                    Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                    leagueClient.Arguments = "--locale=" + Globals.INDONESIAN;
                    Process.Start(leagueClient);
                }

                // No option selected
                else
                {
                    status.Text = "[Error] No option selected!";
                }
                   
                // Save the settings that have been set now
                Properties.Settings.Default.Save();

            }

            catch (Exception ex)
            {
                status.Text = "[Error] " + ex.Message;
            }

        }

        private void discord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/cuRC9pN");
        }

        private void frmLeagueOfLocales_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.league_path = league_path.Text.ToString();
            Properties.Settings.Default.Save();
            Environment.Exit(Environment.ExitCode);
        }

        private void browse_LOL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_lol = new FolderBrowserDialog();
            folder_lol.ShowNewFolderButton = false;

            // Show the FolderBrowserDialog.  
            DialogResult result = folder_lol.ShowDialog();
            if (result == DialogResult.OK)
            {
                league_path.Text = folder_lol.SelectedPath;
                Environment.SpecialFolder root = folder_lol.RootFolder;
                Properties.Settings.Default.league_path = league_path.Text.ToString();
                Properties.Settings.Default.Save();
            }

        }

        private void browse_PBE_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse_PBE = new FolderBrowserDialog();
            browse_PBE.ShowNewFolderButton = false;
            // Show the FolderBrowserDialog.  
            DialogResult result = browse_PBE.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbe_path.Text = browse_PBE.SelectedPath;
                Environment.SpecialFolder root = browse_PBE.RootFolder;
                Properties.Settings.Default.pbe_path = pbe_path.Text.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void pbe_path_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.pbe_path = pbe_path.Text;
            Properties.Settings.Default.Save();
        }

        private void league_path_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.league_path = league_path.Text;
            Properties.Settings.Default.Save();
        }
    }
}
