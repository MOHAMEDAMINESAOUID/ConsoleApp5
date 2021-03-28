using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp5
{
    class CompteEpargne : Compte
    {
        private double TauxInteret;
        public CompteEpargne(Client cl, double tauxinteret) : base(cl)
        {
            if (tauxinteret >= 0 && tauxinteret <= 100)
            {
                this.TauxInteret = tauxinteret;
            }
            else
                Console.WriteLine("Taux d'interêt non valide");
        }
        public void CalculInteret()
        {
            this.Solde = Solde + Solde * (TauxInteret / 100);
        }
    }
}
