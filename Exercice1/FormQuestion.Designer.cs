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
            this.SuspendLayout();
            // 
            // lblNumQuestion
            // 
            this.lblNumQuestion.AutoSize = true;
            this.lblNumQuestion.Location = new System.Drawing.Point(90, 92);
            this.lblNumQuestion.Name = "lblNumQuestion";
            this.lblNumQuestion.Size = new System.Drawing.Size(69, 13);
            this.lblNumQuestion.TabIndex = 0;
            this.lblNumQuestion.Text = "numQuestion";
            // 
            // lblTitreQuestion
            // 
            this.lblTitreQuestion.AutoSize = true;
            this.lblTitreQuestion.Location = new System.Drawing.Point(189, 92);
            this.lblTitreQuestion.Name = "lblTitreQuestion";
            this.lblTitreQuestion.Size = new System.Drawing.Size(66, 13);
            this.lblTitreQuestion.TabIndex = 1;
            this.lblTitreQuestion.Text = "titreQuestion";
            // 
            // clbReponses
            // 
            this.clbReponses.FormattingEnabled = true;
            this.clbReponses.Location = new System.Drawing.Point(76, 197);
            this.clbReponses.Name = "clbReponses";
            this.clbReponses.Size = new System.Drawing.Size(216, 184);
            this.clbReponses.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(212, 422);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gpBoxReponse
            // 
            this.gpBoxReponse.Location = new System.Drawing.Point(341, 197);
            this.gpBoxReponse.Name = "gpBoxReponse";
            this.gpBoxReponse.Size = new System.Drawing.Size(108, 184);
            this.gpBoxReponse.TabIndex = 4;
            this.gpBoxReponse.TabStop = false;
            this.gpBoxReponse.Text = "groupBox1";
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 476);
            this.Controls.Add(this.gpBoxReponse);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.clbReponses);
            this.Controls.Add(this.lblTitreQuestion);
            this.Controls.Add(this.lblNumQuestion);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumQuestion;
        private System.Windows.Forms.Label lblTitreQuestion;
        private System.Windows.Forms.CheckedListBox clbReponses;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gpBoxReponse;
    }
}