using System;
using System.Collections.Generic;
using System.Globalization;
using MyApp.Services;

namespace MyApp
{
    class Program
    {
        private static DemandeALutilisateur _DemandeALutilisateur = new DemandeALutilisateur();
        private static CommuneService _communeService = new CommuneService(_DemandeALutilisateur);
        private static DepartementService _departementService = new DepartementService(_DemandeALutilisateur);

        static void Main(string[] args)
        {
            List<Commune> listcommune = new List<Commune>();
            List<Departement> listeDepartement = new List<Departement>();

            while(true)
            {
                string choix = Menu();

                if(choix == "1")
                {
                   Commune c = _communeService.ajouterCommune();
                    listcommune.Add(c);
                }
                else if(choix == "2")
                {
                    _communeService.affiche(listcommune);
                }
                else if(choix == "3")
                {
                    _communeService.calculNbtotalHabs(listcommune);
                }
                else if(choix == "4")
                {
                    _departementService.ajouterDepartement();
                }
                else if(choix == "5")
                {
                    _departementService.affiche(listeDepartement);
                }
                else if(choix == "Q" || choix == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Je n'ai pas compris"); 
                }
            }       
        }

        public static string Menu()
        {
            Console.WriteLine("Bienvenue dans l'application de gestion de communes");
            Console.WriteLine("Que voulez-vous faire");
            Console.WriteLine("1.Créer une nouvelle communes");
            Console.WriteLine("2.Afficher l'ensemble des communes");
            Console.WriteLine("3.Afficher le nombre total d'habitants");
            Console.WriteLine("4 Créer un Département");
            Console.WriteLine("5 Afficher un Département");
            Console.WriteLine("Q.Quitter");
            string choix = Console.ReadLine();
            return choix;
        }
    }
}
