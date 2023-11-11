using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut4_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string X => textBox2.Text;
        public string Y => textBox3.Text;
        public string Z => textBox4.Text;

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.AppendText(".");
        }

        public double ToDouble(string s, double def = 0.0)
        {
            if (s == null) return def;
            double res = def;
            try
            {
                res = Convert.ToDouble(s);
            }
            catch { res = def; };
            return res;
        }

        public double XValue
        {
            get
            {
                var res = ToDouble(textBox2.Text, 0);
                textBox2.Text = res.ToString();
                return res;
            }
            set
            {
                textBox2.Text = value.ToString();
            }
        }
        public double YValue
        {
            get
            {
                var res = ToDouble(textBox3.Text, 0);
                textBox3.Text = res.ToString();
                return res;
            }
            set
            {
                textBox3.Text = value.ToString();
            }
        }
        public double ZValue
        {
            get
            {
                var res = ToDouble(textBox4.Text, 0);
                textBox4.Text = res.ToString();
                return res;
            }
            set
            {
                textBox4.Text = value.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            XValue += YValue;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            XValue -= YValue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            XValue *= YValue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (YValue!=0) XValue /= YValue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            XValue = -XValue;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (XValue != 0) XValue = 1.0 / XValue;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            XValue = XValue*XValue;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            XValue = Math.Sqrt(XValue);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var tmp = ZValue;
            ZValue = YValue;
            YValue = XValue;
            XValue = tmp;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var tmp = XValue;
            XValue = YValue;
            YValue = ZValue;
            ZValue = tmp;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var pos = textBox1.GetLineFromCharIndex(this.textBox1.SelectionStart);
            XValue = ToDouble(textBox1.Lines[pos]);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.AppendText($"\r\n{XValue}");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var tmp = XValue;
            var pos = textBox1.GetLineFromCharIndex(this.textBox1.SelectionStart);
            XValue = ToDouble(textBox1.Lines[pos]);
            textBox1.AppendText($"\r\n{tmp}");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            XValue = Math.PI;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            XValue = Math.E;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            XValue = 1.0/Math.PI;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            XValue = YValue* YValue + ZValue*ZValue;
        }

        public double ToRadians(double value)
        {
            return value * Math.PI / 180.0;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            var t = comboBox1.Text;
            // локальная версия преобразования строки в число
            var value = this.ToDouble(t,0);
            // результат в ComboBox
            comboBox1.Text = value.ToString();
            // deg -> rad
            value = ToRadians(value);

            XValue = Math.Sin(value);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            var t = comboBox1.Text;
            // локальная версия преобразования строки в число
            var value = this.ToDouble(t, 0);
            // результат в ComboBox
            comboBox1.Text = value.ToString();
            // deg -> rad
            value = ToRadians(value);

            XValue = Math.Cos(value);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            var t = comboBox1.Text;
            // локальная версия преобразования строки в число
            var value = this.ToDouble(t, 0);
            // результат в ComboBox
            comboBox1.Text = value.ToString();
            // deg -> rad
            value = ToRadians(value);

            XValue = Math.Tan(value);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            // deg -> rad
            XValue = XValue*Math.PI/180.0;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            // rad -> deg
            XValue = XValue * 180.0 / Math.PI;
        }

        // временное значение при выборе trackbar
        private double _oldXValue = 0;
        // при изменении trackbar
        private void trackBar1_Enter(object sender, EventArgs e)
        {
            _oldXValue = XValue;
        } 


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var round = trackBar1.Value;
            // если значение -1 - не округлять
            if (round == -1)
            { 
                XValue = _oldXValue; 
                return; 
            }
            // округляем
            XValue = Math.Round(_oldXValue,round);
        }
    }
}
