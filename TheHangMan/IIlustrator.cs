using System.Collections.Generic;

namespace TheHangMan
{
    interface IIlustrator
    {
        void PrintScreenHeader();

        void PrintLettersTried(List<char> lettersTried);

        void PrintWord(List<char> guessedLetters, string currentWord);

        void PrintEmpyGallows();

        void PrintHangMan(int amountOfBodyPartsToDisplay);
    }
}
