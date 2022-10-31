
using System;

namespace MyApplication
{
    class Program
    {

        static void initialiseTab(int[] tab)    // method
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
        
        for (int i = 0; i < tab.Length; i++)
        {
            for (int j = i; i < tab.Length; i++)
            {

                if (tab[i] < tab[j])
                {
                }



            }

        }
    }




}



