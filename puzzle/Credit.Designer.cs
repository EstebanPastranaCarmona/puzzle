namespace puzzle
{
    partial class frmCredit
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
            btnMuteCredit = new Button();
            btnExit = new Button();
            lblLTittle = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            lblCourse = new Label();
            lblProfesor = new Label();
            lbdDate = new Label();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnMuteCredit
            // 
            btnMuteCredit.Location = new Point(70, 443);
            btnMuteCredit.Margin = new Padding(3, 4, 3, 4);
            btnMuteCredit.Name = "btnMuteCredit";
            btnMuteCredit.Size = new Size(57, 52);
            btnMuteCredit.TabIndex = 4;
            btnMuteCredit.UseVisualStyleBackColor = true;
            btnMuteCredit.Click += btnMuteCredit_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Snap ITC", 15.8000011F);
            btnExit.Location = new Point(287, 443);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 52);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += exit_Click;
            // 
            // lblLTittle
            // 
            lblLTittle.AutoSize = true;
            lblLTittle.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLTittle.LinkBehavior = LinkBehavior.NeverUnderline;
            lblLTittle.LinkColor = Color.White;
            lblLTittle.Location = new Point(127, 145);
            lblLTittle.Name = "lblLTittle";
            lblLTittle.Size = new Size(172, 27);
            lblLTittle.TabIndex = 14;
            lblLTittle.TabStop = true;
            lblLTittle.Text = "Puzzle in C#";
            lblLTittle.TextAlign = ContentAlignment.MiddleCenter;
            lblLTittle.LinkClicked += lblLTittle_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Snap ITC", 12F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(255, 192, 255);
            linkLabel1.Location = new Point(42, 183);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(345, 27);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esteban Pastrana Carmona";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Red;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Snap ITC", 12F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(255, 192, 255);
            linkLabel2.Location = new Point(15, 219);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(392, 27);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "José Luis Guadamuz Rodríguez";
            linkLabel2.TextAlign = ContentAlignment.TopCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourse.ForeColor = SystemColors.ButtonHighlight;
            lblCourse.Location = new Point(82, 264);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(276, 27);
            lblCourse.TabIndex = 17;
            lblCourse.Text = "BIS04-Programación ll";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfesor.ForeColor = SystemColors.ButtonHighlight;
            lblProfesor.Location = new Point(104, 301);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(234, 23);
            lblProfesor.TabIndex = 18;
            lblProfesor.Text = "Gerardo Garita Juarez";
            // 
            // lbdDate
            // 
            lbdDate.AutoSize = true;
            lbdDate.Font = new Font("Snap ITC", 9F);
            lbdDate.ForeColor = SystemColors.ButtonHighlight;
            lbdDate.Location = new Point(127, 342);
            lbdDate.Name = "lbdDate";
            lbdDate.Size = new Size(194, 19);
            lbdDate.TabIndex = 19;
            lbdDate.Text = "21 de agosto de 2024";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(15, 13);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(413, 128);
            picLogo.TabIndex = 20;
            picLogo.TabStop = false;
            // 
            // frmCredit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(440, 521);
            ControlBox = false;
            Controls.Add(picLogo);
            Controls.Add(lbdDate);
            Controls.Add(lblProfesor);
            Controls.Add(lblCourse);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(lblLTittle);
            Controls.Add(btnExit);
            Controls.Add(btnMuteCredit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCredit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credits";
            FormClosing += Credit_FormClosing;
            Load += frmCredit_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMuteCredit;
        private Button btnExit;
        private Label lblTittle;
        private LinkLabel lblLTittle;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label lblCourse;
        private Label lblProfesor;
        private Label lbdDate;
        private PictureBox picLogo;
    }
}