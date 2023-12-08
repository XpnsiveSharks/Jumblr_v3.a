using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumblr_v3.a.Commons
{
    public class Functionalities
    {
        static DataSource[] EasyWordsInfo = DataSource.GetArrayOfEasyWords();
        static DataSource[] AverageWordsInfo = DataSource.GetArrayOfAverageWords();
        static DataSource[] DifficultWordsInfo = DataSource.GetArrayOfDifficultWords();
        static Random random = new Random();
        static List<int> UsedNumber = new List<int>();//List of Used index
        static int TrackCorrectGuess = 0;
        static int Score = 0;
        static bool IsNotCorrectAns = false;
        static bool IsHintTriggered = false;
        
        public static string Scoring()// returns the total score
           => $"Score: {Score}";
        public static string TrackLevel()// tracks the correct guess
           => TrackCorrectGuess.ToString();
       /* public static bool PrintWordTriggered()// tracks the correct guess
           => IsPrintWordTriggered;*/
        public static bool HintTriggered()
           => IsHintTriggered;

        public static int WrongGuess() // returns wrong guess binary t and f
        {
            if (IsNotCorrectAns == true)
            {
                IsNotCorrectAns = false;
                return 1;
            }
            else
            {
                return 0;
            }
        } 
        public static string printWord()//returns scrambled words
        {
           // IsPrintWordTriggered = true;
            IsHintTriggered = false;
            if (TrackCorrectGuess <= 20)
            {
                return ScrambleWord(EasyWordsInfo[radomNumberGenerator()].WORDS);
            }
            else if (TrackCorrectGuess >= 21 && TrackCorrectGuess <= 40)
            {
                return ScrambleWord(AverageWordsInfo[radomNumberGenerator()].WORDS);
            }
            else if (TrackCorrectGuess >= 41 && TrackCorrectGuess <= 60)
            {
                return ScrambleWord(DifficultWordsInfo[radomNumberGenerator()].WORDS);
            }
            else
            {
                return "Congratulations You Completed the Jumblr Game";
            }
        }
        public static string printHint()//prints the hint of the current word
        {
            if (TrackCorrectGuess <= 20)
                if (Score >= 3)
                {
                    IsHintTriggered = true;
                    Score -= 3;
                    return EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
                }
                else
                {
                    return "Score must be more than equal to 3";
                }
            else if (TrackCorrectGuess >= 21 && TrackCorrectGuess <= 40)
                if (Score >= 4)
                {
                    IsHintTriggered = true;
                    Score -= 4;
                    return AverageWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
                }
                else
                {
                    return "Score must be more than equal to 4";
                }
            else if (TrackCorrectGuess >= 41 && TrackCorrectGuess <= 60)
                if (Score >= 5)
                {
                    IsHintTriggered = true;
                    Score -= 5;
                    return DifficultWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
                }
                else
                {
                    return "Score must be more than equal to 5";
                }
            else
                return null;
        }
        public static string printActiveHint()// prints the hint of the current word
        {
            if (TrackCorrectGuess <= 20)
            {
                return EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
            }
            else if (TrackCorrectGuess >= 21 && TrackCorrectGuess <= 40)
            {
                return AverageWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
            }
            else if (TrackCorrectGuess >= 41 && TrackCorrectGuess <= 60)
            {
                return DifficultWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
            }
            else
                return null;
        }
        /// <summary>
        /// Reshuffle word
        /// </summary>
        /// <returns></returns>
        public static string ReShuffle()// returns resuffled words
        {
            if (TrackCorrectGuess <= 20)
                return ScrambleWord(EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS);
            else if (TrackCorrectGuess >= 21 && TrackCorrectGuess <= 40)
                return ScrambleWord(AverageWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS);
            else if (TrackCorrectGuess >= 41 && TrackCorrectGuess <= 60)
                return ScrambleWord(DifficultWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS);
            else
                return "Congratulations You Completed the Jumblr Game";
        }
        /// <summary>
        /// Verify the answer and returns the jumbled word if guess is wrong
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string VerifyAnswer(string input)//verefies the answer of the user
        {
            if (TrackCorrectGuess <= 20 && input.ToLower().Equals(EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS.ToLower()))
            {
                TrackCorrectGuess += 1;
                Score += 2;
                return printWord();
            }
            else if (TrackCorrectGuess >= 21 && TrackCorrectGuess <= 60 && input.ToLower().Equals(AverageWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS.ToLower()))
            {
                TrackCorrectGuess += 1;
                Score += 3;
                return printWord();
            }
            else if (TrackCorrectGuess >= 41 && TrackCorrectGuess <= 60 && input.ToLower().Equals(DifficultWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS.ToLower()))
            {
                TrackCorrectGuess += 1;
                Score += 5;
                return printWord();
            }
            else
            {
                trackMaximumWrongGuess--;
                IsNotCorrectAns = true;
                return RePrintWord();
            }
        }
        public static string RePrintWord()
        {
            //IsPrintWordTriggered = false;
            if (TrackCorrectGuess <= 20)
                return ScrambleWord(EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS);
            else if (TrackCorrectGuess >= 21 && TrackCorrectGuess <= 40)
                return ScrambleWord(AverageWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS);
            else if (TrackCorrectGuess >= 41 && TrackCorrectGuess <= 60)
                return ScrambleWord(DifficultWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS);
            else
                return null;
        }

        /// <summary>
        /// number randomizer
        /// </summary>
        /// <returns></returns>
        static int radomNumberGenerator()// index randomizer
        {
            var numbers = new List<int>();// creates a range of number that will be randomly picked
            int index;
            if (UsedNumber.Count == 20)
            {
                UsedNumber.Clear();
                for (int i = 0; i <= 39; i++) // set base on the data source count
                    numbers.Add(i);
                index = random.Next(numbers.Count); //randomly pick a number from the numbers List

                while (UsedNumber.Contains(numbers[index])) // checks if the picked number from the numbers List(Local variable) is already been used in the UsedNumber List(Global variable)
                    index = random.Next(numbers.Count);

                UsedNumber.Add(numbers[index]);// Adds the picked number in the List
            }
            else
            {
                for (int i = 0; i <= 39; i++) // set base on the data source count
                    numbers.Add(i);
                index = random.Next(numbers.Count); //randomly pick a number from the numbers List

                while (UsedNumber.Contains(numbers[index])) // checks if the picked number from the numbers List(Local variable) is already been used in the UsedNumber List(Global variable)
                    index = random.Next(numbers.Count);

                UsedNumber.Add(numbers[index]);// Adds the picked number in the List
            }
            return numbers[index];
        }
        /// <summary>
        /// word randomizer
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ScrambleWord(string word)// reurns scramble words
        {
            string randomizedWord;
            do
            {
                if (word.Contains(' '))// Check if the word contains spaces
                {
                    
                    string[] words = word.Split(' ');// Split the word into two words

                    string randomizedWord1 = ScrambleWord(words[0]);
                    string randomizedWord2 = ScrambleWord(words[1]);

                    randomizedWord = randomizedWord1 + " " + randomizedWord2;// Combine the randomized words with the space
                }
                else
                {
                    char[] characters = word.ToCharArray(); // Randomize the characters of the word

                    for (int i = 0; i < characters.Length; i++)
                    {
                        int randomIndex = random.Next(characters.Length);
                        char temp = characters[i];
                        characters[i] = characters[randomIndex];
                        characters[randomIndex] = temp;
                    }

                    randomizedWord = new string(characters);
                }
            } while (IsSimilar(randomizedWord, word)); // Check if randomized word is similar to original word
           
            return randomizedWord;
        }
        private static bool IsSimilar(string word1, string word2)// Check if the lengths of the words differ by more than 2 characters
        {
            if (Math.Abs(word1.Length - word2.Length) > 2)
                return false;

            int matchingCharacters = 0;// Count the number of matching characters
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[i] == word2[i])
                    matchingCharacters++;
            }
            double similarityScore = (double)matchingCharacters / Math.Min(word1.Length, word2.Length); // Calculate the similarity score based on the number of matching characters
            return similarityScore > 0.7;// Consider the words similar if the similarity score is above 0.7
        }
        //************************************(Challenge Mode) I'll optimize this soon*************************************************//

        //GetArrayOfWordsForChallengeMode
        private static int trackMaximumWrongGuess = 3;
        public static int LivesLeft()
            => trackMaximumWrongGuess;

        public static int GameOver()
        {
            if(trackMaximumWrongGuess == 0) return 0;
            return trackMaximumWrongGuess;
        }
        public static int ScoringForChallengeMode()// returns the total score
          => Score;
        public static void ResetDataFromFunctions()
        {
            UsedNumber.Clear();
            TrackCorrectGuess = 0;
            Score = 0;
            IsNotCorrectAns = false;
            IsHintTriggered = false;
            trackMaximumWrongGuess = 3;
        }
        /*public static string VerifyAnswerForChallenge(string input)//verefies the answer of the user
        {
            if (TrackCorrectGuess <= 20 && input.ToLower().Equals(EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS.ToLower()))
            {
                TrackCorrectGuess += 1;
                Score += 2;
                return printWord();
            }
            else if (TrackCorrectGuess >= 21 && TrackCorrectGuess <= 60 && input.ToLower().Equals(AverageWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS.ToLower()))
            {
                TrackCorrectGuess += 1;
                Score += 3 ;
                return printWord();
            }
            else if (TrackCorrectGuess >= 41 && TrackCorrectGuess <= 60 && input.ToLower().Equals(DifficultWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORDS.ToLower()))
            {
                TrackCorrectGuess += 1;
                Score += 5;
                return printWord();
            }
            else
            {
                
                IsNotCorrectAns = true;
                return RePrintWord();
            }
        }*/
    }
}
