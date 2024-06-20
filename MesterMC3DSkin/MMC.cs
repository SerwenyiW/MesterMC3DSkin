using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace MesterMC3DSkin
{
    public partial class MMC : Form
    {

        public string url = "";
        public MMC()
        {
            InitializeComponent();
        }

        private void genSkinBtn_Click(object sender, EventArgs e)
        {
            bool headOnly = bodyCheckBox.Checked == true ? false : true;
            bool displayHairs = hairCheckBox.Checked;
            int a = karakterdolesTrick.Value;
            int w = karakterfordulTrick.Value;
            int wt = fejfordulTrick.Value;
            int abg = BalkarjaTrick.Value;
            int abd = JobbkarjaTrick.Value;
            int ajg = BallabaTrick.Value;
            int ajd = JobblabaTrick.Value;
            string username = usernameTextbox.Text;

            try
            {
                WebClient wb = new WebClient();
                byte[] imageBytes = wb.DownloadData($"https://mestermc.hu/3dskin/3d.php?a={a}&w={w}&wt={wt}&abg={abg}&abd={abd}&ajg={ajg}&ajd={ajd}&ratio=1&format=png&displayHairs={displayHairs}&headOnly={headOnly}&login={username}");
                var ms = new MemoryStream(imageBytes);
                skinPicture.Image = Image.FromStream(ms);
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void downloadSkinBtn_Click(object sender, EventArgs e)
        {
            bool headOnly = bodyCheckBox.Checked == true ? false : true;
            bool displayHairs = hairCheckBox.Checked;
            int a = karakterdolesTrick.Value;
            int w = karakterfordulTrick.Value;
            int wt = fejfordulTrick.Value;
            int abg = BalkarjaTrick.Value;
            int abd = JobbkarjaTrick.Value;
            int ajg = BallabaTrick.Value;
            int ajd = JobblabaTrick.Value;
            string username = usernameTextbox.Text;
            WebClient wb = new WebClient();
            wb.DownloadFile($"https://mestermc.hu/3dskin/3d.php?a={a}&w={w}&wt={wt}&abg={abg}&abd={abd}&ajg={ajg}&ajd={ajd}&ratio=1&format=png&displayHairs={displayHairs}&headOnly={headOnly}&login={username}", $"{username}.png");
        }
    }
}
