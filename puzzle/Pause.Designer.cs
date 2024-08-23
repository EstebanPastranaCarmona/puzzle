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
            lblPause.Location = new Point(59, 22);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(198, 29);
            lblPause.TabIndex = 0;
            lblPause.Text = "Juego Pausado";
            // 
            // btnPaused
            // 
            btnPaused.Font = new Font("Snap ITC", 16.2F);
            btnPaused.Location = new Point(75, 77);
            btnPaused.Name = "btnPaused";
            btnPaused.Size = new Size(148, 39);
            btnPaused.TabIndex = 1;
            btnPaused.Text = "Continuar";
            btnPaused.UseVisualStyleBackColor = true;
            btnPaused.Click += btnPaused_Click;
            // 
            // pic2
            // 
            pic2.Image = (Image)resources.GetObject("pic2.Image");
            pic2.Location = new Point(7, -79);
            pic2.Name = "pic2";
            pic2.Size = new Size(300, 300);
            pic2.TabIndex = 8;
            pic2.TabStop = false;
            // 
            // frmPause
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(314, 143);
            Controls.Add(btnPaused);
            Controls.Add(lblPause);
            Controls.Add(pic2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPause";
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