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
    public partial class dob3 : Form
    {
        public dob3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1212 main = this.Owner as Form1212;
            if (main != null)
            {
                DataRow nRow = main.kinoDataSet.Tables["Сеансы"].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = rc;
                nRow[2] = rc;
                nRow[3] = textBox5.Text;
                nRow[4] = textBox6.Text;



                main.kinoDataSet.Tables["Сеансы"].Rows.Add(nRow);
                main.сеансыTableAdapter.Update(main.kinoDataSet.Сеансы);
                main.kinoDataSet.Tables["Сеансы"].AcceptChanges();
                main.dataGridView1.Refresh();
             
                textBox5.Text = "";
                textBox6.Text = "";

            }
        }
    }
}
