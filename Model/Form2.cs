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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Stack for temporary objects 
        HObject[] OTemp = new HObject[20];

        // Local iconic variables 

        HObject ho_Image, ho_ImageInvert, ho_Region, ho_RegionDilation;
        HObject ho_ConnectedRegions, ho_SelectedRegions, ho_SortedRegions;
        // Local control variables 

        HTuple hv_Area = null, hv_Row = null, hv_Column = null;
        HTuple hv_FontFile = null, hv_OCRHandle = null, hv_RecNum = null;



        HTuple hv_Confidence = null, hv_i = null;



        private void Form2_Load(object sender, EventArgs e)
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




        public void disp_message(HTuple hv_WindowHandle, HTuple hv_String, HTuple hv_CoordSystem, HTuple hv_Row, HTuple hv_Column, HTuple hv_Color, HTuple hv_Box)
        {
            // Local iconic variables 
            // Local control variables 
            HTuple hv_GenParamName = null, hv_GenParamValue = null;
            HTuple hv_Color_COPY_INP_TMP = hv_Color.Clone();
            HTuple hv_Column_COPY_INP_TMP = hv_Column.Clone();
            HTuple hv_CoordSystem_COPY_INP_TMP = hv_CoordSystem.Clone();
            HTuple hv_Row_COPY_INP_TMP = hv_Row.Clone();
            // Initialize local and output iconic variables 
            //This procedure displays text in a graphics window.
            //
            //Input parameters:
            //WindowHandle: The WindowHandle of the graphics window, where
            //   the message should be displayed
            //String: A tuple of strings containing the text message to be displayed
            //CoordSystem: If set to 'window', the text position is given
            //   with respect to the window coordinate system.
            //   If set to 'image', image coordinates are used.
            //   (This may be useful in zoomed images.)
            //Row: The row coordinate of the desired text position
            //   A tuple of values is allowed to display text at different
            //   positions.
            //Column: The column coordinate of the desired text position
            //   A tuple of values is allowed to display text at different
            //   positions.
            //Color: defines the color of the text as string.
            //   If set to [], '' or 'auto' the currently set color is used.
            //   If a tuple of strings is passed, the colors are used cyclically...
            //   - if |Row| == |Column| == 1: for each new textline
            //   = else for each text position.
            //Box: If Box[0] is set to 'true', the text is written within an orange box.
            //     If set to' false', no box is displayed.
            //     If set to a color string (e.g. 'white', '#FF00CC', etc.),
            //       the text is written in a box of that color.
            //     An optional second value for Box (Box[1]) controls if a shadow is displayed:
            //       'true' -> display a shadow in a default color
            //       'false' -> display no shadow
            //       otherwise -> use given string as color string for the shadow color
            //
            //It is possible to display multiple text strings in a single call.
            //In this case, some restrictions apply:
            //- Multiple text positions can be defined by specifying a tuple
            //  with multiple Row and/or Column coordinates, i.e.:
            //  - |Row| == n, |Column| == n
            //  - |Row| == n, |Column| == 1
            //  - |Row| == 1, |Column| == n
            //- If |Row| == |Column| == 1,
            //  each element of String is display in a new textline.
            //- If multiple positions or specified, the number of Strings
            //  must match the number of positions, i.e.:
            //  - Either |String| == n (each string is displayed at the
            //                          corresponding position),
            //  - or     |String| == 1 (The string is displayed n times).
            //
            //
            //Convert the parameters for disp_text.
            if ((int)((new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(new HTuple()))).TupleOr(new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(new HTuple())))) != 0)
            {
                return;
            }
            if ((int)(new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(-1))) != 0)
            {
                hv_Row_COPY_INP_TMP = 12;
            }
            if ((int)(new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(-1))) != 0)
            {
                hv_Column_COPY_INP_TMP = 12;
            }
            //
            //Convert the parameter Box to generic parameters.
            hv_GenParamName = new HTuple();
            hv_GenParamValue = new HTuple();
            if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(0))) != 0)
            {
                if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleEqual("false"))) != 0)
                {
                    //Display no box
                    hv_GenParamName = hv_GenParamName.TupleConcat("box");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat("false");
                }
                else if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleNotEqual("true"))) != 0)
                {
                    //Set a color other than the default.
                    hv_GenParamName = hv_GenParamName.TupleConcat("box_color");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat(hv_Box.TupleSelect(0));
                }
            }
            if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(1))) != 0)
            {
                if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleEqual("false"))) != 0)
                {
                    //Display no shadow.
                    hv_GenParamName = hv_GenParamName.TupleConcat("shadow");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat("false");
                }
                else if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleNotEqual("true"))) != 0)
                {
                    //Set a shadow color other than the default.
                    hv_GenParamName = hv_GenParamName.TupleConcat("shadow_color");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat(hv_Box.TupleSelect(1));
                }
            }
            //Restore default CoordSystem behavior.
            if ((int)(new HTuple(hv_CoordSystem_COPY_INP_TMP.TupleNotEqual("window"))) != 0)
            {
                hv_CoordSystem_COPY_INP_TMP = "image";
            }
            //
            if ((int)(new HTuple(hv_Color_COPY_INP_TMP.TupleEqual(""))) != 0)
            {
                //disp_text does not accept an empty string for Color.
                hv_Color_COPY_INP_TMP = new HTuple();
            }
            //
            HOperatorSet.DispText(hv_WindowHandle, hv_String, hv_CoordSystem_COPY_INP_TMP,
                hv_Row_COPY_INP_TMP, hv_Column_COPY_INP_TMP, hv_Color_COPY_INP_TMP, hv_GenParamName,
                hv_GenParamValue);

            return;
        }

        // Chapter: Graphics / Text
        // Short Description: Set font independent of OS 
        public void set_display_font(HTuple hv_WindowHandle, HTuple hv_Size, HTuple hv_Font,  HTuple hv_Bold, HTuple hv_Slant)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_OS = null, hv_Fonts = new HTuple();
            HTuple hv_Style = null, hv_Exception = new HTuple(), hv_AvailableFonts = null;
            HTuple hv_Fdx = null, hv_Indices = new HTuple();
            HTuple hv_Font_COPY_INP_TMP = hv_Font.Clone();
            HTuple hv_Size_COPY_INP_TMP = hv_Size.Clone();

            // Initialize local and output iconic variables 
            //This procedure sets the text font of the current window with
            //the specified attributes.
            //
            //Input parameters:
            //WindowHandle: The graphics window for which the font will be set
            //Size: The font size. If Size=-1, the default of 16 is used.
            //Bold: If set to 'true', a bold font is used
            //Slant: If set to 'true', a slanted font is used
            //
            HOperatorSet.GetSystem("operating_system", out hv_OS);
            // dev_get_preferences(...); only in hdevelop
            // dev_set_preferences(...); only in hdevelop
            if ((int)((new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(new HTuple()))).TupleOr(
                new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(-1)))) != 0)
            {
                hv_Size_COPY_INP_TMP = 16;
            }
            if ((int)(new HTuple(((hv_OS.TupleSubstr(0, 2))).TupleEqual("Win"))) != 0)
            {
                //Restore previous behaviour
                hv_Size_COPY_INP_TMP = ((1.13677 * hv_Size_COPY_INP_TMP)).TupleInt();
            }
            else
            {
                hv_Size_COPY_INP_TMP = hv_Size_COPY_INP_TMP.TupleInt();
            }
            if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("Courier"))) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Courier";
                hv_Fonts[1] = "Courier 10 Pitch";
                hv_Fonts[2] = "Courier New";
                hv_Fonts[3] = "CourierNew";
                hv_Fonts[4] = "Liberation Mono";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("mono"))) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Consolas";
                hv_Fonts[1] = "Menlo";
                hv_Fonts[2] = "Courier";
                hv_Fonts[3] = "Courier 10 Pitch";
                hv_Fonts[4] = "FreeMono";
                hv_Fonts[5] = "Liberation Mono";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("sans"))) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Luxi Sans";
                hv_Fonts[1] = "DejaVu Sans";
                hv_Fonts[2] = "FreeSans";
                hv_Fonts[3] = "Arial";
                hv_Fonts[4] = "Liberation Sans";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("serif"))) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Times New Roman";
                hv_Fonts[1] = "Luxi Serif";
                hv_Fonts[2] = "DejaVu Serif";
                hv_Fonts[3] = "FreeSerif";
                hv_Fonts[4] = "Utopia";
                hv_Fonts[5] = "Liberation Serif";
            }
            else
            {
                hv_Fonts = hv_Font_COPY_INP_TMP.Clone();
            }
            hv_Style = "";
            if ((int)(new HTuple(hv_Bold.TupleEqual("true"))) != 0)
            {
                hv_Style = hv_Style + "Bold";
            }
            else if ((int)(new HTuple(hv_Bold.TupleNotEqual("false"))) != 0)
            {
                hv_Exception = "Wrong value of control parameter Bold";
                throw new HalconException(hv_Exception);
            }
            if ((int)(new HTuple(hv_Slant.TupleEqual("true"))) != 0)
            {
                hv_Style = hv_Style + "Italic";
            }
            else if ((int)(new HTuple(hv_Slant.TupleNotEqual("false"))) != 0)
            {
                hv_Exception = "Wrong value of control parameter Slant";
                throw new HalconException(hv_Exception);
            }
            if ((int)(new HTuple(hv_Style.TupleEqual(""))) != 0)
            {
                hv_Style = "Normal";
            }
            HOperatorSet.QueryFont(hv_WindowHandle, out hv_AvailableFonts);
            hv_Font_COPY_INP_TMP = "";
            for (hv_Fdx = 0; (int)hv_Fdx <= (int)((new HTuple(hv_Fonts.TupleLength())) - 1); hv_Fdx = (int)hv_Fdx + 1)
            {
                hv_Indices = hv_AvailableFonts.TupleFind(hv_Fonts.TupleSelect(hv_Fdx));
                if ((int)(new HTuple((new HTuple(hv_Indices.TupleLength())).TupleGreater(0))) != 0)
                {
                    if ((int)(new HTuple(((hv_Indices.TupleSelect(0))).TupleGreaterEqual(0))) != 0)
                    {
                        hv_Font_COPY_INP_TMP = hv_Fonts.TupleSelect(hv_Fdx);
                        break;
                    }
                }
            }
            if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual(""))) != 0)
            {
                throw new HalconException("Wrong value of control parameter Font");
            }
            hv_Font_COPY_INP_TMP = (((hv_Font_COPY_INP_TMP + "-") + hv_Style) + "-") + hv_Size_COPY_INP_TMP;
            HOperatorSet.SetFont(hv_WindowHandle, hv_Font_COPY_INP_TMP);
            // dev_set_preferences(...); only in hdevelop

            return;
        }

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

            }
        }
        private void tb_MinGray_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "" + tb_MinGray.Value;
            if (ho_Image == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            HOperatorSet.Threshold(ho_Image, out ho_Region, tb_MinGray.Value, tb_MaxGray.Value);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            hWindowControl1.HalconWindow.DispObj(ho_Region);
            if (tb_MinGray.Value == tb_MaxGray.Value - 1)
                tb_MaxGray.Value = 255;
        }
        private void tb_MaxGray_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = "" + tb_MaxGray.Value;
            if (ho_Image == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);

            HOperatorSet.Threshold(ho_Image, out ho_Region, tb_MinGray.Value, tb_MaxGray.Value);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            hWindowControl1.HalconWindow.DispObj(ho_Region);

        } 
        private void tb_Dilation_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = "" + (Double)tb_Dilation.Value / 10;
            if (ho_Region == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            double Radius = (Double)tb_Dilation.Value / 10;
            HOperatorSet.DilationCircle(ho_Region, out ho_RegionDilation, Radius);
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
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", "and", tb_MinArea.Value, tb_MaxArea.Value);
            hWindowControl1.HalconWindow.DispObj(ho_SelectedRegions);
            if (tb_MinArea.Value == tb_MaxArea.Value - 1)
                tb_MaxArea.Value = 5000;

        }
        private void tb_MaxArea_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = "" + tb_MaxArea.Value;
            if (ho_ConnectedRegions == null)
                return;
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            hWindowControl1.HalconWindow.SetDraw("fill");//设置填充的模式
            hWindowControl1.HalconWindow.SetColor("red");//设置显示颜色
            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", "and", tb_MinArea.Value, tb_MaxArea.Value);
            hWindowControl1.HalconWindow.DispObj(ho_SelectedRegions);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ho_SelectedRegions == null)
                return;
            HOperatorSet.SortRegion(ho_SelectedRegions, out ho_SortedRegions, "character",  "true", "row");
            //计算每一个字符区域中心
            HOperatorSet.AreaCenter(ho_SortedRegions, out hv_Area, out hv_Row, out hv_Column);
            OpenFileDialog _OpenFileDialog = new OpenFileDialog();
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = _OpenFileDialog.FileName;
                HOperatorSet.ReadOcrClassMlp(filename, out hv_OCRHandle);
                textBox6.Text = filename;
            }

            //读取已训练好的参数

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ho_SortedRegions == null)
                return;
            //识别
            HOperatorSet.DoOcrMultiClassMlp(ho_SortedRegions, ho_Image, hv_OCRHandle, out hv_RecNum, out hv_Confidence);
            //显示在屏幕上
            //set_display_font (3600, 27, 'mono', 'true', 'false')
            // set_display_font(200000, 16, "mono", "true", "false");
            string[] woods = new string[100];
            for (hv_i = 0; (int)hv_i <= (int)((new HTuple(hv_RecNum.TupleLength())) - 1); hv_i = (int)hv_i + 1)
            {
                disp_message(200000, hv_RecNum.TupleSelect(hv_i), "image", hv_Row.TupleSelect( hv_i), hv_Column.TupleSelect(hv_i), "white", "false");
                woods[hv_i] = hv_RecNum[hv_i];
            }
            //将数组输出到文本框测试
            for (int i = 0; i < woods.Length - 1; i++)
            {
                this.textBox7.Text = this.textBox7.Text + woods[i];
            }

        }        












    }
}
