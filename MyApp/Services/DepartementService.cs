using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace MyApp.Services
{
    public class DepartementService
    {

        private DemandeALutilisateur _demandeALutilisateur;

        public DepartementService(DemandeALutilisateur demandealutilisateur)
        {
            this._demandeALutilisateur = demandealutilisateur;
        }

        public Departement ajouterDepartement()
        {
                Departement d = new Departement();
                d.nom = _demandeALutilisateur.saisieNom("Quel est le nom du département ?");
                d.code = _demandeALutilisateur.saisieEntier("Quel est le code du département");

                return d;
        }

        public void affiche(List<Departement> listeDepartement)
        {
            Console.WriteLine("Liste des départements créées");
            foreach (Departement d in listeDepartement)
            {
                Console.WriteLine("Nom : " + d.nom + "Code : " + d.code);
            }
            Console.WriteLine(" ");
        }
    }
}
