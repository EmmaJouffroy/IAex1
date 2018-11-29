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
            this.lblFermesFinaux = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArbreFinal = new System.Windows.Forms.Label();
            this.lbFermesFinaux = new System.Windows.Forms.ListBox();
            this.lbOuvertsFinaux = new System.Windows.Forms.ListBox();
            this.lkExoQuestions = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewFinal = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxRepOuverts = new System.Windows.Forms.ListBox();
            this.listBoxRepFermes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelReponse = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(-2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Padding = new System.Windows.Forms.Padding(150, 50, 150, 50);
            this.lblTitre.Size = new System.Drawing.Size(626, 125);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "Quizz sur l\'Intelligence Artificielle";
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackColor = System.Drawing.Color.Teal;
            this.btnRecommencer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecommencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommencer.ForeColor = System.Drawing.Color.White;
            this.btnRecommencer.Location = new System.Drawing.Point(197, 635);
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
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.LinkColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(598, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "X";
            this.btnExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Correction :";
            // 
            // lblFermesFinaux
            // 
            this.lblFermesFinaux.AutoSize = true;
            this.lblFermesFinaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermesFinaux.Location = new System.Drawing.Point(37, 65);
            this.lblFermesFinaux.Name = "lblFermesFinaux";
            this.lblFermesFinaux.Size = new System.Drawing.Size(112, 16);
            this.lblFermesFinaux.TabIndex = 22;
            this.lblFermesFinaux.Text = "Fermés finaux :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ouverts finaux : ";
            // 
            // lblArbreFinal
            // 
            this.lblArbreFinal.AutoSize = true;
            this.lblArbreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbreFinal.Location = new System.Drawing.Point(426, 65);
            this.lblArbreFinal.Name = "lblArbreFinal";
            this.lblArbreFinal.Size = new System.Drawing.Size(87, 16);
            this.lblArbreFinal.TabIndex = 24;
            this.lblArbreFinal.Text = "Arbre final :";
            // 
            // lbFermesFinaux
            // 
            this.lbFermesFinaux.FormattingEnabled = true;
            this.lbFermesFinaux.Location = new System.Drawing.Point(29, 84);
            this.lbFermesFinaux.Name = "lbFermesFinaux";
            this.lbFermesFinaux.Size = new System.Drawing.Size(120, 147);
            this.lbFermesFinaux.TabIndex = 25;
            // 
            // lbOuvertsFinaux
            // 
            this.lbOuvertsFinaux.ForeColor = System.Drawing.Color.Black;
            this.lbOuvertsFinaux.FormattingEnabled = true;
            this.lbOuvertsFinaux.Location = new System.Drawing.Point(211, 84);
            this.lbOuvertsFinaux.Name = "lbOuvertsFinaux";
            this.lbOuvertsFinaux.Size = new System.Drawing.Size(120, 147);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewFinal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFermesFinaux);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbOuvertsFinaux);
            this.groupBox1.Controls.Add(this.lblArbreFinal);
            this.groupBox1.Controls.Add(this.lbFermesFinaux);
            this.groupBox1.Location = new System.Drawing.Point(26, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 234);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // treeViewFinal
            // 
            this.treeViewFinal.Location = new System.Drawing.Point(398, 84);
            this.treeViewFinal.Name = "treeViewFinal";
            this.treeViewFinal.Size = new System.Drawing.Size(127, 144);
            this.treeViewFinal.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelReponse);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBoxRepOuverts);
            this.groupBox2.Controls.Add(this.listBoxRepFermes);
            this.groupBox2.Location = new System.Drawing.Point(26, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 227);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Votre réponse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fermés finaux :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ouverts finaux : ";
            // 
            // listBoxRepOuverts
            // 
            this.listBoxRepOuverts.FormattingEnabled = true;
            this.listBoxRepOuverts.Location = new System.Drawing.Point(211, 74);
            this.listBoxRepOuverts.Name = "listBoxRepOuverts";
            this.listBoxRepOuverts.Size = new System.Drawing.Size(120, 147);
            this.listBoxRepOuverts.TabIndex = 26;
            // 
            // listBoxRepFermes
            // 
            this.listBoxRepFermes.FormattingEnabled = true;
            this.listBoxRepFermes.Location = new System.Drawing.Point(31, 74);
            this.listBoxRepFermes.Name = "listBoxRepFermes";
            this.listBoxRepFermes.Size = new System.Drawing.Size(118, 147);
            this.listBoxRepFermes.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Arbre final :";
            // 
            // labelReponse
            // 
            this.labelReponse.AutoSize = true;
            this.labelReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReponse.Location = new System.Drawing.Point(437, 87);
            this.labelReponse.Name = "labelReponse";
            this.labelReponse.Size = new System.Drawing.Size(51, 20);
            this.labelReponse.TabIndex = 29;
            this.labelReponse.Text = "label8";
            // 
            // FormFinDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 728);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lkExoQuestions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormFinDijkstra";
            this.Text = "FormFinDijkstra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.LinkLabel btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFermesFinaux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArbreFinal;
        private System.Windows.Forms.ListBox lbFermesFinaux;
        private System.Windows.Forms.ListBox lbOuvertsFinaux;
        private System.Windows.Forms.LinkLabel lkExoQuestions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxRepOuverts;
        private System.Windows.Forms.ListBox listBoxRepFermes;
        private System.Windows.Forms.TreeView treeViewFinal;
        private System.Windows.Forms.Label labelReponse;
        private System.Windows.Forms.Label label3;
    }
}