using System;
using System.Collections.Generic;
using KSharpGui.View;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSharpGui.Model;

namespace KSharpGui.Control
{
    public class Passwordgenerator
    {
        public List<char> characters = new List<char>();
        private int passwordLength;
        private string password;
        private static char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static char[] smallLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static char[] bigLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private static char[] specialCharacters = new char[] { '+', '-', '*', '/', '@', '#', '°', 'ç', '%', '&', '|', '¢', '^', '$', '£' };
        private static Random rnd;

        private void setCharacters()
        {
            PasswordRegistModel model = new PasswordRegistModel();

            #region Char Pool setzen
            //Je nach gesetzten Checkboxen, wird der Inhalt der zur Vefügung stehenden Zeichen vergrössert, oder verkleinert
            if(true)
            {//Letters Checkbox checked
                foreach (char element in smallLetters)
                {
                    characters.Add(element);
                }
            }
            if (true)
            {//BigLetters Checkbox checked
                foreach (char element in bigLetters)
                {
                    characters.Add(element);
                }
            }
            if (true)
            {//numbers Checkbox checked
                foreach (char element in numbers)
                {
                    characters.Add(element);
                }
            }
            if (true)
            {
                foreach (char element in specialCharacters)
                {
                    characters.Add(element);
                }
            }
            #endregion  
            generatePassword();
        }

        public String generatePassword()
        {
            int random;
            for (int i = 0; i < passwordLength; i++)
            {
                random = rnd.Next(characters.Count());
            }
            return "Hallo";
        }
    }
}
