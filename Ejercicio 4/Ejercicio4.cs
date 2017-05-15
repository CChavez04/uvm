using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        decimal suma=0;
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        for(int indice=0; indice<n; indice++)
            {
          
          suma=suma+  arr[indice];
        }
        Console.WriteLine(suma.ToString());
    }
}
