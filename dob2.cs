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
    public partial class dob2 : Form
    {
        public dob2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kino main = this.Owner as kino;
            if (main != null)
            {
                DataRow nRow = main.kinoDataSet.Tables["Кинотеатры"].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox5.Text;
                nRow[2] = textBox6.Text;
                nRow[3] = textBox1.Text;



                main.kinoDataSet.Tables["Кинотеатры"].Rows.Add(nRow);
                main.кинотеатрыTableAdapter.Update(main.kinoDataSet.Кинотеатры);
                main.kinoDataSet.Tables["Кинотеатры"].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox5.Text = "";
                textBox6.Text = "";
                textBox1.Text = "";

            }
        }
    }
}
