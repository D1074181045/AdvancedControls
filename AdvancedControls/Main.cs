using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancedControls
{
    public partial class frmMain : Form
    {
        string[] webUrl = { "https://en.wikipedia.org/wiki/Taiwan" ,
                            "https://en.wikipedia.org/wiki/United_States" ,
                            "https://en.wikipedia.org/wiki/Brazil" ,
                            "https://en.wikipedia.org/wiki/Israel" ,
                            "https://en.wikipedia.org/wiki/South_Korea"};

        private static decimal[,] latlng = new decimal[,]{ { 40.7128M, -74.0060M }, { 34.0522M, -118.2437M }, { 41.8781M, -87.6298M },
                                                           { 29.7604M, -95.3698M }, { 33.4484M, -112.0740M }, { 39.9526M, -75.1652M } };

        private string[] Fahrenheit = new string[6];
        private string[] Celsius = new string[6];

        public frmMain()
        {
            InitializeComponent();
            this.Width = 1000;
        }

        private void llImageList_Click(object sender, EventArgs e)
        {
            if (!panImageList.Visible)
            {
                panImageList.Visible = true;
                panTabControl.Visible = false;
                panTreeView.Visible = false;

                lvFlags.Items[0].Checked = true;
            }
        }
        
        private void lvFlags_ItemCheck(object sender, ItemCheckEventArgs e) // 勾選更動
        {
            if (!lvFlags.Items[e.Index].Checked)
            {
                ListView.CheckedListViewItemCollection coll = lvFlags.CheckedItems;

                for (int i = 0; i < coll.Count; ++i)
                {
                    coll[i].Checked = false;
                }
            }
        }
        
        private void lvFlags_ItemChecked(object sender, ItemCheckedEventArgs e) // 勾選後
        {
            string[] img_file = { "taiwan-flag-small.jpg",
                                  "united-states-of-america-flag-small.jpg" ,
                                  "brazil-flag-small.jpg" ,
                                  "israel-flag-small.jpg" ,
                                  "south-korea-flag-small.jpg" };

            string[] v = { "st", "nd", "rd", "th", "th" };

            if (lvFlags.Items[e.Item.Index].Checked)
            {
                string filename = string.Format(".\\Resources\\{0}", img_file[e.Item.Index]);
                pbFlag.BackgroundImage = Image.FromFile(filename);
                Console.WriteLine(string.Format("[DEBUG] in lvFlags_ItemsChecked() has {0} elements and it is {1}{2} item checked",
                                                     lvFlags.Items.Count, (e.Item.Index + 1), v[e.Item.Index]));
            }
        }

        private void llTabControl_Click(object sender, EventArgs e)
        {
            if (!panTabControl.Visible)
            {
                panTabControl.Refresh();

                panImageList.Visible = false;
                panTabControl.Visible = true;
                panTreeView.Visible = false;

                panTabControl.Location = panImageList.Location;
                tabNations.Size = panTabControl.Size = panImageList.Size;

                this.Cursor = Cursors.WaitCursor;
                this.CreateBrowserObject(0);
                this.Cursor = Cursors.Default;
            }
        }

        private void tabNations_Selected(object sender, TabControlEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.CreateBrowserObject(e.TabPageIndex);
            this.Cursor = Cursors.Default;
        }

        private Control CreateBrowserObject(int index)
        {
            this.tabNations.TabPages[index].Controls.Clear();

            var watch = Stopwatch.StartNew();
            WebBrowser wb = new WebBrowser();
            wb.Location = new Point(0, 0);
            wb.MinimumSize = new Size(20, 20);
            wb.Name = "webBrowser" + index;
            wb.Size = new Size(this.tabNations.Size.Width - 10, this.tabNations.Size.Height - 10);
            wb.TabIndex = 0;
            this.tabNations.TabPages[index].Controls.Add(wb);
            wb.Navigate(this.webUrl[index]);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            string browserNation = this.tabNations.TabPages[index].Text;
            Console.WriteLine(string.Format("[DEBUG] TabNations[{0}] browser thru a web cite take {1} milliseconds", browserNation, elapsedMs));
            return wb;
        }

        private void llTreeView_Click(object sender, EventArgs e)
        {
            if (!panTreeView.Visible)
            {
                panImageList.Visible = false;
                panTabControl.Visible = false;
                panTreeView.Visible = true;

                panTreeView.Location = panImageList.Location;

                this.Cursor = Cursors.WaitCursor;
                this.loadTemperatures();
                this.Cursor = Cursors.Default;
            }
        }

        private void loadTemperatures()
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < tvTemporature.Nodes["ndRoot"].Nodes.Count; i++)
            {
                decimal lat = latlng[i, 0];
                decimal lng = latlng[i, 1];

                gov.weather.graphical.weatherParametersType wtp = new gov.weather.graphical.weatherParametersType();
                gov.weather.graphical.ndfdXML weatherXML = new gov.weather.graphical.ndfdXML();
                string xml = weatherXML.NDFDgen(lat, lng, 
                    gov.weather.graphical.productType.timeseries, DateTime.Now, DateTime.Now, gov.weather.graphical.unitType.m, wtp);

                util.Xml xmlreaderC = new util.Xml(xml);

                Celsius[i] = xmlreaderC.getTagValue("value");
                Fahrenheit[i] = ((int)(Convert.ToDouble(Celsius[i]) * 1.8000 + 32.00)).ToString();
            }
            var elapsedMs = watch.ElapsedMilliseconds;
            watch.Stop();
            
            Console.WriteLine(string.Format("[DEBUG] load temporatures TreeView take {0} milliseconds", elapsedMs));

            rdoF.Checked = true;
        }

        private void rdoF_CheckedChanged(object sender, EventArgs e)
        {
            ShowTemporature(true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ShowTemporature(false);
        }

        private void ShowTemporature(bool isF)
        {
            TreeNodeCollection tdc = tvTemporature.Nodes["ndRoot"].Nodes;

            for (int i = 0; i < tdc.Count; i++)
            {
                string td_name = tdc[i].Name;

                string latstr = Math.Round(latlng[i, 0], 2).ToString();
                string lngstr = Math.Round(latlng[i, 1], 2).ToString();

                this.tvTemporature.Nodes["ndRoot"].Nodes[td_name].Nodes.Clear();

                this.tvTemporature.Nodes["ndRoot"].Nodes[td_name].Nodes.Add("latitude：" + latstr);
                this.tvTemporature.Nodes["ndRoot"].Nodes[td_name].Nodes.Add("longitude：" + lngstr);

                if (isF)
                {
                    this.tvTemporature.Nodes["ndRoot"].Nodes[td_name].Nodes.Add("Fahrenheit：" + this.Fahrenheit[i]);
                }
                else
                {
                    this.tvTemporature.Nodes["ndRoot"].Nodes[td_name].Nodes.Add("Celsius：" + this.Celsius[i]);
                }
            }
        }
    }
}
