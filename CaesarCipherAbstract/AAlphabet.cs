using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherAbstract
{
    //can also be protected
    public abstract class AAlphabet
    {

        #region Properties
        public char[] Alphabet { get; set; }
        #endregion

        /// <summary>
        /// When abstract class is implemented it will require as parameter
        /// the alphabet.
        /// 
        /// </summary>
        /// <param name="alphabet">Array of chars</param>
        #region Constructor
        public AAlphabet(char[] alphabet)
        {
            this.Alphabet = alphabet;
        }

        #endregion

        #region Methods
        public abstract void Transpose(int offset);
        public abstract char GetTransposedChar(char c);
        #endregion
    }
}
