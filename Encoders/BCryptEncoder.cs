using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncoderForms.Encoders
{
    public class BCryptEncoder : IEncoder
    {
        public string Encode(string input)
        {
            return BCrypt.Net.BCrypt.HashPassword(input, 10);
        }

        public string Decode(string input)
        {
            MessageBox.Show("Декодирование невозможно, данный вид хеширования применяется только для кодирования.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            return string.Empty;

        }

        public bool Verify(string input, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(input, hash);
        }
    }
}