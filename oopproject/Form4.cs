﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopproject
{
	public partial class Form4 : Form
	{
        
        public Form4()
		{
			InitializeComponent();
            
        }
		int x, b1, b2, b3, b4, time = 10, score = 0, level = 1;
		CheckBox[] ch;
		private void Form4_Load(object sender, EventArgs e)
		{ 
			ch = new CheckBox[4] { checkBox1, checkBox2, checkBox3, checkBox4 };
			start(10, 30);
           
        }
		void _score()
		{
			if (time <= 2)
			{
				score += 10;
				label6.Text = "+10";
			}
			else if (time <= 4 & time > 2)
			{
				score += 30;
				label6.Text = "+30";
			}
			else if (time <= 6 & time > 4)
			{
				score += 50;
				label6.Text = "+50";
			}
			else if (time <= 8 & time > 6)
			{
				score += 70;
				label6.Text = "+70";
			}
			else if (time <= 10 & time > 8)
			{
				score += 80;
				label6.Text = "+80";
			}
			label5.Text = score.ToString();
		}
		void _level()
		{
			if (score <= 200) { level = 1; }
			else if (score <= 500) { level = 2; }
			else if (score <= 700) { level = 3; }
			else if (score <= 900) { level = 4; }
			else if (score <= 1000) { level = 5; }
			label8.Text = level.ToString();

		}
		void start(int min, int max)
		{
			Random s = new Random();
			x = s.Next(min, max);
			label1.Text = x.ToString();
			do
			{
				b1 = s.Next(2, 100);
				b2 = s.Next(2, 100);
				b3 = s.Next(2, 100);
				b4 = s.Next(2, 100);
			} while ((b1 * b2 != x & b1 * b3 != x & b1 * b4 != x & b2 * b3 != x & b2 * b4 != x & b3 * b4 != x) & (b1 * b2 * b3 != x & b1 * b2 * b4 != x & b2 * b3 * b4 != x & b3 * b4 * b1 != x));

			button1.Text = b1.ToString();
			button2.Text = b2.ToString();
			button3.Text = b3.ToString();
			button4.Text = b4.ToString();
		}
		void BtnChecked(CheckBox ch)
		{
			if (ch.Checked)
			{
				ch.Checked = false;
			}
			else
			{
				ch.Checked = true;
			}
		}
		void answer(CheckBox[] check)
		{
			int mul = 1;
			int[] A = new int[5] { b1, b2, b3, b4, x };
			for (int i = 0; i < check.Length; i++)
			{
				if (check[i].Checked)
				{

					mul *= A[i];
				}
			}

			if (mul == A[4])
			{
				_level();
				_score();
				button5.BackColor = Color.Green;
			}
			else
			{
				button5.BackColor = Color.Red;
			}

		}
		void falseChecked(CheckBox[] ch)
		{
			foreach (CheckBox item in ch)
			{
				item.Checked = false;
			}
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
		{
			BtnChecked(checkBox1);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			BtnChecked(checkBox2);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			BtnChecked(checkBox3);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			BtnChecked(checkBox4);
		}
		private void button5_Click(object sender, EventArgs e)
		{
			answer(ch);
			time = 10;
			falseChecked(ch);
			switch (level)
			{
				case 1:
					start(10, 30);
					break;
				case 2:
					start(30, 40);
					break;
				case 3:
					start(40, 60);
					break;
				case 4:
					start(60, 80);
					break;
				case 5:
					start(80,100);
					break;
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{

			label3.Text = time.ToString();
			time--;
			if (time == -1)
			{
				time = 10;
				start(10, 30);
				falseChecked(ch);
			}
		}
		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 f1 = new Form5();
			f1.Show();
		}

	}
}
