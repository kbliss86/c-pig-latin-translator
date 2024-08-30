using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_pig_latin_translator
{
    internal class Program
    {
            static void Main(string[] args)
            {

            /*
            Capstone: Pig Latin Translator

            Objectives:
            - User Input
            - String Manipulation

            Intro:
            Pig Latin is a playful language game in English where the starting consonants of words are moved to the end of the word, followed by adding "-ay". For example, "Hello World" would be translated to "ellohay orldway" in Pig Latin.
            */

            /*
            Task:
            Translate words from English to Pig Latin.
            */

            /*
            What the Application Will Do:
            1. Prompt the user for a word.
            2. Translate the word to Pig Latin and display it on the console.
            3. Ask the user if they want to translate another word.
            */

            /*
            Build Specifications:
            - Convert each word to lowercase before translating.
            - If a word starts with a vowel, simply add "way" to the end.
            - If a word starts with a consonant, move all the consonants before the first vowel to the end of the word, then add "ay" to the end.
            */

            /*
            Additional Requirements:
            - Ensure you answer the Lab Summary when submitting to the LMS.
            - Deduct 2 points if there are syntax errors or the program does not run (for example, in the Main method).
            */

            /*
            Extended Exercises:
            - Preserve the case of the word (e.g., uppercase, title case, lowercase).
            - Allow punctuation in the input string.
            - Translate words with contractions (e.g., "can’t" becomes "an’tcay").
            - Exclude words that contain numbers or symbols from translation (e.g., "189" or "hello@grandcircus.co").
            - Ensure that the user has entered text before attempting to translate.
            - Extend the application to take a full line of text and translate each word in the line.
            */

            /*
            Hints:
            - Treat "y" as a consonant in your logic.
            */

            /*
            Testing the Code with User Input Prompts:

            To test the code dynamically, prompt the user for input and handle different cases:

            Console.WriteLine("Enter a word to translate to Pig Latin:");
            string userInput = Console.ReadLine();

            // Apply translation logic to userInput and display the result
            string pigLatinTranslation = TranslateToPigLatin(userInput);
            Console.WriteLine($"Pig Latin Translation: {pigLatinTranslation}");

            Console.WriteLine("Translate another word? (y/n):");
            string continueResponse = Console.ReadLine();
            if (continueResponse.ToLower() == "y") {
                // Loop back to ask for another word
            }
            */

            //Prompt the user for a word.
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            //Bool for input validation loop
                bool keepGoing = true;
                //While Loop for input validation
                while (keepGoing)
                {
                    Console.WriteLine("Please enter a word to be translated into Pig Latin");
                    string input = Console.ReadLine();//Prompt the user for a word.

                if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a valid word");
                        continue;
                    }
                    else
                    {
                        //Translate the word to Pig Latin.
                        string translatedLine = TranslateLineToPigLatin(input);//Method to Translate the line to Pig Latin
                        //Display it on the console.
                        Console.WriteLine(translatedLine);

                        //Ask the user if they want to translate another word.
                        Console.Write("Translate another line? (y/n): ");
                        string response = Console.ReadLine().ToLower();
                        keepGoing = response == "y";
                    }

                    /*
                    Example Console Preview:

                    Welcome to the Pig Latin Translator!

                    Enter a line to be translated: {this sentence exists here}

                    Isthay entencesay existsway erehay

                    Translate another line? (y/n): N
                    */

                }//End While Loop
                Console.ReadLine();
        }//End Main

            static string TranslateLineToPigLatin(string input)
            {
                string[] words = input.Split(' ');//convert phrase to array of words by splitting them where there is a " "(Space)
                //for loop to cycle through each word in the array
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = TranslateWordToPigLatin(words[i]);//cycle through the array and use the tanslate words method
                }
                return string.Join(" ", words);//return the array of words as a string and join them with a " "(Space) Delimiter

            }//End TranslateLineToPigLatin

            static string TranslateWordToPigLatin(string word)
            {
                //Extra Credit Preserve the case of the word (e.g., uppercase, title case, lowercase).
                string wordWithoutPunctuation = word.TrimEnd(',', '.', '!', '?');//Remove punctuation from the end of the word
                string punctuation = word.Length > wordWithoutPunctuation.Length ? word.Substring(wordWithoutPunctuation.Length): string.Empty;//Get the punctuation from the end of the word //substring returns the string from the specified index (in this case the length of the word without punctuation) to the end of the string
                //Convert each word to lowercase before translating.
                string wordLower = wordWithoutPunctuation.ToLower();//Convert the word to lowercase

                string pigLatinWord;

                //If a word starts with a vowel, simply add "way" to the end.
                //Treat "y" as a consonant in your logic.
                if ("aeiou".IndexOf(char.ToLower(wordLower[0])) >= 0)//if the first character of the word is a vowel do this, indexOf returns the index of the first instance of the unicode "aeiou" in the word
                {
                    pigLatinWord = wordLower + "way";//add "way" to the end of the word
                }
                //If a word starts with a consonant, move all the consonants before the first vowel to the end of the word, then add "ay" to the end.
                else
                {
                    //find the first vowel in the word
                    int firstVowelIndex = wordLower.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });//find the first vowel in the word indexOfAny returns the index of the first instance of any of the unicode "aeiou" in the word
                    if (firstVowelIndex == -1)//if there are no vowels in the word
                    {
                        pigLatinWord = wordLower + "ay";//return the word
                    }
                    else
                    {
                        pigLatinWord = wordLower.Substring(firstVowelIndex) + wordLower.Substring(0, firstVowelIndex) + "ay";//move all the consonants before the first vowel to the end of the word, then add "ay" to the end.//substring returns the string from the specified index (in this case after the first occurance of a vowel)
                    }
                }

                //Maintain original case
                if (char.IsUpper(word[0]))//if the first character of the word is uppercase
                {
                    pigLatinWord = char.ToUpper(pigLatinWord[0]) + pigLatinWord.Substring(1);//convert the first character of the pig latin word to uppercase
                }
                //Add back punctuation
                pigLatinWord += punctuation;//add the punctuation back to the end of the word

                //Return Value
                return pigLatinWord;//return the pig latin word

            }//End TranslateWordToPigLatin
            
            //tatic int 
        

        //Extra Credit Allow punctuation in the input string.
        //Extra Credit Translate words with contractions (e.g., "can’t" becomes "an’tcay").
        //Extra Credit Exclude words that contain numbers or symbols from translation (e.g., "189" or "hello@grandcircus.co")
        //Extra Credit Ensure that the user has entered text before attempting to translate.
        //Extra Credit Extend the application to take a full line of text and translate each word in the line.


    }//End Class
}//End Namespace
