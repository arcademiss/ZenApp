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
            this.listLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLeaderboard.FormattingEnabled = true;
            this.listLeaderboard.ItemHeight = 20;
            this.listLeaderboard.Location = new System.Drawing.Point(30, 36);
            this.listLeaderboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listLeaderboard.Name = "listLeaderboard";
            this.listLeaderboard.Size = new System.Drawing.Size(314, 404);
            this.listLeaderboard.TabIndex = 0;
            // 
            // LeadearBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZenAppClient.Properties.Resources.hand_painted_watercolor_abstract_background_23_2148993785;
            this.ClientSize = new System.Drawing.Size(387, 460);
            this.Controls.Add(this.listLeaderboard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LeadearBoardForm";
            this.Text = "LeadearBoardForm";
            this.Load += new System.EventHandler(this.LeadearBoardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLeaderboard;
    }
}