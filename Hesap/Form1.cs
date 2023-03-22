using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double number1;
        private double number2;
        private char mark;

        public void SetMark(char sys_mark)
        {
            mark = sys_mark;
        }

        public char GetMark()
        {
            return mark;
        }

        public void SetNum1(double num1)
        {
            number1 = num1;
        }

        public double GetNum1()
        {
            return number1;
        }

        public void SetNum2(double num2)
        {
            number2 = num2;
        }

        public double GetNum2()
        {
            return number2;
        }

        public double Plused()
        {
            return number1 + number2;
        }

        public double Mined()
        {
            return number1 - number2;
        }

        public double Timed()
        {
            return number1 * number2;
        }

        public double Divided()
        {
            return number1 / number2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SetMark('/');
            SetNum1(Convert.ToDouble(sonuc.Text));
            sonuc.Text = " ";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + ",";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sonuc.Text = sonuc.Text + "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            SetNum1(Convert.ToDouble(sonuc.Text));
            SetMark('+');
            sonuc.Text = " ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetNum2(Convert.ToDouble(sonuc.Text));
            if (GetMark() == '+')
            {
                sonuc.Text = Convert.ToString(Plused());
            }
            else if (GetMark() == '-')
            {
                sonuc.Text = Convert.ToString(Mined());
            }
            else if (GetMark() == '*')
            {
                sonuc.Text = Convert.ToString(Timed());
            }
            else if (GetMark() == '/')
            {
                if(GetNum2() == 0)
                {
                    sonuc.Text = "Unvalid process";
                }
                else
                {
                    sonuc.Text = Convert.ToString(Divided());
                }
            }
            SetNum1(0);
            SetNum2(0);
            SetMark(' ');
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            SetMark('*');
            SetNum1(Convert.ToDouble(sonuc.Text));
            sonuc.Text = " ";
        }

        private void buttonMines_Click(object sender, EventArgs e)
        {
            SetMark('-');
            SetNum1(Convert.ToDouble(sonuc.Text));
            sonuc.Text = " ";
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            sonuc.Text = " ";
        }
    }
}
