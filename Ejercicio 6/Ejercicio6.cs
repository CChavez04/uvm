using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        Double positivo=0,cero=0,negativo=0;
        for(int indice=0; indice<n; indice++)
        {
            if (arr[indice]>0)
                positivo++;
            if (arr[indice]==0)
                cero++;
             if (arr[indice]<0)
                negativo++;
        }
        //Console.WriteLine(positivo.ToString());
        Console.WriteLine(Convert.ToDouble((positivo/n)).ToString());        
        Console.WriteLine((negativo/n).ToString());
        Console.WriteLine((cero/n).ToString());
    }
}
