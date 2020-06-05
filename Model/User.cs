using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Verstoppertje_App.Model
{
    public class User
    {
        private int id;
        private string nickname;
        private string first_name;
        private string last_name;
        private int wins;
        private int losses;
        private int score;
        private string email;
        private string password;
        private UserType type;

        public User(int _id, string _nickname, string _first_name, string _last_name, UserType _type, string _email, string _password)
        {
            id = _id;
            nickname = _nickname;
            first_name = _first_name;
            last_name = _last_name;
            type = _type;
            email = _email;
            password = _password;
        }

        public int Id { get => id; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public UserType Type { get => type; set => type = value; }
        public int Wins { get => wins; set => wins = value; }
        public int Losses { get => losses; set => losses = value; }
        public int Score { get => score; set => score = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; }

        public void SetPassword(string _password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(_password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            password = Convert.ToBase64String(hashBytes);
        }

        public void VerifyPassword(string _password)
        {
            byte[] hashBytes = Convert.FromBase64String(password);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(_password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i=0; i < 20; i++)
            {
                if (hashBytes[i+16] != hash[i])
                {
                    throw new UnauthorizedAccessException();
                }
            }
        }
    }
}
