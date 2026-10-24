namespace cmzz
{
    partial class form3dashbord
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
            mainpanel = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnreport = new Button();
            btncategory = new Button();
            btnexpense = new Button();
            btnincome = new Button();
            label2 = new Label();
            btndash = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(98, 172, 255);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(288, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(796, 611);
            mainpanel.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vecteezy_3d_male_character_presenting_to_the_right_24785849;
            pictureBox2.Location = new Point(-22, 287);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 326);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 172, 255);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnreport);
            panel1.Controls.Add(btncategory);
            panel1.Controls.Add(btnexpense);
            panel1.Controls.Add(btnincome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btndash);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 611);
            panel1.TabIndex = 7;
            // 
            // btnreport
            // 
            btnreport.BackColor = Color.FromArgb(98, 172, 255);
            btnreport.FlatAppearance.BorderSize = 0;
            btnreport.FlatStyle = FlatStyle.Popup;
            btnreport.Font = new Font("Fredoka SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreport.ForeColor = Color.FromArgb(5, 43, 64);
            btnreport.Image = Properties.Resources.icons8_reports_24;
            btnreport.ImageAlign = ContentAlignment.MiddleLeft;
            btnreport.Location = new Point(12, 252);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(213, 45);
            btnreport.TabIndex = 21;
            btnreport.Text = "Reports";
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // btncategory
            // 
            btncategory.BackColor = Color.FromArgb(98, 172, 255);
            btncategory.FlatAppearance.BorderSize = 0;
            btncategory.FlatStyle = FlatStyle.Popup;
            btncategory.Font = new Font("Fredoka SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncategory.ForeColor = Color.FromArgb(5, 43, 64);
            btncategory.Image = Properties.Resources.icons8_category_24;
            btncategory.ImageAlign = ContentAlignment.MiddleLeft;
            btncategory.Location = new Point(12, 201);
            btncategory.Name = "btncategory";
            btncategory.Size = new Size(213, 45);
            btncategory.TabIndex = 20;
            btncategory.Text = "Category";
            btncategory.UseVisualStyleBackColor = false;
            btncategory.Click += btncategory_Click;
            // 
            // btnexpense
            // 
            btnexpense.BackColor = Color.FromArgb(98, 172, 255);
            btnexpense.FlatAppearance.BorderSize = 0;
            btnexpense.FlatStyle = FlatStyle.Popup;
            btnexpense.Font = new Font("Fredoka SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexpense.ForeColor = Color.FromArgb(5, 43, 64);
            btnexpense.Image = Properties.Resources.icons8_expense_24__1_;
            btnexpense.ImageAlign = ContentAlignment.MiddleLeft;
            btnexpense.Location = new Point(12, 150);
            btnexpense.Name = "btnexpense";
            btnexpense.Size = new Size(213, 45);
            btnexpense.TabIndex = 19;
            btnexpense.Text = "Expenses";
            btnexpense.UseVisualStyleBackColor = false;
            btnexpense.Click += btnexpense_Click;
            // 
            // btnincome
            // 
            btnincome.BackColor = Color.FromArgb(98, 172, 255);
            btnincome.FlatAppearance.BorderSize = 0;
            btnincome.FlatStyle = FlatStyle.Popup;
            btnincome.Font = new Font("Fredoka SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnincome.ForeColor = Color.FromArgb(5, 43, 64);
            btnincome.Image = Properties.Resources.icons8_income_24__1_;
            btnincome.ImageAlign = ContentAlignment.MiddleLeft;
            btnincome.Location = new Point(12, 99);
            btnincome.Name = "btnincome";
            btnincome.Size = new Size(213, 45);
            btnincome.TabIndex = 18;
            btnincome.Text = "Incomes";
            btnincome.UseVisualStyleBackColor = false;
            btnincome.Click += btnincome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fredoka", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(171, 27, 27);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(170, 36);
            label2.TabIndex = 17;
            label2.Text = "Cash - Mate";
            // 
            // btndash
            // 
            btndash.BackColor = Color.FromArgb(98, 172, 255);
            btndash.FlatAppearance.BorderSize = 0;
            btndash.FlatStyle = FlatStyle.Popup;
            btndash.Font = new Font("Fredoka SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndash.ForeColor = Color.FromArgb(5, 43, 64);
            btndash.Image = Properties.Resources.icons8_dashboard_24;
            btndash.ImageAlign = ContentAlignment.MiddleLeft;
            btndash.Location = new Point(12, 48);
            btndash.Name = "btndash";
            btndash.Size = new Size(213, 45);
            btndash.TabIndex = 12;
            btndash.Text = "Dashbord";
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Fredoka", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(5, 43, 64);
            label1.Location = new Point(93, 307);
            label1.Name = "label1";
            label1.Size = new Size(185, 74);
            label1.TabIndex = 0;
            label1.Text = "HI Buddy ,\r\nhere's your spending\r\noverview";
            // 
            // form3dashbord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 172, 222);
            ClientSize = new Size(1084, 611);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1100, 650);
            MinimumSize = new Size(1100, 650);
            Name = "form3dashbord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashbord";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainpanel;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private Button btndash;
        private Button btncategory;
        private Button btnexpense;
        private Button btnincome;
        private Label label2;
        private Button btnreport;
    }
}