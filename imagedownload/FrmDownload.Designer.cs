namespace imagedownload
{
    partial class FrmDownload
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownload));
            this.uri_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.baidu_pl_rdo = new System.Windows.Forms.RadioButton();
            this.page_pl_rdo = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxCount_numUpd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.succCount_pl_lab = new System.Windows.Forms.Label();
            this.succCountUpdate_tim = new System.Windows.Forms.Timer(this.components);
            this.level_numUpd = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.checkWebUri_txt = new System.Windows.Forms.TextBox();
            this.loaddata = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_dnloadbatch = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkImgUri_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stop_tspBtn = new System.Windows.Forms.Button();
            this.start_tspBtn = new System.Windows.Forms.Button();
            this.tab_dnloudBrowser = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.checkUri_txt = new System.Windows.Forms.TextBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.forword_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.synchrodown_chkBox = new System.Windows.Forms.CheckBox();
            this.succCount_lab = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.page_rdo = new System.Windows.Forms.RadioButton();
            this.baidu_rdo = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.webrow = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCount_numUpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_numUpd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_dnloadbatch.SuspendLayout();
            this.tab_dnloudBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // uri_txt
            // 
            this.uri_txt.Location = new System.Drawing.Point(208, 24);
            this.uri_txt.Name = "uri_txt";
            this.uri_txt.Size = new System.Drawing.Size(516, 21);
            this.uri_txt.TabIndex = 1;
            this.uri_txt.Enter += new System.EventHandler(this.search_txt_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "http://";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "(如:www.baidu.com)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(100, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "最大下载数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "(0:为不限制)";
            // 
            // baidu_pl_rdo
            // 
            this.baidu_pl_rdo.AutoSize = true;
            this.baidu_pl_rdo.Location = new System.Drawing.Point(474, 55);
            this.baidu_pl_rdo.Name = "baidu_pl_rdo";
            this.baidu_pl_rdo.Size = new System.Drawing.Size(95, 16);
            this.baidu_pl_rdo.TabIndex = 9;
            this.baidu_pl_rdo.Text = "下载百度图片";
            this.baidu_pl_rdo.UseVisualStyleBackColor = true;
            // 
            // page_pl_rdo
            // 
            this.page_pl_rdo.AutoSize = true;
            this.page_pl_rdo.Checked = true;
            this.page_pl_rdo.Location = new System.Drawing.Point(575, 55);
            this.page_pl_rdo.Name = "page_pl_rdo";
            this.page_pl_rdo.Size = new System.Drawing.Size(95, 16);
            this.page_pl_rdo.TabIndex = 10;
            this.page_pl_rdo.TabStop = true;
            this.page_pl_rdo.Text = "下载网页图片";
            this.page_pl_rdo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // maxCount_numUpd
            // 
            this.maxCount_numUpd.Location = new System.Drawing.Point(208, 52);
            this.maxCount_numUpd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxCount_numUpd.Name = "maxCount_numUpd";
            this.maxCount_numUpd.Size = new System.Drawing.Size(66, 21);
            this.maxCount_numUpd.TabIndex = 14;
            this.maxCount_numUpd.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(729, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "下载个数：";
            // 
            // succCount_pl_lab
            // 
            this.succCount_pl_lab.AutoSize = true;
            this.succCount_pl_lab.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.succCount_pl_lab.ForeColor = System.Drawing.Color.Red;
            this.succCount_pl_lab.Location = new System.Drawing.Point(812, 53);
            this.succCount_pl_lab.Name = "succCount_pl_lab";
            this.succCount_pl_lab.Size = new System.Drawing.Size(15, 13);
            this.succCount_pl_lab.TabIndex = 17;
            this.succCount_pl_lab.Text = "0";
            // 
            // succCountUpdate_tim
            // 
            this.succCountUpdate_tim.Enabled = true;
            this.succCountUpdate_tim.Interval = 500;
            this.succCountUpdate_tim.Tick += new System.EventHandler(this.succCountUpdate_tim_Tick);
            // 
            // level_numUpd
            // 
            this.level_numUpd.Location = new System.Drawing.Point(421, 52);
            this.level_numUpd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.level_numUpd.Name = "level_numUpd";
            this.level_numUpd.Size = new System.Drawing.Size(47, 21);
            this.level_numUpd.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(366, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "层次：";
            // 
            // checkWebUri_txt
            // 
            this.checkWebUri_txt.Location = new System.Drawing.Point(208, 85);
            this.checkWebUri_txt.Name = "checkWebUri_txt";
            this.checkWebUri_txt.Size = new System.Drawing.Size(516, 21);
            this.checkWebUri_txt.TabIndex = 24;
            // 
            // loaddata
            // 
            this.loaddata.Location = new System.Drawing.Point(18, 66);
            this.loaddata.MinimumSize = new System.Drawing.Size(20, 20);
            this.loaddata.Name = "loaddata";
            this.loaddata.Size = new System.Drawing.Size(63, 40);
            this.loaddata.TabIndex = 25;
            this.loaddata.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_dnloadbatch);
            this.tabControl1.Controls.Add(this.tab_dnloudBrowser);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 479);
            this.tabControl1.TabIndex = 26;
            // 
            // tab_dnloadbatch
            // 
            this.tab_dnloadbatch.Controls.Add(this.label11);
            this.tab_dnloadbatch.Controls.Add(this.label10);
            this.tab_dnloadbatch.Controls.Add(this.label9);
            this.tab_dnloadbatch.Controls.Add(this.checkImgUri_txt);
            this.tab_dnloadbatch.Controls.Add(this.label8);
            this.tab_dnloadbatch.Controls.Add(this.stop_tspBtn);
            this.tab_dnloadbatch.Controls.Add(this.start_tspBtn);
            this.tab_dnloadbatch.Controls.Add(this.level_numUpd);
            this.tab_dnloadbatch.Controls.Add(this.loaddata);
            this.tab_dnloadbatch.Controls.Add(this.uri_txt);
            this.tab_dnloadbatch.Controls.Add(this.checkWebUri_txt);
            this.tab_dnloadbatch.Controls.Add(this.label7);
            this.tab_dnloadbatch.Controls.Add(this.label1);
            this.tab_dnloadbatch.Controls.Add(this.label2);
            this.tab_dnloadbatch.Controls.Add(this.succCount_pl_lab);
            this.tab_dnloadbatch.Controls.Add(this.label3);
            this.tab_dnloadbatch.Controls.Add(this.label6);
            this.tab_dnloadbatch.Controls.Add(this.label4);
            this.tab_dnloadbatch.Controls.Add(this.maxCount_numUpd);
            this.tab_dnloadbatch.Controls.Add(this.label5);
            this.tab_dnloadbatch.Controls.Add(this.baidu_pl_rdo);
            this.tab_dnloadbatch.Controls.Add(this.page_pl_rdo);
            this.tab_dnloadbatch.Location = new System.Drawing.Point(4, 22);
            this.tab_dnloadbatch.Name = "tab_dnloadbatch";
            this.tab_dnloadbatch.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dnloadbatch.Size = new System.Drawing.Size(860, 453);
            this.tab_dnloadbatch.TabIndex = 0;
            this.tab_dnloadbatch.Text = "批量下载";
            this.tab_dnloadbatch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(730, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "(如:www.baidu.com)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(730, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "(如:www.baidu.com)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(100, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "网页过滤规则：";
            // 
            // checkImgUri_txt
            // 
            this.checkImgUri_txt.Location = new System.Drawing.Point(208, 118);
            this.checkImgUri_txt.Name = "checkImgUri_txt";
            this.checkImgUri_txt.Size = new System.Drawing.Size(516, 21);
            this.checkImgUri_txt.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(100, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "网页过滤规则：";
            // 
            // stop_tspBtn
            // 
            this.stop_tspBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop_tspBtn.BackgroundImage")));
            this.stop_tspBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop_tspBtn.Location = new System.Drawing.Point(51, 17);
            this.stop_tspBtn.Name = "stop_tspBtn";
            this.stop_tspBtn.Size = new System.Drawing.Size(30, 30);
            this.stop_tspBtn.TabIndex = 27;
            this.stop_tspBtn.UseVisualStyleBackColor = true;
            // 
            // start_tspBtn
            // 
            this.start_tspBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start_tspBtn.BackgroundImage")));
            this.start_tspBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_tspBtn.Location = new System.Drawing.Point(15, 17);
            this.start_tspBtn.Name = "start_tspBtn";
            this.start_tspBtn.Size = new System.Drawing.Size(30, 30);
            this.start_tspBtn.TabIndex = 26;
            this.start_tspBtn.UseVisualStyleBackColor = true;
            this.start_tspBtn.Click += new System.EventHandler(this.start_tspBtn_Click);
            // 
            // tab_dnloudBrowser
            // 
            this.tab_dnloudBrowser.Controls.Add(this.label12);
            this.tab_dnloudBrowser.Controls.Add(this.checkUri_txt);
            this.tab_dnloudBrowser.Controls.Add(this.refresh_btn);
            this.tab_dnloudBrowser.Controls.Add(this.forword_btn);
            this.tab_dnloudBrowser.Controls.Add(this.back_btn);
            this.tab_dnloudBrowser.Controls.Add(this.synchrodown_chkBox);
            this.tab_dnloudBrowser.Controls.Add(this.succCount_lab);
            this.tab_dnloudBrowser.Controls.Add(this.label14);
            this.tab_dnloudBrowser.Controls.Add(this.page_rdo);
            this.tab_dnloudBrowser.Controls.Add(this.baidu_rdo);
            this.tab_dnloudBrowser.Controls.Add(this.label15);
            this.tab_dnloudBrowser.Controls.Add(this.label16);
            this.tab_dnloudBrowser.Controls.Add(this.label17);
            this.tab_dnloudBrowser.Controls.Add(this.search_btn);
            this.tab_dnloudBrowser.Controls.Add(this.search_txt);
            this.tab_dnloudBrowser.Controls.Add(this.webrow);
            this.tab_dnloudBrowser.Location = new System.Drawing.Point(4, 22);
            this.tab_dnloudBrowser.Name = "tab_dnloudBrowser";
            this.tab_dnloudBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dnloudBrowser.Size = new System.Drawing.Size(860, 453);
            this.tab_dnloudBrowser.TabIndex = 1;
            this.tab_dnloudBrowser.Text = "边浏览边下载";
            this.tab_dnloudBrowser.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(110, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "过滤规则：";
            // 
            // checkUri_txt
            // 
            this.checkUri_txt.Location = new System.Drawing.Point(208, 53);
            this.checkUri_txt.Name = "checkUri_txt";
            this.checkUri_txt.Size = new System.Drawing.Size(311, 21);
            this.checkUri_txt.TabIndex = 40;
            this.checkUri_txt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkUri_txt_MouseUp);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_btn.BackgroundImage")));
            this.refresh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_btn.Location = new System.Drawing.Point(74, 22);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(23, 23);
            this.refresh_btn.TabIndex = 39;
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // forword_btn
            // 
            this.forword_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forword_btn.BackgroundImage")));
            this.forword_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forword_btn.Location = new System.Drawing.Point(45, 22);
            this.forword_btn.Name = "forword_btn";
            this.forword_btn.Size = new System.Drawing.Size(23, 23);
            this.forword_btn.TabIndex = 38;
            this.forword_btn.UseVisualStyleBackColor = true;
            this.forword_btn.Click += new System.EventHandler(this.forword_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_btn.BackgroundImage")));
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.Location = new System.Drawing.Point(16, 22);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(23, 23);
            this.back_btn.TabIndex = 37;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // synchrodown_chkBox
            // 
            this.synchrodown_chkBox.AutoSize = true;
            this.synchrodown_chkBox.Checked = true;
            this.synchrodown_chkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.synchrodown_chkBox.Location = new System.Drawing.Point(15, 56);
            this.synchrodown_chkBox.Name = "synchrodown_chkBox";
            this.synchrodown_chkBox.Size = new System.Drawing.Size(96, 16);
            this.synchrodown_chkBox.TabIndex = 36;
            this.synchrodown_chkBox.Text = "边浏览边下载";
            this.synchrodown_chkBox.UseVisualStyleBackColor = true;
            // 
            // succCount_lab
            // 
            this.succCount_lab.AutoSize = true;
            this.succCount_lab.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.succCount_lab.ForeColor = System.Drawing.Color.Red;
            this.succCount_lab.Location = new System.Drawing.Point(818, 56);
            this.succCount_lab.Name = "succCount_lab";
            this.succCount_lab.Size = new System.Drawing.Size(15, 13);
            this.succCount_lab.TabIndex = 35;
            this.succCount_lab.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(729, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "下载个数：";
            // 
            // page_rdo
            // 
            this.page_rdo.AutoSize = true;
            this.page_rdo.Checked = true;
            this.page_rdo.Location = new System.Drawing.Point(532, 55);
            this.page_rdo.Name = "page_rdo";
            this.page_rdo.Size = new System.Drawing.Size(95, 16);
            this.page_rdo.TabIndex = 33;
            this.page_rdo.TabStop = true;
            this.page_rdo.Text = "下载网页图片";
            this.page_rdo.UseVisualStyleBackColor = true;
            // 
            // baidu_rdo
            // 
            this.baidu_rdo.AutoSize = true;
            this.baidu_rdo.Location = new System.Drawing.Point(632, 55);
            this.baidu_rdo.Name = "baidu_rdo";
            this.baidu_rdo.Size = new System.Drawing.Size(95, 16);
            this.baidu_rdo.TabIndex = 32;
            this.baidu_rdo.Text = "下载百度图片";
            this.baidu_rdo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(730, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "(如:www.baidu.com)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(155, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "http://";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(110, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "地址：";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(649, 22);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 28;
            this.search_btn.Text = "浏览";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(208, 24);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(435, 21);
            this.search_txt.TabIndex = 27;
            this.search_txt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.search_txt_MouseUp);
            // 
            // webrow
            // 
            this.webrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webrow.Location = new System.Drawing.Point(6, 80);
            this.webrow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webrow.Name = "webrow";
            this.webrow.ScriptErrorsSuppressed = true;
            this.webrow.Size = new System.Drawing.Size(848, 365);
            this.webrow.TabIndex = 26;
            this.webrow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webrow_DocumentCompleted);
            this.webrow.NewWindow += new System.ComponentModel.CancelEventHandler(this.webrow_NewWindow);
            this.webrow.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webrow_ProgressChanged);
            // 
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDownload";
            this.Text = "图片下载器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCount_numUpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_numUpd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_dnloadbatch.ResumeLayout(false);
            this.tab_dnloadbatch.PerformLayout();
            this.tab_dnloudBrowser.ResumeLayout(false);
            this.tab_dnloudBrowser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uri_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton baidu_pl_rdo;
        private System.Windows.Forms.RadioButton page_pl_rdo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown maxCount_numUpd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label succCount_pl_lab;
        private System.Windows.Forms.Timer succCountUpdate_tim;
        private System.Windows.Forms.NumericUpDown level_numUpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox checkWebUri_txt;
        private System.Windows.Forms.WebBrowser loaddata;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_dnloadbatch;
        private System.Windows.Forms.TabPage tab_dnloudBrowser;
        private System.Windows.Forms.Button start_tspBtn;
        private System.Windows.Forms.Button stop_tspBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox checkImgUri_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox checkUri_txt;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button forword_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.CheckBox synchrodown_chkBox;
        private System.Windows.Forms.Label succCount_lab;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton page_rdo;
        private System.Windows.Forms.RadioButton baidu_rdo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.WebBrowser webrow;

    }
}

