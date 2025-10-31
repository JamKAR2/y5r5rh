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
    public partial class kino : Form
    {
        public kino()
        {
            InitializeComponent();
        }

        private void kino_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Кинотеатры". При необходимости она может быть перемещена или удалена.
            this.кинотеатрыTableAdapter.Fill(this.kinoDataSet.Кинотеатры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            кинотеатрыTableAdapter.Update(kinoDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kinopoisk af = new kinopoisk();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dob2 af = new dob2();
            af.Owner = this;
            af.Show();
        }
    }
}
