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
    public partial class QLCustomer : Form
    {
        private int _idCellClick;
        CustomerBLL _customerBLL = new CustomerBLL();
        OrderBLL _orderBLL = new OrderBLL();
        OrderItemBLL _orderitemBLL = new OrderItemBLL();
        public QLCustomer()
        {
            InitializeComponent();
            LoadGrid(dgvCustomer);
            LoadGrid(dataGridView1);
        }
        public void LoadGrid(DataGridView Name)
        {
            int stt = 1;

            Name.ColumnCount = 7;

            Name.Columns[0].Name = "STT";
            Name.Columns[1].Name = "ID";
            Name.Columns[2].Name = "FirstName";
            Name.Columns[3].Name = "LastName";
            Name.Columns[4].Name = "City";
            Name.Columns[5].Name = "Country";
            Name.Columns[6].Name = "Phone";

            Name.Rows.Clear();

            foreach (var item in _customerBLL.Getallcustomer())
            {
                Name.Rows.Add(stt++, item.Id, item.FirstName, item.LastName, item.City, item.Country, item.Phone);
            }
        }

        private void QLCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customer ct = new Customer()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
            };

            if (_customerBLL.Create(ct))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadGrid(dgvCustomer);
            LoadGrid(dataGridView1);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            _idCellClick = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[1].Value);
            var obj = _customerBLL.GetById(_idCellClick);
            if (obj != null)
            {
                txtID.Text = obj.Id.ToString();
                txtFirstName.Text = obj.FirstName;
                txtLastName.Text = obj.LastName;
                txtCity.Text = obj.City;
                txtCountry.Text = obj.Country;
                txtPhone.Text = obj.Phone;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            bool stt;
            //if (rdoTrue.Checked == true)
            //{
            //    stt = true;
            //}
            //else
            //{
            //    stt = false;
            //}

            //int supplierID = _lstSupplier[cboSupplierld.SelectedIndex];
            Customer ct = new Customer()
            {
                Id = _idCellClick,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
            };
            if (_customerBLL.Update(ct))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            LoadGrid(dgvCustomer);
            LoadGrid(dataGridView1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPhone.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var getIdOrder = _orderBLL.GetallOrderIdByCusId(_idCellClick).ToList();

            DialogResult dele = MessageBox.Show("Bạn chắc chắn muốn xoá k?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dele == DialogResult.OK)
            {
                if(getIdOrder != null)
                {
                    for (int i = 0; i < getIdOrder.Count; i++)
                    {
                        _orderitemBLL.Delete(getIdOrder[i].Id);
                    }
                }

                if (_orderBLL.Delete(_idCellClick))
                {
                    if (_customerBLL.Delete(_idCellClick))
                    {
                        MessageBox.Show("Xoa Thanh cong");
                        LoadGrid(dgvCustomer);
                        LoadGrid(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Xoa That Bai");
                    }
                }
                else
                {
                    MessageBox.Show("Xoa That Bai");
                }
                
            }
        }
    }
}
