using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bissexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ano;
            ano = Convert.ToInt32(textBox1.Text);
            //m = 4;
            if (ano % 4 == 0)
            {
                label2.Text = "É bissexto";
            }
            else
            {
                label2.Text = "Não é bissexto";
            }
            //}
            //if (((ano % m == 0) && (ano % 100 != 0)) || (ano % 400 == 0))
            //{
            //    label2.Text = "é bissexto";
            //}
            //else
            //{
            //    label2.Text = "Não é bissexto";
            //}
            for (int year = Convert.ToInt32(textBox1.Text); year <= 9999; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    DateTime leapDay = new DateTime(year, 1, 1);
                    DateTime nextYear = leapDay.AddYears(1);
                    label3.Text = ("   O proximo ano bissexto será:" +
                                      Convert.ToString(leapDay));
                    break;
                }
            }
            for (int year = Convert.ToInt32(textBox1.Text); year <= 9999; year--)
            {
                if (DateTime.IsLeapYear(year))
                {
                    DateTime leapDay = new DateTime(year, 1, 1);
                    DateTime nextYear = leapDay.AddYears(1);
                    label4.Text = ("   O último ano bissexto foi:" +
                                      Convert.ToString(leapDay));
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Confirmação!", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
