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
            btnMenu = new Button();
            btnExitGame = new Button();
            btnMuteMenu = new Button();
            picBtn = new Button();
            btnCredits = new Button();
            pbx1 = new PictureBox();
            pbx2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(192, 192, 255);
            btnMenu.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(117, 193);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(261, 49);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "New Game";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
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
            // picBtn
            // 
            picBtn.BackColor = Color.FromArgb(192, 192, 255);
            picBtn.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            picBtn.ForeColor = Color.Black;
            picBtn.Location = new Point(117, 248);
            picBtn.Name = "picBtn";
            picBtn.Size = new Size(261, 49);
            picBtn.TabIndex = 4;
            picBtn.Text = "Pictures";
            picBtn.UseVisualStyleBackColor = false;
            picBtn.Click += btnPic_Click;
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
            // pbx1
            // 
            pbx1.Image = (Image)resources.GetObject("pbx1.Image");
            pbx1.Location = new Point(341, -3);
            pbx1.Margin = new Padding(3, 4, 3, 4);
            pbx1.Name = "pbx1";
            pbx1.Size = new Size(343, 400);
            pbx1.TabIndex = 6;
            pbx1.TabStop = false;
            // 
            // pbx2
            // 
            pbx2.Image = (Image)resources.GetObject("pbx2.Image");
            pbx2.Location = new Point(-9, -3);
            pbx2.Margin = new Padding(3, 4, 3, 4);
            pbx2.Name = "pbx2";
            pbx2.Size = new Size(343, 400);
            pbx2.TabIndex = 7;
            pbx2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-9, 248);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(343, 400);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(171, 347);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(343, 400);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(512, 451);
            Controls.Add(btnCredits);
            Controls.Add(picBtn);
            Controls.Add(btnMuteMenu);
            Controls.Add(btnExitGame);
            Controls.Add(btnMenu);
            Controls.Add(lblMenu);
            Controls.Add(pbx1);
            Controls.Add(pbx2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnMenu;
        private Button btnExitGame;
        private Button btnMuteMenu;
        private Button picBtn;
        private Button btnCredits;
        private PictureBox pbx1;
        private PictureBox pbx2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}