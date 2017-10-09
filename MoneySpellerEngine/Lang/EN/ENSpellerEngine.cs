using System;
namespace MoneySpellerEngine
{
    /// <summary>
    /// EN Speller Engine.
    /// </summary>
    public partial class ENSpellerEngine:ISpeller
    {
        /// <summary>
        /// Invoke English (EN) speller engine.
        /// </summary>
        /// <param name="value">Positive number up to 14 digits long.</param>
        /// <returns>Spelled number in EN format.</returns>
        /// <exception cref="IndexOutOfRangeException">Minimum value is 1.</exception>
        /// <exception cref="NotSupportedException">Maximum digit length is 14.</exception>
        public string Spell(long value)
        {
            if (value <= 0)
            {
                throw new IndexOutOfRangeException();
            }
            long digitLength = GetLength(value) - 1;
            long fromPower = (long)Math.Pow(10, digitLength);
            long firstValue = value / fromPower;
            if (digitLength > 14)
            {
                throw new NotSupportedException("It currently doesn't support number more than 14 digits long.");
            }
            Navigator navigator = new Navigator
            {
                CurrentValue = value,
                FirstValue = firstValue,
                TotalDigit = digitLength
            };
            return CoreConverter(navigator).TrimEnd();
        }
    }
}
