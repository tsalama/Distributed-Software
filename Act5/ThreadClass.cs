using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Act5
{
    class ThreadClass
    {
        int numDigits = 0;
        int numUppers = 0;
        bool isPal = true;

        public void digitCount(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    numDigits++;
            }
        }
        public void upperCount(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    numUppers++;
            }
        }
        public void isPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                char ch1 = Char.ToLower(str[i]);
                char ch2 = Char.ToLower(str[str.Length - 1 - i]);

                if (ch1 != ch2)
                    isPal = false;
            }
        }

        public int getDigitCount()
        {
            return numDigits;
        }

        public int getUpperCount()
        {
            return numUppers;
        }

        public bool isPalin()
        {
            return isPal;
        }

    }
}
