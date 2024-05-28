using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        
        private void tbinput_TextChanged(object sender, EventArgs e)
        {
           

            if (!IsNumeric(tbinput.Text))
            {
                MessageBox.Show("Please enter only numeric digits!");
                tbinput.Text = tbinput.Text.Remove(tbinput.Text.Length-1);
                tbinput.SelectionLength = tbinput.Text.Length;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbinput.Text != string.Empty)
            {
                string num = tbinput.Text;
                double result = Convert.ToDouble(num);
                result = result * result;
                lbloutput.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Enter The Number");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
