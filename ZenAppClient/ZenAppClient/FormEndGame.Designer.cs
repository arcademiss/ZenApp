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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndGame));
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelZenPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(323, 89);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(127, 16);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Better luck next time!";
            // 
            // labelZenPoints
            // 
            this.labelZenPoints.AutoSize = true;
            this.labelZenPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZenPoints.Location = new System.Drawing.Point(181, 269);
            this.labelZenPoints.Name = "labelZenPoints";
            this.labelZenPoints.Size = new System.Drawing.Size(389, 39);
            this.labelZenPoints.TabIndex = 1;
            this.labelZenPoints.Text = "Your ZenPoints Score: ";
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelZenPoints);
            this.Controls.Add(this.labelMessage);
            this.Name = "FormEndGame";
            this.Text = "Game Over!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelZenPoints;
    }
}