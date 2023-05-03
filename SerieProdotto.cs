using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int max = 0;
        
        if(span > digits.Length){
            throw new System.ArgumentException();
        }
        if(span == 0){
            return 1;
        }
        if(span < 0){
            throw new System.ArgumentException();
        }
         
        char[] caratteri = digits.ToCharArray();

        for (int i = 0; i < digits.Length; i++)
        {
            if(char.IsLetter(caratteri[i]))
            {
                throw new System.ArgumentException();                
            }
        }

        for (int j = 0; j <= digits.Length-span; j++)
        {
            int somma = 1;
            int supporto = j;

            for (int y = 0; y < span; y++)
            {
                somma = somma * (caratteri[supporto]-48);
                supporto = supporto + 1;
            }
            if(somma > max)
            {
                max = somma;
            }
        }
        return max;
    }
}