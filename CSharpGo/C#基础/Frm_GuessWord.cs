using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;


namespace CSharpGo
{
    public partial class Frm_GuessWord : Frm_ConsoleBase
    {
        static int wrongGuess, lettersLeft;

        public Frm_GuessWord()
        {
            InitializeComponent();
     
        }
       
        private void Frm_GuessWord_Load(object sender, EventArgs e)
        {
         
        }

        static string GetWordToGuess()
         {
             Random number = new Random();
             int wordNumber = number.Next(0, 9);
 
             string[] words = { "picture", "chinese", "school", "question", "include", "simple", "difficult", "understand", "necessary", "support" };
 
             string selectWord = words[wordNumber];
             return selectWord;
         }
 
         static char[] GetHiddenLetters(string word, char mask)
         {
             char[] hidden = new char[word.Length];
 
             for (int i = 0; i < word.Length; i++)
             {
                 hidden[i] = mask;
             }
 
             return hidden;
         }
 
         static void DisplayCharacters(char[] characters)
         {
             foreach (char letter in characters)
             {
                 Console.Write(letter);
             }
             Console.WriteLine();
         }
 
         static char[] CheckGuess(char letterToCheck, string word, char[] characters)
         {
             if (word.Contains(letterToCheck))
             {
                 for (int i = 0; i < word.Length; i++)
                 {
                     if (word[i] == letterToCheck)
                     {
                         characters[i] = word[i];
                         lettersLeft--;
                     }
                 }
             }
             else
             {
                 wrongGuess--;
             }
 
             return characters;
         }


         public override void Process()
         {
             string wordToGuess = GetWordToGuess();

             char[] maskedWord = GetHiddenLetters(wordToGuess, '-');

             lettersLeft = wordToGuess.Length;
             char userGuess;

             wrongGuess = 6;

             while (wrongGuess > 0 && lettersLeft > 0)
             {
                 DisplayCharacters(maskedWord);

                 Console.WriteLine("Enter a letter?");
                 this.richTextBox1.Text = (m_outSb.ToString());
             
                 string strInput = GetInput(m_outSb.ToString());
                 if (strInput == "")
                     break;
                 userGuess = char.Parse(strInput);

                 maskedWord = CheckGuess(userGuess, wordToGuess, maskedWord);
             }

             Console.WriteLine("Well done! Thanks for playing.");
         }

    }
}
