using SharedDAOProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDAOProject.IDAO
{
public interface IDAOEtudiant
    {
      bool   Ajouter(Etudiant e);
        bool Modifer(Etudiant e);
        bool Supprimer(Etudiant e);
        LinkedList<Etudiant> List
        (Etudiant e);

    }
}
