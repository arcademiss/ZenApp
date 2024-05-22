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

            //string connectionString = "your_connection_string_here"; // Update with your connection string

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


            /*using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Songs (SongCountry, SongYear, SongName, SongArtist, SongLink) VALUES (@SongCountry, @SongYear, @SongName, @SongArtist, @SongLink)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SongCountry", textBox_Country.Text);
                        cmd.Parameters.AddWithValue("@SongYear", textBox_Year.Text);
                        cmd.Parameters.AddWithValue("@SongName", textBox_Song_Name.Text);
                        cmd.Parameters.AddWithValue("@SongArtist", textBox_Artist.Text);
                        cmd.Parameters.AddWithValue("@SongLink", textBox_Link.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved to database successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }*/
            }

        private void SubmitForm_Load(object sender, EventArgs e)
        {

        }

    }
    
}
