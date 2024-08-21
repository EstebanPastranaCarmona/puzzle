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
            exit = new Button();
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
            btnMuteCredit.Location = new Point(49, 399);
            btnMuteCredit.Name = "btnMuteCredit";
            btnMuteCredit.Size = new Size(50, 39);
            btnMuteCredit.TabIndex = 4;
            btnMuteCredit.UseVisualStyleBackColor = true;
            btnMuteCredit.Click += btnMuteCredit_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Snap ITC", 15.8000011F);
            exit.Location = new Point(243, 399);
            exit.Name = "exit";
            exit.Size = new Size(105, 39);
            exit.TabIndex = 10;
            exit.Text = "Salir";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // lblLTittle
            // 
            lblLTittle.AutoSize = true;
            lblLTittle.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold);
            lblLTittle.LinkBehavior = LinkBehavior.NeverUnderline;
            lblLTittle.LinkColor = Color.White;
            lblLTittle.Location = new Point(117, 134);
            lblLTittle.Name = "lblLTittle";
            lblLTittle.Size = new Size(167, 29);
            lblLTittle.TabIndex = 14;
            lblLTittle.TabStop = true;
            lblLTittle.Text = "Rompecabeza C#";
            lblLTittle.TextAlign = ContentAlignment.TopCenter;
            lblLTittle.LinkClicked += lblLTittle_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(73, 172);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(254, 29);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esteban Pastrana Carmona";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(60, 201);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(288, 29);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "José Luis Guadamuz Rodríguez";
            linkLabel2.TextAlign = ContentAlignment.TopCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourse.ForeColor = SystemColors.ButtonHighlight;
            lblCourse.Location = new Point(106, 245);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(187, 29);
            lblCourse.TabIndex = 17;
            lblCourse.Text = "BIS04-Programación ll";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfesor.ForeColor = SystemColors.ButtonHighlight;
            lblProfesor.Location = new Point(106, 274);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(187, 29);
            lblProfesor.TabIndex = 18;
            lblProfesor.Text = "Gerardo Garita Juarez";
            // 
            // lbdDate
            // 
            lbdDate.AutoSize = true;
            lbdDate.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbdDate.ForeColor = SystemColors.ButtonHighlight;
            lbdDate.Location = new Point(105, 303);
            lbdDate.Name = "lbdDate";
            lbdDate.Size = new Size(179, 29);
            lbdDate.TabIndex = 19;
            lbdDate.Text = "21 de agosto de 2024";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(361, 96);
            picLogo.TabIndex = 20;
            picLogo.TabStop = false;
            // 
            // frmCredit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(385, 450);
            Controls.Add(picLogo);
            Controls.Add(lbdDate);
            Controls.Add(lblProfesor);
            Controls.Add(lblCourse);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(lblLTittle);
            Controls.Add(exit);
            Controls.Add(btnMuteCredit);
            Name = "frmCredit";
            Text = "Credit";
            FormClosing += Credit_FormClosing;
            Load += frmCredit_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMuteCredit;
        private Button exit;
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