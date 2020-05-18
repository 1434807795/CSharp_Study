using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CET_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int _t;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = int.Parse(this.textBox1.Text);
            this.timer1.Interval = i * 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> English = new List<string>(); 
            List<string> Chinese = new List<string>(); 
            StreamReader sw = new StreamReader(@".\College_Grade4.txt", Encoding.Default); 
            string tem = sw.ReadToEnd(); 
            string[] group = tem.Split('\n'); 
            for (int i = 0; i < group.Length; i++)
            {
                string[] words = group[i].Trim().Split('\t'); 
                if (words.Length < 2) 
                    continue;
                English.Add(words[0]); 
                Chinese.Add(words[1]);
            }
            
            if (_t < group.Length)
            {
                this.label_E.Text = English[_t];
                this.label_C.Text = Chinese[_t];
            }
            _t++;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("您此次总计记忆了" + _t + "个单词。");
        }
    }
}
