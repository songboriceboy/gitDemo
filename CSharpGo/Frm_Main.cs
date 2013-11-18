﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Reflection;

namespace CSharpGo
{
    public partial class Frm_Main : Form
    {
        private Frm_MainToolWindow mainToolWin = null;
        private static Frm_Main m_Frm_Main = null;
        public static Dictionary<string, Dictionary<string, string>> m_dicFormText2FormTypeName = new Dictionary<string, Dictionary<string, string>>();
 
        public Frm_Main()
        {
            InitializeComponent();
        }
        private void InitFormText2FormTypeNameDic()
        {
            Dictionary<string, string> dicCSharpBase = new Dictionary<string,string>();
            dicCSharpBase.Add("字符串示例", "CSharpGo.Frm_CSharpStringExample");
            dicCSharpBase.Add("字典应用", "CSharpGo.Frm_DictionaryExample");
            dicCSharpBase.Add("Frm_GuessWord", "CSharpGo.Frm_GuessWord");
            
            m_dicFormText2FormTypeName.Add("CSharp基础",dicCSharpBase);

            Dictionary<string, string> dicWinformBase = new Dictionary<string, string>();
            dicWinformBase.Add("进度条示例", "CSharpGo.Frm_WinFormProgressExample");
            dicWinformBase.Add("组合框示例", "CSharpGo.Frm_ComboBoxExample");
            dicWinformBase.Add("树形控件", "CSharpGo.Frm_TreeViewExample");
            m_dicFormText2FormTypeName.Add("WinForm基础", dicWinformBase);


        }
        public static Frm_Main GetMainForm()
        {
            if (m_Frm_Main == null)
            {
                m_Frm_Main = new Frm_Main();
            }

            return m_Frm_Main;
        }
        private DockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.DockingMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }

                return null;
            }
            else
            {
                foreach (DockContent content in dockPanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        public void ShowContent(DockContent frm)
        {
            frm.Show(this.dockPanel);
            frm.Focus();
            frm.BringToFront();
        }
        private string GetClassByName(string strName)
        {
            string strTemp = "";
            foreach (string strModule in Frm_Main.m_dicFormText2FormTypeName.Keys)
            {
                foreach (string strItem in Frm_Main.m_dicFormText2FormTypeName[strModule].Keys)
                {
                    if (strItem == strName)
                    {
                        strTemp = Frm_Main.m_dicFormText2FormTypeName[strModule][strItem];
                        break;
                    }
                }
            }
            return strTemp;
        }
        public DockContent ShowContent(string caption/*, Type formType*/)
        {

            DockContent frm = FindDocument(caption);

            if (frm == null)
            {
                string strTemp = GetClassByName(caption);
                if (strTemp == "")
                    return null;
            
                string[] strSplit = strTemp.Split('.');
                string strAssemblyName = strSplit[0];

                Assembly assembly = Assembly.Load(strAssemblyName);
      

                Type typForm = assembly.GetType(strTemp);

                //关于InvokeMember用法，不明白的可以查看：http://msdn.microsoft.com/zh-cn/library/de3dhzwy(VS.80).aspx
                
                Object mdiChild = typForm.InvokeMember(
                   null,
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance,
                   null,
                   null,
                   null);

                if (mdiChild != null)
                {
                    frm = mdiChild as DockContent;
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;

                }
            }

            frm.Show(this.dockPanel);
            frm.Focus();
            frm.BringToFront();
            return frm;
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            InitFormText2FormTypeNameDic();
            mainToolWin = new Frm_MainToolWindow();
            mainToolWin.Show(this.dockPanel, DockState.DockLeft);
            

            this.dockPanel.DockLeftPortion = 0.17;
        }


    }
}
