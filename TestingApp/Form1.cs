using System;
using System.Drawing.Text;
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
            Application.Exit();
        }


        private void StartBtnClick(object sender, EventArgs e)
        {
            Console.WriteLine("Start btn clicked");
            this.exitBtn.Visible = false;
            this.startBtn.Visible = false;
        }

    }

}
