using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderForms.Encoders
{
    internal interface IEncoder
    {
        string Encode(string data);
        string Decode(string data);
    }
}
