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
        private List<int> questChoisies = new List<int>();

        public FormQuestion()
        {
            InitializeComponent();
            questions = serializeQuestions();
            deserializeQuestions(questions);

            chooseRandomQuestion();
            lblNumQuestion.Text = question.IDQuestion.ToString();
            lblTitreQuestion.Text = question.Intitule;
        }

        public List<Question> serializeQuestions()
        {
            string[] repquest1 = { "cc" };
            string[] repquest2 = { "cc", "ee"};
            string[] repquest3 = { "cc", "bb" };
            string[] repquest4 = { "cc", "ff", "gg" };
            string[] repquest5 = { "cc", "hh", "ii" };

            Question question1 = new Question(1 , "cc" , 2, "bb", repquest1);
            Question question2 = new Question(2, "cc", 2, "bb", repquest2);
            Question question3 = new Question(3, "cc",  2, "bb", repquest3);
            Question question4 = new Question(4, "cc",  2, "bb", repquest4);
            Question question5 = new Question(5, "cc", 2, "bb", repquest5);

            List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);

            QuestionCollection.Save("bonjour.xml", questions);
            return questions;
        }

        public void deserializeQuestions(List<Question> questions)
        {
            questions = QuestionCollection.CreateFromFile("bonjour.xml");
        }

        public void chooseRandomQuestion()
        {
            bool memeQuest = true;
            Random aleatoire = new Random();
            int numQuest = aleatoire.Next(1, 6);

            foreach (int numQuestChoisi in questChoisies)
            {
                if (question.IDQuestion.Equals(numQuestChoisi))
                {
                    memeQuest = true;
                }
                else
                {
                    memeQuest = false;
                }
            }

            do
            {
                 numQuest = aleatoire.Next(1, 5);
            }
            while (memeQuest == false);


            foreach (Question questionXML in questions)
            {
                if (questionXML.IDQuestion == numQuest)
                {
                    question = questionXML;
                }
            }
            questChoisies.Add(numQuest);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

                chooseRandomQuestion();
                lblNumQuestion.Text = question.IDQuestion.ToString();
                lblTitreQuestion.Text = question.Intitule;
        }
    }
}
