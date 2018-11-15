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
            this.SuspendLayout();
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(247, 345);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(210, 81);
            this.btnRecommencer.TabIndex = 0;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(299, 101);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Votre score : ";
            // 
            // lblScoreNbre
            // 
            this.lblScoreNbre.AutoSize = true;
            this.lblScoreNbre.Location = new System.Drawing.Point(264, 188);
            this.lblScoreNbre.Name = "lblScoreNbre";
            this.lblScoreNbre.Size = new System.Drawing.Size(68, 13);
            this.lblScoreNbre.TabIndex = 2;
            this.lblScoreNbre.Text = "lblScoreNbre";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(296, 232);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(35, 13);
            this.lblCommentaire.TabIndex = 3;
            this.lblCommentaire.Text = "label1";
            // 
            // FormFinQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 491);
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
    }
}