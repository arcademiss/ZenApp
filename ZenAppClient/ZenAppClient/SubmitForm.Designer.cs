﻿namespace ZenAppClient
{
    partial class SubmitForm
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
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.textBox_Artist = new System.Windows.Forms.TextBox();
            this.textBox_Link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Song_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(96, 351);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(99, 38);
            this.button_Submit.TabIndex = 0;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(95, 145);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(348, 22);
            this.textBox_Country.TabIndex = 1;
            this.textBox_Country.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(96, 176);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(348, 22);
            this.textBox_Year.TabIndex = 2;
            // 
            // textBox_Artist
            // 
            this.textBox_Artist.Location = new System.Drawing.Point(96, 245);
            this.textBox_Artist.Name = "textBox_Artist";
            this.textBox_Artist.Size = new System.Drawing.Size(348, 22);
            this.textBox_Artist.TabIndex = 3;
            // 
            // textBox_Link
            // 
            this.textBox_Link.Location = new System.Drawing.Point(96, 282);
            this.textBox_Link.Name = "textBox_Link";
            this.textBox_Link.Size = new System.Drawing.Size(348, 22);
            this.textBox_Link.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Artist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Link";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 55);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Give us ideas!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "if you want to, of course, no pressure";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZenAppClient.Properties.Resources.easter_egg;
            this.pictureBox1.Location = new System.Drawing.Point(354, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Message
            // 
            this.textBox_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Message.Location = new System.Drawing.Point(95, 323);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(349, 15);
            this.textBox_Message.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Song Name";
            // 
            // textBox_Song_Name
            // 
            this.textBox_Song_Name.Location = new System.Drawing.Point(96, 211);
            this.textBox_Song_Name.Name = "textBox_Song_Name";
            this.textBox_Song_Name.Size = new System.Drawing.Size(348, 22);
            this.textBox_Song_Name.TabIndex = 14;
            // 
            // SubmitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZenAppClient.Properties.Resources.hand_painted_watercolor_abstract_background_23_2148993785;
            this.ClientSize = new System.Drawing.Size(479, 419);
            this.Controls.Add(this.textBox_Song_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Link);
            this.Controls.Add(this.textBox_Artist);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.button_Submit);
            this.Name = "SubmitForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_Artist;
        private System.Windows.Forms.TextBox textBox_Link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Song_Name;
    }
}