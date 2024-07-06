using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi_double
{
    public partial class Form1 : Form
    {//her bir rakamın buttonu kendi değerinden bir fazla olacak şekildedir
        char _işlem;
        bool _ekrantemizlenecekmi;
        double _ilksayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";          
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)//== true yazmadık ya da false çünkü zaten _ekrantemizleneckminin doğruluk değerini taşıyacak ya da tam tersini 
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;//başta işlem başlatıldığı anda ekran temizlenecek miyi doğru aldığımız için her rakamdan sonra bu sefer ekranı temizler oldu o yüzden burada yanlışladık
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)//clear buttonu
        {
            label1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            double ikincisayı = Convert.ToDouble(label1.Text);
            double toplam;
            double fark;
            double çarpım;
            double bölüm;
            double kare;
            double üslüifade;

            switch (_işlem)
            {
                case '+': toplam = _ilksayı + ikincisayı;
                    label1.Text = Convert.ToString(toplam);
                    break;
                case '-': fark = _ilksayı - ikincisayı;
                    label1.Text = Convert.ToString(fark);
                    break;
                case 'x':çarpım = _ilksayı * ikincisayı;
                    label1.Text = Convert.ToString(çarpım);
                    break;
                case '/':bölüm = _ilksayı / ikincisayı;
                    label1.Text = Convert.ToString(bölüm);
                    break;
                case '2':kare = _ilksayı * _ilksayı;
                    label1.Text = Convert.ToString(kare);
                    break;
                case 'n':üslüifade =Math.Pow( _ilksayı,ikincisayı);
                    label1.Text = Convert.ToString(üslüifade);
                    break;

                    


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {

           _işlem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToDouble(label1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _işlem = 'X';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToDouble(label1.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            _işlem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToDouble(label1.Text);


        }

        private void button12_Click(object sender, EventArgs e)
        {
            _işlem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToDouble(label1.Text);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _işlem = '2';//karesi ifadesi
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToDouble(label1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _işlem = 'n';//n'inci dereceden üssünün alınması ifadesi
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToDouble(label1.Text);
        }
    }
}
