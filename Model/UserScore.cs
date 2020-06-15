using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstoppertje_App.Model
{
    public class UserScore
    {
        private bool won;
        private GameRole role;
        private int score;
        private User user;

        public UserScore(bool _won, GameRole _role, int _score, User _user)
        {
            won = _won;
            role = _role;
            score = _score;
            user = _user;
        }

        public int Score { get => score;}
        public bool Won { get => won; }
        public GameRole Role { get => role; }
        public User User { get => user;}
    }
}
