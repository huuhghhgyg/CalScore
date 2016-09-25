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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.GroupNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.ListView();
            this.groupItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

