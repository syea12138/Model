using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HSystem sys = new HSystem();

        // Local iconic variables 

        HObject ho_Image, ho_ImageGray, ho_Regions;
        HObject ho_RegionDilation, ho_ConnectedRegions, ho_SelectedRegions;
        HObject ho_SortedRegions, ho_SingleWord = null;

        // Local control variables 

        HTuple hv_Number = null, hv_words = null, hv_TrainFile = null;




        private void Form1_Load(object sender, EventArgs e)
        {
            tb_MinGray.Value = 0;
            textBox1.Text = "" + tb_MinGray.Value;
            tb_MaxGray.Value = 109;
            textBox2.Text = "" + tb_MaxGray.Value;
            tb_Dilation.Value = 10;
            textBox3.Text = "" + (Double)tb_Dilation.Value / 10;
            tb_MinArea.Value = 50;
            textBox4.Text = "" + tb_MinArea.Value;
            tb_MaxArea.Value = 1223;  
            textBox5.Text = "" + tb_MaxArea.Value;
        }

        HTuple hv_i = new HTuple(), hv_FontFile = new HTuple();



        HTuple hv_CharacterNames = new HTuple(), hv_CharacterCount = new HTuple();



        HTuple hv_NumHidden = new HTuple(), hv_OCRHandle = new HTuple();
        HTuple hv_Error = new HTuple(), hv_ErrorLog = new HTuple();

        // Local control variables 
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog _OpenFileDialog = new OpenFileDialog();
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = _OpenFileDialog.FileName;
                HOperatorSet.ReadImage(out ho_Image, filename);
                HOperatorSet.InvertImage(ho_Image, out ho_Image);
                // hWindowControl1.HalconWindow.DispObj(ho_Image);
                HTuple width, height;
                HOperatorSet.GetImageSize(ho_Image, out width, out height);
                double ratioWidth = (1.0) * width[0].I / hWindowControl1.Width;
                double ratioHeight = (1.0) * height[0].I / hWindowControl1.Height;
                HTuple row1, column1, row2, column2;
                if (ratioWidth >= ratioHeight)
                {
                    row1 = -(1.0) * ((hWindowControl1.Height * ratioWidth) - height) / 2;
                    column1 = 0;
                    //错了
                    row2 = row1 + hWindowControl1.Height * ratioWidth;
                    column2 = column1 + hWindowControl1.Width * ratioWidth;
                    HOperatorSet.SetPart(hWindowControl1.HalconWindow, row1, column1, row2, column2);
                }
            HOperatorSet.DispObj(ho_Image, hWindowControl1.HalconWindow);
            HOperatorSet.Rgb3ToGray(ho_Image, ho_Image, ho_Image, out ho_ImageGray);
            hWindowControl1.HalconWindow.DispObj(ho_ImageGray);                
            }
        }
        private void tb_MinGray_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = ""+tb_MinGray.Value;
            if (ho_ImageGray == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            HOperatorSet.Threshold(ho_ImageGray, out ho_Regions, tb_MinGray.Value, tb_MaxGray.Value);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            hWindowControl1.HalconWindow.DispObj(ho_Regions);
            if (tb_MinGray.Value == tb_MaxGray.Value - 1)
                tb_MaxGray.Value = 255;
        }

        private void tb_MaxGray_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = "" + tb_MaxGray.Value;
            if (ho_ImageGray == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);

            HOperatorSet.Threshold(ho_ImageGray, out ho_Regions, tb_MinGray.Value, tb_MaxGray.Value);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            hWindowControl1.HalconWindow.DispObj(ho_Regions);
        }
        private void tb_Dilation_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = "" + (Double)tb_Dilation.Value/10;
            if (ho_Regions == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            double Radius = (Double)tb_Dilation.Value / 10;
            HOperatorSet.DilationCircle(ho_Regions, out ho_RegionDilation, Radius);
            hWindowControl1.HalconWindow.DispObj(ho_RegionDilation);
            HOperatorSet.Connection(ho_RegionDilation, out ho_ConnectedRegions);
        }


        private void tb_MinArea_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = "" + tb_MinArea.Value;
            if (ho_ConnectedRegions == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("green");//设置显示颜色
            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", "and", tb_MinArea.Value, tb_MaxArea.Value);
            hWindowControl1.HalconWindow.DispObj(ho_SelectedRegions);
            if (tb_MinArea.Value == tb_MaxArea.Value - 1)
                tb_MaxArea.Value = 5000;
            HOperatorSet.SortRegion(ho_SelectedRegions, out ho_SortedRegions, "character", "true", "row");
            HOperatorSet.CountObj(ho_SortedRegions, out hv_Number);
            textBox6.Text = "共识别到" + hv_Number + "个字符";

        }
        private void tb_MaxArea_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = "" + tb_MaxArea.Value;
            if (ho_ConnectedRegions == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("green");//设置显示颜色
            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", "and", tb_MinArea.Value, tb_MaxArea.Value);
            hWindowControl1.HalconWindow.DispObj(ho_SelectedRegions);
            HOperatorSet.SortRegion(ho_SelectedRegions, out ho_SortedRegions, "character", "true", "row");
            HOperatorSet.CountObj(ho_SortedRegions, out hv_Number);
            textBox6.Text = "共识别到" + hv_Number + "个字符";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            hv_words = new HTuple();
            hv_words[0] = "A";
            hv_words[1] = "B";
            hv_words[2] = "C";
            hv_words[3] = "D";
            hv_words[4] = "E";
            hv_words[5] = "F";
            hv_words[6] = "G";
            hv_words[7] = "H";
            hv_words[8] = "I";
            hv_words[9] = "J";
            hv_words[10] = "K";
            hv_words[11] = "L";
            hv_words[12] = "M";
            hv_words[13] = "N";
            hv_words[14] = "O";
            hv_words[15] = "P";
            hv_words[16] = "Q";
            hv_words[17] = "R";
            hv_words[18] = "S";
            hv_words[19] = "T";
            hv_words[20] = "U";
            hv_words[21] = "V";
            hv_words[22] = "W";
            hv_words[23] = "X";
            hv_words[24] = "Y";
            hv_words[25] = "Z";
            hv_TrainFile = "e:/testWords.trf";
            HTuple end_val17 = hv_Number;
            HTuple step_val17 = 1;
            for (hv_i = 1; hv_i.Continue(end_val17, step_val17); hv_i = hv_i.TupleAdd(step_val17))
            {
                HOperatorSet.SelectObj(ho_SortedRegions, out ho_SingleWord, hv_i);
                HOperatorSet.AppendOcrTrainf(ho_SingleWord, ho_Image, hv_words.TupleSelect(hv_i - 1), hv_TrainFile);
                HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
                hWindowControl1.HalconWindow.DispObj(ho_SingleWord);
                hWindowControl1.HalconWindow.SetDraw("margin");//设置填充的模式
                hWindowControl1.HalconWindow.SetColor("green");//设置显示颜色
            }
            //训练ocr
            hv_FontFile = "e:/testWords.omc";
            //读取训练文件

            HOperatorSet.ReadOcrTrainfNames(hv_TrainFile, out hv_CharacterNames, out hv_CharacterCount);

            hv_NumHidden = 100000;
            //自己创建神经网络分类器
            HOperatorSet.CreateOcrClassMlp(10, 20, "constant", "default", hv_CharacterNames, hv_NumHidden, "none", 10, 42, out hv_OCRHandle);
            //这里采用halcon预训练模型；第二次及以后训练先将文件名改为FontFile，调用已训练的参数继续训练
            HOperatorSet.ReadOcrClassMlp("Industrial_A-Z+_Rej.omc", out hv_OCRHandle);

            //训练

            HOperatorSet.TrainfOcrClassMlp(hv_OCRHandle, hv_TrainFile, 200, 1, 0.01, out hv_Error, out hv_ErrorLog);
            //保存参数到自己命名的文件

            HOperatorSet.WriteOcrClassMlp(hv_OCRHandle, hv_FontFile);
            //释放内存

            HOperatorSet.ClearOcrClassMlp(hv_OCRHandle);
        }
    }
}
