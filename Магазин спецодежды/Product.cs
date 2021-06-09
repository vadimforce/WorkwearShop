using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магазин_спецодежды
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workwearShopDataSet);

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workwearShopDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.workwearShopDataSet.Products);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            About f2 = new About();
            f2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BugReportForm f3 = new BugReportForm();
            f3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cart f5 = new Cart();
            f5.Show();
            this.Hide();
        }
    }
}
