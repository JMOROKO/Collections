using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Collection
    {
        // == / egal
        // != / different de
        // <= / inferieur ou egal
        // => / superieur ou egal
        // < / inferieur
        // > / superieur
        // && / ET
        // || / OU
        // === / egalité valeur et type
        // % / retourne le reste de la division euclidienne
        // / // divisé

        //prend en paramètre un tableau et ne retourne rien
        static void somme(int[] param)
        {
            int somme = 0;
            for(int i = 0; i < param.Length; i++)
            {
                somme += param[i]; // equivaut à somme = somme + t[i];
            }
            Console.WriteLine("La somme est : "+somme);
        }

        // prend en paramètre un tableau et retourne un entier
        static int produit(int[] param)
        {
            int prod = 1;
            for(int i = 0; i < param.Length; i++)
            {
                prod *= param[i]; // equivaut à somme = somme + t[i];
            }
            return prod;
        }

        //
        static void sommeParList()
        {
            List<int> liste = new List<int>();

            while(true)
            {
                Console.WriteLine("Veuillez un nombre : ");
                int nombre = int.Parse(Console.ReadLine());

                liste.Add(nombre);

                Console.WriteLine("Voulez vous continuer ? (O = oui / N = Nom)");
                string cont = Console.ReadLine();  
                if(cont == "N")
                {
                    break;
                }
            }
            int somme = 0;

            for(int i = 0;i < liste.Count;i++)
            {
                somme = somme + liste[i];
            }

            Console.WriteLine("La somme est : " + somme);
        }

        static void Main(string[] args)
        {
            // tableaux
            // declaration
            int[] tab = new int[6];
            //initialisation des cellules
            tab[0] = 1; 
            tab[1] = 2;
            tab[2] = 3;
            tab[3] = 4;
            tab[4] = 5;
            tab[5] = 6;

            Console.WriteLine("Vous devez renseigner "+tab.Length+ " valeurs");
            Console.WriteLine("**********************************");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            somme(tab);
            Console.WriteLine("Le produit est : "+produit(tab));

            // déclaration et initialisation
            int[] tab2 = { 11, 12, 13, 14, 15, 16, 18 };

            Console.WriteLine("Vous devez renseigner " + tab2.Length + " valeurs");
            Console.WriteLine("**********************************");
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.WriteLine(tab2[i]);
            }

            //************************
            //Liste
            List<int> list = new List<int>();
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            Console.WriteLine("**********************************");
            Console.WriteLine("Liste");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            sommeParList();
        }
    }
}