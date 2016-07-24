using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherAbstract
{
    class CaesarCipher
    {

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


