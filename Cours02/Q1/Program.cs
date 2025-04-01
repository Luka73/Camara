class Program {

    static void Main()
    {

        Voiture v1 = new Voiture();
        v1.Marque = "Toyota";
        v1.Modele = "Corolla";
        v1.Annee = 2020;

        Voiture v2 = new Voiture { Marque = "Ford", Modele = "Focus", Annee = 2019 };
    }
}
