using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Helper
    {
        public static string CreateBookCode(string bookName, int number)
        {
            if (string.IsNullOrWhiteSpace(bookName) || number < 0)
            {
                throw new ArgumentException("Invalid inputs.");
            }

            string firstNum = bookName.Length >= 2 ? bookName.Substring(0, 2).ToUpper() : bookName.ToUpper();
            return $"{firstNum}{number}";
        }
    }
}