using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1
{
    public class ArbreRecherche
    {
        private int[,] matrice;
        public List<Noeud> L_Ouverts { get; set; } = new List<Noeud>();
        public List<List<Noeud>> ListeDesOuverts { get; set; } = new List<List<Noeud>>();
        public List<List<Noeud>> ListeDesFermes { get; set; } = new List<List<Noeud>>();
        public List<Noeud> L_Fermes { get; set; } = new List<Noeud>();
        public ArbreRecherche() { }
        public ArbreRecherche(int[,] matrice)
        {
            this.matrice = matrice;
        }
        private Noeud ChercheNoeudDansFermes(Noeud N2)
        {
            int i = 0;
            while (i < L_Fermes.Count)
            {
                if (L_Fermes[i].estEgal(N2))
                    return L_Fermes[i];
                i++;
            }
            return null;
        }
        private Noeud ChercheNoeudDansOuverts(Noeud N2)
        {
            int i = 0;
            while (i < L_Ouverts.Count)
            {
                if (L_Ouverts[i].estEgal(N2))
                    return L_Ouverts[i];
                i++;
            }
            return null;
        }
        public List<Noeud> Dijkstra(Noeud noeudInit, Noeud noeudFinal)
        {
            List<Noeud> SuccNoeudCourant;
            Noeud noeudCourant = new Noeud(noeudInit.ID);
            //Noeud noeudCourant = noeudInit;
            L_Ouverts.Add(noeudCourant);
            int NbNoeud = matrice.GetLength(0);
            while (L_Ouverts.Count != 0 && noeudCourant.estNoeudFinal(noeudFinal.ID) == false)
            {
                //On commence par passer le noeud courant dans les fermes :
                L_Fermes.Add(noeudCourant);
                L_Ouverts.Remove(noeudCourant);
                //On cherche les noeuds successeurs du noeud courant dans le graph:
                SuccNoeudCourant = noeudCourant.GetListeSuccesseurs(this.matrice);
                // On vient placer tous les successeurs dans les ouverts (on fait attention à ceux déjà présents dans les ouverts)
                foreach (Noeud noeud in SuccNoeudCourant)
                {
                    Noeud N2 = ChercheNoeudDansFermes(noeud);
                    if (N2 == null)
                    {
                        // Si il n'est pas déjà dans les fermés on le cherche dans les ouverts
                        N2 = ChercheNoeudDansOuverts(noeud);
                        if (N2 != null)
                        {
                            //il est dans les ouverts on regarde si ce nouveau chemin est meilleur
                            if (N2.InitCout > noeud.CoutEntreNoeud(noeudCourant, matrice) + noeudCourant.InitCout)
                            {
                                //Si celui des fermés à un cout chemin supérieur à celui qui vient de sortir
                                N2.InitCout = noeud.CoutEntreNoeud(noeudCourant, matrice) + noeudCourant.InitCout;
                                // On supprime son noeud parent
                                N2.Supprime_Liens_Parent();
                                // On modifie et on y met ce nouveau noeud parent
                                N2.SetNoeud_Parent(noeudCourant);
                                // On vire des ouverts le noeud N2 avec le mauvais parent
                                L_Ouverts.Remove(N2);
                                // On remet le bon dedans (et on trie à la bonne place)
                                this.InsertDansOuverts(N2);
                            }
                        }
                        else //il n'est ni dans les fermes, ni dans les ouverts
                        {
                            // Noeud est nouveau, on calcule son cout et on lui affecte un parent (le noeud courant)
                            noeud.InitCout = noeudCourant.InitCout + noeudCourant.CoutEntreNoeud(noeud, matrice);
                            Noeud enfant = new Noeud(noeud.ID, noeud.InitCout);
                            enfant.SetNoeud_Parent(noeudCourant);
                            // On l'insere à la bonne place dans les ouverts
                            this.InsertDansOuverts(enfant);
                        }
                    }//Si N2 est déjà dans les fermés on ne le visite pas donc il n'est pas inséré dans les ouverts
                }
                if (L_Ouverts.Count > 0)
                {
                    List<Noeud> tempoOuvert = new List<Noeud>();
                    List<Noeud> tempoFermes = new List<Noeud>();
                    foreach (Noeud noeud in L_Ouverts)
                    {
                        tempoOuvert.Add(noeud);
                    }
                    foreach (Noeud noeud in L_Fermes)
                    {
                        tempoFermes.Add(noeud);
                    }
                    ListeDesOuverts.Add(tempoOuvert);
                    ListeDesFermes.Add(tempoFermes);
                    noeudCourant = L_Ouverts[0];
                }
                else
                {
                    //On arrive sur une liste des ouverts vides, il n'y a pas de solution 
                    noeudCourant = null;
                }
            }
            // On créee une liste pour renvoyer le chemin le plus court
            List<Noeud> CheminLePlusCourt = new List<Noeud>();
            if (noeudCourant != null)
            {
                CheminLePlusCourt.Add(noeudCourant);
                while (noeudCourant.NoeudParent != null)
                {
                    noeudCourant = noeudCourant.NoeudParent;
                    CheminLePlusCourt.Insert(0, noeudCourant);  // On insère en position 1
                }
            }
            return CheminLePlusCourt;
        }
        public void InsertDansOuverts(Noeud NewNode)
        {
            // Insertion pour respecter l'ordre du cout total le plus petit au plus grand
            if (this.L_Ouverts.Count == 0)
            { L_Ouverts.Add(NewNode); }
            else
            {
                Noeud N = L_Ouverts[0];
                bool trouve = false;
                int i = 0;
                do
                    if (NewNode.InitCout < N.InitCout)
                    {
                        L_Ouverts.Insert(i, NewNode);
                        trouve = true;
                    }
                    else
                    {
                        i++;
                        if (L_Ouverts.Count == i)
                        {
                            N = null;
                            L_Ouverts.Insert(i, NewNode);
                        }
                        else
                        { N = L_Ouverts[i]; }
                    }
                while ((N != null) && (trouve == false));
            }
        }
        public void GetArbreRecherche(TreeView TV, bool visible)
        {
            if (L_Fermes == null) return;
            if (L_Fermes.Count == 0) return;
            // On suppose le TreeView préexistant
            TV.Nodes.Clear();
            TreeNode TN = new TreeNode(L_Fermes[0].ToString());
            TV.Nodes.Add(TN);
            AjouteBranche(L_Fermes[0], TN, visible);
        }
        // AjouteBranche est exclusivement appelée par GetSearchTree; les noeuds sont ajoutés de manière récursive
        public void AjouteBranche(Noeud GN, TreeNode TN, bool visible)
        {
            foreach (Noeud GNfils in GN.Enfants)
            {
                TreeNode TNfils;
                if (visible)
                {
                    TNfils = new TreeNode("?");
                }
                else
                {
                    TNfils = new TreeNode(Convert.ToString(GNfils.ID));
                }
                TN.Nodes.Add(TNfils);
                if (GNfils.Enfants.Count > 0) AjouteBranche(GNfils, TNfils, visible);
            }
        }
    }
}
