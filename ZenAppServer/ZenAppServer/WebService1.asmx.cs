using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Remoting.Messaging;

namespace ZenAppServer
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["ZenAppConnectionString"].ConnectionString;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string GetSongNameById(int songId)
        {
            string songName = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT SongName FROM Songs WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", songId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            songName = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                songName = "Error: " + ex.Message;
            }
            return songName;
        }

        [WebMethod]
        public List<(string userID, string points)> GetLeaderBoard()
        {
            string userID = "";
            string points = "";
            var data = new List<(string userID, string points)>();
            string sql = "SELECT [userId],[Points] FROM [dbo].[LeaderBoard] ORDER BY [Points] DESC;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try


                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    userID = reader["userId"].ToString();
                                    points = reader["Points"].ToString();


                                    data.Add((userID, points));
                                }
                            }
                        }
                    }
                }

                catch (Exception ex)
                {

                    userID = "Error: " + ex.Message;
                    points = "Error: " + ex.Message;
                }
            }
            return data;
        }


    
    [WebMethod]
    public void InsSuges(int songId)
    {


         using (SqlConnection connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string sql = "INSERT INTO [dbo].[Sugestions] ([Id],[SongCountry], [SongYear], [SongName], [SongArtist], [SongLink])" +
                                "SELECT [Id],[SongCountry], [SongYear], [SongName], [SongArtist], [SongLink] FROM [dbo].[Songs] " +
                                "WHERE [Id] = @Id;"; ;
             using (SqlCommand command = new SqlCommand(sql, connection))
             {
                 command.Parameters.AddWithValue("@Id", songId);
                 object result = command.ExecuteScalar();

             }
         }

        }
    }
}

