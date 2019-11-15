using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_gui
{
    class EngGameMasterSolo
    {
        //Pictures pic = new Pictures();
        public bool quit = false;
        public string Passcode { get; set; }
        string code;
        public List<char> wrong_letters = new List<char>();
        List<char> used_letters = new List<char>();
        public string RandomWord()
        {
            String[] Possible_words = File.ReadAllLines("Eng-Words.txt");
            Random random = new Random();
            int RandomIndex = random.Next(Possible_words.Length);
            return Possible_words[RandomIndex].ToLower();
        }
        public string Encrypt(String secretword)
        {

            Passcode = secretword.ToLower();
            for (int i = 0; i < Passcode.Length; i++)
            {
                code += "*";
            }
            Char[] pc = Passcode.ToCharArray();
            Char[] c = code.ToCharArray();
            for (int i = 0; i < Passcode.Length; i++)
            {
                if (pc[i] == ' ')
                {
                    c[i] = pc[i];
                }
            }
            code = new string(c);
            return code;
        }
        public bool TestIfUsed(char guess)
        {
            foreach (char c in used_letters)
            {
                if (c == guess)
                {
                    return true;
                }
            }
            used_letters.Add(guess);
            return false;
        }
        public bool TestFor(String word, String code, char guess)
        {
            Char[] pc = word.ToCharArray();
            Char[] c = code.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (pc[i] == guess)
                {
                    return true;
                }
            }
            wrong_letters.Add(guess);
            return false;

        }
        public string Unscramble(String word, String code, char guess)
        {
            List<int> index = new List<int>();
            Char[] pc = word.ToCharArray();
            Char[] c = code.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (pc[i] == guess)
                {
                    index.Add(i);



                }
            }
            foreach (int i in index)
            {
                c[i] = pc[i];
            }
            index.Clear();
            return (new string(c));
        }
    }
}
