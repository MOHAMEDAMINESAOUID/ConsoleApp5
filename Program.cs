using System;

namespace ConsoleApp5
{
    class Program
    {


        public void AppTest()
        {
            Console.WriteLine("---Donner les infos du client 1--- ");
            Console.Write("    Nom :  "); string Nom1 = Console.ReadLine();
            Console.Write("    Prénom :  "); string Prenom1 = Console.ReadLine();
            Console.Write("    Adresse :  "); string Adresse1 = Console.ReadLine();
            Client client1 = new Client(Nom1, Prenom1, Adresse1);//ajouter client 1
                                                                 //-----------------------------------------------------------------------
            Console.WriteLine("Donner les infos du client 2 : ");
            Console.Write("    Nom :  "); string Nom2 = Console.ReadLine();
            Console.Write("    Prénom :  "); string Prenom2 = Console.ReadLine();
            Console.Write("    Adresse :  "); string Adresse2 = Console.ReadLine();
            Client client2 = new Client(Nom2, Prenom2, Adresse2);//ajouter client 2

            Console.WriteLine("-----------------------------------");
            Console.Write("Donnez une valeur du MAD pour le client 1 : "); double valeur1 = double.Parse(Console.ReadLine());
            Console.Write("Donnez une valeur du MAD pour le client 2 : "); double valeur2 = double.Parse(Console.ReadLine());

            MAD MAD1 = new MAD(valeur1);
            MAD MAD2 = new MAD(valeur2);
            Compte compte1 = new Compte(client1, MAD1);//création du compte 1
            Compte compte2 = new Compte(client2, MAD2);//création du compte 2
            Console.WriteLine("*****Affichage du client 1*****");
            client1.Afficher();
            Console.WriteLine("*****Affichage du client 2*****");
            client2.Afficher();
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 1 avant de débiter*****");
            compte1.Consulter();
            //-------------------------------débiter------------------------------------
            Console.Write("Donnez une valeur à débiter : "); double val = double.Parse(Console.ReadLine());
            MAD deb = new MAD(val);//plafond=2000 
            if (compte1.Debiter(deb))
            {
                Console.WriteLine("Compte 1 débiter avec succé!!");
            }
            else
                Console.WriteLine("Compte 1 n'est pas débiter!!");
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 1 après le débit*****");
            compte1.Consulter();
            //-------------------------------créditer------------------------------------
            Console.Write("Donnez une valeur à créditer : "); double val1 = double.Parse(Console.ReadLine());
            MAD cred = new MAD(val1);
            if (compte2.Crediter(cred))
            {
                Console.WriteLine("Compte 2 Créditer avec succé!!");

            }
            else
                Console.WriteLine("Compte 1 n'est pas créditer!!");
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 2 du client 2*****");
            compte2.Consulter();

            //-------------------------------verser------------------------------------
            Console.WriteLine("*****Versement*****");
            Console.Write("Donnez une somme à verser : "); double S = double.Parse(Console.ReadLine());
            MAD somme = new MAD(S);
            if (compte1.Verser(compte2, somme))
            {
                Console.WriteLine("Virement bien passé !!");
            }
            else
                Console.WriteLine("Virement échoué !!");

            //------------------------------------------------------
            Console.WriteLine("*****Consultation du compte 1 *****");
            compte1.Consulter();

            Console.WriteLine("*****Consultation du compte 2 *****");
            compte2.Consulter();
            //---------------Partie 2 test---------------------
            CompteEpargne compteepargne1 = new CompteEpargne(client1, 30);
            compteepargne1.Crediter(new MAD(100));
            compteepargne1.CalculInteret();
            compteepargne1.AfficherOperation();
            compteepargne1.Consulter();
            CompteEpargne compteepargne2 = new CompteEpargne(client2, 20);
            Operation op1 = new Operation("Dépot", new MAD(300), false);
            Operation op2 = new Operation("Retrait", new MAD(100), true);
            compteepargne2.Debiter(new MAD(200));
            Console.Write("Operation "); op1.Afficher();
            op2.Afficher();
            compteepargne2.AfficherOperation();
            compteepargne2.Consulter();
            client1.AfficherListeComptes();

            Console.ReadKey();
        }
    }
}
