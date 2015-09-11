using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulaire
{
    public class Circulaire
    {

        static String Chiffrer(String str, int Value)
        {
            String Encoder = "";
            for (int i = str.Length-(Value%str.Length); i-(Value%str.Length) < str.Length; i++)
			{
			    Encoder+=str.ElementAt(i);
			}
            return Encoder;
          
        }

        static String Dechiffrer(String str, int Value)
        {
            String Encoder = "";
            foreach (Char lettre in str)
            {
                if (Char.IsDigit(lettre))
                {
                    Encoder += (Char)('0' + ((lettre - Value) % 10));
                }
                else if (Char.IsUpper(lettre))
                {
                    Encoder += (Char)('A' + ((lettre - Value) % 26));
                }
                else
                {
                    Encoder += (Char)('a' + ((lettre - Value) % 26));
                }

            }
    }
}
