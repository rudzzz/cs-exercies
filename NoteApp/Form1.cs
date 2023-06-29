﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
	public partial class Form1 : Form
	{

		DataTable table;
		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			table = new DataTable();
			table.Columns.Add("Title", typeof(string));
			table.Columns.Add("Messages", typeof(string));

			dataGridView1.DataSource = table;
			dataGridView1.Columns["Messages"].Visible = false;
			dataGridView1.Columns["Title"].Width = 320;
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			textTitle.Clear();
			textMessage.Clear();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			table.Rows.Add(textTitle.Text, textMessage.Text);
			textTitle.Clear();
			textMessage.Clear();
		}

		private void buttonRead_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			
			if(index > -1)
			{
				textTitle.Text = table.Rows[index].ItemArray[0].ToString();
				textMessage.Text = table.Rows[index].ItemArray[1].ToString();
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			table.Rows[index].Delete();
		}
	}
}
