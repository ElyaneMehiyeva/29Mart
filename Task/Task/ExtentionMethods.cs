using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    static class ExtentionMethods
    {
        public static bool IsOdd(this int number)
        {
            if (number % 2 != 0)
                return true;            
            return false;
        }
        public static bool IsEven(this int number)
        {
            if(number%2 == 0)
                return true;
            return false;
        }
        public static bool IsContainsDigit(this string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                    return true;
            }
            return false;
        }
        public static string ToCapitalize(this string word)
        {
            word = word.ToLower();
            string newStr = char.ToUpper(word[0]) + word.Substring(1);
            return newStr;
        }
        public static int[] GetValueIndexes(this string text,char ch)
        {
            int[] indexes;
            indexes = new int[0];
            int i = 0;
            foreach (char item in text)
            {                
                if (item == ch)
                {
                    Array.Resize(ref indexes, indexes.Length+1);
                    indexes[indexes.Length-1] = i;
                }
                i++;
            }
            return indexes;
        }
    } 
}