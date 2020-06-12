using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;

namespace DownloadRadarChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string dataFullPath;
            //开始时间
            DateTime DateStart = dtp_Start.Value;
            //结束时间
            DateTime DateEnd = dtp_End.Value;
            if (DateStart > DateEnd)
            {
                MessageBox.Show("时间有误，请重新输入！", "警告");
            }
            else
            {
                textBox1.Text = "开始下载！请稍等……\r\n";
                do
                {
                    TryDownloadData(DateStart, out dataFullPath);
                    if (TryDownloadData(DateStart, out dataFullPath))
                    {
                        i++;
                        textBox1.Text += "已完成第" + i.ToString("D2") + "张。\r\n";
                    }
                    DateStart = DateStart.AddDays(1);
                } while (DateStart < DateEnd);
                textBox1.Text += "下载完成，感谢您的使用！";
            }
        }

        static private bool TryDownloadData(DateTime queryHour, out string dataFullPath)
        {
            //文件路径不带中文
            string dataSaveDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            if (!Directory.Exists(dataSaveDir))
            {
                Directory.CreateDirectory(dataSaveDir);
            }
            // 雷达拼图文件名模板 Z_RADA_C_BABJ_20200603033000_P_DOR_RDCP_R_ACHN.PNG
            const string fileNameTemplate = "Z_RADA_C_BABJ_{0}{1}_P_DOR_RDCP_R_ACHN.PNG";
            // 雷达拼图的Url模板 http://image.data.cma.cn/vis/RAD__B0_CR/20200603/Z_RADA_C_BABJ_20200603033000_P_DOR_RDCP_R_ACHN.PNG
            const string urlTemplate = // @"http://101.201.178.252/vis/RAD__B0_CR/{0}/";
                //此处用https://
               @"https://image.data.cma.cn/vis/RAD__B0_CR/{0}/";

            // 构造日期 格式为20161011
            string dateStr = queryHour.Year + queryHour.Month.ToString("D2") + queryHour.Day.ToString("D2");
            // 构造查询时间的文件名，包括日期和小时
            string filename = string.Format(fileNameTemplate, dateStr, queryHour.Hour.ToString("D2") + "0000");
            string url = string.Format(urlTemplate, dateStr) + filename;

            // 构造完整的文件路径
            dataFullPath = Path.Combine(dataSaveDir, filename);
            // 判定文件是否已经下载，如果下载了则直接退出
            if (File.Exists(dataFullPath)) return true;
            // 使用WebClient执行下载
            try
            {
                WebClient client = new WebClient();
                client.DownloadFile(url, dataFullPath);
                client.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionLength = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
    }
}
