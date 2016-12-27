using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Age_of_Empires_Sound_Modifier
{
    public partial class Form1 : Form
    {
        public static bool musicstate = true;
        public static string newsound;
        public static string folder;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "files\\Revolootin.mp3";
            

        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (musicstate==true)
            {
                player.controls.stop();
                musicstate = false;
                button1.Image = System.Drawing.Image.FromFile(@"files\\mute2.jpg");
                
            }
            else
            {
                player.controls.play();
                musicstate = true;
                button1.Image = System.Drawing.Image.FromFile(@"files\\mute1.jpg");


            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.zedpython.com");
            player.controls.stop();
            musicstate = false;
            button1.Image = System.Drawing.Image.FromFile(@"files\\mute2.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String song = comboBox1.Text;
            if (song == "Main Title")
            {
                MessageBox.Show(newsound);
                File.Delete(@folder+"\Sound\ypack\music\interface\Main Title.mp3");
            }
            
        } 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                newsound = Convert.ToString(fbd.FileName);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browsefolder = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK):
            {
                folder = Convert.ToString(browsefolder.SelectedPath);
            }
        }
    }
}
