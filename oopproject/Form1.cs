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
	public partial class Form1 : Form
    {
       // WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
		{
			InitializeComponent();
          //  player.URL = "melody.mp3";

        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 f1 =new Form5();
			f1.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
           // player.controls.play();
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
