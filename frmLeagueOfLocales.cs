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

        public bool LocaleSupplied = true;

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
                        league_path_label.ForeColor = Color.DodgerBlue;
                        browse_LOL.ForeColor = Color.DodgerBlue;
                        league_path.ForeColor = Color.Black;
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

                switch (language_list.SelectedIndex)
                {
                    case 0: // Selected English
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.ENGLISH);
                        break;

                    case 1: // Selected Portuguese
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.PORTUGEUESE);
                        break;

                    case 2: // Selected Turkish
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.TURKISH);
                        break;

                    case 3: // Selected German
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.GERMAN);
                        break;

                    case 4: // Selected French
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.FRENCH);
                        break;

                    case 5: // Selected Italian
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.ITALIAN);
                        break;

                    case 6: // Selected Czech
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.CZECH);
                        break;

                    case 7: // Selected Greek
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.GREEK);
                        break;

                    case 8: // Selected Hungarian
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.HUNGARIAN);
                        break;

                    case 9: // Selected Polish
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.POLISH);
                        break;

                    case 10: // Selected Romanian
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.ROMANIAN);
                        break;

                    case 11: // Selected Russian
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.RUSSIAN);
                        break;

                    case 12: // Selected Spanish
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.SPANISH);
                        break;

                    case 13: // Selected Japanese
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.JAPANESE);
                        break;

                    case 14: // Selected Chinese
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.CHINESE);
                        break;

                    case 15: // Selected Korean
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.KOREAN);
                        break;

                    case 16: // Selected Indonesian
                        Properties.Settings.Default.SelectedIndex = language_list.SelectedIndex;
                        leagueClient.Arguments = String.Format("--locale={0}", Globals.INDONESIAN);
                        break;

                    default:
                        status.Text = "[Error] No option selected!";
                        LocaleSupplied = false;
                        break;
                }

                if (LocaleSupplied) { Process.Start(leagueClient); } // If the locale has been supplied (not the default select locale prompt)
                Properties.Settings.Default.Save(); // Save the settings that have been set now
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
