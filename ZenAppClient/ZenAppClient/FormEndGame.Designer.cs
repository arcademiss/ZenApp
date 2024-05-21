namespace ZenAppClient
{
    partial class FormEndGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelZenScorestatic = new System.Windows.Forms.Label();
            this.labelZenScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSubmitScore = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game over!";
            // 
            // labelZenScorestatic
            // 
            this.labelZenScorestatic.AutoSize = true;
            this.labelZenScorestatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZenScorestatic.Location = new System.Drawing.Point(251, 105);
            this.labelZenScorestatic.Name = "labelZenScorestatic";
            this.labelZenScorestatic.Size = new System.Drawing.Size(294, 42);
            this.labelZenScorestatic.TabIndex = 1;
            this.labelZenScorestatic.Text = "Your ZenScore:";
            // 
            // labelZenScore
            // 
            this.labelZenScore.AutoSize = true;
            this.labelZenScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZenScore.Location = new System.Drawing.Point(367, 171);
            this.labelZenScore.Name = "labelZenScore";
            this.labelZenScore.Size = new System.Drawing.Size(0, 42);
            this.labelZenScore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input your name so you can go down in history as the \"best\" song guesser ever:";
            // 
            // buttonSubmitScore
            // 
            this.buttonSubmitScore.Location = new System.Drawing.Point(344, 400);
            this.buttonSubmitScore.Name = "buttonSubmitScore";
            this.buttonSubmitScore.Size = new System.Drawing.Size(95, 38);
            this.buttonSubmitScore.TabIndex = 4;
            this.buttonSubmitScore.Text = "Submit";
            this.buttonSubmitScore.UseVisualStyleBackColor = true;
            this.buttonSubmitScore.Click += new System.EventHandler(this.buttonSubmitScore_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(319, 335);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(141, 22);
            this.textUsername.TabIndex = 5;
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZenAppClient.Properties.Resources.hand_painted_watercolor_abstract_background_23_2148993785;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.buttonSubmitScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelZenScore);
            this.Controls.Add(this.labelZenScorestatic);
            this.Controls.Add(this.label1);
            this.Name = "FormEndGame";
            this.Text = "Game Over!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelZenScorestatic;
        private System.Windows.Forms.Label labelZenScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSubmitScore;
        private System.Windows.Forms.TextBox textUsername;
    }
}