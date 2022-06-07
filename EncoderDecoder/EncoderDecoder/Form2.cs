using System;
using System.IO;
using System.Windows.Forms;

namespace EncoderDecoder
{
    public partial class Form2 : Form
    {

        public CryptType CryptType;

        private const string InFile = "in.txt";
        private const string OutFile = "out.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isRuLang = this.alphaRuRadioButton.Checked;
            var isEncrypt = this.encryptRadioButton.Checked;

            var fileContent = File.ReadAllText(InFile).Split("\r\n");
            int.TryParse(fileContent[0], out int shiftResult);
            var password = fileContent[1];
            var text = fileContent[2];


            switch (CryptType)
            {
                case CryptType.Vijner:
                    var vijner = new Vijner(isRuLang ? "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" : null);
                    if (isEncrypt)
                    {
                        var encryptedText = vijner.Encrypt(text, password);
                        File.WriteAllText(OutFile, encryptedText);
                    }
                    else
                    {
                        var decryptedText = vijner.Decrypt(text, password);
                        File.WriteAllText(OutFile, decryptedText);
                    }

                    break;
                case CryptType.Caesar:
                    var caesar = new Caesar();
                    caesar.Alphabet = isRuLang ? "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" : "abcdefghijklmnopqrstuvwxyz";
                    caesar.Shift = shiftResult;
                    if (isEncrypt)
                    {
                        var encryptedText = caesar.Encryption(text);
                        File.WriteAllText(OutFile, encryptedText);
                    }
                    else
                    {
                        var decryptedText = caesar.Decryption(text);
                        File.WriteAllText(OutFile, decryptedText);
                    }
                    break;
                case CryptType.Atbash:
                    var atbash = new Atbash(isRuLang ? "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" : null);
                    if (isEncrypt)
                    {
                        var encryptedText = atbash.EncryptText(text);
                        File.WriteAllText(OutFile, encryptedText);
                    }
                    else
                    {
                        var decryptedText = atbash.DecryptText(text);
                        File.WriteAllText(OutFile, decryptedText);
                    }
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
