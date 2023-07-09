using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = SplitSentence(sentence);

            Console.WriteLine("Word frequency:");
            Frequency(words);

            Console.WriteLine();

            Console.WriteLine("Sentence Maker:");
            Console.Write("Enter the number of sentences to generate: ");
            int numberOfSentences = Convert.ToInt32(Console.ReadLine());
            GenerateSentences(words, numberOfSentences);

            Console.WriteLine();

            Console.WriteLine("Longest and Shortest Word Finder:");
            Longest_Shortest(words);

            Console.WriteLine();

            Console.WriteLine("Word Search:");
            Console.Write("Enter a word to search: ");
            string searchWord = Console.ReadLine();
            SearchWord(sentence, searchWord);

            Console.WriteLine();

            Console.WriteLine("Palindrome Detector:");
            FindPalindromicWords(words);

            Console.WriteLine();

            Console.WriteLine("Vowel/Consonant Counter:");
            Vowels_Consonants(words);
            Console.ReadKey();
        }

        static string[] SplitSentence(string sentence)
        {
            char[] separators = { ' ', ',', '.', '?', '!', ';', ':', '-' };
            int wordCount = CountWords(sentence, separators);
            string[] words = new string[wordCount];
            int wordIndex = 0;

            int startIndex = 0;
            int length = sentence.Length;
            for (int i = 0; i < length; i++)
            {
                char currentChar = sentence[i];
                if (IsSeparator(currentChar, separators))
                {
                    if (startIndex != i)
                    {
                        words[wordIndex] = sentence.Substring(startIndex, i - startIndex);
                        wordIndex++;
                    }
                    startIndex = i + 1;
                }
            }

            if (startIndex != length)
            {
                words[wordIndex] = sentence.Substring(startIndex, length - startIndex);
            }

            return words;
        }

        static int CountWords(string sentence, char[] separators)
        {
            int wordCount = 0;
            int startIndex = 0;
            int length = sentence.Length;

            for (int i = 0; i < length; i++)
            {
                char currentChar = sentence[i];
                if (IsSeparator(currentChar, separators))
                {
                    if (startIndex != i)
                    {
                        wordCount++;
                    }
                    startIndex = i + 1;
                }
            }

            if (startIndex != length)
            {
                wordCount++;
            }

            return wordCount;
        }

        static bool IsSeparator(char character, char[] separators)
        {
            foreach (char separator in separators)
            {
                if (character == separator)
                {
                    return true;
                }
            }
            return false;
        }

        static void Frequency(string[] words)
        {
            int length = words.Length;
            string[] uniqueWords = new string[length];
            int[] frequencies = new int[length];
            int uniqueWordCount = 0;

            for (int i = 0; i < length; i++)
            {
                string currentWord = words[i];
                bool isUnique = true;

                for (int j = 0; j < uniqueWordCount; j++)
                {
                    if (uniqueWords[j] == currentWord)
                    {
                        frequencies[j]++;
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueWords[uniqueWordCount] = currentWord;
                    frequencies[uniqueWordCount] = 1;
                    uniqueWordCount++;
                }
            }

            for (int i = 0; i < uniqueWordCount; i++)
            {
                Console.WriteLine($"{uniqueWords[i]}: {frequencies[i]}");
            }
        }

        static void GenerateSentences(string[] words, int numberOfSentences)
        {
            Random random = new Random();

            for (int i = 0; i < numberOfSentences; i++)
            {
                string sentence = "";

                for (int j = 0; j < 5; j++)
                {
                    int randomIndex = random.Next(0, words.Length);
                    sentence += words[randomIndex] + " ";
                }

                Console.WriteLine(sentence.Trim());
            }
        }

        static void Longest_Shortest(string[] words)
        {
            int shortestLength = int.MaxValue;
            int longestLength = int.MinValue;

            foreach (string word in words)
            {
                int wordLength = word.Length;

                if (wordLength < shortestLength)
                {
                    shortestLength = wordLength;
                }

                if (wordLength > longestLength)
                {
                    longestLength = wordLength;
                }
            }

            Console.WriteLine("Shortest word(s):");
            foreach (string word in words)
            {
                if (word.Length == shortestLength)
                {
                    Console.WriteLine(word);
                }
            }

            Console.WriteLine("Longest word(s):");
            foreach (string word in words)
            {
                if (word.Length == longestLength)
                {
                    Console.WriteLine(word);
                }
            }
        }

        static void SearchWord(string sentence, string searchWord)
        {
            int count = 0;
            int startIndex = 0;
            int length = sentence.Length;

            while (startIndex < length)
            {
                int wordIndex = sentence.IndexOf(searchWord, startIndex, StringComparison.OrdinalIgnoreCase);

                if (wordIndex == -1)
                {
                    break;
                }

                count++;
                startIndex = wordIndex + searchWord.Length;
            }

            if (count > 0)
            {
                Console.WriteLine($"The word \"{searchWord}\" appears {count} time(s) in the sentence.");
            }
            else
            {
                Console.WriteLine($"The word \"{searchWord}\" does not exist in the sentence.");
            }
        }

        static void FindPalindromicWords(string[] words)
        {
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Vowels_Consonants(string[] words)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (string word in words)
            {
                int vowelCount = 0;
                int consonantCount = 0;

                foreach (char character in word)
                {
                    if (IsVowel(character, vowels))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }

                Console.WriteLine($"{word}: Vowels - {vowelCount}, Consonants - {consonantCount}");
            }
        }

        static bool IsVowel(char character, char[] vowels)
        {
            foreach (char vowel in vowels)
            {
                if (char.ToLower(character) == vowel)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
    

