using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation
{
    public class Rotations
    {

        public static String Chiffrer(String str, int Value)
        {
            //String Temporaire
            String Encoder="";
            //Pour chaque lettre dans le mot a chiffrer on encrypte la valeur selon l'algorythm de rotation
            foreach (Char lettre in str)
            {
                //Si C'est un chiffre
                if(Char.IsDigit(lettre)) 
                {
                    Encoder += (Char)('0' + ((lettre + Value - '0') % 10));
                }
                //Si C'est une lettre majuscule
                else if (Char.IsUpper(lettre))
                {
                    Encoder += (Char)('A' + ((lettre + Value - 'A') % 26));
                }
                //Si C'est une lettre minuscule
                else
                {
                    Encoder += (Char)('a' + (( lettre + Value - 'a') % 26));
                }
                
            }
            return Encoder;
        }

        public static String Dechiffrer(String str, int Value)
        {
            //String Temporaire
            String Encoder = "";
            //Pour chaque lettre dans le mot a chiffrer on encrypte la valeur selon l'algorythm de rotation
            foreach (Char lettre in str)
            {
                //Si C'est un chiffre
                if (Char.IsDigit(lettre))
                {

                    int carry = ((lettre - Value % 10 - '0'));
                    Encoder += (Char)((carry < 0)? '9' + carry+1:'0' + carry);
                }
                //Si C'est une lettre majuscule
                else if (Char.IsUpper(lettre))
                {
                    int carry = ((lettre - Value % 26 - 'A'));
                    Encoder += (Char)((carry<0)?'Z'+carry+1:'A' + carry);
                }
                //Si C'est une lettre minuscule
                else
                {
                    int carry = ((lettre - Value % 26 - 'a'));
                    Encoder += (Char)((carry < 0) ? 'z' + carry + 1 : 'a' + carry);
                }

            }
            return Encoder;
        }
    }
}
