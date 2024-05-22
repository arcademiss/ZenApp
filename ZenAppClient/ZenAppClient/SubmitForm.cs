using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ZenAppClient
{
    public partial class SubmitForm : Form
    {
        public SubmitForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {

            

            //in the case that one of the textboxes is empty
            if (string.IsNullOrWhiteSpace(textBox_Country.Text) || 
                string.IsNullOrWhiteSpace(textBox_Year.Text) ||
                string.IsNullOrWhiteSpace(textBox_Song_Name.Text) ||
                string.IsNullOrWhiteSpace(textBox_Artist.Text) ||
                string.IsNullOrWhiteSpace(textBox_Link.Text))
            {
            //this textbox doesn't have boareders, its in the middle of the submit button and the Link textbox
                textBox_Message.Text = "Please fill up all the spaces";
                return;
            };

            //it verifies if the text from the texBox_Year is an integer
            if(!int.TryParse(textBox_Year.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }


            
            }

        private void SubmitForm_Load(object sender, EventArgs e)
        {

        }

    }
    
}
