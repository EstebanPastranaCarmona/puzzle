namespace puzzle
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            lblMenu = new Label();
            btnGame = new Button();
            btnExitGame = new Button();
            btnMuteMenu = new Button();
            btnPic = new Button();
            btnCredits = new Button();
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Snap ITC", 60F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(64, 25);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(426, 129);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Puzzle";
            // 
            // btnGame
            // 
            btnGame.BackColor = Color.FromArgb(192, 192, 255);
            btnGame.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGame.ForeColor = Color.Black;
            btnGame.Location = new Point(117, 193);
            btnGame.Name = "btnGame";
            btnGame.Size = new Size(261, 49);
            btnGame.TabIndex = 1;
            btnGame.Text = "New Game";
            btnGame.UseVisualStyleBackColor = false;
            btnGame.Click += btnGame_Click;
            // 
            // btnExitGame
            // 
            btnExitGame.BackColor = Color.FromArgb(192, 192, 255);
            btnExitGame.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExitGame.Location = new Point(117, 303);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(261, 49);
            btnExitGame.TabIndex = 2;
            btnExitGame.Text = "Exit";
            btnExitGame.UseVisualStyleBackColor = false;
            btnExitGame.Click += btnExitGame_Click;
            // 
            // btnMuteMenu
            // 
            btnMuteMenu.BackColor = Color.FromArgb(192, 192, 255);
            btnMuteMenu.Location = new Point(33, 384);
            btnMuteMenu.Margin = new Padding(3, 4, 3, 4);
            btnMuteMenu.Name = "btnMuteMenu";
            btnMuteMenu.Size = new Size(57, 52);
            btnMuteMenu.TabIndex = 3;
            btnMuteMenu.UseVisualStyleBackColor = false;
            btnMuteMenu.Click += btnMuteMenu_Click;
            // 
            // btnPic
            // 
            btnPic.BackColor = Color.FromArgb(192, 192, 255);
            btnPic.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPic.ForeColor = Color.Black;
            btnPic.Location = new Point(117, 248);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(261, 49);
            btnPic.TabIndex = 4;
            btnPic.Text = "Pictures";
            btnPic.UseVisualStyleBackColor = false;
            btnPic.Click += btnPic_Click;
            // 
            // btnCredits
            // 
            btnCredits.BackColor = Color.FromArgb(192, 192, 255);
            btnCredits.Font = new Font("Snap ITC", 11.2F);
            btnCredits.Location = new Point(392, 383);
            btnCredits.Margin = new Padding(3, 4, 3, 4);
            btnCredits.Name = "btnCredits";
            btnCredits.Size = new Size(106, 52);
            btnCredits.TabIndex = 5;
            btnCredits.Text = "Credits";
            btnCredits.UseVisualStyleBackColor = false;
            btnCredits.Click += btnCredit_Click;
            // 
            // pic1
            // 
            pic1.Image = (Image)resources.GetObject("pic1.Image");
            pic1.Location = new Point(341, -3);
            pic1.Margin = new Padding(3, 4, 3, 4);
            pic1.Name = "pic1";
            pic1.Size = new Size(343, 400);
            pic1.TabIndex = 6;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.Image = (Image)resources.GetObject("pic2.Image");
            pic2.Location = new Point(-9, -3);
            pic2.Margin = new Padding(3, 4, 3, 4);
            pic2.Name = "pic2";
            pic2.Size = new Size(343, 400);
            pic2.TabIndex = 7;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.Image = (Image)resources.GetObject("pic3.Image");
            pic3.Location = new Point(-9, 248);
            pic3.Margin = new Padding(3, 4, 3, 4);
            pic3.Name = "pic3";
            pic3.Size = new Size(343, 400);
            pic3.TabIndex = 8;
            pic3.TabStop = false;
            // 
            // pic4
            // 
            pic4.Image = (Image)resources.GetObject("pic4.Image");
            pic4.Location = new Point(171, 347);
            pic4.Margin = new Padding(3, 4, 3, 4);
            pic4.Name = "pic4";
            pic4.Size = new Size(343, 400);
            pic4.TabIndex = 9;
            pic4.TabStop = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(512, 451);
            Controls.Add(btnCredits);
            Controls.Add(btnPic);
            Controls.Add(btnMuteMenu);
            Controls.Add(btnExitGame);
            Controls.Add(btnGame);
            Controls.Add(lblMenu);
            Controls.Add(pic1);
            Controls.Add(pic2);
            Controls.Add(pic3);
            Controls.Add(pic4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnGame;
        private Button btnExitGame;
        private Button btnMuteMenu;
        private Button btnPic;
        private Button btnCredits;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic4;
    }
}