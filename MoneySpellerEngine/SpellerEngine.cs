using System;
namespace MoneySpellerEngine
{
    /// <summary>
    /// General class that supports any language engine to be injected into its main constructor.
    /// </summary>
    public class SpellerEngine
    {
        private ISpeller _speller;
        /// <summary>
        /// Main constructor that supports dependency injection.
        /// </summary>
        /// <param name="speller">Any concrete implementation of  ISpeller interface.</param>
        public SpellerEngine(ISpeller speller)
        {
            _speller = speller;
        }
        /// <summary>
        /// Invoke choosen speller engine.
        /// </summary>
        /// <param name="value">Positive number up to 14 digits long.</param>
        /// <returns>Spelled number in choosen language format.</returns>
        /// <exception cref="IndexOutOfRangeException">Minimum value is 1.</exception>
        /// <exception cref="NotSupportedException">Maximum digit length is 14.</exception>
        public string Spell(long value)
        {
           return _speller.Spell(value);
        }
    }
}
