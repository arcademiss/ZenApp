using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Services;
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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }



        public string connectionString = ConfigurationManager.ConnectionStrings["ZenAppConnectionString"].ConnectionString;

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
                // Handle exceptions, e.g., log or return error message
                songName = "Error: " + ex.Message;
            }
            return songName;
        }
    }
}
