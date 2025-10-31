using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.kinoDataSetTableAdapters;

namespace WindowsFormsApp2
{
    public partial class zal : Form
    {
        public zal()
        {
            InitializeComponent();
        }

        private void zal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.kinoDataSet.Залы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            залыTableAdapter.Update(kinoDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            poiskzal af = new poiskzal();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dob4 af = new dob4();
            af.Owner = this;
            af.Show();
        }
    }
}
