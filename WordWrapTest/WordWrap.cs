using System.Collections.Generic;
using System.Linq;

namespace WordWrapTest
{
    public static class WordWrap
    {
        public static string Warp(string text, int columnLimit)
        {
            //string[] splitTextBySpace = text.Split(" ");

            //string.Join("\n", splitTextBySpace);

            string accumulateCharacters = string.Empty;
            string output = string.Empty;
            char removeCharacter = new char();
            int removeIndex = 1;
            foreach (var character in text)
            {
                if (accumulateCharacters.Length == 10)
                {
                    RemoveCharUntilSpace(columnLimit, ref accumulateCharacters, ref removeCharacter, ref removeIndex);

                    output += accumulateCharacters + "\n";
                    accumulateCharacters = string.Empty;
                    accumulateCharacters += removeCharacter;
                }

                accumulateCharacters += character;
            }

            return output;
        }

        private static void RemoveCharUntilSpace(int columnLimit, ref string accumulateCharacters, ref char removeCharacter, ref int removeIndex)
        {
            foreach (var letter in Letters())
            {
                if (accumulateCharacters[columnLimit - removeIndex].ToString().ToUpper().EndsWith(letter))
                {
                    removeCharacter = accumulateCharacters[columnLimit - removeIndex];
                    accumulateCharacters = accumulateCharacters.Remove(columnLimit - removeIndex);
                    removeIndex++;
                }
            }
        }

        private static List<char> Letters()
        {
            return new List<char>()
            {
                'A',
                'B',
                'C',
                'D',
                'E',
                'F',
                'G',
                'H',
                'I',
                'J',
                'K',
                'L',
                'M',
                'N',
                'O',
                'P',
                'Q',
                'R',
                'S',
                'T',
                'U',
                'V',
                'W',
                'X',
                'Y',
                'Z'
            };
        }
    }
}