using System;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        2) int tipindən bir array olur içində müsbət və mənfi ədədlər olur
            //            elə bir method yazın ki, bu array - i parametr olaraq qəbul 
            //            etsin və qəbul etdiyi array-in əvvəlcədən assign olunması
            //            məcburi olsun daha sonra içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın
            //
           int[] Arr = {1,2,3,-4,5};
           int[] massive= Massiv(ref Arr);
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }



        }

        static int[] Massiv( ref int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * (-1); 
                }



            }
            return arr;






        }
    }
}
