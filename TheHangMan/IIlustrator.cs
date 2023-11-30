using System.Collections.Generic;

namespace TheHangMan
{
    interface IIlustrator
    {
        void WriteScreenHeader();

        void PrintWord(List<char> guessedLetters, string currentWord);

        void PrintEmpyGallows();

        void PrintHangMan(int amountOfBodyPartsToDisplay);
    }
}
