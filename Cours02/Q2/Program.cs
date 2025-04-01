class Program {
    static void Main(String args)
    {
        CompteBancaire c1 = new CompteBancaire();
        c1.NumeroCompte = "123456";
        c1.Solde = 100;

        c1.Deposer(50);
        c1.Retirer(100);
        c1.Retirer(300);
    }
}