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
    public partial class FormQuestion : Form
    {
        private List<Question> questions = new List<Question>();
        private Question question = new Question();

        public FormQuestion()
        {
            InitializeComponent();
            questions = serializeQuestions();
            deserializeQuestions(questions);
            chooseRandomQuestion();

            lblNumQuestion.Text = question.IDQuestion.ToString();
            lblTitreQuestion.Text = question.Intitule;
        }

        public List<Question>  serializeQuestions()
        {
            Question question1 = new Question();
            List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question1);
            QuestionCollection.Save("bonjour.xml", questions);
            return questions;
        }

        public void deserializeQuestions(List<Question> questions)
        {
            questions = QuestionCollection.CreateFromFile("bonjour.xml");
        }

        public void chooseRandomQuestion()
        {
            Random aleatoire = new Random();
            int numQuest= aleatoire.Next(1, 21);
            foreach(Question questionXML in questions)
            {
                if (questionXML.IDQuestion == numQuest)
                {
                    question = questionXML;
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            lblNumQuestion.Text = question.IDQuestion.ToString();

        }
    }
}
