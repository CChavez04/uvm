using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int contador=n;
        
        for(int indice=1; indice<=n; indice++){
             for(int indice1=1; indice1<=n; indice1++){
                if(indice1>=contador)
                    Console.Write("#");
                 else{
                   Console.Write(" ");  
                 }
            }     
            contador--;
             Console.WriteLine("");
        }
    }
}
