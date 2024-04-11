using BLL;
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
    public partial class BanHang : Form
    {
        ProductBLL _productBLL = new ProductBLL();
        SupplierBLL _supplierBll = new SupplierBLL();
        CustomerBLL _customerBLL = new CustomerBLL();
        OrderBLL _orderBLL = new OrderBLL();
        OrderItemBLL _orderItemBLL = new OrderItemBLL();

        List<int> _lstcustomer = new List<int>();
        List<FakeDataOrder> _lstFDO = new List<FakeDataOrder>();

        private int _idCellClickListPro;
        private int _idCellClickChosePro;
        private decimal _total = 0;
        public BanHang()
        {
            InitializeComponent();
            LoadGrid();

        }

        public void LoadGrid()
        {

            int stt = 1;

            dgvListProduct.ColumnCount = 7;

            dgvListProduct.Columns[0].Name = "STT";
            dgvListProduct.Columns[1].Name = "ID";
            dgvListProduct.Columns[2].Name = "ProductName";
            dgvListProduct.Columns[3].Name = "SupplierName";
            dgvListProduct.Columns[4].Name = "UnitPrice";
            dgvListProduct.Columns[5].Name = "Package";
            dgvListProduct.Columns[6].Name = "IsDiscontinued";

            dgvListProduct.Rows.Clear();

            foreach (var item in _productBLL.Getallproduct())
            {
                var nameSupplier = _supplierBll.GetById(item.SupplierId).CompanyName;
                dgvListProduct.Rows.Add(stt++, item.Id, item.ProductName, nameSupplier, item.UnitPrice, item.Package, item.IsDiscontinued == true ? "Hoat Dong" : "Khong Hoat Dong");
                foreach (DataGridViewRow row in dgvListProduct.Rows)
                {
                    if (row.Cells[6].Value == "Khong Hoat Dong")
                    {
                        row.Visible = false;
                    }
                }
            }

            foreach (var item in _customerBLL.Getallcustomer())
            {
                cboKhachHang.Items.Add(item.FirstName);
                _lstcustomer.Add(item.Id);

                cboKhachHang.SelectedIndex = 0;
            }

        }

        public void dgvListProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _idCellClickListPro = Convert.ToInt32(dgvListProduct.Rows[e.RowIndex].Cells[1].Value);
            string namePro = dgvListProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            Quantity quantity = new Quantity();
            quantity.ShowDialog();
            int soLuong = quantity.quantity;
            decimal total = Convert.ToDecimal((_productBLL.GetById(_idCellClickListPro).UnitPrice) * soLuong);
            FakeDataOrder FDO = new FakeDataOrder()
            {
                ID = _lstFDO.Count + 1,
                productId = _idCellClickListPro,
                name = namePro,
                quantity = soLuong,
                price = total,
            };

            _lstFDO.Add(FDO);
            TotalBill();
            loadGridChose();


        }

        private void loadGridChose()
        {
            dgvSPDangChon.Rows.Clear();

            dgvSPDangChon.ColumnCount = 5;

            dgvSPDangChon.Columns[0].Name = "Id";
            dgvSPDangChon.Columns[1].Name = "ProductName";
            dgvSPDangChon.Columns[2].Name = "quantity";
            dgvSPDangChon.Columns[3].Name = "Total";
            dgvSPDangChon.Columns[4].Name = "Delete";

            foreach (var item in _lstFDO)
            {
                dgvSPDangChon.Rows.Add(item.ID, item.name, item.quantity, item.price);

            }
        }

        private void dgvSPDangChon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int newQuantity = Convert.ToInt32(dgvSPDangChon.Rows[e.RowIndex].Cells[2].Value);
            decimal newTotal = Convert.ToDecimal((_productBLL.GetById(_idCellClickListPro).UnitPrice) * newQuantity);
            var obj = _lstFDO.Where(x => x.ID == _idCellClickChosePro).FirstOrDefault();
            if (obj != null)
            {
                obj.quantity = newQuantity;
                obj.price = newTotal;
            }
            TotalBill();
            loadGridChose();
        }

        private void TotalBill()
        {
            _total = 0;

            if (_lstFDO.Count == 0)
            {
                txtTongTien.Text = "0";
            }

            for (int i = 0; i < _lstFDO.Count; i++)
            {
                _total += _lstFDO[i].price;
            }

            txtTongTien.Text = _total.ToString();


        }

        private void dgvSPDangChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idCellClickChosePro = Convert.ToInt32(dgvSPDangChon.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                OrderDate = DateTime.Now.Date,
                CustomerId = _lstcustomer[cboKhachHang.SelectedIndex],
                TotalAmount = _total
            };

            if (_orderBLL.Create(order))
            {
                int check = 0;
                for (int i = 0; i < _lstFDO.Count; i++)
                {
                    decimal unitPrice1 = Convert.ToDecimal(_productBLL.GetById(_lstFDO[i].productId).UnitPrice);

                    OrderItem item = new OrderItem()
                    {
                        OrderId = order.Id,
                        Quantity = _lstFDO[i].quantity,
                        ProductId = _lstFDO[i].productId,
                        UnitPrice = unitPrice1
                    };

                    _orderItemBLL.Create(item);
                    check++;
                }
                if (check == _lstFDO.Count)
                {
                    MessageBox.Show("Oder thanh cong");
                    _lstFDO.Clear();
                    _total = 0;
                    TotalBill();
                    LoadGrid();
                }
                dgvSPDangChon.Rows.Clear();

            }
        }
    }
}
