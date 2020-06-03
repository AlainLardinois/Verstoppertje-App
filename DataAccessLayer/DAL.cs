using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verstoppertje_App.Model;
using System.Data.SqlClient;

namespace Verstoppertje_App.DataAccessLayer
{
    class DAL
    {
        string connectionString = "Data Source=db.ipictserver.nl;Initial Catalog=verstoppertje_app;Persist Security Info=True;User ID=verstoppertje;Password=r6MXpr4Qm74b";
        public List<User> users = new List<User>();
        public List<UserScore> scores = new List<UserScore>();
        public List<UserType> types = new List<UserType>();
        public List<GameRole> roles = new List<GameRole>();

        public void GetData()
        {
            users.Clear();
            scores.Clear();
            string user_query = "SELECT * FROM game_user";
            string type_query = "SELECT * FROM user_type";
            string role_query = "SELECT * FROM game_role";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlDataReader reader;
                SqlCommand cmd;
                // Get user types
                cmd = new SqlCommand(type_query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserType tempType = new UserType(reader.GetInt32(0), reader.GetString(1));
                    types.Add(tempType);
                }
                // Get game roles
                cmd = new SqlCommand(role_query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GameRole tempRole = new GameRole(reader.GetInt32(0), reader.GetString(1));
                    roles.Add(tempRole);
                }
                // Get users
                cmd = new SqlCommand(user_query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    string nickname = reader.GetString(1);
                    string firstname = reader.GetString(2);
                    string lastname = reader.GetString(3);
                    UserType type = types.Find(i => i.Id == reader.GetInt32(4));
                    string password = reader.GetString(5);
                    string email = reader.GetString(6);
                    User tempUser = new User(ID, nickname, firstname, lastname, type, email, password);

                    // Get scores
                    string score_query = "SELECT * FROM user_score WHERE user_id = " + ID.ToString();
                    SqlCommand score_cmd = new SqlCommand(score_query, conn);
                    SqlDataReader score_reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int scoreID = reader.GetInt32(0);
                        bool won = reader.GetBoolean(1);
                        GameRole role = roles.Find(i => i.Id == reader.GetInt32(2));
                        int score = reader.GetInt32(3);
                        UserScore tempScore = new UserScore(won, role, score, tempUser);
                        scores.Add(tempScore);

                        // Add data to user object
                        if (won)
                        {
                            tempUser.Wins = tempUser.Wins += 1;
                        }
                        else
                        {
                            tempUser.Losses = tempUser.Losses += 1;
                        }
                        tempUser.Score += score;
                    }
                    users.Add(tempUser);
                }
            }
        }

        public int SaveScore(UserScore score)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string query = "INSERT INTO user_score (won, role, score, user_id) VALUES (@won, @role, @score, @user_id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@won", score.Won);
                cmd.Parameters.AddWithValue("@role", score.Role.Id);
                cmd.Parameters.AddWithValue("@score", score.Score);
                cmd.Parameters.AddWithValue("@user_id", score.User.Id);
                int rows = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return rows;
            }
        }

        public int SaveUser(User user)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string query = "INSERT INTO game_user (nick_name, first_name, last_name, type, password, email) VALUES (@nickname, @firstname, @lastname, @type, @password, @email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nickname", user.Nickname);
                cmd.Parameters.AddWithValue("@firstname", user.First_name);
                cmd.Parameters.AddWithValue("@lastname", user.Last_name);
                cmd.Parameters.AddWithValue("@type", user.Type.Id);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                int rows = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return rows;
            }
        }

        public int Delete(string table, int ID)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string query = "DELETE FROM " + table + " WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                int rows = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return rows;
            }
        }
    }
}
