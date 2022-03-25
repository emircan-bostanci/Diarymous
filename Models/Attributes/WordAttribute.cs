using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models.Attributes
{
    public class WordAttribute 
    {
        int minLenght;
        public WordAttribute(int minLenght)
        {
            this.minLenght = minLenght;
        }
        public bool WordValidation(string value)
        {
            if (value == null)
            {
                return false;
            }

            int wordCounter = countWord(value.ToString());
           if (wordCounter >= minLenght)
            {
                return true;
            }
            return false;
        }
        static int countWord(string value)
        {
            int wordCounter = 0;
            foreach (char letter in value.ToString())
            {
                if (letter == ' ' || letter == '.')
                {
                    wordCounter++;
                }
            }
            return wordCounter;
 
        }
    }
}
