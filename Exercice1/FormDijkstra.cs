using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1
{
    public partial class FormDijkstra : Form
    {

        static public int[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;
        static public int tour = 0;
        static public List<List<Noeud>> ListeDesOuverts = new List<List<Noeud>>();
        static public List<List<Noeud>> ListeDesFermes = new List<List<Noeud>>();
        List<string> listeRepNoeudsOuverts = new List<string>();
        List<string> listeRepNoeudsFermes = new List<string>();

        public List<String>[] reponses;
        ArbreRecherche sol;
        Noeud Ninit;
        Noeud NF;
        List<Noeud> solution;
        private List<TreeNode> listeTexteNoeuds = new List<TreeNode>();
        string reponseArbreNonVisible = "";
        string reponseArbreVisible = "";
        bool arbreEquivalent = true;

        public FormDijkstra()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            listBoxRepFermes.Enabled = false;
            listBoxRepOuverts.Enabled = false;
            reponses = new List<String>[2];
            reponses[0] = new List<string>();
            reponses[1] = new List<string>();
            InitialisationFichierTexte("graphe1.txt");            
            Noeud Ninit = new Noeud(numinitial);
            Noeud NF = new Noeud(numfinal);
            ArbreRecherche sol = new ArbreRecherche(matrice);
            List<Noeud> solution = sol.Dijkstra(Ninit, NF);
            ListeDesOuverts = sol.ListeDesOuverts;
            ListeDesFermes = sol.ListeDesFermes;
            sol.GetArbreRecherche(this.treeViewExercice,true);
            sol.GetArbreRecherche(this.treeViewNonVisible, false);
            this.treeViewExercice.ExpandAll();


        }

        public void RemplirTexteArbre(bool visible)
        {
            if (!visible)
            {   
                Recursive(treeViewNonVisible.Nodes[0]);
                foreach (TreeNode t in listeTexteNoeuds)
                    reponseArbreNonVisible += t.Text;
            }
            else
            {
                Recursive(treeViewExercice.Nodes[0]);
                foreach (TreeNode t in listeTexteNoeuds)
                    reponseArbreVisible += t.Text;
            }
           
        }

        public void Recursive(TreeNode NoeudParent)
        {            
            listeTexteNoeuds.Add(NoeudParent);       
            foreach (TreeNode NoeudEnfant in NoeudParent.Nodes)
            {
                Recursive(NoeudEnfant);
            }
        }

        private void InitialisationFichierTexte(string titre)
        {
            StreamReader monStreamReader = new StreamReader(titre);
            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new int[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null && ligne[0] != '/')
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                int val = Convert.ToInt32(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                ligne = monStreamReader.ReadLine();
            }
            //Recup noeud init
            i = 0;
            if (ligne[i] == '/')
            {
                while (ligne[i] != ':') i++;
                i++;
                while (ligne[i] == ' ') i++;
                string tempo = Convert.ToString(ligne[i]);
                nomNoeudInit.Text =tempo;
                numinitial = Convert.ToInt32(tempo);
            }
            ligne = monStreamReader.ReadLine();
            //Recup noeud final
            i = 0;
            if (ligne[i] == '/')
            {
                while (ligne[i] != ':') i++;
                i++;
                while (ligne[i] == ' ') i++;
                string tempo = Convert.ToString(ligne[i]);
                nomNoeudFinal.Text = tempo;
                numfinal = Convert.ToInt32(tempo);
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
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
            
            InitialisationFichierTexte("graphe1.txt");
            //numinitial = Convert.ToInt32(textBoxNoeudInitial.Text);
            //numfinal = Convert.ToInt32(textBox2.Text);
            numinitial = 0;
            numfinal = 6;
            Noeud Ninit = new Noeud(numinitial);
            Noeud NF = new Noeud(numfinal);
            ArbreRecherche so = new ArbreRecherche(matrice);
            List<Noeud> solution = so.Dijkstra(Ninit, NF);
            RemplirTexteArbre(false);
            RemplirTexteArbre(false);
            RemplirTexteArbre(true);
          
            if (reponseArbreVisible != reponseArbreNonVisible)
                arbreEquivalent = false;

            FormFinDijkstra correctionDijkstra = new FormFinDijkstra(ListeDesOuverts,ListeDesFermes,this.listeRepNoeudsOuverts,this.listeRepNoeudsFermes, so, arbreEquivalent);
            correctionDijkstra.Show();
            this.Hide();
        }

        private void btnEtapeSuivante_Click(object sender, EventArgs e)
        {
            if (tour < ListeDesOuverts.Count)
            {
                if (verifierEntreeTextBox())
                {
                    reponses[0].Add(UniformisationReponse(this.textBoxO.Text));
                    reponses[1].Add(UniformisationReponse(this.textBoxF.Text));
                    this.listBoxRepFermes.Items.Add(reponses[1][tour]);
                    this.listBoxRepOuverts.Items.Add(reponses[0][tour]);
                    this.listeRepNoeudsOuverts.Add(reponses[0][tour]);
                    this.listeRepNoeudsFermes.Add(reponses[1][tour]);
                    tour++;
                }
                else
                {
                    MessageBox.Show("L'une des entrées est incorrecte ! Veuillez re-vérifer");
                    this.textBoxO.Text = "{}";
                    this.textBoxF.Text = "{}";
                }
                //Affichage des espaces :

                // Construction de l'arbre : 

            }
        }

        public bool verifierEntreeTextBox()
            {
                bool acceptable = true;

                if (this.textBoxO.Text[0] != '{' || this.textBoxF.Text[0] != '{' || this.textBoxO.Text[textBoxO.Text.Count() - 1] != '}' ||
                    this.textBoxF.Text[textBoxF.Text.Count() - 1] != '}') // On teste si les premiers et derniers caractères des textbox sont bien des accolades
                {
                    acceptable = false;
            
                }


                if (this.textBoxO.Text.Count() > 3)
                {
                    for (int i = 2; i < textBoxO.Text.Count() - 2; i = i + 2)
                    {
                        if (this.textBoxO.Text[i] != 44 && this.textBoxO.Text[i] != 46 && this.textBoxO.Text[i] != 58 && this.textBoxO.Text[i] != 59)
                        {
                            acceptable = false;
                
                        }
                    }
                }

                if (this.textBoxF.Text.Count() > 3)
                {
                    for (int i = 2; i < textBoxF.Text.Count() - 2; i = i + 2)
                    {
                        if (this.textBoxF.Text[i] != 44 && this.textBoxF.Text[i] != 46 && this.textBoxF.Text[i] != 58 && this.textBoxF.Text[i] != 59)
                        {
                            acceptable = false;
                        }
                    }
                }


                for (int i = 1; i < textBoxO.Text.Count() - 2; i = i + 2)
                {
                    if (this.textBoxO.Text.Count() != 2)
                    { // On vérifie la taille du stirng, s'il est "vide" pas besoin de faire la condition prochaine
                        if (this.textBoxO.Text[i] > 57 || this.textBoxO.Text[i] < 48)
                        // On vérifie si tous les caractères impairs sont bien des lettres (gestion ascii + maj/min)
                        {
                            acceptable = false;
                          
                        }
                    }
                }

                for (int i = 1; i < textBoxF.Text.Count() - 2; i = i + 2)
                {
                    if (this.textBoxF.Text.Count() != 2)
                    { // On vérifie la taille du stirng, s'il est "vide" pas besoin de faire la condition prochaine
                        if (this.textBoxF.Text[i] > 57 || this.textBoxF.Text[i] < 48)
                        // On vérifie si tous les caractères impairs sont bien des lettres (gestion ascii + maj/min)
                        {
                            acceptable = false;
                       
                        }
                    }
                }
                return acceptable;
            }

        public void treeViewExercice_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeViewExercice.SelectedNode.BeginEdit();

        }

        private string UniformisationReponse(string reponse)
            {

                char[] reponseEnTableauDeChar = reponse.ToCharArray(); // String immuable
                                                                       // passage obligatoire en tableau de char  
                if (reponse.Count() > 2)
                {
                    for (int i = 1; i < reponse.Count() - 1; i++)
                    {
                        if (i % 2 == 1) // Si on est sur une lettre
                        {
                            if (reponse[i] > 96) // Si minuscule
                            {
                                reponseEnTableauDeChar[i] = (char)((int)reponse[i] - 32); // Transformation en majuscule
                            }
                        }

                        else
                        {
                            if (reponse[i] != 44) // Si minuscule
                            {
                                reponseEnTableauDeChar[i] = (char)44; // Transformation en majuscule
                            }
                        }
                    }
                }
                return new string(reponseEnTableauDeChar);
            }
        }
    
}

