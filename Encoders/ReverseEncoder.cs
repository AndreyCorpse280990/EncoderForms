using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderForms.Encoders
{
    public class ReverseEncoder : IEncoder
    {
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string Encode(string input)
        {
            return Reverse(input);
        }

        public string Decode(string input)
        {
            return Reverse(input);
        }
    }
}
