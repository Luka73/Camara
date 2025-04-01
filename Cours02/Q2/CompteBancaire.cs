using System;

namespace Heritage.Q2
{
    class CompteBancaire
    {

        public double Solde; //attibuts == AVOIR
        public string NumeroCompte; //0017283

        //parametre --> les infos que on passe pour les methodes
        public void Deposer(double montant) //methode == FAIRE 
        {
            if (montant > 0)
            {
                Solde += montant;
                Console.WriteLine($"Dépôt de : {montant}. Nouveau solde : {Solde}");
            } 
            else
            {
                Console.WriteLine("Le montant du dépôt doit être positif");
            }
        }

        public void Retirer(double montant)
        {
            //montant = 150
            //Solde = 100

            //Passport -> ID et Certificat --> &&
            //Passport -> ID ou Certificat --> ||
            if (montant > 0 && montant <= Solde)  
            {
                Solde -= montant;
                Console.WriteLine($"Retrait de {montant}. Nouveau solde : {Solde}");
            } 
            else if(montant > Solde) 
            {
                Console.WriteLine("Fonds insuffisants pour ce retrait.");
            }
            else
            {
                Console.WriteLine("Le montant du retrait doit être positif.");
            }
        }


    }
}
