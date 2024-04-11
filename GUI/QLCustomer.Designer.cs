namespace GUI
{
    partial class QLCustomer
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            dgvCustomer = new DataGridView();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            btnThem = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1069, 617);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(dgvCustomer);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1061, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DS Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(359, 42);
            label7.Name = "label7";
            label7.Size = new Size(291, 32);
            label7.TabIndex = 2;
            label7.Text = "DANH SÁCH CUSTOMER";
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(8, 120);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.RowTemplate.Height = 33;
            dgvCustomer.Size = new Size(1045, 449);
            dgvCustomer.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1061, 579);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "QL Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(txtCountry);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(664, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 563);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao Tac";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(18, 382);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(352, 34);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(18, 435);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(352, 34);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(18, 486);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(352, 34);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 333);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(352, 34);
            btnThem.TabIndex = 12;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(147, 93);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(211, 31);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(147, 136);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(211, 31);
            txtLastName.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(147, 178);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(211, 31);
            txtCity.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(147, 220);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(211, 31);
            txtCountry.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(147, 261);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(211, 31);
            txtPhone.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(147, 50);
            txtID.Name = "txtID";
            txtID.Size = new Size(211, 31);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 96);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 5;
            label6.Text = "FirstName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 4;
            label5.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 184);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 223);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 264);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 563);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Customers";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(635, 527);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // QLCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 617);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "QLCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLCustomer";
            Load += QLCustomer_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvCustomer;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private TextBox txtID;
        private Button btnSua;
        private Button btnXoa;
        private Button btnClear;
        private Button btnThem;
        private Label label7;
    }
}