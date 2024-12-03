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
    //class
    public partial class Form1 : Form
    {
       //constorກຳກົດຄ່່າເລີ່ມຕົ້ນໃຫ້ຄາສ
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("15 + 5 =" + (15 +5)+ ("leoPai"));
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Green;
            button1.Text = "Calculate";
        }
      
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Reset to default appearance when mouse leaves
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            button1.Text = "Button"; // Restore original text
        }
    }
}
