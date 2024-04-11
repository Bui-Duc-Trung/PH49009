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
    public partial class QLOrder : Form
    {
        OrderBLL _OrderBLL = new OrderBLL();
        //ProductBLL _productBLL = new ProductBLL();
        CustomerBLL _CustomerBLL = new CustomerBLL();
        ProductBLL _productBLL = new ProductBLL();
        List<int> _lstCustomer = new List<int>();

        private int _idCellClick;
        public QLOrder()
        {
            InitializeComponent();
            LoadGrid(dgvOrder);
            LoadGrid(dataGridView1);
            LoadCmb();
        }
        public void LoadCmb()
        {
            foreach (var item in _CustomerBLL.Getallcustomer())
            {
                cboCustomerPhone.Items.Add(item.Phone);
                _lstCustomer.Add(item.Id);

                cboCustomerPhone.SelectedIndex = 0;
            }
        }
        public void LoadGrid(DataGridView Name)
        {
            int stt = 1;

            Name.ColumnCount = 7;

            Name.Columns[0].Name = "STT";
            Name.Columns[1].Name = "ID";
            Name.Columns[2].Name = "OrderDate";
            Name.Columns[3].Name = "OrderNumber";
            Name.Columns[4].Name = "CustomerFirstName";
            Name.Columns[5].Name = "CustomerPhone";
            Name.Columns[6].Name = "TotalAmount";

            Name.Rows.Clear();

            foreach (var item in _OrderBLL.GetallOrder())
            {
                var CustomerFirstName = _CustomerBLL.GetById(item.CustomerId).FirstName;
                var CustomerPhone = _CustomerBLL.GetById(item.CustomerId).Phone;
                Name.Rows.Add(stt++, item.Id, item.OrderDate, item.OrderNumber, CustomerFirstName, CustomerPhone, item.TotalAmount);
            }

           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool stt;
            int CustomerID = _lstCustomer[cboCustomerPhone.SelectedIndex];
            Order order = new Order()
            {
                OrderDate = DateTime.Now,
                OrderNumber = txtOrderNumber.Text,
                CustomerId = CustomerID,
                TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
            };
            if (_OrderBLL.Create(order))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadGrid(dgvOrder);
            LoadGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            _idCellClick = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[1].Value);
            var obj = _OrderBLL.GetById(_idCellClick);

            if (obj != null)
            {
                txtID.Text = obj.Id.ToString();
                dateTimePicker1.Value = obj.OrderDate;
                txtOrderNumber.Text = obj.OrderNumber;
                cboCustomerPhone.SelectedIndex = _lstCustomer.FindIndex(x => x == obj.CustomerId);
                txtTotalAmount.Text = obj.TotalAmount.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtOrderNumber.Clear();
            txtTotalAmount.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            int customerID = _lstCustomer[cboCustomerPhone.SelectedIndex];
            Order order = new Order()       
            {
                Id = _idCellClick,
                OrderDate = dateTimePicker1.Value,
                OrderNumber = txtOrderNumber.Text,
                CustomerId = customerID,
                TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
              
            };

            if (_OrderBLL.Update(order))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            LoadGrid(dgvOrder);
            LoadGrid(dataGridView1);
        }
    }
}
