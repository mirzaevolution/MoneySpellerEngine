using System;

namespace MoneySpellerEngine
{
    /// <summary>
    /// EN Speller Engine.
    /// </summary>
    public partial class ENSpellerEngine
    {
        private string[] units = new string[]
       {
              "One ","Two ","Three ","Four ","Five ","Six ","Seven ","Eight ","Nine ","Ten "
       };
        private string[] mainUnits = new string[]
            {
               "Hundred ","Thousand ","Million ","Billion ","Trillion "
            };
        private string[] numbers11to19 = new string[]
        {
            "Eleven ","Twelve ", "Thirteen ", "Fourteen ", "Fifteen ","Sixten ","Seventeen ","Eighteen ","Nineteen "
        };
        private string[] numbers20to90 = new string[]
        {
            "Twenty ","Thirty ","Forty ","Fifty ","Sixty ","Seventy ","Eighty ","Ninety "
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
                    return CoreConverter(leftNavigator) + mainUnits[3];
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
                    return CoreConverter(leftNavigator) + mainUnits[3] + CoreConverter(rightNavigator);
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
                    return CoreConverter(leftNavigator) + mainUnits[2];
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
                    return CoreConverter(leftNavigator) + mainUnits[2] + CoreConverter(rightNavigator);
                }
            }

            if (navigator.TotalDigit >= 3 && navigator.TotalDigit < 6)
            {
                long rightPart = navigator.CurrentValue % 1000;
                long leftPart = navigator.CurrentValue / 1000;
                if (rightPart == 0)
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
                    return CoreConverter(leftPartNavigator) + mainUnits[1];
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

                    return CoreConverter(leftPartNavigator) + mainUnits[1] + CoreConverter(rightPartNavigator);
                }
            }

            if (navigator.TotalDigit == 2)
            {
                long currentFirstValue = navigator.FirstValue;
                navigator.CurrentValue %= 100;
                if (navigator.CurrentValue == 0)
                {
                    return units[currentFirstValue - 1] + mainUnits[0];
                }
                else
                {
                    navigator.TotalDigit = GetLength(navigator.CurrentValue) - 1;
                    long fromPower = (long)Math.Pow(10, navigator.TotalDigit);
                    navigator.FirstValue = (navigator.CurrentValue / fromPower);
                    return units[currentFirstValue - 1] + mainUnits[0] + CoreConverter(navigator);
                }
            }
            else if (navigator.TotalDigit == 1)
            {
                if (navigator.CurrentValue == 10)
                {
                    return units[9];
                }
                else if (navigator.CurrentValue >= 11 && navigator.CurrentValue <= 19)
                {
                    long subUnit = navigator.CurrentValue % 10;
                    return numbers11to19[subUnit - 1];
                }
                else
                {
                    long subUnit = navigator.CurrentValue % 10;
                    if (subUnit != 0)
                    {
                        return numbers20to90[navigator.FirstValue - 2] + units[subUnit - 1]; 
                    }
                    else
                    {
                        return numbers20to90[navigator.FirstValue - 2]; 
                    }
                }
            }
            else
            {
                return units[navigator.FirstValue - 1];
            }
        }
    }
}
