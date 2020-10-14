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

        public Departement ajouterDepartement(List<Commune>listeCommune)
        {
                Departement d = new Departement();
                d.nom = _demandeALutilisateur.saisieNom("Quel est le nom du département ?");
                d.code = _demandeALutilisateur.saisieEntier("Quel est le code du département");
                foreach (Commune c in listeCommune)
                {
                    if (c.codeDepartement == d.code)
                    {
                    d.listeCommune.Add(c);
                    }
                }

                return d;
        }

        public void affiche(List<Departement> listeDepartement)
        {
            int nbHab = 0;
            Console.WriteLine("Liste des départements créées");
            foreach (Departement d in listeDepartement)
            {
                Console.WriteLine("Nom : " + d.nom + "Code : " + d.code);

                foreach(Commune c in d.listeCommune)
                {
                    nbHab = nbHab + c.NbHab;
                }
                Console.WriteLine("Nombre d'habitant dans le departement" + nbHab);
            }
            Console.WriteLine(" ");
        }
    }
}
