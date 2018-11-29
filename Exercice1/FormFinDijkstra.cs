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
        
        public FormFinDijkstra(List<List<Noeud>> listeNoeudsOuverts, List<List<Noeud>> listeNoeudsFermes, List<string> lOuverts, List<string> lFermes, ArbreRecherche a, bool arbreEquivalent)
        {
           
            InitializeComponent();
            a.GetArbreRecherche(this.treeViewFinal, false);
            treeViewFinal.ExpandAll();
            //MessageBox.Show(reponseArbreVisible);
            if (arbreEquivalent)
            {
                this.labelReponse.Text = "Bonne réponse !";
                this.labelReponse.ForeColor = Color.Green;
            }
            else
            {
                this.labelReponse.Text = "Mauvaise réponse !";
                this.labelReponse.ForeColor = Color.Red;
            }

            foreach (List<Noeud> listeNoeuds in listeNoeudsOuverts)
            {
                string str = "{";
                int cpt = 0;
                foreach (Noeud noeud in listeNoeuds)
                {
                    if (cpt != listeNoeuds.Count - 1)
                        str = str + noeud.ToString() + ",";
                    else
                        str = str + noeud.ToString() + "}";
                    cpt++;
                }
                this.lbOuvertsFinaux.Items.Add(str);
            }
            foreach (List<Noeud> listeNoeuds in listeNoeudsFermes)
            {
                string str = "{";
                int cpt = 0;
                foreach (Noeud noeud in listeNoeuds)
                {
                    if(cpt!=listeNoeuds.Count-1)
                         str = str + noeud.ToString() + ",";
                    else
                        str = str + noeud.ToString() + "}";
                    cpt++;

                }
                
                this.lbFermesFinaux.Items.Add(str);
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lbFermesFinaux.Enabled = false;
            lbOuvertsFinaux.Enabled = false;
            treeViewFinal.Enabled = false;
           
            foreach(string s in lOuverts)
            {
                this.listBoxRepOuverts.Items.Add(s);
            }

            foreach (string s in lFermes)
            {
                this.listBoxRepFermes.Items.Add(s);
            }

             for(int i=0; i<this.listBoxRepFermes.Items.Count;i++)
             {
                 if (this.lbFermesFinaux.Items.Count == this.listBoxRepFermes.Items.Count)
                 {
                         if (Convert.ToString(this.lbFermesFinaux.Items[i]) != Convert.ToString(this.listBoxRepFermes.Items[i]))
                         {
                             this.listBoxRepFermes.ForeColor = Color.Red;
                         }
                     else
                     {
                         this.listBoxRepFermes.ForeColor = Color.Green;
                     }

                 }
                 else
                 {
                     this.listBoxRepFermes.ForeColor = Color.Red;
                 }
             }

            for (int i = 0; i < this.listBoxRepOuverts.Items.Count; i++)
            {
                if (this.lbOuvertsFinaux.Items.Count == this.listBoxRepOuverts.Items.Count)
                {
                    if (Convert.ToString(this.lbOuvertsFinaux.Items[i]) != Convert.ToString(this.listBoxRepOuverts.Items[i]))
                    {
                        this.listBoxRepOuverts.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.listBoxRepOuverts.ForeColor = Color.Green;
                    }

                }
                else
                {
                    this.listBoxRepOuverts.ForeColor = Color.Red;
                }
            }




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
