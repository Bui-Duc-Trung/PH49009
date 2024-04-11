namespace GUI
{
    partial class QLOrder
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
            dgvOrder = new DataGridView();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            cboCustomerPhone = new ComboBox();
            btnClear = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTotalAmount = new TextBox();
            txtOrderNumber = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
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
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1069, 617);
            tabControl1.TabIndex = 0;
            tabControl1.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dgvOrder);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1061, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Order";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.UseWaitCursor = true;
            // 
            // dgvOrder
            // 
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(3, 119);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.Size = new Size(1052, 449);
            dgvOrder.TabIndex = 0;
            dgvOrder.UseWaitCursor = true;
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
            tabPage2.Text = "QL Order";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboCustomerPhone);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtTotalAmount);
            groupBox2.Controls.Add(txtOrderNumber);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(667, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 562);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao Tac";
            groupBox2.UseWaitCursor = true;
            // 
            // cboCustomerPhone
            // 
            cboCustomerPhone.FormattingEnabled = true;
            cboCustomerPhone.Location = new Point(172, 175);
            cboCustomerPhone.Name = "cboCustomerPhone";
            cboCustomerPhone.Size = new Size(205, 33);
            cboCustomerPhone.TabIndex = 14;
            cboCustomerPhone.UseWaitCursor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(25, 507);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(339, 34);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.UseWaitCursor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(25, 444);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(339, 34);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.UseWaitCursor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(25, 383);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(339, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.UseWaitCursor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 318);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(339, 34);
            btnThem.TabIndex = 10;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.UseWaitCursor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(172, 221);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(205, 31);
            txtTotalAmount.TabIndex = 9;
            txtTotalAmount.UseWaitCursor = true;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(172, 127);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(205, 31);
            txtOrderNumber.TabIndex = 7;
            txtOrderNumber.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(172, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(205, 31);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(172, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(205, 31);
            txtID.TabIndex = 5;
            txtID.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 87);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 4;
            label5.Text = "OrderDate";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 130);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 3;
            label4.Text = "OrderNumber";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 178);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 2;
            label3.Text = "Customer Phone";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 224);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "TotalAmount";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 43);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 562);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Order";
            groupBox1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(628, 526);
            dataGridView1.TabIndex = 0;
            dataGridView1.UseWaitCursor = true;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(378, 38);
            label6.Name = "label6";
            label6.Size = new Size(244, 32);
            label6.TabIndex = 2;
            label6.Text = "DANH SÁCH ORDER";
            // 
            // QLOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 617);
            Controls.Add(tabControl1);
            Name = "QLOrder";
            Text = "QLOrder";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
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
        private DataGridView dgvOrder;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTotalAmount;
        private TextBox txtOrderNumber;
        private DateTimePicker dateTimePicker1;
        private Button btnClear;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboCustomerPhone;
        private Label label6;
    }
}