using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "my name is may";
            Console.WriteLine($"Original: {text}");
            string alphaString = "abcdefghijklmnopqrstuvwxyz ";
            char[] alphaArray = alphaString.ToCharArray();

            DictionaryBasedAlphabet dictionaryAlpha = new DictionaryBasedAlphabet(alphaArray);
            CaesarCipher Ciphered = new CaesarCipher(dictionaryAlpha);
            string cipheredText = Ciphered.Cipher(text, 3);
            Console.WriteLine($"Ciphered:  {cipheredText}");

            string decipherAlpha = "defghijklmnopqrstuvwxyz abc";
            char[] decipherArray = decipherAlpha.ToCharArray();
            DictionaryBasedAlphabet deciferAlpha = new DictionaryBasedAlphabet(decipherArray);
            CaesarCipher Deciphered = new CaesarCipher(deciferAlpha);
            string decipheredText = Deciphered.Cipher(cipheredText, -3);
            Console.WriteLine($"Deciphered:  {decipheredText}");


            //CaesarCipher caeserCipher = new CaesarCipher("abcdefghijklmnopqrstuvwxyz ");
            //caeserCipher.SetOffset();
            //string text = "my name is may";
            //Console.WriteLine("Original text: {0}", text);
            //string ciphered = caeserCipher.Cypher(text);
            //Console.WriteLine("Ciphered: {0}", ciphered);
            //Console.WriteLine("Deciphered: {0}", caeserCipher.Decipher(ciphered));
        }
    }
}
