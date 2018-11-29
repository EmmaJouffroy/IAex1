namespace Exercice1
{
    partial class FormFinDijkstra
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
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewFinal = new System.Windows.Forms.TreeView();
            this.lblFermesFinaux = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArbreFinal = new System.Windows.Forms.Label();
            this.lbFermesFinaux = new System.Windows.Forms.ListBox();
            this.lbOuvertsFinaux = new System.Windows.Forms.ListBox();
            this.lkExoQuestions = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(-2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Padding = new System.Windows.Forms.Padding(150, 50, 150, 50);
            this.lblTitre.Size = new System.Drawing.Size(630, 128);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "Quizz sur l\'Intelligence Artificielle";
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackColor = System.Drawing.Color.Teal;
            this.btnRecommencer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecommencer.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommencer.ForeColor = System.Drawing.Color.White;
            this.btnRecommencer.Location = new System.Drawing.Point(195, 338);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(210, 81);
            this.btnRecommencer.TabIndex = 13;
            this.btnRecommencer.Text = "Retour au menu";
            this.btnRecommencer.UseVisualStyleBackColor = false;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.LinkColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(598, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 20);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "X";
            this.btnExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Voici la correction finale de l\'exercice :";
            // 
            // treeViewFinal
            // 
            this.treeViewFinal.Location = new System.Drawing.Point(410, 211);
            this.treeViewFinal.Name = "treeViewFinal";
            this.treeViewFinal.Size = new System.Drawing.Size(121, 97);
            this.treeViewFinal.TabIndex = 21;
            // 
            // lblFermesFinaux
            // 
            this.lblFermesFinaux.AutoSize = true;
            this.lblFermesFinaux.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermesFinaux.Location = new System.Drawing.Point(79, 182);
            this.lblFermesFinaux.Name = "lblFermesFinaux";
            this.lblFermesFinaux.Size = new System.Drawing.Size(109, 18);
            this.lblFermesFinaux.TabIndex = 22;
            this.lblFermesFinaux.Text = "Fermés finaux :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ouverts finaux : ";
            // 
            // lblArbreFinal
            // 
            this.lblArbreFinal.AutoSize = true;
            this.lblArbreFinal.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbreFinal.Location = new System.Drawing.Point(407, 180);
            this.lblArbreFinal.Name = "lblArbreFinal";
            this.lblArbreFinal.Size = new System.Drawing.Size(85, 18);
            this.lblArbreFinal.TabIndex = 24;
            this.lblArbreFinal.Text = "Arbre final :";
            // 
            // lbFermesFinaux
            // 
            this.lbFermesFinaux.FormattingEnabled = true;
            this.lbFermesFinaux.Location = new System.Drawing.Point(85, 211);
            this.lbFermesFinaux.Name = "lbFermesFinaux";
            this.lbFermesFinaux.Size = new System.Drawing.Size(120, 95);
            this.lbFermesFinaux.TabIndex = 25;
            // 
            // lbOuvertsFinaux
            // 
            this.lbOuvertsFinaux.FormattingEnabled = true;
            this.lbOuvertsFinaux.Location = new System.Drawing.Point(239, 213);
            this.lbOuvertsFinaux.Name = "lbOuvertsFinaux";
            this.lbOuvertsFinaux.Size = new System.Drawing.Size(120, 95);
            this.lbOuvertsFinaux.TabIndex = 26;
            // 
            // lkExoQuestions
            // 
            this.lkExoQuestions.AutoSize = true;
            this.lkExoQuestions.BackColor = System.Drawing.Color.Teal;
            this.lkExoQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkExoQuestions.LinkColor = System.Drawing.Color.White;
            this.lkExoQuestions.Location = new System.Drawing.Point(23, 13);
            this.lkExoQuestions.Name = "lkExoQuestions";
            this.lkExoQuestions.Size = new System.Drawing.Size(163, 18);
            this.lkExoQuestions.TabIndex = 27;
            this.lkExoQuestions.TabStop = true;
            this.lkExoQuestions.Text = "Quizz sur les questions";
            this.lkExoQuestions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkExoQuestions_LinkClicked);
            // 
            // FormFinDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 431);
            this.Controls.Add(this.lkExoQuestions);
            this.Controls.Add(this.lbOuvertsFinaux);
            this.Controls.Add(this.lbFermesFinaux);
            this.Controls.Add(this.lblArbreFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFermesFinaux);
            this.Controls.Add(this.treeViewFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormFinDijkstra";
            this.Text = "FormFinDijkstra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.LinkLabel btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewFinal;
        private System.Windows.Forms.Label lblFermesFinaux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArbreFinal;
        private System.Windows.Forms.ListBox lbFermesFinaux;
        private System.Windows.Forms.ListBox lbOuvertsFinaux;
        private System.Windows.Forms.LinkLabel lkExoQuestions;
    }
}