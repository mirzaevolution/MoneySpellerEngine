using System;

namespace MoneySpellerEngine
{
    /// <summary>
    /// ID Speller Engine.
    /// </summary>
    public partial class IDSpellerEngine
    {
        private string[] units = new string[]
      {
              "Satu ","Dua ","Tiga ","Empat ","Lima ","Enam ","Tujuh ","Delapan ","Sembilan "
      };
        private string[] mainUnits = new string[]
            {
               "Belas ","Puluh ","Ratus ","Ribu ","Juta ","Milyar ","Triliun "
            };
        private string[] specialUnits = new string[]
            {
                "Sepuluh ","Sebelas ","Seratus ","Seribu "
            };
        private struct Navigator
        {
            public long FirstValue { get; set; }
            public long TotalDigit { get; set; }
            public long CurrentValue { get; set; }
        }
        private long GetLength(long number)
        {
            long len = 0;
            while (number != 0)
            {
                number = number / 10;
                len++;
            }
            return len;
        }
        private string CoreConverter(Navigator navigator)
        {
            if (navigator.TotalDigit >= 12 && navigator.TotalDigit < 15)
            {

                long leftPart = navigator.CurrentValue / 1000000000000;
                long rightPart = navigator.CurrentValue % 1000000000000;

                long leftPartLen = GetLength(leftPart) - 1;
                long leftPartFromPower = (long)Math.Pow(10, leftPartLen);
                long leftPartFirstValue = leftPart / leftPartFromPower;
                Navigator leftNavigator = new Navigator
                {
                    CurrentValue = leftPart,
                    FirstValue = leftPartFirstValue,
                    TotalDigit = leftPartLen
                };
                if (rightPart == 0)
                {
                    return CoreConverter(leftNavigator) + mainUnits[6];
                }
                else
                {
                    long rightPartLen = GetLength(rightPart) - 1;
                    long righPartFromPower = (long)Math.Pow(10, rightPartLen);
                    long rightPartFirstValue = rightPart / righPartFromPower;
                    Navigator rightNavigator = new Navigator
                    {
                        CurrentValue = rightPart,
                        FirstValue = rightPartFirstValue,
                        TotalDigit = rightPartLen
                    };
                    return CoreConverter(leftNavigator) + mainUnits[6] + CoreConverter(rightNavigator);
                }

            }

            if (navigator.TotalDigit >= 9 && navigator.TotalDigit < 12)
            {

                long leftPart = navigator.CurrentValue / 1000000000;
                long rightPart = navigator.CurrentValue % 1000000000;
                long leftPartLen = GetLength(leftPart) - 1;
                long leftPartFromPower = (long)Math.Pow(10, leftPartLen);
                long leftPartFirstValue = leftPart / leftPartFromPower;
                Navigator leftNavigator = new Navigator
                {
                    CurrentValue = leftPart,
                    FirstValue = leftPartFirstValue,
                    TotalDigit = leftPartLen
                };
                if (rightPart == 0)
                {
                    return CoreConverter(leftNavigator) + mainUnits[5];
                }
                else
                {
                    long rightPartLen = GetLength(rightPart) - 1;
                    long righPartFromPower = (long)Math.Pow(10, rightPartLen);
                    long rightPartFirstValue = rightPart / righPartFromPower;
                    Navigator rightNavigator = new Navigator
                    {
                        CurrentValue = rightPart,
                        FirstValue = rightPartFirstValue,
                        TotalDigit = rightPartLen
                    };
                    return CoreConverter(leftNavigator) + mainUnits[5] + CoreConverter(rightNavigator);
                }

            }

            if (navigator.TotalDigit >= 6 && navigator.TotalDigit < 9)
            {
                long leftPart = navigator.CurrentValue / 1000000;
                long rightPart = navigator.CurrentValue % 1000000;
                long leftPartLen = GetLength(leftPart) - 1;
                long leftPartFromPower = (long)Math.Pow(10, leftPartLen);
                long leftPartFirstValue = leftPart / leftPartFromPower;
                Navigator leftNavigator = new Navigator
                {
                    CurrentValue = leftPart,
                    FirstValue = leftPartFirstValue,
                    TotalDigit = leftPartLen
                };
                if (rightPart == 0)
                {
                    return CoreConverter(leftNavigator) + mainUnits[4];
                }
                else
                {
                    long rightPartLen = GetLength(rightPart) - 1;
                    long righPartFromPower = (long)Math.Pow(10, rightPartLen);
                    long rightPartFirstValue = rightPart / righPartFromPower;
                    Navigator rightNavigator = new Navigator
                    {
                        CurrentValue = rightPart,
                        FirstValue = rightPartFirstValue,
                        TotalDigit = rightPartLen
                    };
                    return CoreConverter(leftNavigator) + mainUnits[4] + CoreConverter(rightNavigator);
                }
            }

            if (navigator.TotalDigit >= 3 && navigator.TotalDigit < 6)
            {
                long rightPart = navigator.CurrentValue % 1000;
                long leftPart = navigator.CurrentValue / 1000;
                if (rightPart == 0)
                {
                    if (leftPart == 1)
                    {
                        return specialUnits[3];
                    }
                    else
                    {
                        long len = GetLength(leftPart) - 1;
                        long fromPower = (long)Math.Pow(10, len);
                        long firstValue = leftPart / fromPower;
                        Navigator leftPartNavigator = new Navigator
                        {
                            CurrentValue = leftPart,
                            FirstValue = firstValue,
                            TotalDigit = len
                        };
                        return CoreConverter(leftPartNavigator) + mainUnits[3];
                    }
                }
                else
                {
                    if (leftPart == 1)
                    {

                        long len = GetLength(rightPart) - 1;
                        long fromPower = (long)Math.Pow(10, len);
                        long firstValue = rightPart / fromPower;
                        return specialUnits[3] + CoreConverter(new Navigator
                        {
                            CurrentValue = rightPart,
                            FirstValue = firstValue,
                            TotalDigit = len
                        });
                    }
                    else
                    {
                        Navigator leftPartNavigator = new Navigator();
                        Navigator rightPartNavigator = new Navigator();
                        long leftPartLen = GetLength(leftPart) - 1;
                        long leftPartFromPower = (long)Math.Pow(10, leftPartLen);
                        long leftPartFirstValue = leftPart / leftPartFromPower;
                        leftPartNavigator.CurrentValue = leftPart;
                        leftPartNavigator.FirstValue = leftPartFirstValue;
                        leftPartNavigator.TotalDigit = leftPartLen;
                        long rightPartLen = GetLength(rightPart) - 1;
                        long rightPartFromPower = (long)Math.Pow(10, rightPartLen);
                        long rightPartFirstValue = rightPart / rightPartFromPower;
                        rightPartNavigator.CurrentValue = rightPart;
                        rightPartNavigator.FirstValue = rightPartFirstValue;
                        rightPartNavigator.TotalDigit = rightPartLen;

                        return CoreConverter(leftPartNavigator) + mainUnits[3] + CoreConverter(rightPartNavigator);
                    }
                }
            }

            if (navigator.TotalDigit == 2)
            {
                if (navigator.FirstValue == 1)
                {
                    navigator.CurrentValue %= 100;
                    if (navigator.CurrentValue == 0)
                    {
                        return specialUnits[2];
                    }
                    else
                    {
                        navigator.TotalDigit = GetLength(navigator.CurrentValue) - 1;
                        long fromPower = (long)Math.Pow(10, navigator.TotalDigit);
                        navigator.FirstValue = (navigator.CurrentValue / fromPower);
                        return specialUnits[2] + CoreConverter(navigator);
                    }

                }
                else
                {
                    long currentFirstValue = navigator.FirstValue;
                    navigator.CurrentValue %= 100;
                    if (navigator.CurrentValue == 0)
                    {
                        return units[currentFirstValue - 1] + mainUnits[2];
                    }
                    else
                    {

                        navigator.TotalDigit = GetLength(navigator.CurrentValue) - 1;
                        long fromPower = (long)Math.Pow(10, navigator.TotalDigit);
                        navigator.FirstValue = (navigator.CurrentValue / fromPower);
                        return units[currentFirstValue - 1] + mainUnits[2] + CoreConverter(navigator);
                    }
                }
            }
            else if (navigator.TotalDigit == 1)
            {
                if (navigator.CurrentValue == 10)
                {
                    return specialUnits[0];
                }
                else if (navigator.CurrentValue == 11)
                {
                    return specialUnits[1];
                }
                else if (navigator.FirstValue == 1)
                {
                    long subUnit = navigator.CurrentValue % 10;
                    return units[subUnit - 1] + mainUnits[0];
                }
                else
                {
                    long subUnit = navigator.CurrentValue % 10;
                    if (subUnit != 0)
                        return units[navigator.FirstValue - 1] + mainUnits[1] + units[subUnit - 1];
                    else
                        return units[navigator.FirstValue - 1] + mainUnits[1]; 
                }
            }
            else
            {
                return units[navigator.FirstValue - 1];
            }
        }
    }
}
