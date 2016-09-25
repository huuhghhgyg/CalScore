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
