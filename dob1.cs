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
    public partial class dob1 : Form
    {
        public dob1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            film main = this.Owner as film;
            if (main != null)
            {
                DataRow nRow = main.kinoDataSet.Tables["Фильмы"].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox5.Text;
                nRow[2] = textBox6.Text;
                nRow[3] = textBox7.Text;
                nRow[4] = textBox8.Text;
                nRow[5] = textBox2.Text;
                nRow[6] = textBox1.Text;


                main.kinoDataSet.Tables["Фильмы"].Rows.Add(nRow);
                main.фильмыTableAdapter.Update(main.kinoDataSet.Фильмы);
                main.kinoDataSet.Tables["Фильмы"].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }
    }
}
