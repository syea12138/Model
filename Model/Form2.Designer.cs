namespace Model
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Dilation = new System.Windows.Forms.TrackBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_MaxArea = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_MinArea = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MinGray = new System.Windows.Forms.TrackBar();
            this.tb_MaxGray = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Dilation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxGray)).BeginInit();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(12, 12);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(520, 197);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(520, 197);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "读取图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 52;
            this.label15.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(521, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 51;
            this.label14.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 50;
            this.label13.Text = "Dilation";
            // 
            // tb_Dilation
            // 
            this.tb_Dilation.BackColor = System.Drawing.Color.White;
            this.tb_Dilation.Location = new System.Drawing.Point(10, 245);
            this.tb_Dilation.Maximum = 100;
            this.tb_Dilation.Minimum = 5;
            this.tb_Dilation.Name = "tb_Dilation";
            this.tb_Dilation.Size = new System.Drawing.Size(522, 45);
            this.tb_Dilation.TabIndex = 49;
            this.tb_Dilation.Value = 10;
            this.tb_Dilation.Scroll += new System.EventHandler(this.tb_Dilation_Scroll);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 375);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 48;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 296);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 46;
            this.label12.Text = "Area最大值";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "Area最小值";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "10000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 42;
            this.label8.Text = "0";
            // 
            // tb_MaxArea
            // 
            this.tb_MaxArea.BackColor = System.Drawing.Color.White;
            this.tb_MaxArea.Location = new System.Drawing.Point(7, 399);
            this.tb_MaxArea.Maximum = 5000;
            this.tb_MaxArea.Minimum = 1;
            this.tb_MaxArea.Name = "tb_MaxArea";
            this.tb_MaxArea.Size = new System.Drawing.Size(522, 45);
            this.tb_MaxArea.TabIndex = 41;
            this.tb_MaxArea.Value = 1;
            this.tb_MaxArea.Scroll += new System.EventHandler(this.tb_MaxArea_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "5000";
            // 
            // tb_MinArea
            // 
            this.tb_MinArea.BackColor = System.Drawing.Color.White;
            this.tb_MinArea.Location = new System.Drawing.Point(10, 323);
            this.tb_MinArea.Maximum = 4999;
            this.tb_MinArea.Name = "tb_MinArea";
            this.tb_MinArea.Size = new System.Drawing.Size(522, 45);
            this.tb_MinArea.TabIndex = 39;
            this.tb_MinArea.Scroll += new System.EventHandler(this.tb_MinArea_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(620, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(620, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1047, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1047, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "灰度最大值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "灰度最小值";
            // 
            // tb_MinGray
            // 
            this.tb_MinGray.BackColor = System.Drawing.Color.White;
            this.tb_MinGray.Location = new System.Drawing.Point(548, 73);
            this.tb_MinGray.Maximum = 254;
            this.tb_MinGray.Name = "tb_MinGray";
            this.tb_MinGray.Size = new System.Drawing.Size(522, 45);
            this.tb_MinGray.TabIndex = 29;
            this.tb_MinGray.Scroll += new System.EventHandler(this.tb_MinGray_Scroll);
            // 
            // tb_MaxGray
            // 
            this.tb_MaxGray.BackColor = System.Drawing.Color.White;
            this.tb_MaxGray.Location = new System.Drawing.Point(548, 148);
            this.tb_MaxGray.Maximum = 255;
            this.tb_MaxGray.Minimum = 1;
            this.tb_MaxGray.Name = "tb_MaxGray";
            this.tb_MaxGray.Size = new System.Drawing.Size(522, 45);
            this.tb_MaxGray.TabIndex = 28;
            this.tb_MaxGray.Value = 1;
            this.tb_MaxGray.Scroll += new System.EventHandler(this.tb_MaxGray_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "读取模板";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(995, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "识别";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(548, 229);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(429, 21);
            this.textBox6.TabIndex = 55;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(548, 280);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(429, 21);
            this.textBox7.TabIndex = 56;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 523);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form2";
            this.Text = "识别";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Dilation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MinGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaxGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar tb_Dilation;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tb_MaxArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tb_MinArea;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_MinGray;
        private System.Windows.Forms.TrackBar tb_MaxGray;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}