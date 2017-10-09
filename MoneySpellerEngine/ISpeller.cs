using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySpellerEngine
{
    /// <summary>
    /// Core interface that provides abstraction over concrete implementations of
    /// many different languages.
    /// </summary>
    public interface ISpeller
    {
        /// <summary>
        /// This main method spells given number in long format.
        /// </summary>
        /// <param name="value">Input number.</param>
        /// <returns>Spelled number in string.</returns>
        string Spell(long value);
    }
}
