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
            lblMenu = new Label();
            btnMenu = new Button();
            btnExitGame = new Button();
            btnMuteMenu = new Button();
            picBtn = new Button();
            btnCredits = new Button();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Snap ITC", 72F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(2, -1);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(509, 155);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
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
    }
}