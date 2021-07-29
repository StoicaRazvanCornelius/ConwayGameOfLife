using System;
using System.Drawing.Text;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConwayGameOfLife
{
    public partial class mainForm : Form
    {
        private Button startBtn = new Button();
        private Button exitBtn = new Button();
        private Label gameTitle = new Label();
        
       
        public mainForm()
        {
            InitializeComponent();

        }


        private void ExitBtnClick(object sender, EventArgs e)
        {
            PlaySoundClick();
            System.Threading.Thread.Sleep(300);
            Application.Exit();
        }


        private void StartBtnClick(object sender, EventArgs e)
        {
            Console.WriteLine("Start btn clicked");
            this.exitBtn.Visible = false;
            this.startBtn.Visible = false;
            this.controller.ClickOnGrid();
            PlaySoundClick();
        }

        private void ClickSound(object sender, EventArgs e)
        {
            PlaySoundClick();
        }

        private void PlaySoundClick()
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Properties.Resources.buttonSound);
            soundPlayer.Play();
        }
    }

}
