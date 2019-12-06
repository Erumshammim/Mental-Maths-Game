using System;
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
	public partial class Form5 : Form
	{
       
        public Form5()
		{
			InitializeComponent();
          
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 f2 = new Form2();
			f2.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 f = new Form3();
			f.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form4 f1 = new Form4();
			f1.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f3 = new Form1();
			f3.Show();

		}
		private void button6_Click(object sender, EventArgs e)
		{

			this.Hide();
			Form6 f4 = new Form6();
			f4.Show();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

     
    }
}
