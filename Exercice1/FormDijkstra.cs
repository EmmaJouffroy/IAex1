using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1
{
    public partial class FormDijkstra : Form
    {
        public FormDijkstra()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lbFermes.Enabled = false;
            lbOuverts.Enabled = false;
        }

        private void btnExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lkMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormFinDijkstra correctionDijkstra = new FormFinDijkstra();
            correctionDijkstra.Show();
            this.Hide();
        }
    }
}
