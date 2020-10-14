using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Services
{
    public class DemandeALutilisateur
    {
        public string saisieNom(string message)
        {
            Console.WriteLine(message);
            string Nom = Console.ReadLine();
            bool ok = false;
            int valeurconvertie;

            while (ok == false)
            {
                if (string.IsNullOrEmpty(Nom))
                {
                    Console.WriteLine("Saisie incorrecte: veuillez saisir quelque chose");
                    Nom = Console.ReadLine();
                }
                else if (int.TryParse(Nom, out valeurconvertie))
                {
                    Console.WriteLine("Saisie incorrecte: le nom de votre ville ne peut pas être un nombre");
                    Nom = Console.ReadLine();
                }
                else if (Nom[0] < 65 || Nom[0] > 90)
                {
                    Console.WriteLine("Saisie incorrecte: veuillez commencer le nom de votre commune par une majuscule");
                    Nom = Console.ReadLine();
                }
                else
                {
                    ok = true;
                }
            }
            return Nom;
        }

        public int saisieEntier(string message)
        {
            int valeurconvertie;
            Console.WriteLine(message);
            string entier = Console.ReadLine();

            while (true)
            {
                if(!int.TryParse(entier, out valeurconvertie))
                {
                    Console.WriteLine("Veuillez saisir un entier correcte");
                    entier = Console.ReadLine();
                }
                else if (valeurconvertie<0)
                {
                    Console.WriteLine("Veuillez saisir un entier positif");
                    entier = Console.ReadLine();
                }
                else
                {
                    break;
                }
                
            }
            return valeurconvertie;
        }

    }
}
