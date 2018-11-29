using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public class Noeud
    {
        public int InitCout { get; set; }  // coût du chemin du noeud initial jusqu'à ce noeud
        public Noeud NoeudParent;  // noeud parent
        //Grace à la liste des successeur et du noeud parent on pourra def la liste des enfants
        public List<Noeud> Enfants { get; set; } = new List<Noeud>(); // Liste noeuds enfants
        public int ID { get; set; } //id 
        public char x;
        public Noeud(char x, int ID)
        {
            this.x = x;
            this.ID = ID;

        }
        public Noeud(int ID)
        {
            this.ID = ID;
        }
        public Noeud(int ID, int InitCout)
        {
            this.ID = ID;
            this.InitCout = InitCout;
        }
        public bool estEgal(Noeud N2)
        {
            return this.ID == N2.ID;
        }
        public bool estNoeudFinal(int numFinal)
        {
            return (this.ID == numFinal);
        }
        public int CoutEntreNoeud(Noeud N2, int[,] matrice)
        {
            return matrice[this.ID, N2.ID];
        }
        public void Supprime_Liens_Parent()
        {
            if (this.NoeudParent == null) { return; }
            else
            {
                this.NoeudParent.Enfants.Remove(this);
                this.NoeudParent = null;
            }
        }
        public void SetNoeud_Parent(Noeud g)
        {
            NoeudParent = g;
            g.Enfants.Add(this);
        }

        public List<Noeud> GetListeSuccesseurs(int[,] matrice)
        {
            int nbNoeuds = matrice.GetLength(0);
            List<Noeud> lsucc = new List<Noeud>();
            for (int i = 0; i < nbNoeuds; i++)
            {
                if (matrice[this.ID, i] != -1)
                {
                    Noeud newnode = new Noeud(i);
                    lsucc.Add(newnode);
                }
            }
            return lsucc;
        }
        public override string ToString()
        {
            return Convert.ToString(ID);
        }
    }
}
