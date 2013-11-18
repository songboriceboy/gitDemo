namespace CSharpGo
{
    partial class Frm_MainToolWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainToolWindow));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.outlookBar1 = new UtilityLibrary.WinControls.OutlookBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Web.png");
            this.imageList.Images.SetKeyName(1, "Alert.png");
            this.imageList.Images.SetKeyName(2, "Applications.png");
            this.imageList.Images.SetKeyName(3, "Back.png");
            this.imageList.Images.SetKeyName(4, "Bookmark.png");
            this.imageList.Images.SetKeyName(5, "Char.png");
            this.imageList.Images.SetKeyName(6, "Delete.png");
            this.imageList.Images.SetKeyName(7, "Documents.png");
            this.imageList.Images.SetKeyName(8, "Download.png");
            this.imageList.Images.SetKeyName(9, "Favorite.png");
            this.imageList.Images.SetKeyName(10, "Forward.png");
            this.imageList.Images.SetKeyName(11, "HD.png");
            this.imageList.Images.SetKeyName(12, "Home.png");
            this.imageList.Images.SetKeyName(13, "Mail.png");
            this.imageList.Images.SetKeyName(14, "Package.png");
            this.imageList.Images.SetKeyName(15, "Refresh.png");
            this.imageList.Images.SetKeyName(16, "RSS.png");
            this.imageList.Images.SetKeyName(17, "Search.png");
            this.imageList.Images.SetKeyName(18, "Security.png");
            this.imageList.Images.SetKeyName(19, "Select.png");
            this.imageList.Images.SetKeyName(20, "Settings.png");
            this.imageList.Images.SetKeyName(21, "Speaker.png");
            this.imageList.Images.SetKeyName(22, "Stats.png");
            this.imageList.Images.SetKeyName(23, "Stop.png");
            this.imageList.Images.SetKeyName(24, "System.png");
            this.imageList.Images.SetKeyName(25, "Temporary.png");
            this.imageList.Images.SetKeyName(26, "Upload.png");
            this.imageList.Images.SetKeyName(27, "User.png");
            this.imageList.Images.SetKeyName(28, "Video.png");
            this.imageList.Images.SetKeyName(29, "Weather.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.outlookBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 368);
            this.panel1.TabIndex = 1;
            // 
            // outlookBar1
            // 
            this.outlookBar1.AnimationSpeed = 20;
            this.outlookBar1.BackgroundBitmap = null;
            this.outlookBar1.BorderType = UtilityLibrary.WinControls.BorderType.None;
            this.outlookBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlookBar1.FlatArrowButtons = false;
            this.outlookBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.outlookBar1.LeftTopColor = System.Drawing.Color.Empty;
            this.outlookBar1.Location = new System.Drawing.Point(0, 0);
            this.outlookBar1.Name = "outlookBar1";
            this.outlookBar1.RightBottomColor = System.Drawing.Color.Empty;
            this.outlookBar1.Size = new System.Drawing.Size(309, 368);
            this.outlookBar1.TabIndex = 0;
            this.outlookBar1.Text = "outlookBar1";
            // 
            // Frm_MainToolWindow
            // 
            this.AutoHidePortion = 0.17;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 368);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Frm_MainToolWindow";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.Text = "工具窗口";
            this.Load += new System.EventHandler(this.Frm_MainToolWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel1;
        private UtilityLibrary.WinControls.OutlookBar outlookBar1;
    }
}