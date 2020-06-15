using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verstoppertje_App.DataAccessLayer;
using Verstoppertje_App.Model;

namespace Verstoppertje_App.Model
{
    public partial class LeaderBoardForm : Form
    {
        private DAL dal = new DAL();
        public LeaderBoardForm()
        {
            InitializeComponent();
            dal.GetData();
            foreach (var user in dal.users)
            {
                List<UserScore> scores = dal.scores.FindAll(i => i.User.Id == user.Id);
                int wins = 0;
                int losses = 0;
                int totalScore = 0;
                foreach (var score in scores)
                {
                    if (score.Won)
                    {
                        wins += 1;
                    }
                    else
                    {
                        losses += 1;
                    }
                    totalScore += score.Score;
                }
                this.leaderBoard.Rows.Add(user.Nickname, wins, losses, totalScore);
            }
            this.leaderBoard.Sort(this.leaderBoard.Columns[3], ListSortDirection.Descending);
        }
    }
}
