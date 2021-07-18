namespace Model
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
            this.button1 = new System.Windows.Forms.Button();
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.tb_MaxGray = new System.Windows.Forms.TrackBar();
            this.tb_MinGray = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_MinArea = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_MaxArea = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_Dilation = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Dilation)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "读取图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(12, 12);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(541, 193);
            this.hWindowControl1.TabIndex = 1;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(541, 193);
            // 
            // tb_MaxGray
            // 
            this.tb_MaxGray.BackColor = System.Drawing.Color.White;
            this.tb_MaxGray.Location = new System.Drawing.Point(12, 321);
            this.tb_MaxGray.Maximum = 255;
            this.tb_MaxGray.Minimum = 1;
            this.tb_MaxGray.Name = "tb_MaxGray";
            this.tb_MaxGray.Size = new System.Drawing.Size(522, 45);
            this.tb_MaxGray.TabIndex = 2;
            this.tb_MaxGray.Value = 1;
            this.tb_MaxGray.Scroll += new System.EventHandler(this.tb_MaxGray_Scroll);
            // 
            // tb_MinGray
            // 
            this.tb_MinGray.BackColor = System.Drawing.Color.White;
            this.tb_MinGray.Location = new System.Drawing.Point(12, 246);
            this.tb_MinGray.Maximum = 254;
            this.tb_MinGray.Name = "tb_MinGray";
            this.tb_MinGray.Size = new System.Drawing.Size(522, 45);
            this.tb_MinGray.TabIndex = 3;
            this.tb_MinGray.Scroll += new System.EventHandler(this.tb_MinGray_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "灰度最小值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "灰度最大值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "255";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 371);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1052, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "开始训练";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_MinArea
            // 
            this.tb_MinArea.BackColor = System.Drawing.Color.White;
            this.tb_MinArea.Location = new System.Drawing.Point(12, 486);
            this.tb_MinArea.Maximum = 4999;
            this.tb_MinArea.Name = "tb_MinArea";
            this.tb_MinArea.Size = new System.Drawing.Size(522, 45);
            this.tb_MinArea.TabIndex = 14;
            this.tb_MinArea.Scroll += new System.EventHandler(this.tb_MinArea_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "5000";
            // 
            // tb_MaxArea
            // 
            this.tb_MaxArea.BackColor = System.Drawing.Color.White;
            this.tb_MaxArea.Location = new System.Drawing.Point(12, 571);
            this.tb_MaxArea.Maximum = 5000;
            this.tb_MaxArea.Minimum = 1;
            this.tb_MaxArea.Name = "tb_MaxArea";
            this.tb_MaxArea.Size = new System.Drawing.Size(522, 45);
            this.tb_MaxArea.TabIndex = 16;
            this.tb_MaxArea.Value = 1;
            this.tb_MaxArea.Scroll += new System.EventHandler(this.tb_MaxArea_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 607);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "10000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "Area最小值";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "Area最大值";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 459);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(84, 547);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 23;
            // 
            // tb_Dilation
            // 
            this.tb_Dilation.BackColor = System.Drawing.Color.White;
            this.tb_Dilation.Location = new System.Drawing.Point(12, 398);
            this.tb_Dilation.Maximum = 100;
            this.tb_Dilation.Minimum = 5;
            this.tb_Dilation.Name = "tb_Dilation";
            this.tb_Dilation.Size = new System.Drawing.Size(522, 45);
            this.tb_Dilation.TabIndex = 24;
            this.tb_Dilation.Value = 10;
            this.tb_Dilation.Scroll += new System.EventHandler(this.tb_Dilation_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "Dilation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(697, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 21);
            this.textBox6.TabIndex = 28;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 628);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_Dilation);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_MaxArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_MinArea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MinGray);
            this.Controls.Add(this.tb_MaxGray);
            this.Controls.Add(this.hWindowControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "训练";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Dilation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.TrackBar tb_MaxGray;
        private System.Windows.Forms.TrackBar tb_MinGray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar tb_MinArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tb_MaxArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TrackBar tb_Dilation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
    }
}

