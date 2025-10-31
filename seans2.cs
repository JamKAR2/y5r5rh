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
    public partial class seans2 : Form
    {
        public seans2()
        {
            InitializeComponent();
        }

        private void seans2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            this.сеансыTableAdapter.Fill(this.kinoDataSet.Сеансы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poisk3 af = new poisk3();
            af.Owner = this;
            af.Show();
        }
    }
}
