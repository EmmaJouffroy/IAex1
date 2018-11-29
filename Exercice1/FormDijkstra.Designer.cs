namespace Exercice1
{
    partial class FormDijkstra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.lblNoeudInit = new System.Windows.Forms.Label();
            this.nomNoeudInit = new System.Windows.Forms.Label();
            this.lblNoeudFinal = new System.Windows.Forms.Label();
            this.nomNoeudFinal = new System.Windows.Forms.Label();
            this.lblExercice = new System.Windows.Forms.Label();
            this.lblExerciceConsigne = new System.Windows.Forms.Label();
            this.treeViewCorr = new System.Windows.Forms.TreeView();
            this.tbFermesEx = new System.Windows.Forms.TextBox();
            this.tbOuvertsEx = new System.Windows.Forms.TextBox();
            this.lblFermes = new System.Windows.Forms.Label();
            this.lblOuverts = new System.Windows.Forms.Label();
            this.lblTreeView = new System.Windows.Forms.Label();
            this.btnEtapeSuivante = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.LinkLabel();
            this.lkMenu = new System.Windows.Forms.LinkLabel();
            this.lbFermes = new System.Windows.Forms.ListBox();
            this.lbOuverts = new System.Windows.Forms.ListBox();
            this.lblTsFermes = new System.Windows.Forms.Label();
            this.lblTsOuverts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(-1, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Padding = new System.Windows.Forms.Padding(150, 50, 150, 50);
            this.lblTitre.Size = new System.Drawing.Size(630, 128);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "Quizz sur l\'Intelligence Artificielle";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(39, 145);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(179, 18);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "Description de l\'arbre :";
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(42, 171);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(555, 206);
            this.photo.TabIndex = 14;
            this.photo.TabStop = false;
            // 
            // lblNoeudInit
            // 
            this.lblNoeudInit.AutoSize = true;
            this.lblNoeudInit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoeudInit.Location = new System.Drawing.Point(156, 394);
            this.lblNoeudInit.Name = "lblNoeudInit";
            this.lblNoeudInit.Size = new System.Drawing.Size(90, 18);
            this.lblNoeudInit.TabIndex = 15;
            this.lblNoeudInit.Text = "Noeud initial :";
            // 
            // nomNoeudInit
            // 
            this.nomNoeudInit.AutoSize = true;
            this.nomNoeudInit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomNoeudInit.Location = new System.Drawing.Point(254, 394);
            this.nomNoeudInit.Name = "nomNoeudInit";
            this.nomNoeudInit.Size = new System.Drawing.Size(15, 18);
            this.nomNoeudInit.TabIndex = 16;
            this.nomNoeudInit.Text = "1";
            // 
            // lblNoeudFinal
            // 
            this.lblNoeudFinal.AutoSize = true;
            this.lblNoeudFinal.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoeudFinal.Location = new System.Drawing.Point(300, 394);
            this.lblNoeudFinal.Name = "lblNoeudFinal";
            this.lblNoeudFinal.Size = new System.Drawing.Size(118, 18);
            this.lblNoeudFinal.TabIndex = 17;
            this.lblNoeudFinal.Text = "Nom noeud final : ";
            // 
            // nomNoeudFinal
            // 
            this.nomNoeudFinal.AutoSize = true;
            this.nomNoeudFinal.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomNoeudFinal.Location = new System.Drawing.Point(414, 395);
            this.nomNoeudFinal.Name = "nomNoeudFinal";
            this.nomNoeudFinal.Size = new System.Drawing.Size(15, 18);
            this.nomNoeudFinal.TabIndex = 18;
            this.nomNoeudFinal.Text = "2";
            // 
            // lblExercice
            // 
            this.lblExercice.AutoSize = true;
            this.lblExercice.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercice.Location = new System.Drawing.Point(42, 449);
            this.lblExercice.Name = "lblExercice";
            this.lblExercice.Size = new System.Drawing.Size(84, 20);
            this.lblExercice.TabIndex = 19;
            this.lblExercice.Text = "Exercice : ";
            // 
            // lblExerciceConsigne
            // 
            this.lblExerciceConsigne.AutoSize = true;
            this.lblExerciceConsigne.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciceConsigne.Location = new System.Drawing.Point(132, 449);
            this.lblExerciceConsigne.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblExerciceConsigne.Name = "lblExerciceConsigne";
            this.lblExerciceConsigne.Size = new System.Drawing.Size(480, 36);
            this.lblExerciceConsigne.TabIndex = 20;
            this.lblExerciceConsigne.Text = "A chaque tour, rentrez les ouverts et les fermés, dans l\'ordre qui vous semble le" +
    " plus pertinent. L\'ordre associé servira à construire l\'arbre. ";
            // 
            // treeViewCorr
            // 
            this.treeViewCorr.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCorr.Location = new System.Drawing.Point(412, 528);
            this.treeViewCorr.Name = "treeViewCorr";
            this.treeViewCorr.Size = new System.Drawing.Size(185, 147);
            this.treeViewCorr.TabIndex = 21;
            // 
            // tbFermesEx
            // 
            this.tbFermesEx.Location = new System.Drawing.Point(158, 713);
            this.tbFermesEx.Name = "tbFermesEx";
            this.tbFermesEx.Size = new System.Drawing.Size(100, 20);
            this.tbFermesEx.TabIndex = 22;
            // 
            // tbOuvertsEx
            // 
            this.tbOuvertsEx.Location = new System.Drawing.Point(497, 708);
            this.tbOuvertsEx.Name = "tbOuvertsEx";
            this.tbOuvertsEx.Size = new System.Drawing.Size(100, 20);
            this.tbOuvertsEx.TabIndex = 23;
            // 
            // lblFermes
            // 
            this.lblFermes.AutoSize = true;
            this.lblFermes.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermes.Location = new System.Drawing.Point(35, 713);
            this.lblFermes.Name = "lblFermes";
            this.lblFermes.Size = new System.Drawing.Size(121, 18);
            this.lblFermes.TabIndex = 24;
            this.lblFermes.Text = "Nouveau fermé : ";
            // 
            // lblOuverts
            // 
            this.lblOuverts.AutoSize = true;
            this.lblOuverts.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuverts.Location = new System.Drawing.Point(382, 708);
            this.lblOuverts.Name = "lblOuverts";
            this.lblOuverts.Size = new System.Drawing.Size(109, 18);
            this.lblOuverts.TabIndex = 25;
            this.lblOuverts.Text = "Nouvel ouvert :";
            // 
            // lblTreeView
            // 
            this.lblTreeView.AutoSize = true;
            this.lblTreeView.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreeView.Location = new System.Drawing.Point(412, 509);
            this.lblTreeView.Name = "lblTreeView";
            this.lblTreeView.Size = new System.Drawing.Size(199, 18);
            this.lblTreeView.TabIndex = 26;
            this.lblTreeView.Text = "Arbre associé à vos réponses :\r\n";
            // 
            // btnEtapeSuivante
            // 
            this.btnEtapeSuivante.BackColor = System.Drawing.Color.Teal;
            this.btnEtapeSuivante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtapeSuivante.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtapeSuivante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEtapeSuivante.Location = new System.Drawing.Point(99, 776);
            this.btnEtapeSuivante.Name = "btnEtapeSuivante";
            this.btnEtapeSuivante.Size = new System.Drawing.Size(191, 46);
            this.btnEtapeSuivante.TabIndex = 28;
            this.btnEtapeSuivante.Text = "Tour suivant";
            this.btnEtapeSuivante.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.LinkColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(579, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 20);
            this.btnExit.TabIndex = 30;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "X";
            this.btnExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExit_LinkClicked);
            // 
            // lkMenu
            // 
            this.lkMenu.AutoSize = true;
            this.lkMenu.BackColor = System.Drawing.Color.Teal;
            this.lkMenu.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkMenu.LinkColor = System.Drawing.Color.White;
            this.lkMenu.Location = new System.Drawing.Point(38, 9);
            this.lkMenu.Name = "lkMenu";
            this.lkMenu.Size = new System.Drawing.Size(49, 20);
            this.lkMenu.TabIndex = 31;
            this.lkMenu.TabStop = true;
            this.lkMenu.Text = "Menu";
            this.lkMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkMenu_LinkClicked);
            // 
            // lbFermes
            // 
            this.lbFermes.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFermes.FormattingEnabled = true;
            this.lbFermes.ItemHeight = 18;
            this.lbFermes.Location = new System.Drawing.Point(46, 528);
            this.lbFermes.Name = "lbFermes";
            this.lbFermes.Size = new System.Drawing.Size(154, 130);
            this.lbFermes.TabIndex = 32;
            // 
            // lbOuverts
            // 
            this.lbOuverts.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOuverts.FormattingEnabled = true;
            this.lbOuverts.ItemHeight = 18;
            this.lbOuverts.Location = new System.Drawing.Point(226, 528);
            this.lbOuverts.Name = "lbOuverts";
            this.lbOuverts.Size = new System.Drawing.Size(154, 130);
            this.lbOuverts.TabIndex = 33;
            // 
            // lblTsFermes
            // 
            this.lblTsFermes.AutoSize = true;
            this.lblTsFermes.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTsFermes.Location = new System.Drawing.Point(42, 510);
            this.lblTsFermes.Name = "lblTsFermes";
            this.lblTsFermes.Size = new System.Drawing.Size(119, 18);
            this.lblTsFermes.TabIndex = 34;
            this.lblTsFermes.Text = "Tous vos fermés :";
            // 
            // lblTsOuverts
            // 
            this.lblTsOuverts.AutoSize = true;
            this.lblTsOuverts.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTsOuverts.Location = new System.Drawing.Point(222, 509);
            this.lblTsOuverts.Name = "lblTsOuverts";
            this.lblTsOuverts.Size = new System.Drawing.Size(123, 18);
            this.lblTsOuverts.TabIndex = 35;
            this.lblTsOuverts.Text = "Tous vos ouverts :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(362, 776);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Valider l\'exercice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 857);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTsOuverts);
            this.Controls.Add(this.lblTsFermes);
            this.Controls.Add(this.lbOuverts);
            this.Controls.Add(this.lbFermes);
            this.Controls.Add(this.lkMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTreeView);
            this.Controls.Add(this.lblOuverts);
            this.Controls.Add(this.lblFermes);
            this.Controls.Add(this.tbOuvertsEx);
            this.Controls.Add(this.tbFermesEx);
            this.Controls.Add(this.treeViewCorr);
            this.Controls.Add(this.lblExerciceConsigne);
            this.Controls.Add(this.lblExercice);
            this.Controls.Add(this.nomNoeudFinal);
            this.Controls.Add(this.lblNoeudFinal);
            this.Controls.Add(this.nomNoeudInit);
            this.Controls.Add(this.lblNoeudInit);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnEtapeSuivante);
            this.Name = "FormDijkstra";
            this.Text = "FormDijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label lblNoeudInit;
        private System.Windows.Forms.Label nomNoeudInit;
        private System.Windows.Forms.Label lblNoeudFinal;
        private System.Windows.Forms.Label nomNoeudFinal;
        private System.Windows.Forms.Label lblExercice;
        private System.Windows.Forms.Label lblExerciceConsigne;
        private System.Windows.Forms.TreeView treeViewCorr;
        private System.Windows.Forms.TextBox tbFermesEx;
        private System.Windows.Forms.TextBox tbOuvertsEx;
        private System.Windows.Forms.Label lblFermes;
        private System.Windows.Forms.Label lblOuverts;
        private System.Windows.Forms.Label lblTreeView;
        private System.Windows.Forms.Button btnEtapeSuivante;
        private System.Windows.Forms.LinkLabel btnExit;
        private System.Windows.Forms.LinkLabel lkMenu;
        private System.Windows.Forms.ListBox lbFermes;
        private System.Windows.Forms.ListBox lbOuverts;
        private System.Windows.Forms.Label lblTsFermes;
        private System.Windows.Forms.Label lblTsOuverts;
        private System.Windows.Forms.Button button1;
    }
}