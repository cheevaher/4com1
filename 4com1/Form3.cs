using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4com1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cboStyle.Items.Add("d MMMM yyyy"); cboStyle.Items.Add("d MM yyyy");
            cboStyle.Items.Add("MMMM dd, yyyy");
            cboStyle.Items.Add("dd-MM-yy");
            cboStyle.Items.Add("dd/MM/yyyy");
            cboStyle.Items.Add("dddd, MMMM dd "); cboStyle.Items.Add("hh.mm.ss");
            cboStyle.Items.Add("hh.mm");
            cboStyle.SelectedIndex = 0;
        }

        private void cmdFormat_Click_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTimeFormatInfo dtInfo;
            string DateStyle = cboStyle.Text; 
            if (radioButton2.Checked) 
            {
                CultureInfo laoCulture = new CultureInfo("lo-LA");
                dtInfo = laoCulture.DateTimeFormat;
            }
            else if (radioButton1.Checked) 
            {
                dtInfo = DateTimeFormatInfo.InvariantInfo;
            }
            else
            {
                dtInfo = DateTimeFormatInfo.CurrentInfo; 
            }
            lblDisplay.Text = dt.ToString(DateStyle, dtInfo);
        }
    }
}
