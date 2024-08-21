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
            lblCongrats = new Label();
            lblTime = new Label();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // lblCongrats
            // 
            lblCongrats.AutoSize = true;
            lblCongrats.Font = new Font("Snap ITC", 18F);
            lblCongrats.ForeColor = Color.Black;
            lblCongrats.Location = new Point(3, 22);
            lblCongrats.Name = "lblCongrats";
            lblCongrats.Size = new Size(454, 78);
            lblCongrats.TabIndex = 0;
            lblCongrats.Text = "Congratulations you have\r\n finished the game!!!!!";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Snap ITC", 18F);
            lblTime.Location = new Point(3, 122);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(234, 39);
            lblTime.TabIndex = 1;
            lblTime.Text = "In a time of:";
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Showcard Gothic", 9F);
            btnMenu.Location = new Point(172, 187);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(100, 70);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // frmWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(455, 269);
            ControlBox = false;
            Controls.Add(btnMenu);
            Controls.Add(lblTime);
            Controls.Add(lblCongrats);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmWin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCongrats;
        private Label lblTime;
        private Button btnMenu;
    }
}