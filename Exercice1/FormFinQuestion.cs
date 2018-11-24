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
    public partial class FormFinQuestion : Form
    {
        public FormFinQuestion(int score)
        {
            InitializeComponent();
            lblScoreNbre.Text = score.ToString()+"/20";
            if (score < 10) { lblCommentaire.Text = "Vous devriez réviser votre cours avant le partiel..."; }
            else { lblCommentaire.Text = "Bravo, vous êtes fin prêts pour ce qui arrive ! ";  }
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            Form1 debut = new Form1();
            debut.Show();
            this.Hide();
        }
    }
}
