using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = string.Empty;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			string result=$"{DateTime.Now:HH:mm:ss}\n\aHI";
			label1.Text = result;
		}
    }
}
