using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstoppertje_App.Model
{
    public class GameRole
    {
        private int id;
        private string name;

        public GameRole(int _id, string _name)
        {
            id = _id;
            name = _name;
        }

        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
    }
}
