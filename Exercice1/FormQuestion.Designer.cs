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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestion));
            this.lblNumQuestion = new System.Windows.Forms.Label();
            this.lblTitreQuestion = new System.Windows.Forms.Label();
            this.clbReponses = new System.Windows.Forms.CheckedListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.gpBoxReponse = new System.Windows.Forms.GroupBox();
            this.lblBonneRep = new System.Windows.Forms.Label();
            this.lnlBonneRepTitre = new System.Windows.Forms.Label();
            this.btnQuestSuiv = new System.Windows.Forms.Button();
            this.lblNoRepChecked = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.lblNumQuestTxt = new System.Windows.Forms.Label();
            this.pbQuest = new System.Windows.Forms.ProgressBar();
            this.lblTitre = new System.Windows.Forms.Label();
            this.gpBoxReponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumQuestion
            // 
            this.lblNumQuestion.AutoSize = true;
            this.lblNumQuestion.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestion.Location = new System.Drawing.Point(175, 141);
            this.lblNumQuestion.Name = "lblNumQuestion";
            this.lblNumQuestion.Size = new System.Drawing.Size(115, 22);
            this.lblNumQuestion.TabIndex = 0;
            this.lblNumQuestion.Text = "numQuestion";
            // 
            // lblTitreQuestion
            // 
            this.lblTitreQuestion.AutoSize = true;
            this.lblTitreQuestion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreQuestion.Location = new System.Drawing.Point(35, 173);
            this.lblTitreQuestion.MaximumSize = new System.Drawing.Size(550, 100);
            this.lblTitreQuestion.Name = "lblTitreQuestion";
            this.lblTitreQuestion.Size = new System.Drawing.Size(546, 100);
            this.lblTitreQuestion.TabIndex = 1;
            this.lblTitreQuestion.Text = resources.GetString("lblTitreQuestion.Text");
            this.lblTitreQuestion.Click += new System.EventHandler(this.lblTitreQuestion_Click);
            // 
            // clbReponses
            // 
            this.clbReponses.BackColor = System.Drawing.SystemColors.HighlightText;
            this.clbReponses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbReponses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbReponses.FormattingEnabled = true;
            this.clbReponses.HorizontalScrollbar = true;
            this.clbReponses.Location = new System.Drawing.Point(33, 512);
            this.clbReponses.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.clbReponses.Name = "clbReponses";
            this.clbReponses.Size = new System.Drawing.Size(555, 121);
            this.clbReponses.TabIndex = 2;
            this.clbReponses.ThreeDCheckBoxes = true;
            this.clbReponses.UseCompatibleTextRendering = true;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Teal;
            this.btnValider.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(189, 769);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(191, 69);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gpBoxReponse
            // 
            this.gpBoxReponse.Controls.Add(this.lblBonneRep);
            this.gpBoxReponse.Controls.Add(this.lnlBonneRepTitre);
            this.gpBoxReponse.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxReponse.Location = new System.Drawing.Point(33, 648);
            this.gpBoxReponse.Name = "gpBoxReponse";
            this.gpBoxReponse.Size = new System.Drawing.Size(555, 101);
            this.gpBoxReponse.TabIndex = 4;
            this.gpBoxReponse.TabStop = false;
            this.gpBoxReponse.Text = "Réponses";
            this.gpBoxReponse.Visible = false;
            // 
            // lblBonneRep
            // 
            this.lblBonneRep.AutoSize = true;
            this.lblBonneRep.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonneRep.Location = new System.Drawing.Point(20, 44);
            this.lblBonneRep.MaximumSize = new System.Drawing.Size(420, 50);
            this.lblBonneRep.Name = "lblBonneRep";
            this.lblBonneRep.Size = new System.Drawing.Size(43, 18);
            this.lblBonneRep.TabIndex = 5;
            this.lblBonneRep.Text = "label1";
            // 
            // lnlBonneRepTitre
            // 
            this.lnlBonneRepTitre.AutoSize = true;
            this.lnlBonneRepTitre.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlBonneRepTitre.Location = new System.Drawing.Point(17, 21);
            this.lnlBonneRepTitre.Name = "lnlBonneRepTitre";
            this.lnlBonneRepTitre.Size = new System.Drawing.Size(175, 20);
            this.lnlBonneRepTitre.TabIndex = 4;
            this.lnlBonneRepTitre.Text = "La bonne réponse était :";
            // 
            // btnQuestSuiv
            // 
            this.btnQuestSuiv.BackColor = System.Drawing.Color.Teal;
            this.btnQuestSuiv.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestSuiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuestSuiv.Location = new System.Drawing.Point(189, 769);
            this.btnQuestSuiv.Name = "btnQuestSuiv";
            this.btnQuestSuiv.Size = new System.Drawing.Size(191, 69);
            this.btnQuestSuiv.TabIndex = 5;
            this.btnQuestSuiv.Text = "question suivante";
            this.btnQuestSuiv.UseVisualStyleBackColor = false;
            this.btnQuestSuiv.Visible = false;
            this.btnQuestSuiv.Click += new System.EventHandler(this.btnQuestSuiv_Click);
            // 
            // lblNoRepChecked
            // 
            this.lblNoRepChecked.AutoSize = true;
            this.lblNoRepChecked.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRepChecked.Location = new System.Drawing.Point(162, 621);
            this.lblNoRepChecked.Name = "lblNoRepChecked";
            this.lblNoRepChecked.Size = new System.Drawing.Size(341, 20);
            this.lblNoRepChecked.TabIndex = 6;
            this.lblNoRepChecked.Text = "Vous devez choisir une réponse avant de valider";
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Teal;
            this.btnResult.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResult.Location = new System.Drawing.Point(189, 755);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(191, 69);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Voir Résultat";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(33, 237);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(555, 269);
            this.photo.TabIndex = 8;
            this.photo.TabStop = false;
            // 
            // lblNumQuestTxt
            // 
            this.lblNumQuestTxt.AutoSize = true;
            this.lblNumQuestTxt.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestTxt.Location = new System.Drawing.Point(30, 141);
            this.lblNumQuestTxt.Name = "lblNumQuestTxt";
            this.lblNumQuestTxt.Size = new System.Drawing.Size(153, 22);
            this.lblNumQuestTxt.TabIndex = 9;
            this.lblNumQuestTxt.Text = "Question numéro :";
            // 
            // pbQuest
            // 
            this.pbQuest.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbQuest.ForeColor = System.Drawing.Color.White;
            this.pbQuest.Location = new System.Drawing.Point(439, 141);
            this.pbQuest.Maximum = 20;
            this.pbQuest.Name = "pbQuest";
            this.pbQuest.Size = new System.Drawing.Size(165, 16);
            this.pbQuest.TabIndex = 10;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(0, -2);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Padding = new System.Windows.Forms.Padding(150, 50, 150, 50);
            this.lblTitre.Size = new System.Drawing.Size(630, 128);
            this.lblTitre.TabIndex = 11;
            this.lblTitre.Text = "Quizz sur l\'Intelligence Artificielle";
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 846);
            this.Controls.Add(this.pbQuest);
            this.Controls.Add(this.lblNumQuestTxt);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblNoRepChecked);
            this.Controls.Add(this.btnQuestSuiv);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.gpBoxReponse);
            this.Controls.Add(this.clbReponses);
            this.Controls.Add(this.lblTitreQuestion);
            this.Controls.Add(this.lblNumQuestion);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            this.gpBoxReponse.ResumeLayout(false);
            this.gpBoxReponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
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
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label lblNumQuestTxt;
        private System.Windows.Forms.ProgressBar pbQuest;
        private System.Windows.Forms.Label lblTitre;
    }
}