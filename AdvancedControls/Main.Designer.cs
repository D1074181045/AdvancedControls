using System.Windows.Forms;

namespace AdvancedControls
{
    partial class frmMain : Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Taiwan", 0);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("USA", 1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Brazil", 2);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Israel", 3);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Korea", 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("New York City, NY");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Los Angeles, CA");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Chicago, IL");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Houston, TX");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Phoenix, AZ");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Philadelphia, PA");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("USA City Temporature", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.panCommand = new System.Windows.Forms.Panel();
            this.llTreeView = new System.Windows.Forms.LinkLabel();
            this.llTabControl = new System.Windows.Forms.LinkLabel();
            this.llImageList = new System.Windows.Forms.LinkLabel();
            this.grpTemp = new System.Windows.Forms.GroupBox();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoF = new System.Windows.Forms.RadioButton();
            this.panImageList = new System.Windows.Forms.Panel();
            this.lvFlags = new System.Windows.Forms.ListView();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.tabNations = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tvTemporature = new System.Windows.Forms.TreeView();
            this.panTreeView = new System.Windows.Forms.Panel();
            this.panTabControl = new System.Windows.Forms.Panel();
            this.panCommand.SuspendLayout();
            this.grpTemp.SuspendLayout();
            this.panImageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.tabNations.SuspendLayout();
            this.panTreeView.SuspendLayout();
            this.panTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCommand
            // 
            this.panCommand.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panCommand.Controls.Add(this.llTreeView);
            this.panCommand.Controls.Add(this.llTabControl);
            this.panCommand.Controls.Add(this.llImageList);
            this.panCommand.Cursor = System.Windows.Forms.Cursors.Default;
            this.panCommand.Dock = System.Windows.Forms.DockStyle.Left;
            this.panCommand.Location = new System.Drawing.Point(0, 0);
            this.panCommand.Name = "panCommand";
            this.panCommand.Size = new System.Drawing.Size(133, 645);
            this.panCommand.TabIndex = 0;
            // 
            // llTreeView
            // 
            this.llTreeView.AutoSize = true;
            this.llTreeView.Font = new System.Drawing.Font("新細明體", 12F);
            this.llTreeView.LinkColor = System.Drawing.Color.White;
            this.llTreeView.Location = new System.Drawing.Point(16, 136);
            this.llTreeView.Name = "llTreeView";
            this.llTreeView.Size = new System.Drawing.Size(83, 16);
            this.llTreeView.TabIndex = 2;
            this.llTreeView.TabStop = true;
            this.llTreeView.Text = "WebService";
            this.llTreeView.Click += new System.EventHandler(this.llTreeView_Click);
            // 
            // llTabControl
            // 
            this.llTabControl.AutoSize = true;
            this.llTabControl.Font = new System.Drawing.Font("新細明體", 12F);
            this.llTabControl.LinkColor = System.Drawing.Color.White;
            this.llTabControl.Location = new System.Drawing.Point(15, 83);
            this.llTabControl.Name = "llTabControl";
            this.llTabControl.Size = new System.Drawing.Size(58, 16);
            this.llTabControl.TabIndex = 1;
            this.llTabControl.TabStop = true;
            this.llTabControl.Text = "UrlTabs";
            this.llTabControl.Click += new System.EventHandler(this.llTabControl_Click);
            // 
            // llImageList
            // 
            this.llImageList.AutoSize = true;
            this.llImageList.Font = new System.Drawing.Font("新細明體", 12F);
            this.llImageList.LinkColor = System.Drawing.Color.White;
            this.llImageList.Location = new System.Drawing.Point(15, 27);
            this.llImageList.Name = "llImageList";
            this.llImageList.Size = new System.Drawing.Size(58, 16);
            this.llImageList.TabIndex = 0;
            this.llImageList.TabStop = true;
            this.llImageList.Text = "FlagList";
            this.llImageList.Click += new System.EventHandler(this.llImageList_Click);
            // 
            // grpTemp
            // 
            this.grpTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpTemp.Controls.Add(this.rdoC);
            this.grpTemp.Controls.Add(this.rdoF);
            this.grpTemp.Location = new System.Drawing.Point(0, 441);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(195, 63);
            this.grpTemp.TabIndex = 0;
            this.grpTemp.TabStop = false;
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoC.ForeColor = System.Drawing.Color.White;
            this.rdoC.Location = new System.Drawing.Point(6, 35);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(65, 19);
            this.rdoC.TabIndex = 0;
            this.rdoC.Text = "Celsius";
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoF
            // 
            this.rdoF.AutoSize = true;
            this.rdoF.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoF.ForeColor = System.Drawing.Color.White;
            this.rdoF.Location = new System.Drawing.Point(6, 12);
            this.rdoF.Name = "rdoF";
            this.rdoF.Size = new System.Drawing.Size(85, 19);
            this.rdoF.TabIndex = 0;
            this.rdoF.Text = "Fahrenheit";
            this.rdoF.UseVisualStyleBackColor = true;
            this.rdoF.CheckedChanged += new System.EventHandler(this.rdoF_CheckedChanged);
            // 
            // panImageList
            // 
            this.panImageList.BackColor = System.Drawing.Color.White;
            this.panImageList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panImageList.Controls.Add(this.lvFlags);
            this.panImageList.Controls.Add(this.pbFlag);
            this.panImageList.Cursor = System.Windows.Forms.Cursors.Default;
            this.panImageList.ForeColor = System.Drawing.SystemColors.Window;
            this.panImageList.Location = new System.Drawing.Point(179, 29);
            this.panImageList.Name = "panImageList";
            this.panImageList.Size = new System.Drawing.Size(764, 571);
            this.panImageList.TabIndex = 1;
            this.panImageList.Visible = false;
            // 
            // lvFlags
            // 
            this.lvFlags.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFlags.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvFlags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFlags.CheckBoxes = true;
            this.lvFlags.GridLines = true;
            this.lvFlags.HideSelection = false;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            this.lvFlags.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.lvFlags.LabelEdit = true;
            this.lvFlags.LargeImageList = this.imglist;
            this.lvFlags.Location = new System.Drawing.Point(23, 51);
            this.lvFlags.MultiSelect = false;
            this.lvFlags.Name = "lvFlags";
            this.lvFlags.Size = new System.Drawing.Size(102, 356);
            this.lvFlags.TabIndex = 0;
            this.lvFlags.UseCompatibleStateImageBehavior = false;
            this.lvFlags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvFlags_ItemCheck);
            this.lvFlags.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFlags_ItemChecked);
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "taiwan-flag-large.jpg");
            this.imglist.Images.SetKeyName(1, "united-states-of-america-flag-large.jpg");
            this.imglist.Images.SetKeyName(2, "brazil-flag-large.jpg");
            this.imglist.Images.SetKeyName(3, "israel-flag-large.jpg");
            this.imglist.Images.SetKeyName(4, "south-korea-flag-large.jpg");
            // 
            // pbFlag
            // 
            this.pbFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFlag.InitialImage = null;
            this.pbFlag.Location = new System.Drawing.Point(147, 20);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(596, 440);
            this.pbFlag.TabIndex = 1;
            this.pbFlag.TabStop = false;
            // 
            // tabNations
            // 
            this.tabNations.Controls.Add(this.tabPage1);
            this.tabNations.Controls.Add(this.tabPage2);
            this.tabNations.Controls.Add(this.tabPage3);
            this.tabNations.Controls.Add(this.tabPage4);
            this.tabNations.Controls.Add(this.tabPage5);
            this.tabNations.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabNations.Location = new System.Drawing.Point(-1, -1);
            this.tabNations.Name = "tabNations";
            this.tabNations.SelectedIndex = 0;
            this.tabNations.Size = new System.Drawing.Size(289, 571);
            this.tabNations.TabIndex = 0;
            this.tabNations.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabNations_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Taiwan";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(281, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "United States";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(281, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Brazil";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(281, 545);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Israel";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(281, 545);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "South Korea";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tvTemporature
            // 
            this.tvTemporature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tvTemporature.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tvTemporature.ForeColor = System.Drawing.SystemColors.Info;
            this.tvTemporature.Location = new System.Drawing.Point(0, 0);
            this.tvTemporature.Name = "tvTemporature";
            treeNode8.Name = "NY";
            treeNode8.Text = "New York City, NY";
            treeNode9.Name = "CA";
            treeNode9.Text = "Los Angeles, CA";
            treeNode10.Name = "IL";
            treeNode10.Text = "Chicago, IL";
            treeNode11.Name = "TX";
            treeNode11.Text = "Houston, TX";
            treeNode12.Name = "AZ";
            treeNode12.Text = "Phoenix, AZ";
            treeNode13.Name = "PA";
            treeNode13.Text = "Philadelphia, PA";
            treeNode14.Name = "ndRoot";
            treeNode14.Text = "USA City Temporature";
            this.tvTemporature.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.tvTemporature.Size = new System.Drawing.Size(195, 447);
            this.tvTemporature.TabIndex = 0;
            // 
            // panTreeView
            // 
            this.panTreeView.Controls.Add(this.grpTemp);
            this.panTreeView.Controls.Add(this.tvTemporature);
            this.panTreeView.Location = new System.Drawing.Point(1244, 29);
            this.panTreeView.Name = "panTreeView";
            this.panTreeView.Size = new System.Drawing.Size(195, 504);
            this.panTreeView.TabIndex = 1;
            this.panTreeView.Visible = false;
            // 
            // panTabControl
            // 
            this.panTabControl.BackColor = System.Drawing.Color.Gold;
            this.panTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTabControl.Controls.Add(this.tabNations);
            this.panTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.panTabControl.Location = new System.Drawing.Point(949, 29);
            this.panTabControl.Name = "panTabControl";
            this.panTabControl.Size = new System.Drawing.Size(289, 571);
            this.panTabControl.TabIndex = 1;
            this.panTabControl.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1476, 645);
            this.Controls.Add(this.panTreeView);
            this.Controls.Add(this.panCommand);
            this.Controls.Add(this.panTabControl);
            this.Controls.Add(this.panImageList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Controls Main Window";
            this.panCommand.ResumeLayout(false);
            this.panCommand.PerformLayout();
            this.grpTemp.ResumeLayout(false);
            this.grpTemp.PerformLayout();
            this.panImageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.tabNations.ResumeLayout(false);
            this.panTreeView.ResumeLayout(false);
            this.panTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCommand;
        private System.Windows.Forms.LinkLabel llTreeView;
        private System.Windows.Forms.LinkLabel llTabControl;
        private System.Windows.Forms.LinkLabel llImageList;
        private System.Windows.Forms.Panel panImageList;
        private ListView lvFlags;
        private ImageList imglist;
        private PictureBox pbFlag;
        private TabControl tabNations;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TreeView tvTemporature;
        public RadioButton rdoF;
        private GroupBox grpTemp;
        private RadioButton rdoC;
        private Panel panTreeView;
        private TabPage tabPage1;
        private Panel panTabControl;
    }
}

