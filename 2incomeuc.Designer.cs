namespace cmzz
{
    partial class addincome
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
            label11 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            cmbicategory = new ComboBox();
            label3 = new Label();
            txtiamount = new TextBox();
            txtiitem = new TextBox();
            btniclear = new Button();
            btnidelete = new Button();
            btniupdate = new Button();
            btniadd = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtidescription = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Fredoka", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(171, 27, 27);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(108, 36);
            label11.TabIndex = 19;
            label11.Text = "Income";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(5, 43, 64);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(390, 30);
            label1.TabIndex = 20;
            label1.Text = "Every Income Counts, Track It Here.";
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
            panel1.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(cmbicategory);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtiamount);
            panel3.Controls.Add(txtiitem);
            panel3.Controls.Add(btniclear);
            panel3.Controls.Add(btnidelete);
            panel3.Controls.Add(btniupdate);
            panel3.Controls.Add(btniadd);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(txtidescription);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 260);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 253);
            panel3.TabIndex = 1;
            // 
            // cmbicategory
            // 
            cmbicategory.Font = new Font("Fredoka", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbicategory.ForeColor = Color.FromArgb(5, 43, 64);
            cmbicategory.FormattingEnabled = true;
            cmbicategory.Items.AddRange(new object[] { "Primary Income", "Secondary Income" });
            cmbicategory.Location = new Point(151, 139);
            cmbicategory.Name = "cmbicategory";
            cmbicategory.Size = new Size(208, 34);
            cmbicategory.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(5, 43, 64);
            label3.Location = new Point(31, 140);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 40;
            label3.Text = "Category : ";
            // 
            // txtiamount
            // 
            txtiamount.Font = new Font("Fredoka", 15.75F);
            txtiamount.ForeColor = Color.FromArgb(5, 43, 64);
            txtiamount.Location = new Point(151, 34);
            txtiamount.Name = "txtiamount";
            txtiamount.Size = new Size(208, 33);
            txtiamount.TabIndex = 30;
            // 
            // txtiitem
            // 
            txtiitem.Font = new Font("Fredoka", 15.75F);
            txtiitem.ForeColor = Color.FromArgb(5, 43, 64);
            txtiitem.Location = new Point(151, 89);
            txtiitem.Name = "txtiitem";
            txtiitem.Size = new Size(208, 33);
            txtiitem.TabIndex = 41;
            // 
            // btniclear
            // 
            btniclear.BackColor = Color.FromArgb(98, 172, 255);
            btniclear.FlatStyle = FlatStyle.Flat;
            btniclear.Font = new Font("Fredoka", 14.25F);
            btniclear.ForeColor = Color.FromArgb(5, 43, 64);
            btniclear.Location = new Point(480, 200);
            btniclear.Name = "btniclear";
            btniclear.Size = new Size(100, 33);
            btniclear.TabIndex = 36;
            btniclear.Text = "CLEAR";
            btniclear.UseVisualStyleBackColor = false;
            btniclear.Click += btniclear_Click;
            // 
            // btnidelete
            // 
            btnidelete.BackColor = Color.FromArgb(98, 172, 255);
            btnidelete.FlatStyle = FlatStyle.Flat;
            btnidelete.Font = new Font("Fredoka", 14.25F);
            btnidelete.ForeColor = Color.FromArgb(5, 43, 64);
            btnidelete.Location = new Point(374, 200);
            btnidelete.Name = "btnidelete";
            btnidelete.Size = new Size(100, 33);
            btnidelete.TabIndex = 35;
            btnidelete.Text = "DELETE";
            btnidelete.UseVisualStyleBackColor = false;
            btnidelete.Click += btnidelete_Click;
            // 
            // btniupdate
            // 
            btniupdate.BackColor = Color.FromArgb(98, 172, 255);
            btniupdate.FlatStyle = FlatStyle.Flat;
            btniupdate.Font = new Font("Fredoka", 14.25F);
            btniupdate.ForeColor = Color.FromArgb(5, 43, 64);
            btniupdate.Location = new Point(253, 200);
            btniupdate.Name = "btniupdate";
            btniupdate.Size = new Size(100, 33);
            btniupdate.TabIndex = 34;
            btniupdate.Text = "UPDATE";
            btniupdate.UseVisualStyleBackColor = false;
            btniupdate.Click += btniupdate_Click;
            // 
            // btniadd
            // 
            btniadd.BackColor = Color.FromArgb(98, 172, 255);
            btniadd.FlatStyle = FlatStyle.Flat;
            btniadd.Font = new Font("Fredoka", 14.25F);
            btniadd.ForeColor = Color.FromArgb(5, 43, 64);
            btniadd.Location = new Point(147, 200);
            btniadd.Name = "btniadd";
            btniadd.Size = new Size(100, 33);
            btniadd.TabIndex = 33;
            btniadd.Text = "ADD";
            btniadd.UseVisualStyleBackColor = false;
            btniadd.Click += btniadd_Click;
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
            // txtidescription
            // 
            txtidescription.Font = new Font("Fredoka", 15.75F);
            txtidescription.ForeColor = Color.FromArgb(5, 43, 64);
            txtidescription.Location = new Point(523, 34);
            txtidescription.Multiline = true;
            txtidescription.Name = "txtidescription";
            txtidescription.Size = new Size(226, 85);
            txtidescription.TabIndex = 31;
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
            label4.Location = new Point(80, 89);
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
            label2.Size = new Size(133, 30);
            label2.TabIndex = 23;
            label2.Text = "Income List";
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
            button1.TabIndex = 22;
            button1.Text = "LOGOUT";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addincome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 172, 255);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label11);
            Name = "addincome";
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

        private Label label11;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtiamount;
        private TextBox txtidescription;
        private DateTimePicker dateTimePicker1;
        private Button btniclear;
        private Button btnidelete;
        private Button btniupdate;
        private Button btniadd;
        private ComboBox cmbicategory;
        private TextBox txtiitem;
        private Label label3;
    }
}
