namespace puzzle
{
    partial class frmPause
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPause));
            lblPause = new Label();
            btnPaused = new Button();
            pic2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            SuspendLayout();
            // 
            // lblPause
            // 
            lblPause.AutoSize = true;
            lblPause.Font = new Font("Snap ITC", 16.2F);
            lblPause.ForeColor = SystemColors.ButtonHighlight;
            lblPause.Location = new Point(51, 28);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(205, 36);
            lblPause.TabIndex = 0;
            lblPause.Text = "Game Pause";
            // 
            // btnPaused
            // 
            btnPaused.Font = new Font("Snap ITC", 16.2F);
            btnPaused.Location = new Point(86, 103);
            btnPaused.Margin = new Padding(3, 4, 3, 4);
            btnPaused.Name = "btnPaused";
            btnPaused.Size = new Size(169, 52);
            btnPaused.TabIndex = 1;
            btnPaused.Text = "Continue";
            btnPaused.UseVisualStyleBackColor = true;
            btnPaused.Click += btnPaused_Click;
            // 
            // pic2
            // 
            pic2.Image = (Image)resources.GetObject("pic2.Image");
            pic2.Location = new Point(8, -105);
            pic2.Margin = new Padding(3, 4, 3, 4);
            pic2.Name = "pic2";
            pic2.Size = new Size(343, 400);
            pic2.TabIndex = 8;
            pic2.TabStop = false;
            // 
            // frmPause
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(359, 191);
            Controls.Add(btnPaused);
            Controls.Add(lblPause);
            Controls.Add(pic2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPause";
            Opacity = 0.5D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pause";
            FormClosing += frmPause_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPause;
        private Button btnPaused;
        private PictureBox pic2;
    }
}