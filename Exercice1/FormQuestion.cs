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
        private int compteur = 0;
        private int score = 0;
        private string reponse = "";

        public FormQuestion() // Normalement cette fonction là est bonne
        {
            InitializeComponent();
            questions = serializeQuestions();
            deserializeQuestions(questions);
            lblNoRepChecked.Visible = false;
            chooseRandomQuestion();
            lblBonneRep.Text = reponse;
            lblNumQuestion.Text = compteur.ToString();
            lblTitreQuestion.Text = question.Intitule;
            clbReponses.Items.AddRange(question.Reponses);
            
        }

        public List<Question> serializeQuestions() // Celle-ci est bonne, il ne reste plus qu'à mettre les bonnes questions dedans, ainsi que les bonnes réponses associées aux questions
        {
            string[] repquest1 = { "cc" };
            string[] repquest2 = { "cc", "ee"};
            string[] repquest3 = { "cc", "bb" };
            string[] repquest4 = { "cc", "ff", "gg" };
            string[] repquest5 = { "cc", "hh", "ii" };

            Question question1 = new Question(1 , "question1" , 0, "bb", repquest1);
            Question question2 = new Question(2, "question2", 0, "bb", repquest2);
            Question question3 = new Question(3, "question3",  0, "bb", repquest3);
            Question question4 = new Question(4, "question4",  0, "bb", repquest4);
            Question question5 = new Question(5, "question5", 0, "bb", repquest5);

            List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);

            QuestionCollection.Save("bonjour.xml", questions);
            return questions;
        }

        public void deserializeQuestions(List<Question> questions)  // Ca c'est bon, permet de déserializer le fichier XML et de mettre le résultat dans une liste de questions
        {
            questions = QuestionCollection.CreateFromFile("bonjour.xml");
        }

        public void chooseRandomQuestion() // permet de choisir aléatoirement la question que l'on va traiter. Reste plus qu'à faire en sorte que le numéro choisi n'a pas encore été choisi pour le moment. 
        {
            bool sortie = true;
            Random aleatoire = new Random();
            int numQuest = 0;
            while (sortie == true)
            {
                numQuest = aleatoire.Next(0, questions.Count());
                if(questions[numQuest].Choisie == true)
                {
                     numQuest = aleatoire.Next(0, questions.Count());
                }
                else {
                    sortie = false;
                    question = questions[numQuest];
                    reponse = question.Reponses[question.ID_BonneReponse];
                    question.Choisie = true;
                    compteur++;

                }
            }

        }

        private void btnValider_Click(object sender, EventArgs e) // Quand on clique sur le boutton valider, la bonne réponse s'affiche et le bouton suivant s'affiche mais l'utilisateur ne peut pas modifier sa réponse. 
        {
            if (clbReponses.CheckedItems.Count == 0)
            {

                lblNoRepChecked.Visible = true;
            }
            else
            {

                foreach (int indexChecked in clbReponses.CheckedIndices)
                {
                    if (clbReponses.GetItemCheckState(indexChecked) == CheckState.Checked)
                    {
                        if(indexChecked == question.ID_BonneReponse)
                        {
                            score++;
                        }
                    }
                }
                
                gpBoxReponse.Visible = true;
                btnQuestSuiv.Visible = true;
                btnValider.Visible = false;
                clbReponses.Enabled = false;
                lblNoRepChecked.Visible = false;
                }

            }

        private void clbReponses_ItemCheck(object sender, ItemCheckEventArgs e)

        {

            if (clbReponses.CheckedItems.Count >= 1 && e.CurrentValue != CheckState.Checked)

            {

                e.NewValue = e.CurrentValue;

            }

        }


        private void btnQuestSuiv_Click(object sender, EventArgs e)
        {
            gpBoxReponse.Visible = false;
            btnQuestSuiv.Visible = false;
            btnValider.Visible = true;
            clbReponses.Enabled = true;
            clbReponses.Items.Clear();
            chooseRandomQuestion();
            lblBonneRep.Text = reponse;
            lblNumQuestion.Text = compteur.ToString();
            lblTitreQuestion.Text = question.Intitule;
            clbReponses.Items.AddRange(question.Reponses);

        }


    }
}
