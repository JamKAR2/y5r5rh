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
    public partial class kino2 : Form
    {
        public kino2()
        {
            InitializeComponent();
        }

        private void kino2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Кинотеатры". При необходимости она может быть перемещена или удалена.
            this.кинотеатрыTableAdapter.Fill(this.kinoDataSet.Кинотеатры);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poisk2 af = new poisk2();
            af.Owner = this;
            af.Show();
        }
    }
}
