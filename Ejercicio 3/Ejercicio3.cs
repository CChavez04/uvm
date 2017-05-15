using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
        // Complete this function
        int suma1=0;
        int suma2=0;
        int[] valor=new int[2];
        
        if(a0!=b0){
           if(a0>b0)
            suma1++;
           else
            suma2++;
        }
         if(a1!=b1){
           if(a1>b1)
            suma1++;
           else
            suma2++;
        }
         if(a2!=b2){
           if(a2>b2)
            suma1++;
           else
            suma2++;
        }
        valor[0]=suma1;
        valor[1]=suma2;        
        
        return valor;
    }

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));
        

    }
}