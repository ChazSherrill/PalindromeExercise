using System;
using System.Linq;
namespace PalindromeExercise
{
    public class Wordsmith
    {
        public Wordsmith()
        {
        }
        public bool IsAPalindrome(string word)
        {
            // int length = word.Length - 1;
            // string drow = string.Empty; 
            // for (; length <= 0; length--)
            // {
            //     drow += word[length];
            // }
            //
            // return word == drow;


            var wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            return word == new string(wordArray);


        }
    }
}
