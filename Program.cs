

using System;

namespace MyApplication
{
    class Program
    {
        static void initialiseTab(int[] tab)
        {
            tab = new int[4];
            Console.WriteLine(" saisir les elements du tableau");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        static void SortTab(int[] tab)
        {
            int k;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = i; i < tab.Length; i++)
                {

                    if (tab[i] < tab[j])
                    {
                        k = tab[i];
                        tab[i] = tab[j];
                        tab[j] = k;
                    }
                    else
                    {
                        continue;
                    }




                }

            }

        }




        static void AfficheTab(int[] tab)
        {
        
            

            for (int i = 0; i < tab.Length; i++)
            {
                
                    Console.WriteLine(tab[i]);
            }

        }


        static void InsirerElem(int[] tab)
        {
            int cpt = 0;
            int X;
            Console.WriteLine(" saisir  L'elements que vous voullez insirer dans le tableau");
            X = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] <X)
                    {
                       
                    }
                 else
                    {
                        continue;
                    }




                

            }

        }




        static void Main(string[] args)
        {
            int [] T= new int [4];
            initialiseTab(T);
            SortTab(T);
            AfficheTab(T);


        }
    }
}













