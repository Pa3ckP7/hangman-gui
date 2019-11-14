using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_gui
{
    class GameMaster
    {
        //Pictures pic = new Pictures();
        public bool quit = false;
        public string Passcode { get; set; }
        int lives=10;
        string code;
        bool PasscodeGuessed = false;
        bool Reset = false;
        public List<char> wrong_letters = new List<char>();
        List<char> used_letters = new List<char>();
        public string EncryptWord(String words) 
        {
            Passcode = words.ToLower();
            Passcode =Passcode.Trim();
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
        public bool TestFor(String word,String code,char guess) 
        {
            Char[] pc = Passcode.ToCharArray();
            Char[] c = code.ToCharArray();
            for (int i = 0; i < Passcode.Length; i++)
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
            Char[] pc = Passcode.ToCharArray();
            Char[] c = code.ToCharArray();
            for (int i = 0; i < Passcode.Length; i++)
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
        public void Game() 
        {
            while (PasscodeGuessed == false && lives > 0 && Reset==false)
            {
                Stats();
                Console.Write("your guess>");
                string your_guesss = Console.ReadLine().ToLower();
                
                if (your_guesss.Equals("")) 
                {
                    Console.Clear();
                    Console.WriteLine();
                    continue;
                }
                if (your_guesss.Equals("/help")) 
                {
                    Console.WriteLine("/quit to exit\n/reset to reset");
                    Console.WriteLine("press enter to continue...");
                    Console.Read();
                    Console.Clear();
                    Console.WriteLine();
                    continue;
                }
                if (your_guesss.Equals("/reset")) 
                {
                    Reset = true;
                    break;
                }
                if (your_guesss.Equals("/quit")) 
                {
                    quit = true;
                    break;
                }
                
                if (your_guesss.Length > 1)
                {
                    if (your_guesss.Equals(Passcode))
                    {
                        PasscodeGuessed = true;
                        break;
                    }
                    else 
                    {
                        lives = 0;
                        break;
                    }
                }
                char your_guess=Convert.ToChar(your_guesss);
                if (used_letters.Contains(your_guess)) 
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You already tried that");
                    continue;
                }
                used_letters.Add(your_guess);
                bool found = false;
                List<int> index = new List<int>();
                Char[] pc = Passcode.ToCharArray();
                Char[] c = code.ToCharArray();
                for (int i = 0; i < Passcode.Length; i++)
                {
                    if (pc[i] == your_guess)
                    {
                        index.Add(i);
                        
                        found = true;
                        
                    }  
                }
                if (found == true)
                {
                    foreach (int i in index)
                    {
                        c[i] = pc[i];
                    }
                    index.Clear();
                }
                else 
                {
                    wrong_letters.Add(your_guess);
                }
                code = new string(c);
                if (found == false)
                {
                    lives--;
                }
                if (Passcode.Equals(code))
                {
                    PasscodeGuessed = true;
                }
                Console.Clear();
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine();
            GameEnd();
        }
        public void Stats() 
        {
            Console.WriteLine($"{code}     | {Passcode.Length} letters");
            if (lives <= 5 && lives > 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (lives <= 3 && lives > 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (lives == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            //Console.WriteLine(pic.Image[lives]);
            
            Console.ResetColor();
            Console.Write("incorect letters: ");
            wrong_letters.ForEach(Console.Write);
            Console.WriteLine("\n------------------------");
        }
        public void GameEnd() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (lives == 0&& PasscodeGuessed==false)
            {
                //Console.WriteLine($"You Lose.\n{pic.Image[lives]}\nThe passcode was {Passcode}");
            }
            Console.ResetColor();
            if (PasscodeGuessed == true) 
            {
                Console.WriteLine("You win");
            }
            if (PasscodeGuessed == true && lives == 0) 
            {
                Console.WriteLine("Impossible");
            }
            if (Reset==true) 
            {
                Console.WriteLine($"Force reset triggered. The word was {Passcode}");
            }
            code = "";
            lives = 10;
            PasscodeGuessed = false;
            Reset = false;
            wrong_letters.Clear();
            used_letters.Clear();
            if (quit == false)
            {
                //StartGame();
            }
            else 
            {
                quit = false;
            }
        }
    }
}
