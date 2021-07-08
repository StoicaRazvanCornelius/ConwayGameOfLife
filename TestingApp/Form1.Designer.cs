
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConwayGameOfLife
{
    partial class mainForm
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
            this.SuspendLayout();
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            MinimumSize = this.Size;
            MaximumSize = new Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            this.WindowState = FormWindowState.Maximized;
            this.BackColor=Color.Black;
            this.Name = "mainForm";
            this.Text = "Conway's game of life";
            this.Click += new System.EventHandler(ClickSound);
            // 
            // Game Title
            // 
            this.gameTitle.Name = "gameTitleLable";
            this.gameTitle.Size = new System.Drawing.Size(this.Size.Width / 2 + this.Size.Width / 4, this.Size.Height / 2);
            this.gameTitle.Location = new System.Drawing.Point(this.Size.Width /8, this.Size.Height / 4 - this.Size.Height/8);
            this.gameTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.gameTitle.Font = new Font(getPrivateFontCollection().Families[0],110 );
            this.gameTitle.Text = "Conway's game of life";
            this.gameTitle.UseCompatibleTextRendering = true;
            this.gameTitle.BackColor = Color.Black;
            this.gameTitle.ForeColor = Color.Lime;
            this.gameTitle.Click += new EventHandler(ClickSound);


            this.Controls.Add(this.gameTitle);
            // 
            // Start button
            // 
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(Constants.buttonSize * 4, Constants.buttonSize / 2);
            this.startBtn.Location = new System.Drawing.Point(this.Size.Width / 2 - this.startBtn.Size.Width / 2 , this.Size.Height / 2 + this.Size.Height / 4);
            this.TabIndex = 0;
            this.startBtn.Text = "START";
            this.startBtn.Font = new Font(getPrivateFontCollection().Families[0], 25,FontStyle.Bold);
            this.startBtn.UseCompatibleTextRendering = true;
            this.startBtn.ForeColor = Color.Lime;
            this.startBtn.BackColor = Color.Black;
            this.startBtn.FlatStyle = FlatStyle.Flat;
            this.startBtn.FlatAppearance.BorderColor = Color.Lime;
            this.startBtn.FlatAppearance.BorderSize = 2;
            this.startBtn.Anchor = AnchorStyles.None;
            this.startBtn.Click += new System.EventHandler(this.StartBtnClick);
            this.Controls.Add(this.startBtn);
            // 
            // Exit button
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(Constants.buttonSize*2, Constants.buttonSize/2);
            this.exitBtn.Location = new System.Drawing.Point(this.Size.Width / 2 - this.exitBtn.Size.Width/2, this.Size.Height / 2 + this.Size.Height / 4 + this.startBtn.Height + Constants.buttonPadding);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Font = new Font(getPrivateFontCollection().Families[0], 25, FontStyle.Bold);
            this.exitBtn.UseCompatibleTextRendering = true;
            this.exitBtn.ForeColor = Color.Lime;
            this.exitBtn.BackColor = Color.Black;
            this.exitBtn.FlatStyle = FlatStyle.Flat; 
            this.exitBtn.FlatAppearance.BorderColor=Color.Lime;
            this.exitBtn.FlatAppearance.BorderSize = 2;
            this.exitBtn.Anchor = AnchorStyles.None;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            this.Controls.Add(this.exitBtn);

            this.ResumeLayout(false);

        }

        #endregion

        private PrivateFontCollection getPrivateFontCollection()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.C_C_Red_Alert__INET_.Length;
            byte[] fontData = Properties.Resources.C_C_Red_Alert__INET_;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            return pfc;
        }

    }
}

