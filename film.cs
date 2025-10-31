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
    public partial class film : Form
    {
        public film()
        {
            InitializeComponent();
        }

        private void film_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.kinoDataSet.Фильмы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            фильмыTableAdapter.Update(kinoDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filmpoisk af = new filmpoisk();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dob1 af = new dob1();
            af.Owner = this;
            af.Show();
        }
    }
}
