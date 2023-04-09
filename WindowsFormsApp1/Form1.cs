using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            int signIndex = 0;
            if (input[0] == '+' || input[0] == '-')
            {
                signIndex = 1;
            }

            bool valid = true;
            for (int i = signIndex; i < input.Length; i++)
            {
                if (!Char.IsDigit(input[i]))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
            {
                MessageBox.Show("Вхідні дані - дійсне ціле число зі знаком.");
            }
            else
            {
                MessageBox.Show("Вхідні дані не є дійсним цілим числом зі знаком.");
            }
        }
    }
}
