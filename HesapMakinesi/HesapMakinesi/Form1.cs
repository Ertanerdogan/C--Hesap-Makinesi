using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool ilk_sayı = true;
        public Form1()
        {
            InitializeComponent();
        }
        string sayi1 = "";
        string sayi2 = "";
        char islem;
        double sonuc;
        private void Btn1_Click(object sender, EventArgs e)
        {
            if(sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "1";
            if(ilk_sayı == true)
            {
                sayi1 += "1";
            }
            else
            {
                sayi2 += "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "2";
            if (ilk_sayı == true)
            {
                sayi1 += "2";
            }
            else
            {
                sayi2 += "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "3";
            if (ilk_sayı == true)
            {
                sayi1 += "3";
            }
            else
            {
                sayi2 += "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "4";
            if (ilk_sayı == true)
            {
                sayi1 += "4";
            }
            else
            {
                sayi2 += "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "5";
            if (ilk_sayı == true)
            {
                sayi1 += "5";
            }
            else
            {
                sayi2 += "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "6";
            if (ilk_sayı == true)
            {
                sayi1 += "6";
            }
            else
            {
                sayi2 += "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "7";
            if (ilk_sayı == true)
            {
                sayi1 += "7";
            }
            else
            {
                sayi2 += "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "8";
            if (ilk_sayı == true)
            {
                sayi1 += "8";
            }
            else
            {
                sayi2 += "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "9";
            if (ilk_sayı == true)
            {
                sayi1 += "9";
            }
            else
            {
                sayi2 += "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                sayac = 0;
                textBox1.Text = "";
            }
            textBox1.Text += "0";
            if (ilk_sayı == true)
            {
                sayi1 += "0";
            }
            else
            {
                sayi2 += "0";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sayi1 = "";
            sayi2 = "";
            ilk_sayı = true;
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            islem = '+';
            if(textBox1.Text != "" && sayi1 != "")
            {
                ilk_sayı = false;
            }
            textBox1.Text += " + ";
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            islem = '-';
            if (textBox1.Text != "" && sayi1 != "")
            {
                ilk_sayı = false;
            }
            textBox1.Text += " - ";
        }

        private void BtnCarp_Click(object sender, EventArgs e)
        {
            islem = '*';
            if (textBox1.Text != "" && sayi1 != "")
            {
                ilk_sayı = false;
            }
            textBox1.Text += " * ";
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            islem = '/';
            if (textBox1.Text != "" && sayi1 != "")
            {
                ilk_sayı = false;
            }
            textBox1.Text += " / ";
        }
        int sayac = 0;
        private void BtnEsit_Click(object sender, EventArgs e)
        {
            if(sayi1 != "" && sayi2 != "")
            {
                switch(islem)
                {
                    case '+':
                        sonuc = double.Parse(sayi1) + double.Parse(sayi2);
                        textBox1.Text = sonuc.ToString();
                        break;

                    case '-':
                        sonuc = double.Parse(sayi1) - double.Parse(sayi2);
                        textBox1.Text = sonuc.ToString();
                        break;

                    case '*':
                        sonuc = double.Parse(sayi1) * double.Parse(sayi2);
                        textBox1.Text = sonuc.ToString();
                        break;

                    case '/':
                        sonuc = double.Parse(sayi1) / double.Parse(sayi2);
                        textBox1.Text = sonuc.ToString();
                        break;
                }
            }
            
            else
            {
                MessageBox.Show(sayi1 + " " +  sayi2);
            }
            sayi1 = "";
            sayi2 = "";
            ilk_sayı = true;
            sayac = 1;
            
        }

        private void Btn1_MouseEnter(object sender, EventArgs e)
        {
            Btn1.BackColor = Color.Cyan;
        }

        private void Btn1_MouseLeave(object sender, EventArgs e)
        {
            Btn1.BackColor = Color.White;
        }

        private void Btn2_MouseEnter(object sender, EventArgs e)
        {
            Btn2.BackColor = Color.Cyan;
        }

        private void Btn2_MouseLeave(object sender, EventArgs e)
        {
            Btn2.BackColor = Color.White;
        }

        private void Btn3_MouseEnter(object sender, EventArgs e)
        {
            Btn3.BackColor = Color.Cyan;
        }

        private void Btn3_MouseLeave(object sender, EventArgs e)
        {
            Btn3.BackColor = Color.White;
        }

        private void Btn4_MouseEnter(object sender, EventArgs e)
        {
            Btn4.BackColor = Color.Cyan;
        }

        private void Btn4_MouseLeave(object sender, EventArgs e)
        {
            Btn4.BackColor = Color.White;
        }

        private void Btn5_MouseEnter(object sender, EventArgs e)
        {
            Btn5.BackColor = Color.Cyan;
        }

        private void Btn5_MouseLeave(object sender, EventArgs e)
        {
            Btn5.BackColor = Color.White;
        }

        private void Btn6_MouseEnter(object sender, EventArgs e)
        {
            Btn6.BackColor = Color.Cyan;
        }

        private void Btn6_MouseLeave(object sender, EventArgs e)
        {
            Btn6.BackColor = Color.White;
        }

        private void Btn7_MouseEnter(object sender, EventArgs e)
        {
            Btn7.BackColor = Color.Cyan;
        }

        private void Btn7_MouseLeave(object sender, EventArgs e)
        {
            Btn7.BackColor = Color.White;
        }

        private void Btn8_MouseEnter(object sender, EventArgs e)
        {
            Btn8.BackColor = Color.Cyan;
        }

        private void Btn8_MouseLeave(object sender, EventArgs e)
        {
            Btn8.BackColor = Color.White;
        }

        private void Btn9_MouseEnter(object sender, EventArgs e)
        {
            Btn9.BackColor = Color.Cyan;
        }

        private void Btn9_MouseLeave(object sender, EventArgs e)
        {
            Btn9.BackColor = Color.White;
        }

        private void Btn0_MouseEnter(object sender, EventArgs e)
        {
            Btn0.BackColor = Color.Cyan;
        }

        private void Btn0_MouseLeave(object sender, EventArgs e)
        {
            Btn0.BackColor = Color.White;
        }

        private void BtnC_MouseEnter(object sender, EventArgs e)
        {
            BtnC.BackColor = Color.Cyan;
        }

        private void BtnC_MouseLeave(object sender, EventArgs e)
        {
            BtnC.BackColor = Color.White;
        }

        private void BtnTopla_MouseEnter(object sender, EventArgs e)
        {
            BtnTopla.BackColor = Color.Cyan;
        }

        private void BtnTopla_MouseLeave(object sender, EventArgs e)
        {
            BtnTopla.BackColor = Color.White;
        }

        private void BtnCikar_MouseEnter(object sender, EventArgs e)
        {
            BtnCikar.BackColor = Color.Cyan;
        }

        private void BtnCikar_MouseLeave(object sender, EventArgs e)
        {
            BtnCikar.BackColor = Color.White;
        }

        private void BtnCarp_MouseEnter(object sender, EventArgs e)
        {
            BtnCarp.BackColor = Color.Cyan;
        }

        private void BtnCarp_MouseLeave(object sender, EventArgs e)
        {
            BtnCarp.BackColor = Color.White;
        }

        private void BtnBol_MouseEnter(object sender, EventArgs e)
        {
            BtnBol.BackColor = Color.Cyan;
        }

        private void BtnBol_MouseLeave(object sender, EventArgs e)
        {
            BtnBol.BackColor = Color.White;
        }

        private void BtnEsit_MouseEnter(object sender, EventArgs e)
        {
            BtnEsit.BackColor = Color.Cyan;
        }

        private void BtnEsit_MouseLeave(object sender, EventArgs e)
        {
            BtnEsit.BackColor = Color.White;
        }
    }
}
