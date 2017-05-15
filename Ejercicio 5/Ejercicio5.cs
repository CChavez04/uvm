using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        int suma1=0,suma2=0;
        int contador=0,contador1=n-1;
        
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
           suma1=suma1+a[a_i][contador];
            suma2=suma2+a[a_i][contador1];
            contador++;
            contador1--;
        }
        suma1=Math.Abs(suma1-suma2);
        Console.WriteLine(suma1.ToString());
    }
}
