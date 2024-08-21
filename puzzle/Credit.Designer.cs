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
            lklblEsteban = new LinkLabel();
            lklblJose = new LinkLabel();
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
            btnExit.Click += btnExit_Click;
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
            lblLTittle.LinkClicked += lblTittle_LinkClicked;
            // 
            // lklblEsteban
            // 
            lklblEsteban.ActiveLinkColor = Color.Red;
            lklblEsteban.AutoSize = true;
            lklblEsteban.Font = new Font("Snap ITC", 12F, FontStyle.Bold);
            lklblEsteban.LinkBehavior = LinkBehavior.NeverUnderline;
            lklblEsteban.LinkColor = Color.FromArgb(255, 192, 255);
            lklblEsteban.Location = new Point(42, 183);
            lklblEsteban.Name = "lklblEsteban";
            lklblEsteban.Size = new Size(345, 27);
            lklblEsteban.TabIndex = 15;
            lklblEsteban.TabStop = true;
            lklblEsteban.Text = "Esteban Pastrana Carmona";
            lklblEsteban.TextAlign = ContentAlignment.TopCenter;
            lklblEsteban.LinkClicked += lklblEsteban_LinkClicked_1;
            // 
            // lklblJose
            // 
            lklblJose.ActiveLinkColor = Color.Red;
            lklblJose.AutoSize = true;
            lklblJose.Font = new Font("Snap ITC", 12F, FontStyle.Bold);
            lklblJose.LinkBehavior = LinkBehavior.NeverUnderline;
            lklblJose.LinkColor = Color.FromArgb(255, 192, 255);
            lklblJose.Location = new Point(15, 219);
            lklblJose.Name = "lklblJose";
            lklblJose.Size = new Size(392, 27);
            lklblJose.TabIndex = 16;
            lklblJose.TabStop = true;
            lklblJose.Text = "José Luis Guadamuz Rodríguez";
            lklblJose.TextAlign = ContentAlignment.TopCenter;
            lklblJose.LinkClicked += lklblJose_LinkClicked;
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
            Controls.Add(lklblJose);
            Controls.Add(lklblEsteban);
            Controls.Add(lblLTittle);
            Controls.Add(btnExit);
            Controls.Add(btnMuteCredit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCredit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credits";
            FormClosing += frmCredit_FormClosing;
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
        private LinkLabel lklblEsteban;
        private LinkLabel lklblJose;
        private Label lblCourse;
        private Label lblProfesor;
        private Label lbdDate;
        private PictureBox picLogo;
    }
}