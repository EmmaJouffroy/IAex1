namespace Exercice1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnQuestions = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.lblExplications = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnQuestions
            // 
            this.btnQuestions.BackColor = System.Drawing.Color.Teal;
            this.btnQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestions.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestions.ForeColor = System.Drawing.Color.White;
            this.btnQuestions.Location = new System.Drawing.Point(40, 429);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(173, 77);
            this.btnQuestions.TabIndex = 0;
            this.btnQuestions.Text = "Questions";
            this.btnQuestions.UseVisualStyleBackColor = false;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(2, 1);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Padding = new System.Windows.Forms.Padding(70, 50, 70, 50);
            this.lblTitre.Size = new System.Drawing.Size(470, 128);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Quizz sur l\'Intelligence Artificielle";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.BackColor = System.Drawing.Color.Teal;
            this.lblSousTitre.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.ForeColor = System.Drawing.Color.White;
            this.lblSousTitre.Location = new System.Drawing.Point(92, 83);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(274, 17);
            this.lblSousTitre.TabIndex = 2;
            this.lblSousTitre.Text = "Un résumé de ce que vous avez appris en cours";
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.BackColor = System.Drawing.Color.Teal;
            this.btnDijkstra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDijkstra.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDijkstra.ForeColor = System.Drawing.Color.White;
            this.btnDijkstra.Location = new System.Drawing.Point(254, 429);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(173, 77);
            this.btnDijkstra.TabIndex = 3;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = false;
            // 
            // lblExplications
            // 
            this.lblExplications.AutoSize = true;
            this.lblExplications.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplications.Location = new System.Drawing.Point(12, 181);
            this.lblExplications.MaximumSize = new System.Drawing.Size(450, 505);
            this.lblExplications.Name = "lblExplications";
            this.lblExplications.Size = new System.Drawing.Size(450, 180);
            this.lblExplications.TabIndex = 4;
            this.lblExplications.Text = resources.GetString("lblExplications.Text");
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.LinkColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(431, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 20);
            this.btnExit.TabIndex = 15;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "X";
            this.btnExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExit_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 550);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblExplications);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuestions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Label lblExplications;
        private System.Windows.Forms.LinkLabel btnExit;
    }
}

