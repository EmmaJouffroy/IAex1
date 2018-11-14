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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            FormQuestion formQuestion = new FormQuestion();
            formQuestion.Show();
            this.Hide();
        }
    }
}
