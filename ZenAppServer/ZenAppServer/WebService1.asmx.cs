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
        public string connectionString = ConfigurationManager.ConnectionStrings["ZenAppConnectionString"].ConnectionString;

        [WebMethod]
        public Song GetRandomSong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM Songs ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Song
                    {
                        Id = reader.GetInt32(0),
                        SongCountry = reader.GetString(1),
                        SongYear = reader.GetString(2),
                        SongName = reader.GetString(3),
                        SongArtist = reader.GetString(4),
                        SongLink = reader.GetString(5)
                    };
                }
            }
            return null;
        }

        [WebMethod]
        public bool VerifyGuess(int songId, string guessedYear, string guessedCountry)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SongYear, SongCountry FROM Songs WHERE Id = @SongId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SongId", songId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string actualYear = reader.GetString(0);
                    string actualCountry = reader.GetString(1);
                    return actualYear == guessedYear && actualCountry == guessedCountry;
                }
            }
            return false;
        }

        [WebMethod]
        public string GetHintYear(int songId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SongYear FROM Songs WHERE Id = @SongId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SongId", songId);
                conn.Open();
                return cmd.ExecuteScalar().ToString();
            }
        }

        [WebMethod]
        public string GetHintCountry(int songId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SongCountry FROM Songs WHERE Id = @SongId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SongId", songId);
                conn.Open();
                return cmd.ExecuteScalar().ToString();
            }
        }

        [WebMethod]
        public string GetRandomAnswer(bool isCorrect)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Answer FROM Answers WHERE Correct = @IsCorrect ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IsCorrect", isCorrect ? 1 : 0);
                conn.Open();
                return cmd.ExecuteScalar().ToString();
            }
        }

        [WebMethod]
        public void UpdatePoints(string userId, int points)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Points = Points + @Points WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Points", points);
                cmd.Parameters.AddWithValue("@UserId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public List<Song> StartNewRound()
        {
            List<Song> songs = new List<Song>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 3 * FROM Songs ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    songs.Add(new Song
                    {
                        Id = reader.GetInt32(0),
                        SongCountry = reader.GetString(1),
                        SongYear = reader.GetString(2),
                        SongName = reader.GetString(3),
                        SongArtist = reader.GetString(4),
                        SongLink = reader.GetString(5)
                    });
                }
            }
            return songs;
        }
    }

    public class Song
    {
        public int Id { get; set; }
        public string SongCountry { get; set; }
        public string SongYear { get; set; }
        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public string SongLink { get; set; }
    }
}
