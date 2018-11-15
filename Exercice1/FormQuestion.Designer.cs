namespace Exercice1
{
    partial class FormQuestion
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
            this.lblNumQuestion = new System.Windows.Forms.Label();
            this.lblTitreQuestion = new System.Windows.Forms.Label();
            this.clbReponses = new System.Windows.Forms.CheckedListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.gpBoxReponse = new System.Windows.Forms.GroupBox();
            this.lblBonneRep = new System.Windows.Forms.Label();
            this.lnlBonneRepTitre = new System.Windows.Forms.Label();
            this.btnQuestSuiv = new System.Windows.Forms.Button();
            this.lblNoRepChecked = new System.Windows.Forms.Label();
            this.gpBoxReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumQuestion
            // 
            this.lblNumQuestion.AutoSize = true;
            this.lblNumQuestion.Location = new System.Drawing.Point(34, 39);
            this.lblNumQuestion.Name = "lblNumQuestion";
            this.lblNumQuestion.Size = new System.Drawing.Size(69, 13);
            this.lblNumQuestion.TabIndex = 0;
            this.lblNumQuestion.Text = "numQuestion";
            // 
            // lblTitreQuestion
            // 
            this.lblTitreQuestion.AutoSize = true;
            this.lblTitreQuestion.Location = new System.Drawing.Point(155, 39);
            this.lblTitreQuestion.Name = "lblTitreQuestion";
            this.lblTitreQuestion.Size = new System.Drawing.Size(66, 13);
            this.lblTitreQuestion.TabIndex = 1;
            this.lblTitreQuestion.Text = "titreQuestion";
            // 
            // clbReponses
            // 
            this.clbReponses.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clbReponses.FormattingEnabled = true;
            this.clbReponses.Location = new System.Drawing.Point(37, 94);
            this.clbReponses.Name = "clbReponses";
            this.clbReponses.Size = new System.Drawing.Size(413, 139);
            this.clbReponses.TabIndex = 2;
            this.clbReponses.UseCompatibleTextRendering = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(158, 399);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(180, 52);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gpBoxReponse
            // 
            this.gpBoxReponse.Controls.Add(this.lblBonneRep);
            this.gpBoxReponse.Controls.Add(this.lnlBonneRepTitre);
            this.gpBoxReponse.Location = new System.Drawing.Point(40, 291);
            this.gpBoxReponse.Name = "gpBoxReponse";
            this.gpBoxReponse.Size = new System.Drawing.Size(413, 102);
            this.gpBoxReponse.TabIndex = 4;
            this.gpBoxReponse.TabStop = false;
            this.gpBoxReponse.Text = "Réponses";
            this.gpBoxReponse.Visible = false;
            // 
            // lblBonneRep
            // 
            this.lblBonneRep.AutoSize = true;
            this.lblBonneRep.Location = new System.Drawing.Point(22, 47);
            this.lblBonneRep.Name = "lblBonneRep";
            this.lblBonneRep.Size = new System.Drawing.Size(35, 13);
            this.lblBonneRep.TabIndex = 5;
            this.lblBonneRep.Text = "label1";
            // 
            // lnlBonneRepTitre
            // 
            this.lnlBonneRepTitre.AutoSize = true;
            this.lnlBonneRepTitre.Location = new System.Drawing.Point(17, 21);
            this.lnlBonneRepTitre.Name = "lnlBonneRepTitre";
            this.lnlBonneRepTitre.Size = new System.Drawing.Size(122, 13);
            this.lnlBonneRepTitre.TabIndex = 4;
            this.lnlBonneRepTitre.Text = "La bonne réponse était :";
            // 
            // btnQuestSuiv
            // 
            this.btnQuestSuiv.Location = new System.Drawing.Point(257, 412);
            this.btnQuestSuiv.Name = "btnQuestSuiv";
            this.btnQuestSuiv.Size = new System.Drawing.Size(196, 52);
            this.btnQuestSuiv.TabIndex = 5;
            this.btnQuestSuiv.Text = "question suivante";
            this.btnQuestSuiv.UseVisualStyleBackColor = true;
            this.btnQuestSuiv.Visible = false;
            this.btnQuestSuiv.Click += new System.EventHandler(this.btnQuestSuiv_Click);
            // 
            // lblNoRepChecked
            // 
            this.lblNoRepChecked.AutoSize = true;
            this.lblNoRepChecked.Location = new System.Drawing.Point(119, 258);
            this.lblNoRepChecked.Name = "lblNoRepChecked";
            this.lblNoRepChecked.Size = new System.Drawing.Size(237, 13);
            this.lblNoRepChecked.TabIndex = 6;
            this.lblNoRepChecked.Text = "Vous devez choisir une réponse avant de valider";
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 613);
            this.Controls.Add(this.lblNoRepChecked);
            this.Controls.Add(this.btnQuestSuiv);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.gpBoxReponse);
            this.Controls.Add(this.clbReponses);
            this.Controls.Add(this.lblTitreQuestion);
            this.Controls.Add(this.lblNumQuestion);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            this.gpBoxReponse.ResumeLayout(false);
            this.gpBoxReponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumQuestion;
        private System.Windows.Forms.Label lblTitreQuestion;
        private System.Windows.Forms.CheckedListBox clbReponses;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gpBoxReponse;
        private System.Windows.Forms.Button btnQuestSuiv;
        private System.Windows.Forms.Label lblBonneRep;
        private System.Windows.Forms.Label lnlBonneRepTitre;
        private System.Windows.Forms.Label lblNoRepChecked;
    }
}