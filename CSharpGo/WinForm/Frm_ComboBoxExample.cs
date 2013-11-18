using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CSharpGo
{
    public partial class Frm_ComboBoxExample : DockContent
    {
        public Frm_ComboBoxExample()
        {
            InitializeComponent();
        }

        private void Frm_ComboBoxExample_Load(object sender, EventArgs e)
        {
          
            DataSet ds = new DataSet();
            ds.ReadXml(System.Environment.CurrentDirectory + @"..\..\..\xml\员工基本信息.xml");

            this.comboBoxEmployee.DataSource = ds.Tables[0];
            this.comboBoxEmployee.DisplayMember = "姓名";
            this.comboBoxEmployee.ValueMember = "职工号";
            this.comboBoxEmployee.SelectedIndex = 0;
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxName.Text = "选中的员工姓名是" + this.comboBoxEmployee.Text;
        }
    }
}
