namespace cmzz
{
    partial class form1login
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtname = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            txtpw = new TextBox();
            label3 = new Label();
            btnsignin = new Button();
            btnsignup = new Button();
            btnexit = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.vecteezy_people_with_clipboard_3d_render_46352850;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(32, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 284);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fredoka", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(171, 27, 27);
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(170, 36);
            label1.TabIndex = 1;
            label1.Text = "Cash - Mate";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 43, 64);
            panel2.Location = new Point(496, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_face_50__1_;
            pictureBox2.Location = new Point(331, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(98, 172, 255);
            txtname.BorderStyle = BorderStyle.None;
            txtname.Font = new Font("Fredoka", 17.9999981F);
            txtname.ForeColor = Color.FromArgb(5, 43, 64);
            txtname.Location = new Point(496, 78);
            txtname.Name = "txtname";
            txtname.Size = new Size(200, 30);
            txtname.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fredoka", 15.75F);
            label2.ForeColor = Color.FromArgb(5, 43, 64);
            label2.Location = new Point(367, 78);
            label2.Name = "label2";
            label2.Size = new Size(132, 26);
            label2.TabIndex = 9;
            label2.Text = "User Name  :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(5, 43, 64);
            panel3.Location = new Point(496, 194);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_lock_801;
            pictureBox1.Location = new Point(331, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtpw
            // 
            txtpw.BackColor = Color.FromArgb(98, 172, 255);
            txtpw.BorderStyle = BorderStyle.None;
            txtpw.Font = new Font("Fredoka", 17.9999981F);
            txtpw.ForeColor = Color.FromArgb(5, 43, 64);
            txtpw.Location = new Point(496, 162);
            txtpw.Name = "txtpw";
            txtpw.PasswordChar = '*';
            txtpw.Size = new Size(200, 30);
            txtpw.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Fredoka", 15.75F);
            label3.ForeColor = Color.FromArgb(5, 43, 64);
            label3.Location = new Point(367, 162);
            label3.Name = "label3";
            label3.Size = new Size(129, 26);
            label3.TabIndex = 13;
            label3.Text = "Password    :";
            // 
            // btnsignin
            // 
            btnsignin.Font = new Font("Fredoka", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsignin.ForeColor = Color.FromArgb(5, 43, 64);
            btnsignin.Location = new Point(586, 304);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(114, 37);
            btnsignin.TabIndex = 18;
            btnsignin.Text = "SIGN IN";
            btnsignin.UseVisualStyleBackColor = true;
            btnsignin.Click += btnsignin_Click;
            // 
            // btnsignup
            // 
            btnsignup.Font = new Font("Fredoka", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsignup.ForeColor = Color.FromArgb(5, 43, 64);
            btnsignup.Location = new Point(331, 304);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(114, 37);
            btnsignup.TabIndex = 19;
            btnsignup.Text = "SIGN UP";
            btnsignup.UseVisualStyleBackColor = true;
            btnsignup.Click += btnsignup_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Transparent;
            btnexit.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.FromArgb(171, 27, 27);
            btnexit.Location = new Point(702, 1);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(23, 24);
            btnexit.TabIndex = 20;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.FromArgb(5, 43, 64);
            checkBox1.Location = new Point(588, 217);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // form1login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 172, 255);
            ClientSize = new Size(726, 389);
            Controls.Add(checkBox1);
            Controls.Add(btnexit);
            Controls.Add(btnsignup);
            Controls.Add(btnsignin);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(txtpw);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "form1login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtname;
        private Label label2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private TextBox txtpw;
        private Label label3;
        private Button btnsignin;
        private Button btnsignup;
        private Button btnexit;
        private CheckBox checkBox1;
    }
}
