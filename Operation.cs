using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Operation
    {
        public static int cpt = 12345;
        public int num_op;
        public DateTime date_op;
        public string libelle;
        public MAD montant;
        public bool minus;
        public Operation(string libelle, MAD montant, bool minus)
        {
            this.num_op = ++cpt;
            this.date_op = DateTime.Now;
            this.libelle = libelle;
            this.montant = montant;
            this.minus = minus;
        }
        public void AfficherOperation()
        {
            string type = minus ? "-" : "";
            Console.Write($"Operation : {date_op.ToShortDateString()} | N°  {num_op} ||{type}");
            montant.Afficher();
        }
    }
}
