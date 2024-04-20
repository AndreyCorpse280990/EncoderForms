using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderForms.Encoders
{
    public class CaesarEncoder : IEncoder
    {
        private readonly int shift;

        public CaesarEncoder(int shift)
        {
            this.shift = shift;
        }

        public string Encode(string input)
        {
            return CaesarShift(input, shift);
        }

        public string Decode(string input)
        {
            return CaesarShift(input, -shift);
        }

        private string CaesarShift(string text, int shift)
        {
            var result = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char d = char.IsUpper(c) ? 'A' : 'a';
                    result.Append((char)(((c + shift - d + 26) % 26) + d));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
