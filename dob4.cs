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
    public partial class dob4 : Form
    {
        public dob4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zal main = this.Owner as zal;
            if (main != null)
            {
                DataRow nRow = main.kinoDataSet.Tables["Залы"].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = rc;
                nRow[2] = textBox5.Text;
                nRow[3] = textBox6.Text;



                main.kinoDataSet.Tables["Залы"].Rows.Add(nRow);
                main.залыTableAdapter.Update(main.kinoDataSet.Залы);
                main.kinoDataSet.Tables["Залы"].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox5.Text = "";
                textBox6.Text = "";

            }
        }
    }
}
