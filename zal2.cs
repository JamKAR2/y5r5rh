using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class zal2 : Form
    {
        public zal2()
        {
            InitializeComponent();
        }

        private void zal2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.kinoDataSet.Залы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poisk1 af = new poisk1();
            af.Owner = this;
            af.Show();
        }
    }
}
