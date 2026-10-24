namespace cmzz
{
    partial class category
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
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btncdelete = new Button();
            btncclear = new Button();
            btncupdate = new Button();
            btncadd = new Button();
            cmbcstatus = new ComboBox();
            cmbctype = new ComboBox();
            cmbccategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(5, 43, 64);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(435, 30);
            label1.TabIndex = 24;
            label1.Text = "Set Clear Categories, Manage Smarter.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Fredoka", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(171, 27, 27);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(138, 36);
            label11.TabIndex = 23;
            label11.Text = "Category";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(10, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 514);
            panel1.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(263, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 502);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Fredoka", 17.9999981F);
            label5.ForeColor = Color.FromArgb(5, 43, 64);
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(131, 30);
            label5.TabIndex = 24;
            label5.Text = "Categories";
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
            dataGridView1.Location = new Point(16, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(475, 446);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btncdelete);
            panel2.Controls.Add(btncclear);
            panel2.Controls.Add(btncupdate);
            panel2.Controls.Add(btncadd);
            panel2.Controls.Add(cmbcstatus);
            panel2.Controls.Add(cmbctype);
            panel2.Controls.Add(cmbccategory);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 502);
            panel2.TabIndex = 0;
            // 
            // btncdelete
            // 
            btncdelete.BackColor = Color.FromArgb(98, 172, 255);
            btncdelete.FlatStyle = FlatStyle.Popup;
            btncdelete.Font = new Font("Fredoka", 14.25F);
            btncdelete.ForeColor = Color.FromArgb(5, 43, 64);
            btncdelete.ImageAlign = ContentAlignment.MiddleLeft;
            btncdelete.Location = new Point(26, 451);
            btncdelete.Name = "btncdelete";
            btncdelete.Size = new Size(95, 37);
            btncdelete.TabIndex = 23;
            btncdelete.Text = "DELETE";
            btncdelete.UseVisualStyleBackColor = false;
            btncdelete.Click += btncdelete_Click;
            // 
            // btncclear
            // 
            btncclear.BackColor = Color.FromArgb(98, 172, 255);
            btncclear.FlatStyle = FlatStyle.Popup;
            btncclear.Font = new Font("Fredoka", 14.25F);
            btncclear.ForeColor = Color.FromArgb(5, 43, 64);
            btncclear.ImageAlign = ContentAlignment.MiddleLeft;
            btncclear.Location = new Point(140, 451);
            btncclear.Name = "btncclear";
            btncclear.Size = new Size(95, 37);
            btncclear.TabIndex = 22;
            btncclear.Text = "CLEAR";
            btncclear.UseVisualStyleBackColor = false;
            btncclear.Click += btncclear_Click;
            // 
            // btncupdate
            // 
            btncupdate.BackColor = Color.FromArgb(98, 172, 255);
            btncupdate.FlatStyle = FlatStyle.Popup;
            btncupdate.Font = new Font("Fredoka", 14.25F);
            btncupdate.ForeColor = Color.FromArgb(5, 43, 64);
            btncupdate.ImageAlign = ContentAlignment.MiddleLeft;
            btncupdate.Location = new Point(140, 388);
            btncupdate.Name = "btncupdate";
            btncupdate.Size = new Size(95, 37);
            btncupdate.TabIndex = 21;
            btncupdate.Text = "UPDATE";
            btncupdate.UseVisualStyleBackColor = false;
            btncupdate.Click += btncupdate_Click;
            // 
            // btncadd
            // 
            btncadd.BackColor = Color.FromArgb(98, 172, 255);
            btncadd.FlatStyle = FlatStyle.Popup;
            btncadd.Font = new Font("Fredoka", 14.25F);
            btncadd.ForeColor = Color.FromArgb(5, 43, 64);
            btncadd.ImageAlign = ContentAlignment.MiddleLeft;
            btncadd.Location = new Point(26, 388);
            btncadd.Name = "btncadd";
            btncadd.Size = new Size(95, 37);
            btncadd.TabIndex = 20;
            btncadd.Text = "ADD";
            btncadd.UseVisualStyleBackColor = false;
            btncadd.Click += btncadd_Click;
            // 
            // cmbcstatus
            // 
            cmbcstatus.Font = new Font("Fredoka", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbcstatus.ForeColor = Color.FromArgb(5, 43, 64);
            cmbcstatus.FormattingEnabled = true;
            cmbcstatus.Items.AddRange(new object[] { "Active", "Non - Avtive" });
            cmbcstatus.Location = new Point(26, 293);
            cmbcstatus.Name = "cmbcstatus";
            cmbcstatus.Size = new Size(209, 34);
            cmbcstatus.TabIndex = 19;
            // 
            // cmbctype
            // 
            cmbctype.Font = new Font("Fredoka", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbctype.ForeColor = Color.FromArgb(5, 43, 64);
            cmbctype.FormattingEnabled = true;
            cmbctype.Items.AddRange(new object[] { "Income", "Expense" });
            cmbctype.Location = new Point(26, 172);
            cmbctype.Name = "cmbctype";
            cmbctype.Size = new Size(209, 34);
            cmbctype.TabIndex = 18;
            // 
            // cmbccategory
            // 
            cmbccategory.Font = new Font("Fredoka", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbccategory.ForeColor = Color.FromArgb(5, 43, 64);
            cmbccategory.FormattingEnabled = true;
            cmbccategory.Location = new Point(26, 53);
            cmbccategory.Name = "cmbccategory";
            cmbccategory.Size = new Size(209, 34);
            cmbccategory.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Fredoka", 17.9999981F);
            label4.ForeColor = Color.FromArgb(5, 43, 64);
            label4.Location = new Point(3, 249);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 9;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Fredoka", 17.9999981F);
            label3.ForeColor = Color.FromArgb(5, 43, 64);
            label3.Location = new Point(3, 126);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 8;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fredoka", 17.9999981F);
            label2.ForeColor = Color.FromArgb(5, 43, 64);
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(98, 172, 255);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(5, 43, 64);
            button4.Image = Properties.Resources.icons8_logout_26;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(642, 3);
            button4.Name = "button4";
            button4.Size = new Size(151, 45);
            button4.TabIndex = 26;
            button4.Text = "LOGOUT";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 172, 255);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label11);
            Name = "category";
            Size = new Size(796, 611);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label11;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbccategory;
        private ComboBox cmbcstatus;
        private ComboBox cmbctype;
        private Button btncdelete;
        private Button btncclear;
        private Button btncupdate;
        private Button btncadd;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button4;
    }
}
