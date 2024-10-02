using SharedDAOProject.Entity;
using SharedDAOProject.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOProject.AmpliEtudiant
{
public class IEtudiant : IDAOEtudiant
    {
        public IEtudiant() { }
           
        bool IDAOEtudiant.Ajouter(Etudiant e)
        {
            throw new NotImplementedException();
        }

        public bool Modifer(Etudiant e)
        {
            throw new NotImplementedException();
        }

        bool IDAOEtudiant.Supprimer(Etudiant e)
        {
            throw new NotImplementedException();
        }

        public LinkedList<Etudiant> List(Etudiant e)
        {
            throw new NotImplementedException();
        }
    }
    
}
