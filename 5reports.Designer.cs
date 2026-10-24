namespace cmzz
{
    partial class _5reports
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            label11 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            txtrdate = new TextBox();
            btniclear = new Button();
            btnrsearch = new Button();
            label5 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            cmbrtype = new ComboBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
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
            button1.TabIndex = 23;
            button1.Text = "LOGOUT";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Fredoka", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(171, 27, 27);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(118, 36);
            label11.TabIndex = 24;
            label11.Text = "Reports";
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
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btniclear);
            panel3.Controls.Add(btnrsearch);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 260);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 253);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(98, 172, 255);
            label4.Font = new Font("Fredoka", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(5, 43, 64);
            label4.Location = new Point(95, 121);
            label4.Name = "label4";
            label4.Size = new Size(233, 16);
            label4.TabIndex = 41;
            label4.Text = "Please use this format (YYYY-MM-DD)";
            // 
            // txtrdate
            // 
            txtrdate.BackColor = Color.Gainsboro;
            txtrdate.BorderStyle = BorderStyle.None;
            txtrdate.Font = new Font("Fredoka", 15.75F);
            txtrdate.ForeColor = Color.FromArgb(5, 43, 64);
            txtrdate.Location = new Point(105, 29);
            txtrdate.Name = "txtrdate";
            txtrdate.Size = new Size(208, 26);
            txtrdate.TabIndex = 30;
            // 
            // btniclear
            // 
            btniclear.BackColor = Color.FromArgb(98, 172, 255);
            btniclear.FlatStyle = FlatStyle.Flat;
            btniclear.Font = new Font("Fredoka", 14.25F);
            btniclear.ForeColor = Color.FromArgb(5, 43, 64);
            btniclear.Location = new Point(394, 200);
            btniclear.Name = "btniclear";
            btniclear.Size = new Size(100, 33);
            btniclear.TabIndex = 36;
            btniclear.Text = "CLEAR";
            btniclear.UseVisualStyleBackColor = false;
            btniclear.Click += btniclear_Click;
            // 
            // btnrsearch
            // 
            btnrsearch.BackColor = Color.FromArgb(98, 172, 255);
            btnrsearch.FlatStyle = FlatStyle.Flat;
            btnrsearch.Font = new Font("Fredoka", 14.25F);
            btnrsearch.ForeColor = Color.FromArgb(5, 43, 64);
            btnrsearch.Location = new Point(271, 200);
            btnrsearch.Name = "btnrsearch";
            btnrsearch.Size = new Size(100, 33);
            btnrsearch.TabIndex = 33;
            btnrsearch.Text = "SEARCH";
            btnrsearch.UseVisualStyleBackColor = false;
            btnrsearch.Click += btnrsearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(98, 172, 255);
            label5.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(5, 43, 64);
            label5.Location = new Point(15, 26);
            label5.Name = "label5";
            label5.Size = new Size(84, 30);
            label5.TabIndex = 26;
            label5.Text = "Date : ";
            label5.Click += label5_Click;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(98, 172, 255);
            dataGridViewCellStyle3.Font = new Font("Fredoka", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(5, 43, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(16, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(733, 198);
            dataGridView1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(5, 43, 64);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(170, 30);
            label2.TabIndex = 23;
            label2.Text = "Search Results";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(5, 43, 64);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(462, 30);
            label1.TabIndex = 26;
            label1.Text = "Track Progress, Understand Your Reports.";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(98, 172, 255);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtrdate);
            panel4.Location = new Point(16, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(355, 97);
            panel4.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(98, 172, 255);
            label3.Font = new Font("Fredoka", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(5, 43, 64);
            label3.Location = new Point(37, 29);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 40;
            label3.Text = "Type : ";
            // 
            // cmbrtype
            // 
            cmbrtype.BackColor = Color.Gainsboro;
            cmbrtype.Font = new Font("Fredoka", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbrtype.ForeColor = Color.FromArgb(5, 43, 64);
            cmbrtype.FormattingEnabled = true;
            cmbrtype.Items.AddRange(new object[] { "Income", "Expense" });
            cmbrtype.Location = new Point(108, 29);
            cmbrtype.Name = "cmbrtype";
            cmbrtype.Size = new Size(208, 34);
            cmbrtype.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(98, 172, 255);
            panel5.Controls.Add(cmbrtype);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(394, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(355, 97);
            panel5.TabIndex = 43;
            // 
            // _5reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 172, 255);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label11);
            Controls.Add(button1);
            Name = "_5reports";
            Size = new Size(796, 611);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label11;
        private Panel panel1;
        private Panel panel3;
        private Button btniclear;
        private Button btnrsearch;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox txtrdate;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private ComboBox cmbrtype;
        private Label label3;
        private Panel panel5;
    }
}
