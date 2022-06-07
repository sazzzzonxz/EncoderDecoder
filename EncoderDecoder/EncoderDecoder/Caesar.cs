using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
    public class Caesar
    {
        public string Alphabet { get; set; }
        public int Shift { private get; set; }
        public string Encryption(string text)
        {
            text = text.ToLower();
            var res = new StringBuilder();
            // Проходим по каждой букве слова
            for (int i = 0; i < text.Length; i++)
            {
                // Проходим по каждому букве алфавита
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    //Если буква слова = букве алфавита, то мы достаем из алфавита букву со смещением, берем остаток от деления чтобы не выйти за пределы
                    if (text[i] == Alphabet[j])
                    {
                        res.Append(Alphabet[(j + Shift) % Alphabet.Length]);
                    }
                }
            }
            return res.ToString();
        }
        public string Decryption(string crypt)
        {
            crypt = crypt.ToLower();
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    //Весь процесс тот же самый, только мы достаем букву вычитая смещение, для получения оригинальной буквы.
                    if (crypt[i] == Alphabet[j])
                    {
                        res.Append(Alphabet[(j - Shift + Alphabet.Length) % Alphabet.Length]);
                    }

                }

            }

            return res.ToString();
        }

    }
}
