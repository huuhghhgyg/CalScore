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
            nowTime.Text=DateTime.Now.ToShortTimeString().ToString();
        }

        bool t1staerted = false;
        private void startTimeBtn_Click(object sender, EventArgs e)
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
                gresult.Text = rd.Next(1, groupList.Items.Count+1).ToString(); ;
            }
            catch
            {
                gresult.Text = "计算错误";
                MessageBox.Show("计算错误，是否正确输入了组数?","错误提示");
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

        private void t1Stop_Click(object sender, EventArgs e)
        {
            t1.Enabled = false;
            min = 0; sec = 0; ms = 0;
            calTime.Text = "00:00:00";

            pm1.Text = "00:00:00";
            pm2.Text = "00:00:00";
            pm3.Text = "00:00:00";
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            nowTime.Text= DateTime.Now.ToShortTimeString().ToString();

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
    }
}
