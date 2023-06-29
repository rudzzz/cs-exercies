using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do you want to close this window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(dialogResult == DialogResult.Yes)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show("You clicked no!");
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			button2.Enabled = checkBox1.Checked;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("User registered succefully!");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
