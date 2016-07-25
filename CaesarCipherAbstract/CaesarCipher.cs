using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherAbstract
{
    class CaesarCipher
    {
        /// <summary>
        /// This is an abstract class based on AAlphabet.
        /// Constructor takes in an alphabet and ciphers
        /// a string based on the offset.
        /// </summary>

        #region Properties
        public AAlphabet aAlphabet;
        public int offset;
        #endregion

        #region Constructor
        public CaesarCipher(AAlphabet aAlphabet)
        {
            this.aAlphabet = aAlphabet;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Ciphers a string.
        /// </summary>
        /// <param name="text">String to be ciphered</param>
        /// <param name="offset">The offset for each of the characters
        /// in the string</param>
        /// <returns></returns>
        public string Cipher(string text, int offset)
        {
            aAlphabet.Transpose(offset);
            string textTransformed = "";

            //Go through text to transpose
            for (int i = 0; i < text.Length; i++)
            {
                textTransformed += aAlphabet.GetTransposedChar(text[i]);
            }

            return textTransformed;
        }
        #endregion
    }
}


