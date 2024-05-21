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
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZenAppClient.Properties.Resources.hand_painted_watercolor_abstract_background_23_2148993785;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}