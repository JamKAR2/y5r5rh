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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void залыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zal af = new zal();
            af.Owner = this;
            af.Show();
        }

        private void кинотеатрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kino af = new kino();
            af.Owner = this;
            af.Show();
        }

        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1212 af = new Form1212();
            af.Owner = this;
            af.Show();
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            film af = new film();
            af.Owner = this;
            af.Show();
        }
    }
}
