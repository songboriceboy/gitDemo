using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpGo
{
    public partial class Frm_GetInput : Form
    {
        private string m_strContent = "";
        public Frm_GetInput(string strContent)
        {
            InitializeComponent();
            m_strContent = strContent;
        }

        private void Frm_GetInput_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = m_strContent;
            
        }
        public string GetInput()
        {
            return this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.button1.Focus();
        }
    }
}
