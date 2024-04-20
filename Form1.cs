using EncoderForms.Encoders;
using System;
using System.IO;
using System.Windows.Forms;

namespace EncoderForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeEncodingAlgorithms();
            this.checkBoxCopyToClipboard.CheckedChanged += new System.EventHandler(this.checkBoxCopyToClipboard_CheckedChanged_CheckedChanged);


        }
        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string input = File.ReadAllText(filePath);
                textBoxInput.Text = input;
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string output = textBoxOutput.Text;
                File.WriteAllText(filePath, output);
            }
        }

        public enum EncodingAlgorithm
        {
            BCrypt,
            Caesar,
            MD5,
            Reverse,
            SHA1,
            SHA256
        }

        private void InitializeEncodingAlgorithms()
        {
            comboBoxEncodingAlgorithm.Items.AddRange(Enum.GetNames(typeof(EncodingAlgorithm)));
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            EncodeText();
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            DecodeText();
        }

        private void EncodeText()
        {
            if (comboBoxEncodingAlgorithm.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxInput.Text))
                return;

            string input = textBoxInput.Text;
            EncodingAlgorithm algorithm = (EncodingAlgorithm)Enum.Parse(typeof(EncodingAlgorithm), comboBoxEncodingAlgorithm.SelectedItem.ToString());

            IEncoder encoder = GetEncoder(algorithm);
            string encodedText = encoder.Encode(input);

            textBoxOutput.Text = encodedText;

            if (checkBoxCopyToClipboard.Checked)
            {
                Clipboard.SetText(encodedText);
                MessageBox.Show("Закодированная строка скопирована в буфер обмена.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void DecodeText()
        {
            if (comboBoxEncodingAlgorithm.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxInput.Text))
                return;

            string input = textBoxInput.Text;
            EncodingAlgorithm algorithm = (EncodingAlgorithm)Enum.Parse(typeof(EncodingAlgorithm), comboBoxEncodingAlgorithm.SelectedItem.ToString());

            IEncoder encoder = GetEncoder(algorithm);
            string decodedText = encoder.Decode(input);

            textBoxOutput.Text = decodedText;
        }

        private IEncoder GetEncoder(EncodingAlgorithm algorithm)
        {
            switch (algorithm)
            {
                case EncodingAlgorithm.BCrypt:
                    return new BCryptEncoder();
                case EncodingAlgorithm.Caesar:
                    return new CaesarEncoder(3); 
                case EncodingAlgorithm.MD5:
                    return new MD5Encoder();
                case EncodingAlgorithm.Reverse:
                    return new ReverseEncoder();
                case EncodingAlgorithm.SHA1:
                    return new SHA1Encoder();
                case EncodingAlgorithm.SHA256:
                    return new SHA256Encoder();
                default:
                    throw new NotSupportedException($"Алгоритм {algorithm} не выбран.");
            }
        }


        private void checkBoxCopyToClipboard_CheckedChanged_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                string encodedString = textBoxOutput.Text; // Получаем закодированную строку из TextBox
                if (!string.IsNullOrEmpty(encodedString))
                {
                    Clipboard.SetText(encodedString); // Копируем закодированную строку в буфер обмена
                    MessageBox.Show("Закодированная строка, скопированная в буфер обмена.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Нет закодированной строки для копирования.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}