using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDAOProject.Entity
{
   public class Etudiant 
    {

        int _id;
        string _name;
        string _prenom;

        public Etudiant(int id, string name, string prenom)
        {
            _id = id;
            _name = name;
            _prenom = prenom;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
    }
}
