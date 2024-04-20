using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncoderForms.Encoders
{
    public class MD5Encoder : IEncoder
    {   
        public string Encode(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input); // преобразование строки в массив байтов
                byte[] hashBytes = md5.ComputeHash(inputBytes); // вычисление хэша

                // Преобразовывание массива байтов в шестнадцатеричную строку
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2")); // X2 - шестнадцатеричная система счисления
                }

                return sb.ToString();
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