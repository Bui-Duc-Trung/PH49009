using BLL;
using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QLProduct : Form
    {
        private ASM2CSHARP2Context dbContextt = new ASM2CSHARP2Context();
        private DataTable dtPro = new DataTable();
        ProductBLL _productBLL = new ProductBLL();
        SupplierBLL _supplierBll = new SupplierBLL();
        List<int> _lstSupplier = new List<int>();
        OrderItemBLL _OIBLL = new OrderItemBLL();

        private int _idCellClick;
        public QLProduct()
        {
            InitializeComponent();
            LoadGrid(dgvQLProduct);
            LoadGrid(dataGridView1);
            LoadCmb();
        }

        private void QLProduct_Load(object sender, EventArgs e)
        {
            dgvQLProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadCmb()
        {
            foreach (var item in _supplierBll.GetAllSupplier())
            {
                cboSupplierld.Items.Add(item.CompanyName);
                _lstSupplier.Add(item.Id);

                cboSupplierld.SelectedIndex = 0;
            }
        }

        public void LoadGrid(DataGridView Name)
        {
            int stt = 1;

            Name.ColumnCount = 7;

            Name.Columns[0].Name = "STT";
            Name.Columns[1].Name = "ID";
            Name.Columns[2].Name = "ProductName";
            Name.Columns[3].Name = "SupplierName";
            Name.Columns[4].Name = "UnitPrice";
            Name.Columns[5].Name = "Package";
            Name.Columns[6].Name = "IsDiscontinued";

            Name.Rows.Clear();

            foreach (var item in _productBLL.Getallproduct())
            {
                var nameSupplier = _supplierBll.GetById(item.SupplierId).CompanyName;
                Name.Rows.Add(stt++, item.Id, item.ProductName, nameSupplier, item.UnitPrice, item.Package, item.IsDiscontinued);
            }
        }


        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool stt;
            if (rdoTrue.Checked == true)
            {
                stt = true;
            }
            else
            {
                stt = false;
            }

            int supplierID = _lstSupplier[cboSupplierld.SelectedIndex];
            Product pr = new Product()
            {
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                Package = txtPackagr.Text,
                IsDiscontinued = stt,
                SupplierId = supplierID,
            };

            if (_productBLL.Create(pr))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadGrid(dgvQLProduct);
            LoadGrid(dataGridView1);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool stt;
            if (rdoTrue.Checked == true)
            {
                stt = true;
            }
            else
            {
                stt = false;
            }

            int supplierID = _lstSupplier[cboSupplierld.SelectedIndex];
            Product pr = new Product()
            {
                Id = _idCellClick,
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                Package = txtPackagr.Text,
                IsDiscontinued = stt,
                SupplierId = supplierID,
            };

            if (_productBLL.Update(pr))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            LoadGrid(dgvQLProduct);
            LoadGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            _idCellClick = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[1].Value);
            var obj = _productBLL.GetById(_idCellClick);

            if (obj != null)
            {
                txtID.Text = obj.Id.ToString();
                txtProductName.Text = obj.ProductName.ToString();
                txtUnitPrice.Text = obj.UnitPrice.ToString();
                txtPackagr.Text = obj.Package;
                if (obj.IsDiscontinued == true)
                {
                    rdoTrue.Checked = true;
                }
                else
                {
                    rdoFalse.Checked = true;
                }
                cboSupplierld.SelectedIndex = _lstSupplier.FindIndex(x => x == obj.SupplierId);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dele = MessageBox.Show("Bạn chắc chắn muốn xoá k?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (dele == DialogResult.OK)
            {
                if (_OIBLL.Delete(_idCellClick))
                {
                    if (_productBLL.Delete(_idCellClick))
                    {
                        MessageBox.Show("Xoá Thành Công");
                        LoadGrid(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại1");
                    }
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtPackagr.Clear();
        }

        private void dgvQLProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
} 

