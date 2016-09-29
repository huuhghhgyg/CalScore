namespace Timer
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.TC = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pm3 = new System.Windows.Forms.Label();
            this.pm2 = new System.Windows.Forms.Label();
            this.pm1 = new System.Windows.Forms.Label();
            this.t1Stop = new MaterialSkin.Controls.MaterialFlatButton();
            this.calTime = new System.Windows.Forms.Label();
            this.nowTime = new MaterialSkin.Controls.MaterialLabel();
            this.startTimeBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gresult = new System.Windows.Forms.Label();
            this.aGroup = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.GroupNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.ListView();
            this.groupItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.firNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.secNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.getResult = new System.Windows.Forms.Label();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resBox = new System.Windows.Forms.ListBox();
            this.clearBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Interval = 1;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // TC
            // 
            this.TC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC.Controls.Add(this.tabPage1);
            this.TC.Controls.Add(this.tabPage2);
            this.TC.Controls.Add(this.tabPage3);
            this.TC.Depth = 0;
            this.TC.Location = new System.Drawing.Point(1, 116);
            this.TC.MouseState = MaterialSkin.MouseState.HOVER;
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(800, 382);
            this.TC.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pm3);
            this.tabPage1.Controls.Add(this.pm2);
            this.tabPage1.Controls.Add(this.pm1);
            this.tabPage1.Controls.Add(this.t1Stop);
            this.tabPage1.Controls.Add(this.calTime);
            this.tabPage1.Controls.Add(this.nowTime);
            this.tabPage1.Controls.Add(this.startTimeBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "计时器";
            // 
            // pm3
            // 
            this.pm3.AutoSize = true;
            this.pm3.Location = new System.Drawing.Point(33, 259);
            this.pm3.Name = "pm3";
            this.pm3.Size = new System.Drawing.Size(88, 25);
            this.pm3.TabIndex = 6;
            this.pm3.Text = "00:00:00";
            // 
            // pm2
            // 
            this.pm2.AutoSize = true;
            this.pm2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.pm2.Location = new System.Drawing.Point(32, 226);
            this.pm2.Name = "pm2";
            this.pm2.Size = new System.Drawing.Size(118, 31);
            this.pm2.TabIndex = 5;
            this.pm2.Text = "00:00:00";
            // 
            // pm1
            // 
            this.pm1.AutoSize = true;
            this.pm1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.pm1.Location = new System.Drawing.Point(31, 186);
            this.pm1.Name = "pm1";
            this.pm1.Size = new System.Drawing.Size(149, 40);
            this.pm1.TabIndex = 4;
            this.pm1.Text = "00:00:00";
            // 
            // t1Stop
            // 
            this.t1Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t1Stop.AutoSize = true;
            this.t1Stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t1Stop.Depth = 0;
            this.t1Stop.Location = new System.Drawing.Point(622, 299);
            this.t1Stop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.t1Stop.MouseState = MaterialSkin.MouseState.HOVER;
            this.t1Stop.Name = "t1Stop";
            this.t1Stop.Primary = false;
            this.t1Stop.Size = new System.Drawing.Size(59, 36);
            this.t1Stop.TabIndex = 3;
            this.t1Stop.Text = "清除";
            this.t1Stop.UseVisualStyleBackColor = true;
            this.t1Stop.Click += new System.EventHandler(this.t1Stop_Click);
            // 
            // calTime
            // 
            this.calTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calTime.AutoSize = true;
            this.calTime.Font = new System.Drawing.Font("微软雅黑", 70F, System.Drawing.FontStyle.Bold);
            this.calTime.Location = new System.Drawing.Point(7, 15);
            this.calTime.Name = "calTime";
            this.calTime.Size = new System.Drawing.Size(674, 185);
            this.calTime.TabIndex = 2;
            this.calTime.Text = "00:00:00";
            this.calTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // nowTime
            // 
            this.nowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nowTime.AutoSize = true;
            this.nowTime.Depth = 0;
            this.nowTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.nowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nowTime.Location = new System.Drawing.Point(7, 303);
            this.nowTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(70, 27);
            this.nowTime.TabIndex = 1;
            this.nowTime.Text = "00:00";
            // 
            // startTimeBtn
            // 
            this.startTimeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeBtn.AutoSize = true;
            this.startTimeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startTimeBtn.Depth = 0;
            this.startTimeBtn.Location = new System.Drawing.Point(677, 299);
            this.startTimeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startTimeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startTimeBtn.Name = "startTimeBtn";
            this.startTimeBtn.Primary = false;
            this.startTimeBtn.Size = new System.Drawing.Size(105, 36);
            this.startTimeBtn.TabIndex = 0;
            this.startTimeBtn.Text = "开始计时";
            this.startTimeBtn.UseVisualStyleBackColor = true;
            this.startTimeBtn.Click += new System.EventHandler(this.startTimeBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupList);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "计分";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gresult);
            this.groupBox2.Controls.Add(this.aGroup);
            this.groupBox2.Location = new System.Drawing.Point(548, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 146);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "抽组";
            // 
            // gresult
            // 
            this.gresult.AutoSize = true;
            this.gresult.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.gresult.Location = new System.Drawing.Point(6, 55);
            this.gresult.Name = "gresult";
            this.gresult.Size = new System.Drawing.Size(199, 37);
            this.gresult.TabIndex = 1;
            this.gresult.Text = "按下OK键开始";
            // 
            // aGroup
            // 
            this.aGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aGroup.AutoSize = true;
            this.aGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aGroup.Depth = 0;
            this.aGroup.Location = new System.Drawing.Point(186, 101);
            this.aGroup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.aGroup.Name = "aGroup";
            this.aGroup.Primary = false;
            this.aGroup.Size = new System.Drawing.Size(41, 36);
            this.aGroup.TabIndex = 0;
            this.aGroup.Text = "OK";
            this.aGroup.UseVisualStyleBackColor = true;
            this.aGroup.Click += new System.EventHandler(this.aGroup_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(334, 222);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(271, 27);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Tips:双击组号可以加分哦~";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialFlatButton1);
            this.groupBox1.Controls.Add(this.GroupNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(339, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "小组";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(155, 101);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(41, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "OK";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // GroupNum
            // 
            this.GroupNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNum.Depth = 0;
            this.GroupNum.Hint = "";
            this.GroupNum.Location = new System.Drawing.Point(11, 55);
            this.GroupNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.GroupNum.Name = "GroupNum";
            this.GroupNum.PasswordChar = '\0';
            this.GroupNum.SelectedText = "";
            this.GroupNum.SelectionLength = 0;
            this.GroupNum.SelectionStart = 0;
            this.GroupNum.Size = new System.Drawing.Size(163, 32);
            this.GroupNum.TabIndex = 1;
            this.GroupNum.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "组数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(330, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "设置";
            // 
            // groupList
            // 
            this.groupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.groupItem,
            this.scoreItem});
            this.groupList.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.groupList.Location = new System.Drawing.Point(7, 18);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(317, 320);
            this.groupList.TabIndex = 0;
            this.groupList.UseCompatibleStateImageBehavior = false;
            this.groupList.View = System.Windows.Forms.View.Details;
            this.groupList.DoubleClick += new System.EventHandler(this.groupList_DoubleClick);
            // 
            // groupItem
            // 
            this.groupItem.Text = "小组";
            this.groupItem.Width = 99;
            // 
            // scoreItem
            // 
            this.scoreItem.Text = "分数";
            this.scoreItem.Width = 213;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.TC;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-3, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(804, 58);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.clearBtn);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 344);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "抽取";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.materialFlatButton2);
            this.groupBox3.Controls.Add(this.secNum);
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Controls.Add(this.firNum);
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Location = new System.Drawing.Point(7, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 308);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "抽取";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 31);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 27);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "最小值";
            // 
            // firNum
            // 
            this.firNum.Depth = 0;
            this.firNum.Hint = "";
            this.firNum.Location = new System.Drawing.Point(12, 61);
            this.firNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.firNum.Name = "firNum";
            this.firNum.PasswordChar = '\0';
            this.firNum.SelectedText = "";
            this.firNum.SelectionLength = 0;
            this.firNum.SelectionStart = 0;
            this.firNum.Size = new System.Drawing.Size(144, 32);
            this.firNum.TabIndex = 1;
            this.firNum.Text = "1";
            this.firNum.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 96);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(78, 27);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "最大值";
            // 
            // secNum
            // 
            this.secNum.Depth = 0;
            this.secNum.Hint = "";
            this.secNum.Location = new System.Drawing.Point(12, 126);
            this.secNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.secNum.Name = "secNum";
            this.secNum.PasswordChar = '\0';
            this.secNum.SelectedText = "";
            this.secNum.SelectionLength = 0;
            this.secNum.SelectionStart = 0;
            this.secNum.Size = new System.Drawing.Size(144, 32);
            this.secNum.TabIndex = 3;
            this.secNum.UseSystemPasswordChar = false;
            // 
            // getResult
            // 
            this.getResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getResult.AutoSize = true;
            this.getResult.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.getResult.Location = new System.Drawing.Point(77, 52);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(94, 106);
            this.getResult.TabIndex = 4;
            this.getResult.Text = "0";
            this.getResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(110, 263);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton2.TabIndex = 4;
            this.materialFlatButton2.Text = "开始";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.resBox);
            this.groupBox4.Controls.Add(this.getResult);
            this.groupBox4.Location = new System.Drawing.Point(189, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 308);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "结果";
            // 
            // resBox
            // 
            this.resBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resBox.BackColor = System.Drawing.Color.White;
            this.resBox.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.resBox.FormattingEnabled = true;
            this.resBox.ItemHeight = 34;
            this.resBox.Location = new System.Drawing.Point(257, 19);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(182, 276);
            this.resBox.TabIndex = 5;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.AutoSize = true;
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.Depth = 0;
            this.clearBtn.Location = new System.Drawing.Point(723, 302);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Primary = false;
            this.clearBtn.Size = new System.Drawing.Size(59, 36);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "清空";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 79);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tips:抽取的值包括您所输入的最小值和最大值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TC);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "加分计时器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t1;
        private MaterialSkin.Controls.MaterialTabControl TC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton startTimeBtn;
        private MaterialSkin.Controls.MaterialLabel nowTime;
        private System.Windows.Forms.Label calTime;
        private MaterialSkin.Controls.MaterialFlatButton t1Stop;
        private System.Windows.Forms.Label pm3;
        private System.Windows.Forms.Label pm2;
        private System.Windows.Forms.Label pm1;
        private System.Windows.Forms.ColumnHeader groupItem;
        private System.Windows.Forms.ColumnHeader scoreItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField GroupNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView groupList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton aGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label gresult;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox resBox;
        private System.Windows.Forms.Label getResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField secNum;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField firNum;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton clearBtn;
        private System.Windows.Forms.Label label3;
    }
}

