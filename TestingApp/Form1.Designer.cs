
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
            this.ClientSize = new System.Drawing.Size(1043, 570);
            this.Name = "mainForm";
            this.Text = "Conway's game of life";
            // 
            // Exit button
            // 
            this.exitButton.Location = new System.Drawing.Point(this.Size.Height / 2 - Constants.buttonSize, this.Size.Width / 2 -Constants.buttonSize);
            this.exitButton.Name = "exitBtn";
            this.exitButton.Size = new System.Drawing.Size(Constants.buttonSize, Constants.buttonSize);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += 


            this.ResumeLayout(false);

        }

        #endregion
    }
}

