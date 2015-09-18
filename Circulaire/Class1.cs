using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulaire
{
    public class Circulaires
    {

        public static String Chiffrer(String str, int Value)
        {
            //String temporaire
            String Encoder = "";
            //Prend la première partie de la string de character a chiffrer et l'envoit à la fin du reste de la string selon la valeur envoyer en parametre 
            Encoder =  str.Substring(Value % str.Length)+str.Substring(0,Value % str.Length);           
            return Encoder;
          
        }

        public static String Dechiffrer(String str, int Value)
        {
            //String temporaire
            String Encoder = "";            
            Encoder = str.Substring(str.Length - (Value % str.Length)) + str.Substring(0, str.Length - (Value % str.Length));
            return Encoder;
        }
    }
}
