using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verstoppertje_App.Model;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Verstoppertje_App.DataAccessLayer
{
    public class DAL
    {
        string connectionString = "Data Source=db.ipictserver.nl;Initial Catalog=verstoppertje_app;Persist Security Info=True;User ID=verstoppertje;Password=r6MXpr4Qm74b;MultipleActiveResultSets=true";
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
                reader.Close();
                cmd.Dispose();
                // Get game roles
                cmd = new SqlCommand(role_query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GameRole tempRole = new GameRole(reader.GetInt32(0), reader.GetString(1));
                    roles.Add(tempRole);
                }
                reader.Close();
                cmd.Dispose();
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

                    /*
                    // Get scores
                    string score_query = "SELECT * FROM user_score WHERE user_id = " + ID.ToString();
                    SqlCommand score_cmd = new SqlCommand(score_query, conn);
                    SqlDataReader score_reader = score_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int scoreID = Convert.ToInt32(reader["ID"]);
                        bool won = Convert.ToBoolean(reader["won"]);
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
                    score_reader.Close();
                    score_cmd.Dispose();
                    */
                    users.Add(tempUser);
                }
                reader.Close();
                cmd.Dispose();
            }
        }

        public int SaveScore(bool _won, GameRole _role, int _score, User _user)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string query = "INSERT INTO user_score (won, role, score, user_id) VALUES (@won, @role, @score, @user_id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@won", _won);
                cmd.Parameters.AddWithValue("@role", _role.Id);
                cmd.Parameters.AddWithValue("@score", _score);
                cmd.Parameters.AddWithValue("@user_id", _user.Id);
                int rows = cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.GetData();
                return rows;
            }
        }

        public int SaveUser(string _nickname, string _firstname, string _lastname, UserType _type, string _password, string _email)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string query = "INSERT INTO game_user (nick_name, first_name, last_name, type, password, email) VALUES (@nickname, @firstname, @lastname, @type, @password, @email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nickname", _nickname);
                cmd.Parameters.AddWithValue("@firstname", _firstname);
                cmd.Parameters.AddWithValue("@lastname", _lastname);
                cmd.Parameters.AddWithValue("@type", _type.Id);
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var pbkdf2 = new Rfc2898DeriveBytes(_password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                cmd.Parameters.AddWithValue("@password", Convert.ToBase64String(hashBytes));
                cmd.Parameters.AddWithValue("@email", _email);
                int rows = cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.GetData();
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
