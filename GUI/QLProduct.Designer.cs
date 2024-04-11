namespace GUI
{
    partial class QLProduct
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
            dgvQLProduct = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            rdoFalse = new RadioButton();
            rdoTrue = new RadioButton();
            cboSupplierld = new ComboBox();
            btnXoa = new Button();
            btnClear = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtPackagr = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtID = new TextBox();
            lblUnitPrice = new Label();
            lblPackage = new Label();
            lblIsDiscontinued = new Label();
            lblProductName = new Label();
            lblSupplierId = new Label();
            lblID = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQLProduct).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvQLProduct
            // 
            dgvQLProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQLProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLProduct.Location = new Point(6, 122);
            dgvQLProduct.Name = "dgvQLProduct";
            dgvQLProduct.RowHeadersWidth = 62;
            dgvQLProduct.RowTemplate.Height = 33;
            dgvQLProduct.Size = new Size(1045, 449);
            dgvQLProduct.TabIndex = 0;
            dgvQLProduct.CellContentClick += dgvQLProduct_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1069, 617);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvQLProduct);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1061, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DS Product";
            tabPage1.UseVisualStyleBackColor = true;
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
            tabPage2.Text = "QL Product";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoFalse);
            groupBox2.Controls.Add(rdoTrue);
            groupBox2.Controls.Add(cboSupplierld);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtPackagr);
            groupBox2.Controls.Add(txtUnitPrice);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(lblUnitPrice);
            groupBox2.Controls.Add(lblPackage);
            groupBox2.Controls.Add(lblIsDiscontinued);
            groupBox2.Controls.Add(lblProductName);
            groupBox2.Controls.Add(lblSupplierId);
            groupBox2.Controls.Add(lblID);
            groupBox2.Location = new Point(668, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 570);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao Tac";
            // 
            // rdoFalse
            // 
            rdoFalse.AutoSize = true;
            rdoFalse.Location = new Point(297, 235);
            rdoFalse.Name = "rdoFalse";
            rdoFalse.Size = new Size(75, 29);
            rdoFalse.TabIndex = 19;
            rdoFalse.TabStop = true;
            rdoFalse.Text = "False";
            rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            rdoTrue.AutoSize = true;
            rdoTrue.Location = new Point(160, 235);
            rdoTrue.Name = "rdoTrue";
            rdoTrue.Size = new Size(69, 29);
            rdoTrue.TabIndex = 18;
            rdoTrue.TabStop = true;
            rdoTrue.Text = "True";
            rdoTrue.UseVisualStyleBackColor = true;
            // 
            // cboSupplierld
            // 
            cboSupplierld.FormattingEnabled = true;
            cboSupplierld.Location = new Point(160, 104);
            cboSupplierld.Name = "cboSupplierld";
            cboSupplierld.Size = new Size(206, 33);
            cboSupplierld.TabIndex = 17;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(15, 434);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(351, 34);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(15, 493);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(351, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(15, 375);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(351, 34);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(15, 320);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(351, 34);
            btnThem.TabIndex = 13;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtPackagr
            // 
            txtPackagr.Location = new Point(160, 190);
            txtPackagr.Name = "txtPackagr";
            txtPackagr.Size = new Size(206, 31);
            txtPackagr.TabIndex = 11;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(160, 144);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(206, 31);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(160, 64);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(206, 31);
            txtProductName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(160, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(206, 31);
            txtID.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(6, 150);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(81, 25);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "UnitPrice";
            // 
            // lblPackage
            // 
            lblPackage.AutoSize = true;
            lblPackage.Location = new Point(6, 193);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(76, 25);
            lblPackage.TabIndex = 5;
            lblPackage.Text = "Package";
            // 
            // lblIsDiscontinued
            // 
            lblIsDiscontinued.AutoSize = true;
            lblIsDiscontinued.Location = new Point(6, 235);
            lblIsDiscontinued.Name = "lblIsDiscontinued";
            lblIsDiscontinued.Size = new Size(129, 25);
            lblIsDiscontinued.TabIndex = 4;
            lblIsDiscontinued.Text = "IsDiscontinued";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 67);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(121, 25);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "ProductName";
            // 
            // lblSupplierId
            // 
            lblSupplierId.AutoSize = true;
            lblSupplierId.Location = new Point(6, 107);
            lblSupplierId.Name = "lblSupplierId";
            lblSupplierId.Size = new Size(124, 25);
            lblSupplierId.TabIndex = 2;
            lblSupplierId.Text = "SupplierName";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(6, 27);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 25);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 570);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(645, 540);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(373, 37);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH PRODUCT";
            // 
            // QLProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 617);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "QLProduct";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLProduct";
            Load += QLProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLProduct).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvQLProduct;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label lblID;
        private Label lblUnitPrice;
        private Label lblPackage;
        private Label lblIsDiscontinued;
        private Label lblProductName;
        private Label lblSupplierId;
        private Button btnXoa;
        private Button btnClear;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtPackagr;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtID;
        private ComboBox cboSupplierld;
        private RadioButton rdoFalse;
        private RadioButton rdoTrue;
        private Label label1;
    }
}