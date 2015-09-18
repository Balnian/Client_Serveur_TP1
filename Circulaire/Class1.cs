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
            String Encoder = "";
            //Encoder = str.Split(str.ElementAt(Value % str.Length)).ElementAt(1) + str.Split(str.ElementAt((Value % str.Length + 1 < str.Length)? Value % str.Length + 1:)).ElementAt(0);
            Encoder =  str.Substring(Value % str.Length)+str.Substring(0,Value % str.Length);
            //for (int i = 0; i < Value; i++)
            //{
            //    Encoder += str.ElementAt(str.Length - i-1);
            //}
            //for (int i = str.Length-(Value%str.Length); i%str.Length < str.Length; i++)
            //{
            //    Encoder += str.ElementAt(i);
            //}
            return Encoder;
          
        }

        public static String Dechiffrer(String str, int Value)
        {
            String Encoder = "";
            Encoder = str.Substring(str.Length - (Value % str.Length)) + str.Substring(0, str.Length - (Value % str.Length));
            return Encoder;
        }
    }
}
