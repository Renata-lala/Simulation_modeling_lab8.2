using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИМЛаба8_2
{
    public partial class Form1 : Form
    {
        string[] wordsArray = new string[]{"Да, конечно", "Может быть", "Возможно", "Вероятно да", "НЕТ НЕТ НЕТ", "Хм, нет!", "Поробуй", "Делай как хочешь"};
        double[] PArray = new double[] { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125 , 0.125 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double a = rnd.NextDouble();
            int k = 0;
            while (a > 0 && k < wordsArray.Length)
            {
                
                a -= PArray[k];
                k += 1;

            }
            if (k < wordsArray.Length)
            {
                label2.Text = wordsArray[k];
            }

        }
    }
}
