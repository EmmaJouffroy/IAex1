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
    public partial class FormFinDijkstra : Form
    {
        public FormFinDijkstra()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lbFermesFinaux.Enabled = false;
            lbOuvertsFinaux.Enabled = false;
            treeViewFinal.Enabled = false;
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            Form1 debut = new Form1();
            debut.Show();
            this.Hide();
        }

        private void btnExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lkExoQuestions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuestion questions = new FormQuestion();
            questions.Show();
            this.Hide();
        }
    }
}
