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
        public int score = 0;
        private string reponse = "";

        public FormQuestion() // Normalement cette fonction là est bonne
        {
            InitializeComponent();
            clbReponses.Click += new EventHandler(clbReponses_SelectedIndexChanged);
            questions = serializeQuestions();
            deserializeQuestions(questions);
            lblNoRepChecked.Visible = false;
            chooseRandomQuestion();
            lblBonneRep.Text = reponse;
            lblNumQuestion.Text = compteur.ToString();
            lblTitreQuestion.Text = question.Intitule;
            clbReponses.Items.AddRange(question.Reponses);
            btnResult.Visible = false;
            if(question.ImagePath == "")
            {
                photo.Visible = false;
            }
            else {
                photo.Visible = true;
                photo.Image = Image.FromFile(question.ImagePath);
            }
        }

        public List<Question> serializeQuestions() // Celle-ci est bonne, il ne reste plus qu'à mettre les bonnes questions dedans, ainsi que les bonnes réponses associées aux questions
        {
            string[] repquest1 = { "cc" };
            string[] repquest2 = { "cc", "ee"};
            string[] repquest3 = { "cc", "bb" };
            string[] repquest4 = { "cc", "ff", "gg" };
            string[] repquest5 = { "cc", "hh", "ii" };

            Question question1 = new Question(1 , "question1" , 0, "bonjour.png", repquest1);
            Question question2 = new Question(2, "question2", 0, "", repquest2);
            Question question3 = new Question(3, "question3",  0, "bonjour.png", repquest3);
            Question question4 = new Question(4, "question4",  0, "bonjour.png", repquest4);
            Question question5 = new Question(5, "question5", 0, "", repquest5);
            Question question6 = new Question(5, "question5", 0, "bonjour.png", repquest5);
            Question question7 = new Question(5, "question5", 0, "bonjour.png", repquest5);
            Question question8 = new Question(5, "question5", 0, "", repquest5);
            Question question9 = new Question(5, "question5", 0, "bonjour.png", repquest5);
            Question question10 = new Question(5, "question5", 0, "", repquest5);
            Question question11 = new Question(5, "question5", 0, "bonjour.png", repquest5);
            Question question12 = new Question(5, "question5", 0, "bonjour.png", repquest5);
            Question question13 = new Question(5, "question5", 0, "", repquest5);
            Question question14 = new Question(5, "question5", 0, "", repquest5);
            Question question15 = new Question(5, "question5", 0, "bonjour.png", repquest5);
            Question question16 = new Question(5, "question5", 0, "bonjour.png", repquest5);
            Question question17 = new Question(5, "question5", 0, "", repquest5);
            Question question18 = new Question(5, "question5", 0, "", repquest5);
            Question question19 = new Question(5, "question5", 0, "", repquest5);
            Question question20 = new Question(5, "question5", 0, "bonjour.png", repquest5);


            List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);
            questions.Add(question6);
            questions.Add(question7);
            questions.Add(question8);
            questions.Add(question9);
            questions.Add(question10);
            questions.Add(question11);
            questions.Add(question12);
            questions.Add(question13);
            questions.Add(question14);
            questions.Add(question15);
            questions.Add(question16);
            questions.Add(question17);
            questions.Add(question18);
            questions.Add(question19);
            questions.Add(question20);


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
                if (compteur == 20)
                {
                    btnResult.Visible = true;
                    btnQuestSuiv.Visible = false;
                    btnValider.Visible = false;
                }
                else
                {
                    btnQuestSuiv.Visible = true;
                }

                gpBoxReponse.Visible = true;
                btnValider.Visible = false;
                clbReponses.Enabled = false;
                lblNoRepChecked.Visible = false;
                }

            }


        private void clbReponses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = clbReponses.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < clbReponses.Items.Count; iIndex++)
                clbReponses.SetItemCheckState(iIndex, CheckState.Unchecked);
            clbReponses.SetItemCheckState(iSelectedIndex, CheckState.Checked);
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
            if (question.ImagePath == "")
            {
                photo.Visible = false;
            }
            else {
                photo.Visible = true;
                photo.Image = Image.FromFile(question.ImagePath);
            }

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            FormFinQuestion formResultat = new FormFinQuestion(score);
            formResultat.Show();
            this.Hide();
        }
    }
}
