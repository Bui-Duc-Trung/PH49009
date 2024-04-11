namespace GUI
{
    partial class BanHang
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
            grpListProduct = new GroupBox();
            dgvListProduct = new DataGridView();
            grpSPDangChon = new GroupBox();
            dgvSPDangChon = new DataGridView();
            txtTimKiemSP = new TextBox();
            cboKhachHang = new ComboBox();
            label1 = new Label();
            btnDatHang = new Button();
            txtTongTien = new TextBox();
            label2 = new Label();
            grpListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            grpSPDangChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSPDangChon).BeginInit();
            SuspendLayout();
            // 
            // grpListProduct
            // 
            grpListProduct.Controls.Add(dgvListProduct);
            grpListProduct.Location = new Point(12, 75);
            grpListProduct.Name = "grpListProduct";
            grpListProduct.Size = new Size(1045, 263);
            grpListProduct.TabIndex = 0;
            grpListProduct.TabStop = false;
            grpListProduct.Text = "List Product";
            // 
            // dgvListProduct
            // 
            dgvListProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.Location = new Point(6, 30);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowHeadersWidth = 62;
            dgvListProduct.RowTemplate.Height = 33;
            dgvListProduct.Size = new Size(1033, 225);
            dgvListProduct.TabIndex = 0;
            dgvListProduct.CellDoubleClick += dgvListProduct_CellDoubleClick;
            // 
            // grpSPDangChon
            // 
            grpSPDangChon.Controls.Add(dgvSPDangChon);
            grpSPDangChon.Location = new Point(12, 344);
            grpSPDangChon.Name = "grpSPDangChon";
            grpSPDangChon.Size = new Size(1045, 261);
            grpSPDangChon.TabIndex = 1;
            grpSPDangChon.TabStop = false;
            grpSPDangChon.Text = "Product Dang Chon";
            // 
            // dgvSPDangChon
            // 
            dgvSPDangChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSPDangChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSPDangChon.Location = new Point(6, 30);
            dgvSPDangChon.Name = "dgvSPDangChon";
            dgvSPDangChon.RowHeadersWidth = 62;
            dgvSPDangChon.RowTemplate.Height = 33;
            dgvSPDangChon.Size = new Size(1033, 225);
            dgvSPDangChon.TabIndex = 0;
            dgvSPDangChon.CellClick += dgvSPDangChon_CellClick;
            dgvSPDangChon.CellEndEdit += dgvSPDangChon_CellEndEdit;
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.Location = new Point(12, 28);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(418, 31);
            txtTimKiemSP.TabIndex = 2;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(579, 28);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(266, 33);
            cboKhachHang.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 4;
            label1.Text = "Khach hang";
            // 
            // btnDatHang
            // 
            btnDatHang.Location = new Point(1322, 25);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(112, 34);
            btnDatHang.TabIndex = 5;
            btnDatHang.Text = "Dat Hang";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(1035, 30);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(222, 31);
            txtTongTien.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(909, 31);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 7;
            label2.Text = "Tong tien";
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 617);
            Controls.Add(label2);
            Controls.Add(txtTongTien);
            Controls.Add(btnDatHang);
            Controls.Add(label1);
            Controls.Add(cboKhachHang);
            Controls.Add(txtTimKiemSP);
            Controls.Add(grpSPDangChon);
            Controls.Add(grpListProduct);
            Name = "BanHang";
            Text = "BanHang";
            grpListProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            grpSPDangChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSPDangChon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpListProduct;
        private GroupBox grpSPDangChon;
        private TextBox txtTimKiemSP;
        private ComboBox cboKhachHang;
        private Label label1;
        private DataGridView dgvListProduct;
        private DataGridView dgvSPDangChon;
        private Button btnDatHang;
        private TextBox txtTongTien;
        private Label label2;
    }
}