using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncoderForms.Encoders
{
    public class SHA1Encoder : IEncoder
    {
        public string Encode(string input)
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] bytes = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string Decode(string input)
        {
            MessageBox.Show("Декодирование невозможно, данный вид хеширования применяется только для кодирования.",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return string.Empty;
        }
    }
}