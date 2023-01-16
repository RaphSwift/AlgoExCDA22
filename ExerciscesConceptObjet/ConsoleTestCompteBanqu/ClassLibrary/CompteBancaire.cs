namespace ClassLibrary
{
    public class CompteBancaire
    {
        private int decouvertAutorise;
        private string nom;
        private int numeroUnique;
        private float solde;


        public CompteBancaire(int numeroUnique, string nom, int solde, int decouvertAutorise)
        {
            this.decouvertAutorise = decouvertAutorise;
            this.nom = nom;
            this.numeroUnique = numeroUnique;
            this.solde = solde;
        }

        public void CrediterMontant(float montant)
        {
            solde = montant + solde; 
        }

        public bool AUnSoldeSuperieur(CompteBancaire autreCompte)
        {
            throw new System.NotImplementedException();
            return true;
        }

        public bool Debiter(float montant)
        {
            if (montant <= solde - decouvertAutorise)
            {
                solde = solde - montant;
                return true;
            }

            return false;
        }

        public bool Transferer(float montant, CompteBancaire nom)
        {
            Debiter(montant);
            nom.CrediterMontant(montant);
            return true;
        }

        public override string ToString()
        {
            return "numero: " + numeroUnique + " nom : " + nom + " solde : "+solde+ " découvert autorisé: " + decouvertAutorise;
        }
    }
}


