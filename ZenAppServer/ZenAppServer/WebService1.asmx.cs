using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Services;
namespace ZenAppServer
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["ZenAppConnectionString"].ConnectionString;
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

        [WebMethod]
        public Song GetRandomSong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM Songs WHERE AudioFilePath IS NOT NULL ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Song
                    {
                        Id = reader.GetInt32(0),
                        SongCountry = reader.GetString(1),
                        SongYear = reader.GetInt32(2),
                        SongArtist = reader.GetString(4),
                        SongName = reader.GetString(3),
                        SongLink = reader.GetString(5),
                        SongPath = reader.GetString(6)
                    };
                }
            }
            return null;
        }

        [WebMethod]
        public bool VerifyGuess(int Id, int guessedYear, string guessedCountry)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SongYear, SongCountry FROM Songs WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int actualYear = reader.GetInt32(0);
                    string actualCountry = reader.GetString(1);
                    return actualYear == guessedYear && actualCountry == guessedCountry;
                }
            }
            return false;
        }

        [WebMethod]
        public string GetHintYear(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SongYear FROM Songs WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                conn.Open();
                return cmd.ExecuteScalar().ToString();
            }
        }

        [WebMethod]
        public string GetHintCountry(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SongCountry FROM Songs WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
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
                string query = @"
MERGE LeaderBoard AS target
USING (SELECT @UserId AS UserId, @Points AS Points) AS source
ON (target.UserId = source.UserId)
WHEN MATCHED THEN 
    UPDATE SET Points = source.Points + target.Points
WHEN NOT MATCHED THEN 
    INSERT (UserId, Points) 
    VALUES (source.UserId, source.Points);
";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Points", points);
                cmd.Parameters.AddWithValue("@UserId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

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
                        SongYear = reader.GetInt32(2),
                        SongArtist = reader.GetString(3),
                        SongName = reader.GetString(4),
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
        public int SongYear { get; set; }
        public string SongArtist { get; set; }
        public string SongName { get; set; }
        public string SongLink { get; set; }
        public string SongPath { get; set; }
    }
}
