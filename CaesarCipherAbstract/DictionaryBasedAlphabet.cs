using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherAbstract
{
    public class DictionaryBasedAlphabet : AAlphabet
    {
        #region Properties

        public Dictionary<char, char> charMap = new Dictionary<char, char>();
        public char[] Alphabet;

        #endregion

        #region Constructor
        public DictionaryBasedAlphabet(char[] alphabet) : base(alphabet)
        {
            this.Alphabet = alphabet;
        }

        #endregion

        #region Methods
        /// <summary>
        /// This method creates a dictionary that maps each letter to its offset letter
        /// </summary>
        /// <param name="offset">The number letters will be offset by</param>
        public override void Transpose(int offset)
        {
            //Create dictionary of alphabet (key) with its offset alphabet (value)

            for(int i = 0; i < Alphabet.Length; i++)
            {   
                int offsetIndex = (i + offset) % Alphabet.Length;
                charMap.Add(Alphabet[i], Alphabet[offsetIndex]);
            }
        }
        /// <summary>
        /// This method returns the offset char that is mapped to the char inputted
        /// </summary>
        /// <param name="c">character we want to find the offset of</param>
        /// <returns></returns>
        public override char GetTransposedChar(char c)
        {
            char mappedChar = charMap[c];
            return mappedChar;
        }
        #endregion
    }
}
