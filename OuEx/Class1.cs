using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuEx
{
    public class OuExs
    {
        //Une Fonction pour chiffrer et Déchiffrer
        public static String ChiffrerDechiffrer(String str, int Value)
        {
            //Tableau char utiliser pour faire le ou sur chaque lettre ou chiffre
            Char[] carry = str.ToArray();
            //Boucle qui applique le ou exclusife sur chaque character
            for (int i = 0; i < str.Length; i++)
            {
                carry[i] ^= (char)Value;
            }
            return new string(carry);
           
        }
    }
}
