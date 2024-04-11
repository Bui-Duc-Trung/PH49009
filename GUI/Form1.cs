using DTO.Models;
using System.Data;

namespace GUI
{

    public partial class Form1 : Form
    {
        private ASM2CSHARP2Context dbContext = new ASM2CSHARP2Context();
        private DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("SupplierId", typeof(int));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("Package", typeof(string));
            dt.Columns.Add("IsDiscontinued", typeof(bool));
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLProduct qLProduct = new QLProduct();
            qLProduct.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLCustomer qLCustomer = new QLCustomer();
            qLCustomer.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLOrder qLOrder = new QLOrder();
            qLOrder.ShowDialog();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            banHang.ShowDialog();
        }
    }
}
