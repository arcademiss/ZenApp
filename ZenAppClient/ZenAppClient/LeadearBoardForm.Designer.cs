namespace ZenAppClient
{
    partial class LeadearBoardForm
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
            this.listLeaderboard = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listLeaderboard
            // 
            this.listLeaderboard.BackColor = System.Drawing.Color.Azure;
            this.listLeaderboard.FormattingEnabled = true;
            this.listLeaderboard.ItemHeight = 16;
            this.listLeaderboard.Location = new System.Drawing.Point(40, 44);
            this.listLeaderboard.Name = "listLeaderboard";
            this.listLeaderboard.Size = new System.Drawing.Size(418, 500);
            this.listLeaderboard.TabIndex = 0;
            // 
            // LeadearBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZenAppClient.Properties.Resources.hand_painted_watercolor_abstract_background_23_2148993785;
            this.ClientSize = new System.Drawing.Size(516, 566);
            this.Controls.Add(this.listLeaderboard);
            this.Name = "LeadearBoardForm";
            this.Text = "LeadearBoardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLeaderboard;
    }
}