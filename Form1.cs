using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float Num1, Num2, Result;
        char Oper=' ';

        private float Calculater()
        {
            switch(Oper)
            {
                case '+':
                    return Num1 + Num2;
                  
                case '-':
                    return Num1 - Num2;
                  
                case '*':
                    return Num1 * Num2;
                   
                case '/': 
                    if(Num2==0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        lblScreen.Text = " ";
                        return 0;
                    }
                    else
                    {
                        return Num1 / Num2;
                    }
                case '%':
                    return Num1 % Num2;

            }
                  return 0;


        }

        void Number_Click(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;

            lblScreen.Text += btn.Text;

        }
        void Operation_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
        
            Num1 = Convert.ToSingle(lblScreen.Text);
            Oper = Convert.ToChar(btn.Text);
            lblScreen.Text = " ";

        }
        private void DeleteBTNClick(object sender, EventArgs e)
        {
            if (lblScreen.Text.Length > 0)
            {
                lblScreen.Text = lblScreen.Text.Substring(0, lblScreen.Text.Length - 1);
            }

        }

        private void ClearBTNClick(object sender, EventArgs e)
        {
            lblScreen.Text = " ";
            Num1 = 0;
            Num2 = 0;
            Oper = '\0';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToSingle(lblScreen.Text);
            Result = Calculater();
            lblScreen.Text = Result.ToString();
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
