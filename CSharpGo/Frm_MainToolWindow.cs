using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using UtilityLibrary.WinControls;
namespace CSharpGo
{
    public partial class Frm_MainToolWindow : DockContent
    {
        
         private void InitializeOutlookbar()
        {
     
            #region 

            foreach (string strModule in Frm_Main.m_dicFormText2FormTypeName.Keys)
            {
                OutlookBarBand outlookShortcutsBand = new OutlookBarBand(strModule);
                outlookShortcutsBand.SmallImageList = this.imageList;
                outlookShortcutsBand.LargeImageList = this.imageList;
                int nImageIndex = 0;
                foreach (string strItem in Frm_Main.m_dicFormText2FormTypeName[strModule].Keys)
                {
                    outlookShortcutsBand.Items.Add(new OutlookBarItem(strItem, nImageIndex++));
                    outlookShortcutsBand.Background = SystemColors.AppWorkspace;
                    outlookShortcutsBand.TextColor = Color.White;
                    
                }

                outlookBar1.Bands.Add(outlookShortcutsBand);
            }

            #endregion

            //#endregion
            outlookBar1.Dock = DockStyle.Fill;
            outlookBar1.SetCurrentBand(0);
      
            outlookBar1.ItemClicked += new OutlookBarItemClickedHandler(OnOutlookBarItemClicked);
            outlookBar1.ItemDropped += new OutlookBarItemDroppedHandler(OnOutlookBarItemDropped);

            //outlookBar1.FlatArrowButtons = true;
            this.panel1.Controls.AddRange(new Control[] { outlookBar1 });
        }
         
        private void OnOutlookBarItemClicked(OutlookBarBand band, OutlookBarItem item)
        {
            Frm_Main.GetMainForm().ShowContent(item.Text);
           
        }

         private void OnOutlookBarItemDropped(OutlookBarBand band, OutlookBarItem item)
         {
           
         }
         public Frm_MainToolWindow()
        {
            
            InitializeComponent();
            InitializeOutlookbar();
        }

         private void Frm_MainToolWindow_Load(object sender, EventArgs e)
         {

         }
    }
}
