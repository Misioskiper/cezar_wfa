using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cezar_wfa
{
    class szyfry
    {
        static public string szyfrowanie(int a, string b)
        {
            
            int key = Convert.ToInt16(a); //
            key = key % 37;
            
            string para = b; //tekst
            string parag = para.ToUpper();
            char[] text = parag.ToCharArray();
            int j = text.Length - 1;
            int k = alpha.Length - 1;
            char[] text3 = new char[text.Length];
            for (int i = 0; i <= j; i++)
            {
                char text2 = text[i];
                int n = Array.IndexOf(alpha, text2);
                int f = n + key;
                if (f > k)
                {
                    f = f - k;
                }
                text3[i] = alpha[f];
            }
            string fin = new string(text3);
            //Wypisywanie tekstu
            return fin;
        }

        static public string deszyfrowanie(int a, string b)
        {
            
            int key = a;
            key = key % 37;
            
            string para = b;
            string parag = para.ToUpper();
            char[] text = parag.ToCharArray();
            int j = text.Length - 1;
            int k = alpha.Length - 1;
            char[] text3 = new char[text.Length];
            for (int i = 0; i <= j; i++)
            {
                char text2 = text[i];
                int n = Array.IndexOf(alpha, text2);
                int f = n - key;
                if (f < 0)
                {
                    f = f + k;
                }
                text3[i] = alpha[f];
            }
            string fin = new string(text3);
            return fin;
            
        }
        static char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '5', '6', '7', '8', '9', '0', ' ', '.', ',', '?' };
    }
}
