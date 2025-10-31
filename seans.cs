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
    public partial class Form1212 : Form
    {
        public Form1212()
        {
            InitializeComponent();
        }

        private void seans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            this.сеансыTableAdapter.Fill(this.kinoDataSet.Сеансы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сеансыTableAdapter.Update(kinoDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seanspoisk af = new seanspoisk();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dob3 af = new dob3();
            af.Owner = this;
            af.Show();
        }
    }
}
