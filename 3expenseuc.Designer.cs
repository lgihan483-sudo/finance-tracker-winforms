namespace cmzz
{
    partial class addexpense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label11 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            cmbecategory = new ComboBox();
            label3 = new Label();
            cmbetype = new TextBox();
            btneclear = new Button();
            btnedelete = new Button();
            btneupdate = new Button();
            btenadd = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtedescription = new TextBox();
            txteamount = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(5, 43, 64);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(407, 30);
            label1.TabIndex = 22;
            label1.Text = "Every Expense Matters, Track It Now.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Fredoka", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(171, 27, 27);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(125, 36);
            label11.TabIndex = 21;
            label11.Text = "Expense";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(98, 172, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(5, 43, 64);
            button1.Image = Properties.Resources.icons8_logout_26;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(642, 3);
            button1.Name = "button1";
            button1.Size = new Size(151, 45);
            button1.TabIndex = 24;
            button1.Text = "LOGOUT";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 172, 255);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Fredoka SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 518);
            panel1.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(cmbecategory);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cmbetype);
            panel3.Controls.Add(btneclear);
            panel3.Controls.Add(btnedelete);
            panel3.Controls.Add(btneupdate);
            panel3.Controls.Add(btenadd);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(txtedescription);
            panel3.Controls.Add(txteamount);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 260);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 253);
            panel3.TabIndex = 1;
            // 
            // cmbecategory
            // 
            cmbecategory.Font = new Font("Fredoka", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbecategory.ForeColor = Color.FromArgb(5, 43, 64);
            cmbecategory.FormattingEnabled = true;
            cmbecategory.Items.AddRange(new object[] { "Food & Drinks", "Housing / Utilities", "Transport", "Personal / Shopping", "Health & Medical", "Education / Learning", "Entertainment / Leisure", "Savings / Investments / Donations", "Communication", "Other" });
            cmbecategory.Location = new Point(151, 140);
            cmbecategory.Name = "cmbecategory";
            cmbecategory.Size = new Size(212, 34);
            cmbecategory.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(5, 43, 64);
            label3.Location = new Point(31, 141);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 40;
            label3.Text = "Category : ";
            // 
            // cmbetype
            // 
            cmbetype.Font = new Font("Fredoka", 15.75F);
            cmbetype.ForeColor = Color.FromArgb(5, 43, 64);
            cmbetype.Location = new Point(155, 86);
            cmbetype.Name = "cmbetype";
            cmbetype.Size = new Size(208, 33);
            cmbetype.TabIndex = 42;
            // 
            // btneclear
            // 
            btneclear.BackColor = Color.FromArgb(98, 172, 255);
            btneclear.FlatStyle = FlatStyle.Flat;
            btneclear.Font = new Font("Fredoka", 14.25F);
            btneclear.ForeColor = Color.FromArgb(5, 43, 64);
            btneclear.Location = new Point(480, 200);
            btneclear.Name = "btneclear";
            btneclear.Size = new Size(100, 33);
            btneclear.TabIndex = 36;
            btneclear.Text = "CLEAR";
            btneclear.UseVisualStyleBackColor = false;
            btneclear.Click += btneclear_Click;
            // 
            // btnedelete
            // 
            btnedelete.BackColor = Color.FromArgb(98, 172, 255);
            btnedelete.FlatStyle = FlatStyle.Flat;
            btnedelete.Font = new Font("Fredoka", 14.25F);
            btnedelete.ForeColor = Color.FromArgb(5, 43, 64);
            btnedelete.Location = new Point(374, 200);
            btnedelete.Name = "btnedelete";
            btnedelete.Size = new Size(100, 33);
            btnedelete.TabIndex = 35;
            btnedelete.Text = "DELETE";
            btnedelete.UseVisualStyleBackColor = false;
            btnedelete.Click += btnedelete_Click;
            // 
            // btneupdate
            // 
            btneupdate.BackColor = Color.FromArgb(98, 172, 255);
            btneupdate.FlatStyle = FlatStyle.Flat;
            btneupdate.Font = new Font("Fredoka", 14.25F);
            btneupdate.ForeColor = Color.FromArgb(5, 43, 64);
            btneupdate.Location = new Point(253, 200);
            btneupdate.Name = "btneupdate";
            btneupdate.Size = new Size(100, 33);
            btneupdate.TabIndex = 34;
            btneupdate.Text = "UPDATE";
            btneupdate.UseVisualStyleBackColor = false;
            btneupdate.Click += btneupdate_Click;
            // 
            // btenadd
            // 
            btenadd.BackColor = Color.FromArgb(98, 172, 255);
            btenadd.FlatStyle = FlatStyle.Flat;
            btenadd.Font = new Font("Fredoka", 14.25F);
            btenadd.ForeColor = Color.FromArgb(5, 43, 64);
            btenadd.Location = new Point(147, 200);
            btenadd.Name = "btenadd";
            btenadd.Size = new Size(100, 33);
            btenadd.TabIndex = 33;
            btenadd.Text = "ADD";
            btenadd.UseVisualStyleBackColor = false;
            btenadd.Click += btenadd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(5, 43, 64);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(5, 43, 64);
            dateTimePicker1.Font = new Font("Fredoka", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(523, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 33);
            dateTimePicker1.TabIndex = 32;
            // 
            // txtedescription
            // 
            txtedescription.Font = new Font("Fredoka", 15.75F);
            txtedescription.ForeColor = Color.FromArgb(5, 43, 64);
            txtedescription.Location = new Point(523, 34);
            txtedescription.Multiline = true;
            txtedescription.Name = "txtedescription";
            txtedescription.Size = new Size(226, 85);
            txtedescription.TabIndex = 31;
            // 
            // txteamount
            // 
            txteamount.Font = new Font("Fredoka", 15.75F);
            txteamount.ForeColor = Color.FromArgb(5, 43, 64);
            txteamount.Location = new Point(155, 34);
            txteamount.Name = "txteamount";
            txteamount.Size = new Size(208, 33);
            txteamount.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(5, 43, 64);
            label7.Location = new Point(374, 140);
            label7.Name = "label7";
            label7.Size = new Size(84, 30);
            label7.TabIndex = 28;
            label7.Text = "Date : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(5, 43, 64);
            label6.Location = new Point(374, 34);
            label6.Name = "label6";
            label6.Size = new Size(153, 30);
            label6.TabIndex = 27;
            label6.Text = "Description : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(5, 43, 64);
            label5.Location = new Point(47, 34);
            label5.Name = "label5";
            label5.Size = new Size(116, 30);
            label5.TabIndex = 26;
            label5.Text = "Amount : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(5, 43, 64);
            label4.Location = new Point(80, 86);
            label4.Name = "label4";
            label4.Size = new Size(83, 30);
            label4.TabIndex = 25;
            label4.Text = "Type : ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Fredoka", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 253);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(98, 172, 255);
            dataGridViewCellStyle1.Font = new Font("Fredoka", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(5, 43, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(16, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(733, 198);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(5, 43, 64);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(148, 30);
            label2.TabIndex = 23;
            label2.Text = "Expense List";
            // 
            // addexpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 172, 255);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label11);
            Name = "addexpense";
            Size = new Size(796, 611);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label11;
        private Button button1;
        private Panel panel1;
        private Panel panel3;
        private Button btneclear;
        private Button btnedelete;
        private Button btneupdate;
        private Button btenadd;
        private DateTimePicker dateTimePicker1;
        private TextBox txtedescription;
        private TextBox txteamount;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox cmbecategory;
        private Label label3;
        private TextBox cmbetype;
    }
}
