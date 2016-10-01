using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;

namespace Timer
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nowTime.Text = DateTime.Now.ToShortTimeString().ToString();
        }

        bool t1staerted = false;
        bool backfir = false;
        private void startTimeBtn_Click(object sender, EventArgs e)
        {
            if (startTimeBtn.Text == "开始计时")
            {
                pm1.Text = "00:00:00";
                pm2.Text = "00:00:00";
                pm3.Text = "00:00:00";
            }

            if (plusT.Checked == true)
            {
                if (sec5.Checked == true)
                {
                    T5.Enabled = true;
                }
                else
                {
                    if (t1staerted == false)
                    {
                        startTimeBtn.Text = "暂停";
                        t1staerted = true;
                        t1.Enabled = true;
                    }
                    else
                    {
                        startTimeBtn.Text = "继续";
                        t1staerted = false;
                        t1.Enabled = false;
                    }
                }
            }
            else//倒计时
            {
                if (backfir == false)//开始倒计时了没
                {//要开始
                    backfir = true;
                    if (secTxt.Text == "")
                    {
                        secTxt.Text = "0";
                    }
                    secTxt.Text = int.Parse(secTxt.Text).ToString();
                    if (minTxt.Text == "")
                    {
                        minTxt.Text="0";
                    }
                    m = int.Parse(minTxt.Text);
                    s = int.Parse(secTxt.Text);
                    ms2 = 0;
                    t1.Enabled = true;
                }
                else
                {//已开始
                    if (t1staerted == false)
                    {
                        startTimeBtn.Text = "暂停";
                        t1staerted = true;
                        t1.Enabled = true;
                    }
                    else
                    {
                        startTimeBtn.Text = "继续";
                        t1staerted = false;
                        t1.Enabled = false;
                    }
                }
            }
            groupBox5.Visible = false;
        }
        int m, s, ms2;
        private void label1_Click(object sender, EventArgs e)
        {
            if (pm1.Text == "00:00:00")
            {
                pm1.Text = calTime.Text;
            }
            else
            {
                if (pm2.Text == "00:00:00")
                {
                    pm2.Text = calTime.Text;
                }
                else
                {
                    if (pm3.Text == "00:00:00")
                    {
                        pm3.Text = calTime.Text;
                    }
                }
            }
        }

        int min = 0, sec = 0, ms = 0;

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            groupList.Items.Clear();

            for (int i = 0; i < int.Parse(GroupNum.Text); i++)
            {
                ListViewItem group = groupList.Items.Add((i + 1).ToString());
                //group.SubItems.Add(i.ToString());
                group.SubItems.Add("0");
            }
            MessageBox.Show("添加组成功，您可以双击组号加分");
        }

        private void groupList_DoubleClick(object sender, EventArgs e)
        {
            groupList.SelectedItems[0].SubItems[1].Text = (int.Parse(groupList.SelectedItems[0].SubItems[1].Text) + 1).ToString();
        }

        private void aGroup_Click(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random();
                gresult.Text = rd.Next(1, groupList.Items.Count + 1).ToString(); ;
            }
            catch
            {
                gresult.Text = "计算错误";
                MessageBox.Show("计算错误，是否正确输入了组数?", "错误提示");
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random();
                getResult.Text = rd.Next(int.Parse(firNum.Text), int.Parse(secNum.Text) + 1).ToString();
                resBox.Items.Add(getResult.Text);
                resBox.TopIndex = resBox.Items.Count - resBox.Height / resBox.ItemHeight;
            }
            catch
            {
                MessageBox.Show("抽取值错误，请检查输入值是否有误!", "错误提示");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要清空抽取的数据吗?\n这不会包括其他板块的数据", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                getResult.Text = "0";
                resBox.Items.Clear();
            }
        }

        private void subT_CheckedChanged(object sender, EventArgs e)
        {
            sec5.Enabled = false;
            minTxt.Enabled = true;
            secTxt.Enabled = true;
        }

        private void plusT_CheckedChanged(object sender, EventArgs e)
        {
            sec5.Enabled = true;
            minTxt.Enabled = false;
            secTxt.Enabled = false;
        }

        int i = 5;
        private void T5_Tick(object sender, EventArgs e)
        {
            if (i <= 0)
            {
                startTimeBtn.Text = "暂停";
                t1staerted = true;
                t1.Enabled = true;
                sec5.Checked = false;

                T5.Enabled = false;
            }
            else
            {
                i -= 1;
                calTime.Text = "00:" + i.ToString("00") + ":00";
            }
        }

        private void t1Stop_Click(object sender, EventArgs e)
        {
            t1.Enabled = false;
            min = 0; sec = 0; ms = 0;
            calTime.Text = "00:00:00";

            pm1.Text = "00:00:00";
            pm2.Text = "00:00:00";
            pm3.Text = "00:00:00";

            groupBox5.Visible = true;
            startTimeBtn.Text = "开始计时";
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            nowTime.Text = DateTime.Now.ToShortTimeString().ToString();
            if (plusT.Checked == true)
            {
                ms += 1;
                if (ms == 60)
                {
                    sec += 1;
                    ms = 0;
                }
                if (sec == 60)
                {
                    min += 1;
                    sec = 0;
                }
                calTime.Text = min.ToString("00") + ":" + sec.ToString("00") + ":" + ms.ToString("00");
            }
            else
            {
                startTimeBtn.Text = "暂停";
                ms2--;
                if (ms2 <= 0)
                {
                    ms2 += 60;
                    s--;
                }
                if (s< 0)
                {
                    s += 60;
                    m--;
                }
                calTime.Text = m.ToString("00") + ":" + s.ToString("00") + ":" + ms2.ToString("00");
                if (m < 0)
                {
                    t1.Enabled = false;
                    calTime.Text = "00:00:00";
                    ms2 = 0;s = 0;m = 0;
                    startTimeBtn.Text = "开始计时";
                    MessageBox.Show("时间到");
                    groupBox5.Visible = true;
                }
            }
        }
    }
}
