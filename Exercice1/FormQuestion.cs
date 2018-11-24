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
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuest.Visible = true;
            pbQuest.Minimum = 1;
            pbQuest.Maximum = 20;
            pbQuest.Value = 1;
            pbQuest.Step = 1;
            deserializeQuestions();
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



        public void deserializeQuestions()  // Ca c'est bon, permet de déserializer le fichier XML et de mettre le résultat dans une liste de questions
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
            pbQuest.PerformStep();


        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            FormFinQuestion formResultat = new FormFinQuestion(score);
            formResultat.Show();
            this.Hide();
        }

        private void lblTitreQuestion_Click(object sender, EventArgs e)
        {

        }
}
}
