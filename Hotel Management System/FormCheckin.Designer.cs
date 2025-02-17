
namespace Hotel_Management_System
{
    partial class FormCheckin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckin));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbloginDataSet8 = new Hotel_Management_System.cmbloginDataSet8();
            this.checkInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkInTableAdapter = new Hotel_Management_System.cmbloginDataSet8TableAdapters.CheckInTableAdapter();
            this.cmbloginDataSet9 = new Hotel_Management_System.cmbloginDataSet9();
            this.checkInBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkInTableAdapter1 = new Hotel_Management_System.cmbloginDataSet9TableAdapters.CheckInTableAdapter();
            this.cmbloginDataSet10 = new Hotel_Management_System.cmbloginDataSet10();
            this.checkInBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.checkInTableAdapter2 = new Hotel_Management_System.cmbloginDataSet10TableAdapters.CheckInTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1007, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(870, -5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 44);
            this.button3.TabIndex = 25;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1129, -4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 44);
            this.button4.TabIndex = 26;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "NAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(931, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "ADDRESS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(561, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "NID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(798, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "CHECK-IN DATE";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(47, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "PHONE NO.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label13.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(866, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 22);
            this.label13.TabIndex = 32;
            this.label13.Text = "CUSTOMER INFO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(410, 540);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 22);
            this.label14.TabIndex = 33;
            this.label14.Text = "NUMBER OF PERSON";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.Location = new System.Drawing.Point(191, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox2.Location = new System.Drawing.Point(621, 469);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 22);
            this.textBox2.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1253, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox3.Location = new System.Drawing.Point(1039, 469);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 22);
            this.textBox3.TabIndex = 37;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 537);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 22);
            this.textBox4.TabIndex = 38;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1039, 536);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 22);
            this.textBox7.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(621, 537);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 42;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(969, 61);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 44;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(736, -4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 44);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbloginDataSet8
            // 
            this.cmbloginDataSet8.DataSetName = "cmbloginDataSet8";
            this.cmbloginDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkInBindingSource
            // 
            this.checkInBindingSource.DataMember = "CheckIn";
            this.checkInBindingSource.DataSource = this.cmbloginDataSet8;
            // 
            // checkInTableAdapter
            // 
            this.checkInTableAdapter.ClearBeforeFill = true;
            // 
            // cmbloginDataSet9
            // 
            this.cmbloginDataSet9.DataSetName = "cmbloginDataSet9";
            this.cmbloginDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkInBindingSource1
            // 
            this.checkInBindingSource1.DataMember = "CheckIn";
            this.checkInBindingSource1.DataSource = this.cmbloginDataSet9;
            // 
            // checkInTableAdapter1
            // 
            this.checkInTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbloginDataSet10
            // 
            this.cmbloginDataSet10.DataSetName = "cmbloginDataSet10";
            this.cmbloginDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkInBindingSource2
            // 
            this.checkInBindingSource2.DataMember = "CheckIn";
            this.checkInBindingSource2.DataSource = this.cmbloginDataSet10;
            // 
            // checkInTableAdapter2
            // 
            this.checkInTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.nIDDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.numberOfPersonDataGridViewTextBoxColumn,
            this.customerInfoDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkInBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 567);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 237);
            this.dataGridView1.TabIndex = 45;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nIDDataGridViewTextBoxColumn
            // 
            this.nIDDataGridViewTextBoxColumn.DataPropertyName = "NID";
            this.nIDDataGridViewTextBoxColumn.HeaderText = "NID";
            this.nIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIDDataGridViewTextBoxColumn.Name = "nIDDataGridViewTextBoxColumn";
            this.nIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfPersonDataGridViewTextBoxColumn
            // 
            this.numberOfPersonDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPerson";
            this.numberOfPersonDataGridViewTextBoxColumn.HeaderText = "NumberOfPerson";
            this.numberOfPersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfPersonDataGridViewTextBoxColumn.Name = "numberOfPersonDataGridViewTextBoxColumn";
            this.numberOfPersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerInfoDataGridViewTextBoxColumn
            // 
            this.customerInfoDataGridViewTextBoxColumn.DataPropertyName = "CustomerInfo";
            this.customerInfoDataGridViewTextBoxColumn.HeaderText = "CustomerInfo";
            this.customerInfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerInfoDataGridViewTextBoxColumn.Name = "customerInfoDataGridViewTextBoxColumn";
            this.customerInfoDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "Check-InDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "Check-InDate";
            this.checkInDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1249, 808);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckin";
            this.Text = "FormCheckin";
            this.Load += new System.EventHandler(this.FormCheckin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAdd;
        private cmbloginDataSet8 cmbloginDataSet8;
        private System.Windows.Forms.BindingSource checkInBindingSource;
        private cmbloginDataSet8TableAdapters.CheckInTableAdapter checkInTableAdapter;
        private cmbloginDataSet9 cmbloginDataSet9;
        private System.Windows.Forms.BindingSource checkInBindingSource1;
        private cmbloginDataSet9TableAdapters.CheckInTableAdapter checkInTableAdapter1;
        private cmbloginDataSet10 cmbloginDataSet10;
        private System.Windows.Forms.BindingSource checkInBindingSource2;
        private cmbloginDataSet10TableAdapters.CheckInTableAdapter checkInTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
    }
}