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
    public partial class FormMENU : Form
    {
        public FormMENU()
        {
            InitializeComponent();
        }

        private void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void залыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zal2 af = new zal2();
            af.Owner = this;
            af.Show();
        }

        private void кинотеатрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kino2 af = new kino2();
            af.Owner = this;
            af.Show();
        }

        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seans2 af = new seans2();
            af.Owner = this;
            af.Show();
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            film2 af = new film2();
            af.Owner = this;
            af.Show();
        }
    }
}
