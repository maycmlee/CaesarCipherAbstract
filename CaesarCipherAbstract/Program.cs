﻿using System;
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
            CaesarCipher caeserCipher = new CaesarCipher("abcdefghijklmnopqrstuvwxyz ");
            caeserCipher.SetOffset();
            string text = "my name is may";
            Console.WriteLine("Original text: {0}", text);
            string ciphered = caeserCipher.Cypher(text);
            Console.WriteLine("Ciphered: {0}", ciphered);
            Console.WriteLine("Deciphered: {0}", caeserCipher.Decipher(ciphered));
        }
    }
}
