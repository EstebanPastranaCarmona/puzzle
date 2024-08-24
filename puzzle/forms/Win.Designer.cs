namespace puzzle
{
    partial class frmWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWin));
            lblCongrats = new Label();
            lblTime = new Label();
            btnMenu = new Button();
            pic2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCongrats
            // 
            lblCongrats.AutoSize = true;
            lblCongrats.Font = new Font("Snap ITC", 18F);
            lblCongrats.ForeColor = Color.Black;
            lblCongrats.Location = new Point(15, 9);
            lblCongrats.Name = "lblCongrats";
            lblCongrats.Size = new Size(364, 62);
            lblCongrats.TabIndex = 0;
            lblCongrats.Text = "Congratulations you have\r\n finished the game!!!!!";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Snap ITC", 18F);
            lblTime.Location = new Point(27, 93);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(188, 31);
            lblTime.TabIndex = 1;
            lblTime.Text = "In a time of:";
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Showcard Gothic", 9F);
            btnMenu.Location = new Point(150, 140);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(88, 52);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pic2
            // 
            pic2.Image = (Image)resources.GetObject("pic2.Image");
            pic2.Location = new Point(91, -89);
            pic2.Name = "pic2";
            pic2.Size = new Size(300, 300);
            pic2.TabIndex = 8;
            pic2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(391, 195);
            ControlBox = false;
            Controls.Add(btnMenu);
            Controls.Add(lblTime);
            Controls.Add(lblCongrats);
            Controls.Add(pic2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmWin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCongrats;
        private Label lblTime;
        private Button btnMenu;
        private PictureBox pic2;
        private PictureBox pictureBox1;
    }
}