namespace Exercice1
{
    partial class FormFinQuestion
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
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreNbre = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackColor = System.Drawing.Color.Teal;
            this.btnRecommencer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecommencer.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommencer.ForeColor = System.Drawing.Color.White;
            this.btnRecommencer.Location = new System.Drawing.Point(115, 371);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(210, 81);
            this.btnRecommencer.TabIndex = 0;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = false;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(175, 174);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(85, 18);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Votre score : ";
            // 
            // lblScoreNbre
            // 
            this.lblScoreNbre.AutoSize = true;
            this.lblScoreNbre.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNbre.Location = new System.Drawing.Point(195, 219);
            this.lblScoreNbre.Name = "lblScoreNbre";
            this.lblScoreNbre.Size = new System.Drawing.Size(130, 26);
            this.lblScoreNbre.TabIndex = 2;
            this.lblScoreNbre.Text = "lblScoreNbre";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.Location = new System.Drawing.Point(112, 280);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(43, 18);
            this.lblCommentaire.TabIndex = 3;
            this.lblCommentaire.Text = "label1";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.BackColor = System.Drawing.Color.Teal;
            this.lblSousTitre.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.ForeColor = System.Drawing.Color.White;
            this.lblSousTitre.Location = new System.Drawing.Point(90, 82);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(274, 17);
            this.lblSousTitre.TabIndex = 5;
            this.lblSousTitre.Text = "Un résumé de ce que vous avez appris en cours";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Padding = new System.Windows.Forms.Padding(70, 50, 70, 50);
            this.lblTitre.Size = new System.Drawing.Size(470, 128);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Quizz sur l\'Intelligence Artificielle";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.LinkColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(436, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 20);
            this.btnExit.TabIndex = 16;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "X";
            this.btnExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExit_LinkClicked);
            // 
            // FormFinQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 491);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblScoreNbre);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRecommencer);
            this.Name = "FormFinQuestion";
            this.Text = "FormFinQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreNbre;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.LinkLabel btnExit;
    }
}