# Capstone: Pig Latin Translator

## Objectives:
- User Input
- String Manipulation

## Intro:
Pig Latin is a playful language game in English where the starting consonants of words are moved to the end of the word, followed by adding "-ay". For example, "Hello World" would be translated to "ellohay orldway" in Pig Latin. Learn more about similar games in other languages at [Mental Floss](http://mentalfloss.com/article/50242/pig-latins-11-other-languages).

## Task:
Translate words from English to Pig Latin.

## What the Application Will Do:
1. **1 Point:** The application prompts the user for a word.
2. **1 Point:** The application translates the word to Pig Latin and displays it on the console.
3. **1 Point:** The application asks the user if they want to translate another word.

## Build Specifications:
- **1 Point:** Convert each word to lowercase before translating.
- **1 Point:** If a word starts with a vowel, simply add "way" to the end.
- **2 Points:** If a word starts with a consonant, move all the consonants before the first vowel to the end of the word, then add "ay" to the end.

## Additional Requirements:
- **1 Point:** Ensure you answer the Lab Summary when submitting to the LMS.
- **-2 Points:** Deduct 2 points if there are syntax errors or the program does not run (for example, in the Main method).

## Extended Exercises (2 points maximum):
- **1 Point:** Preserve the case of the word (e.g., uppercase, title case, lowercase).
- **1 Point:** Allow punctuation in the input string.
- **1 Point:** Translate words with contractions (e.g., "can’t" becomes "an’tcay").
- **1 Point:** Exclude words that contain numbers or symbols from translation (e.g., "189" or "hello@grandcircus.co").
- **1 Point:** Ensure that the user has entered text before attempting to translate.
- **1 Point:** Extend the application to take a full line of text and translate each word in the line.

## Hints:
- Treat "y" as a consonant in your logic.

## Example Console Preview:

