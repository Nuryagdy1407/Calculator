using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Goshmaca_txt.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(amal_txt.Text=="+")
            {
                double a = Convert.ToDouble(esasy_txt.Text);
                double b = Convert.ToDouble(Goshmaca_txt.Text);
                esasy_txt.ResetText();
                esasy_txt.Text = (a + b).ToString();
            }
            else if (amal_txt.Text == "-")
            {
                double a = Convert.ToDouble(esasy_txt.Text);
                double b = Convert.ToDouble(Goshmaca_txt.Text);
                esasy_txt.ResetText();
                esasy_txt.Text = (a - b).ToString();
            }
            else if (amal_txt.Text == "*")
            {
                double a = Convert.ToDouble(esasy_txt.Text);
                double b = Convert.ToDouble(Goshmaca_txt.Text);
                esasy_txt.ResetText();
                esasy_txt.Text = (a * b).ToString();
            }
            else if (amal_txt.Text == "/")
            {
                double a = Convert.ToDouble(esasy_txt.Text);
                double b = Convert.ToDouble(Goshmaca_txt.Text);
                esasy_txt.ResetText();
                esasy_txt.Text = (a / b).ToString();
            }
            else if (amal_txt.Text == "^")
            {
                double a = Convert.ToDouble(esasy_txt.Text);
                double b = Convert.ToDouble(Goshmaca_txt.Text);


                esasy_txt.ResetText();
                esasy_txt.Text = (Math.Pow(a,b)).ToString();
            }

            else if (amal_txt.Text == "%")
            {
                double a = Convert.ToDouble(esasy_txt.Text);
                double b = Convert.ToDouble(Goshmaca_txt.Text);
                esasy_txt.ResetText();
                esasy_txt.Text = (a*b/100).ToString();
            }

            else if (amal_txt.Text == "Log")
            {
                double a = Convert.ToDouble(Goshmaca_txt.Text);
                double c = Convert.ToInt32(esasy_txt.Text);
                double b = Math.Log(a, c);
                esasy_txt.Text = b.ToString();
            }

            Goshmaca_txt.ResetText(); Goshmaca_txt.Select(); amal_txt.ResetText();
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            amal_txt.ResetText();
            amal_txt.Text = plus_btn.Text;
            if(Goshmaca_txt.Text!="")
            {
            esasy_txt.Text = Goshmaca_txt.Text;
            }
            Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            amal_txt.ResetText();
            amal_txt.Text = minus_btn.Text;
            if (Goshmaca_txt.Text != "")
            {
                esasy_txt.Text = Goshmaca_txt.Text;
            }
            Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
        }

        private void multiple_btn_Click(object sender, EventArgs e)
        {
            amal_txt.ResetText();
            amal_txt.Text = multiple_btn.Text;
            if (Goshmaca_txt.Text != "")
            {
                esasy_txt.Text = Goshmaca_txt.Text;
            }
            Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            amal_txt.ResetText();
            amal_txt.Text = div_btn.Text;
            if (Goshmaca_txt.Text != "")
            {
                esasy_txt.Text = Goshmaca_txt.Text;
            }
            Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text =Goshmaca_txt.Text+button9.Text;
        }

        private void Goshmaca_txt_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode==Keys.Multiply)
            //{
            //    esasy_txt.Text = Goshmaca_txt.Text;
            //    amal_txt.Text = "*";
            //    Goshmaca_txt.ResetText();
            //}
            //else if (e.KeyCode == Keys.Divide)
            //{ amal_txt.Text = "/"; }
            //else if (e.KeyCode ==Keys.Oemplus)
            //{ amal_txt.Text = "+"; }
            //else if (e.KeyCode == Keys.OemMinus)
            //{ amal_txt.Text = "-"; }
            

            //if(amal_txt.Text!="")
            //{
            //    Goshmaca_txt.ResetText();
            //}
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button14.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Goshmaca_txt.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.ResetText(); amal_txt.ResetText(); esasy_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = a*a;
            esasy_txt.Text = b.ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Goshmaca_txt.Text == "")
            {
                esasy_txt.Text = "SINTAKTIK ÝALŇYŞLYK...   ";
            }
            else
            {
                double a = Convert.ToDouble(Goshmaca_txt.Text);
                double b = Math.Sqrt(a);
                esasy_txt.Text = b.ToString();
            }
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = 1 / a;
            esasy_txt.Text = b.ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            esasy_txt.Text = Goshmaca_txt.Text;
            amal_txt.Text = button16.Text;
            Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Goshmaca_txt.Text);
            int s = 1;
            for (int i = 1; i <= a;i++ )
            {
                s *= i;
            }
            esasy_txt.Text = s.ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Goshmaca_txt.Text);
            esasy_txt.Text=(Math.Sin(a*Math.PI/180)).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Goshmaca_txt.Text);
            esasy_txt.Text = (Math.Cos(a * Math.PI / 180)).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Goshmaca_txt.Text);
            esasy_txt.Text = (Math.Tan(a * Math.PI / 180)).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Goshmaca_txt.Text);
            int s = 0;
            for (int i = 1; i <= a; i++)
            {
                s += i;
            }
            esasy_txt.Text = s.ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Math.PI.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = Math.E.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            esasy_txt.Text = (Math.Pow(Math.E, a)).ToString();
           
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = 180 * Math.Asin(a) / Math.PI;
            esasy_txt.Text = (b).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (Goshmaca_txt.Text != "-")
            {
                Goshmaca_txt.Text = "-";
            }
            else
                Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text += ",";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = a * Math.PI / 180;
            esasy_txt.Text = b.ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = 180 * a / Math.PI; 
            esasy_txt.Text = b.ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select(); 
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = 180 * Math.Acos(a) / Math.PI;
            esasy_txt.Text = (b).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = 180 * Math.Atan(a) / Math.PI;
            esasy_txt.Text = (b).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            amal_txt.Text = button4.Text; 
            esasy_txt.Text = Goshmaca_txt.Text;
            Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(esasy_txt.Text);
            double b = Math.Round(a);
            esasy_txt.Text = b.ToString();
            //Goshmaca_txt.ResetText();
            //Goshmaca_txt.Select();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Goshmaca_txt.Text = esasy_txt.Text;
            esasy_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(esasy_txt.Text);
            double b = Math.Ceiling(a);
            esasy_txt.Text = b.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = Math.Log(a,Math.E);
            esasy_txt.Text = b.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Goshmaca_txt.Text);
            double b = Math.Log10(a);
            esasy_txt.Text = b.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            amal_txt.Text = "Log";
            esasy_txt.Text = Goshmaca_txt.Text;
            Goshmaca_txt.ResetText(); Goshmaca_txt.Select();
        }

        private void Goshmaca_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Goshmaca_txt.Text);
            esasy_txt.Text = (Math.Sinh(a * Math.PI / 180)).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Goshmaca_txt.Text);
            esasy_txt.Text = (Math.Cosh(a * Math.PI / 180)).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Goshmaca_txt.Text);
            esasy_txt.Text = (Math.Tanh(a * Math.PI / 180)).ToString();
            Goshmaca_txt.ResetText();
            Goshmaca_txt.Select();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void amal_txt_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
