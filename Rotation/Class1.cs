using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation
{
    public class Rotation
    {
        static String Chiffrer(String str, int Value)
        {
            String Encoder="";
            foreach (Char lettre in str)
            {
                if(Char.IsDigit(lettre)) 
                {
                    Encoder += (Char)('0' + ((lettre + Value) % 10));
                }
                else if (Char.IsUpper(lettre))
                {
                    Encoder += (Char)('A' + ((lettre + Value) % 26));
                }
                else
                {
                    Encoder += (Char)('a' + ((lettre + Value) % 26));
                }
                
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
            return Encoder;
        }
    }
}
