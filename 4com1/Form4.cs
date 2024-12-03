using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4com1
{
    public partial class Form4 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        private void btnAnEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (resultValue * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (resultValue / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (resultValue % Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
            resultValue = Double.Parse(txtDisplay.Text);
            operationPerformed = "";
        
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
          if (txtDisplay.Text.Length > 0)
             txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }
    }
}
