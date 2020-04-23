using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定义变量
        int a, b, i;
        string op;
        int result;
        int[] score = new int[100];

        //随机数
        Random rnd = new Random();
        //点击出题按钮事件
        private void BtnNew_Click(object sender, EventArgs e)
        {
            a = rnd.Next(9) + 1;
            b = rnd.Next(9) + 1;
            int c = rnd.Next(4);

            switch (c)
            {
                case 0: op = "+"; result = a + b; break;
                case 1: op = "-"; result = a - b; break;
                case 2: op = "*"; result = a * b; break;
                case 3: op = "/"; result = a / b; break;
            }

            Lb1.Text = a.ToString();
            Lb2.Text = b.ToString();
            LbOp.Text = op;

            TextAnswer.Text = "";
        }
        //点击判断按钮事件
        private void BtnJudge_Click(object sender, EventArgs e)
        {

            if (TextAnswer.Text == "")
            {
                MessageBox.Show("请输入您的答案！");
            }
            else
            {
                string str = TextAnswer.Text;
                double d = double.Parse(str);
                string disp = "" + a + op + b + "=" + str + " ";
                if (Math.Abs(d - result) < 1e-3)
                {
                    disp += "☆";
                    score[i] = 1;
                    i++;
                }
                else
                    disp += "╳";
                listBox1.Items.Add(disp);
            };
            BtnNew_Click(null,null);
        }
        //点击帮助按钮事件
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好！这是一个自动出题并判分的小工具，它有手动和自动模式，自动模式出题间隔时间为10秒且自动模式会在5分钟后关闭,启用自动模式后需等待10秒方可出现第一道题。它还能计算您所获得的的总分（每答对一题算一分，错误不算分，最多计100分）");
        }
        //点击总分按钮事件
        private void BtnScore_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for ( i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            MessageBox.Show("您总共答对" + sum + "道题，共计" + sum + "分");
        }
        //勾选自动出题
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
        }
        //timer1控件，单题计时
        private void timer1_Tick(object sender, EventArgs e)
        {
            BtnNew_Click(null,null);
            BtnJudge_Click(null,null);
        }
        //勾选手动出题
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            timer2.Enabled = false;
            timer2.Stop();
        }
        //timer2控件，自动出题整体计时
        private void timer2_Tick(object sender, EventArgs e)
        {
            radioButton2_CheckedChanged(null,null);
        }
        //输入答案后按下Enter事件
        private void TextAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                BtnJudge_Click(null,null);
            }
        }
    }
}
