using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuEx
{
    public class OuExs
    {
        public static String ChiffrerDechiffrer(String str, int Value)
        {
            Char[] carry = str.ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                carry[i] ^= (char)Value;
            }
            return new string(carry);
           
        }
    }
}
