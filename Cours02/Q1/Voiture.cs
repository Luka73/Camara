using System;

namespace Heritage.Q1
{
    class Voiture
    {
        //Attibuts
        public string Marque;
        public string Modele;
        public int Annee;

        //Methode
        public void AfficherInfo()
        {
            //WriteLine --> afficher un texte sur le console (écran)
            //Marque : {Ford}, Modèle : {Focus}, Année : {2020}
            Console.WriteLine($"Marque : {Marque}, Modèle : {Modele}, Année : {Annee}");
        }
    }
}
