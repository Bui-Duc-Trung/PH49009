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
    public partial class Quantity : Form
    {
        public int quantity;
        public Quantity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(textBox1.Text);
            this.Close();
        }

        private void Quantity_Load(object sender, EventArgs e)
        {

        }
    }
}
