namespace mycalc
{
    partial class Formjisuanqi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.paneljieguo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lableresult = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttondengyu = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonchu = new System.Windows.Forms.Button();
            this.buttoncheng = new System.Windows.Forms.Button();
            this.buttonjian = new System.Windows.Forms.Button();
            this.buttonjia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxop2 = new System.Windows.Forms.TextBox();
            this.textBoxop1 = new System.Windows.Forms.TextBox();
            this.paneljieguo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // paneljieguo
            // 
            this.paneljieguo.Controls.Add(this.panel4);
            this.paneljieguo.Controls.Add(this.panel3);
            this.paneljieguo.Controls.Add(this.panel2);
            this.paneljieguo.Location = new System.Drawing.Point(30, 12);
            this.paneljieguo.Name = "paneljieguo";
            this.paneljieguo.Size = new System.Drawing.Size(712, 416);
            this.paneljieguo.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lableresult);
            this.panel4.Location = new System.Drawing.Point(20, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(429, 125);
            this.panel4.TabIndex = 2;
            // 
            // lableresult
            // 
            this.lableresult.AutoSize = true;
            this.lableresult.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lableresult.Location = new System.Drawing.Point(38, 29);
            this.lableresult.Name = "lableresult";
            this.lableresult.Size = new System.Drawing.Size(60, 31);
            this.lableresult.TabIndex = 0;
            this.lableresult.Text = "结果";
            this.lableresult.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttondengyu);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.buttonchu);
            this.panel3.Controls.Add(this.buttoncheng);
            this.panel3.Controls.Add(this.buttonjian);
            this.panel3.Controls.Add(this.buttonjia);
            this.panel3.Location = new System.Drawing.Point(500, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 306);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttondengyu
            // 
            this.buttondengyu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttondengyu.Location = new System.Drawing.Point(69, 240);
            this.buttondengyu.Name = "buttondengyu";
            this.buttondengyu.Size = new System.Drawing.Size(54, 40);
            this.buttondengyu.TabIndex = 4;
            this.buttondengyu.Text = "=";
            this.buttondengyu.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(69, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonchu
            // 
            this.buttonchu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonchu.Location = new System.Drawing.Point(69, 157);
            this.buttonchu.Name = "buttonchu";
            this.buttonchu.Size = new System.Drawing.Size(54, 40);
            this.buttonchu.TabIndex = 3;
            this.buttonchu.Text = "÷";
            this.buttonchu.UseVisualStyleBackColor = true;
            this.buttonchu.Click += new System.EventHandler(this.buttonchu_Click);
            // 
            // buttoncheng
            // 
            this.buttoncheng.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttoncheng.Location = new System.Drawing.Point(69, 111);
            this.buttoncheng.Name = "buttoncheng";
            this.buttoncheng.Size = new System.Drawing.Size(54, 40);
            this.buttoncheng.TabIndex = 2;
            this.buttoncheng.Text = "×";
            this.buttoncheng.UseVisualStyleBackColor = true;
            this.buttoncheng.Click += new System.EventHandler(this.buttoncheng_Click);
            // 
            // buttonjian
            // 
            this.buttonjian.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonjian.Location = new System.Drawing.Point(69, 65);
            this.buttonjian.Name = "buttonjian";
            this.buttonjian.Size = new System.Drawing.Size(54, 40);
            this.buttonjian.TabIndex = 1;
            this.buttonjian.Text = "-";
            this.buttonjian.UseVisualStyleBackColor = true;
            this.buttonjian.Click += new System.EventHandler(this.buttonjian_Click);
            // 
            // buttonjia
            // 
            this.buttonjia.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonjia.Location = new System.Drawing.Point(69, 19);
            this.buttonjia.Name = "buttonjia";
            this.buttonjia.Size = new System.Drawing.Size(54, 40);
            this.buttonjia.TabIndex = 0;
            this.buttonjia.Text = "+";
            this.buttonjia.UseVisualStyleBackColor = true;
            this.buttonjia.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxop2);
            this.panel2.Controls.Add(this.textBoxop1);
            this.panel2.Location = new System.Drawing.Point(20, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 227);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxop2
            // 
            this.textBoxop2.Location = new System.Drawing.Point(28, 162);
            this.textBoxop2.Name = "textBoxop2";
            this.textBoxop2.Size = new System.Drawing.Size(308, 27);
            this.textBoxop2.TabIndex = 1;
            this.textBoxop2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxop1
            // 
            this.textBoxop1.Location = new System.Drawing.Point(28, 75);
            this.textBoxop1.Name = "textBoxop1";
            this.textBoxop1.Size = new System.Drawing.Size(308, 27);
            this.textBoxop1.TabIndex = 0;
            // 
            // Formjisuanqi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 432);
            this.Controls.Add(this.paneljieguo);
            this.Name = "Formjisuanqi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneljieguo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel paneljieguo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttondengyu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonchu;
        private System.Windows.Forms.Button buttoncheng;
        private System.Windows.Forms.Button buttonjian;
        private System.Windows.Forms.Button buttonjia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxop2;
        private System.Windows.Forms.TextBox textBoxop1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lableresult;
    }
}

