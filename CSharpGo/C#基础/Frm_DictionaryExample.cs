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
    public partial class Frm_DictionaryExample : Frm_ConsoleBase
    {
        public Frm_DictionaryExample()
        {
            InitializeComponent();
        }
        public override void Process()
        {
            string text = "I love programming for ever and love csharp for ever";

            Dictionary<string, int> frequencies = CountWords(text);
            //打印映射中的每个键/值对。
            foreach (KeyValuePair<string, int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0}:{1}", word, frequency);
            }
        }
        private Dictionary<string, int> CountWords(string text)
        {
            //创建单词到频率的新映射,它将有效统计每个单词在一段给定文本中出现的频率
            Dictionary<string, int> frequencies;
            frequencies = new Dictionary<string, int>();
            /*将文本分解成单词，对于每个单词，都检查它是否已经存在映射中，
            如果是则增加现有计数；否则就为单词赋予一个初始计数1 */
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    /*这里需要注意下：负责递增的代码不需要执行到int的强制类型转换，就可以执行加法运算：
                    取回的值在编译时已经知道是int类型。使计数递增的步骤实际是先对映射的索引器执行一次取值操作，
                    然后增加，然后对索引器执行赋值操作。*/
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }
            return frequencies;
        }

        private void Frm_DictionaryExample_Load(object sender, EventArgs e)
        {
    

        


          
        }
    }
}
