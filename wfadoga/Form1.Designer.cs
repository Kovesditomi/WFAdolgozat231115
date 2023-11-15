namespace wfadoga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtname = new TextBox();
            btnWelcome = new Button();
            lblwelcome = new Label();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            txtcounter = new TextBox();
            btnosszead = new Button();
            btnszorz = new Button();
            btnkivon = new Button();
            btnoszt = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            btndefault = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "név:";
            // 
            // txtname
            // 
            txtname.Location = new Point(56, 31);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 1;
            // 
            // btnWelcome
            // 
            btnWelcome.Location = new Point(174, 31);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(75, 23);
            btnWelcome.TabIndex = 2;
            btnWelcome.Text = "Köszönj!";
            btnWelcome.UseVisualStyleBackColor = true;
            // 
            // lblwelcome
            // 
            lblwelcome.BackColor = Color.FromArgb(255, 255, 128);
            lblwelcome.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblwelcome.Location = new Point(21, 70);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(228, 43);
            lblwelcome.TabIndex = 3;
            lblwelcome.Text = "###UDVOZLES###";
            lblwelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            lblRed.BackColor = Color.Red;
            lblRed.Location = new Point(284, 31);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(65, 61);
            lblRed.TabIndex = 4;
            lblRed.Text = "piros";
            // 
            // lblGreen
            // 
            lblGreen.BackColor = Color.Green;
            lblGreen.Location = new Point(355, 31);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(65, 61);
            lblGreen.TabIndex = 4;
            lblGreen.Text = "zöld";
            // 
            // lblBlue
            // 
            lblBlue.BackColor = Color.Blue;
            lblBlue.Location = new Point(426, 31);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(69, 61);
            lblBlue.TabIndex = 5;
            lblBlue.Text = "kék";
            // 
            // txtcounter
            // 
            txtcounter.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcounter.Location = new Point(21, 153);
            txtcounter.Name = "txtcounter";
            txtcounter.Size = new Size(64, 43);
            txtcounter.TabIndex = 6;
            // 
            // btnosszead
            // 
            btnosszead.Location = new Point(110, 146);
            btnosszead.Name = "btnosszead";
            btnosszead.Size = new Size(31, 28);
            btnosszead.TabIndex = 7;
            btnosszead.Text = "+";
            btnosszead.UseVisualStyleBackColor = true;
            // 
            // btnszorz
            // 
            btnszorz.Location = new Point(110, 180);
            btnszorz.Name = "btnszorz";
            btnszorz.Size = new Size(31, 29);
            btnszorz.TabIndex = 8;
            btnszorz.Text = "*";
            btnszorz.UseVisualStyleBackColor = true;
            // 
            // btnkivon
            // 
            btnkivon.Location = new Point(147, 146);
            btnkivon.Name = "btnkivon";
            btnkivon.Size = new Size(31, 29);
            btnkivon.TabIndex = 9;
            btnkivon.Text = "-";
            btnkivon.UseVisualStyleBackColor = true;
            // 
            // btnoszt
            // 
            btnoszt.Location = new Point(147, 180);
            btnoszt.Name = "btnoszt";
            btnoszt.Size = new Size(31, 29);
            btnoszt.TabIndex = 10;
            btnoszt.Text = "/";
            btnoszt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(201, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(64, 43);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 149);
            label2.Name = "label2";
            label2.Size = new Size(206, 40);
            label2.TabIndex = 12;
            label2.Text = "#eredmeny#";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(284, 153);
            label3.Name = "label3";
            label3.Size = new Size(25, 25);
            label3.TabIndex = 13;
            label3.Text = "=";
            // 
            // button5
            // 
            button5.Location = new Point(20, 215);
            button5.Name = "button5";
            button5.Size = new Size(501, 28);
            button5.TabIndex = 14;
            button5.Text = "Számolj!";
            button5.UseVisualStyleBackColor = true;
            // 
            // btndefault
            // 
            btndefault.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndefault.ForeColor = Color.Teal;
            btndefault.Location = new Point(284, 249);
            btndefault.Name = "btndefault";
            btndefault.Size = new Size(105, 29);
            btndefault.TabIndex = 15;
            btndefault.Text = "Alaphelyzet";
            btndefault.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.ForeColor = Color.Red;
            btnexit.Location = new Point(418, 249);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(103, 29);
            btnexit.TabIndex = 16;
            btnexit.Text = "Kilépés";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 280);
            Controls.Add(btnexit);
            Controls.Add(btndefault);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btnoszt);
            Controls.Add(btnkivon);
            Controls.Add(btnszorz);
            Controls.Add(btnosszead);
            Controls.Add(txtcounter);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(lblwelcome);
            Controls.Add(btnWelcome);
            Controls.Add(txtname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtname;
        private Button btnWelcome;
        private Label lblwelcome;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private TextBox txtcounter;
        private Button btnosszead;
        private Button btnszorz;
        private Button btnkivon;
        private Button btnoszt;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button5;
        private Button btndefault;
        private Button btnexit;
    }
}