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
    public partial class Frm_ConsoleBase : DockContent
    {
        protected StringBuilder m_outSb = new StringBuilder();
        public Frm_ConsoleBase()
        {
            InitializeComponent();

            StringWriter Sw = new StringWriter(m_outSb);
            Console.SetOut(Sw);

        }
        public virtual void Process()
        {
            return;
        }
        protected string GetInput(string strContent)
        {
            Frm_GetInput frmGetInput = new Frm_GetInput(strContent);
            if (frmGetInput.ShowDialog() == DialogResult.OK)
            {
                return frmGetInput.GetInput();
            }

            return "";

        }

        private void Frm_ConsoleBase_Load(object sender, EventArgs e)
        {
            Process();
            this.richTextBox1.AppendText(m_outSb.ToString());
        }
    }
}
