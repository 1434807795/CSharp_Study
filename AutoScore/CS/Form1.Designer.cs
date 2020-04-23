namespace CS
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lb1 = new System.Windows.Forms.Label();
            this.LbOp = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.TextAnswer = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnJudge = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lb1
            // 
            resources.ApplyResources(this.Lb1, "Lb1");
            this.Lb1.BackColor = System.Drawing.Color.Transparent;
            this.Lb1.Name = "Lb1";
            // 
            // LbOp
            // 
            resources.ApplyResources(this.LbOp, "LbOp");
            this.LbOp.BackColor = System.Drawing.Color.Transparent;
            this.LbOp.Name = "LbOp";
            // 
            // Lb2
            // 
            resources.ApplyResources(this.Lb2, "Lb2");
            this.Lb2.BackColor = System.Drawing.Color.Transparent;
            this.Lb2.Name = "Lb2";
            // 
            // TextAnswer
            // 
            resources.ApplyResources(this.TextAnswer, "TextAnswer");
            this.TextAnswer.Name = "TextAnswer";
            this.TextAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextAnswer_KeyPress);
            // 
            // BtnNew
            // 
            resources.ApplyResources(this.BtnNew, "BtnNew");
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnJudge
            // 
            resources.ApplyResources(this.BtnJudge, "BtnJudge");
            this.BtnJudge.Name = "BtnJudge";
            this.BtnJudge.UseVisualStyleBackColor = true;
            this.BtnJudge.Click += new System.EventHandler(this.BtnJudge_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // BtnHelp
            // 
            resources.ApplyResources(this.BtnHelp, "BtnHelp");
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnScore
            // 
            resources.ApplyResources(this.BtnScore, "BtnScore");
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.UseVisualStyleBackColor = true;
            this.BtnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS.Properties.Resources.background1;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnScore);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnJudge);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TextAnswer);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.LbOp);
            this.Controls.Add(this.Lb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label LbOp;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.TextBox TextAnswer;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnJudge;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Timer timer2;
    }
}

