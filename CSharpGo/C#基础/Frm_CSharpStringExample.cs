using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;


namespace CSharpGo
{
    public partial class Frm_CSharpStringExample : Frm_ConsoleBase
    {
        public Frm_CSharpStringExample()
        {
            InitializeComponent();
        }

        public override void Process()
        {
            testSplit();
            tokenizing("I like this food,are you?"); 
        }
        void testSplit()
        {
            Console.WriteLine("---testSplit---");
            string s = "abcdeabcdeabcde";
            string[] sArray = s.Split('c');
            foreach (string i in sArray)
                Console.WriteLine(i.ToString());
        }
        void tokenizing(string strTemp)
        {
            Console.WriteLine("---tokenizing---");
            char[] separators = { ' ', ',', '?', ':', '!' };
            int startpos = 0;
            int endpos = 0;
            do
            {
                endpos = strTemp.IndexOfAny(separators, startpos);
                if (endpos == -1) endpos = strTemp.Length;
                if (endpos != startpos)
                    Console.WriteLine(strTemp.Substring(startpos, (endpos - startpos)));
                startpos = (endpos + 1);
            } while (startpos < strTemp.Length);

        }

        private void Frm_StringExample_Load(object sender, EventArgs e)
        {
        }
    }
}
