using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _DemoPiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowNote();
            ShowBColor();
        }
        //Show Hide Note
        private void ShowNote()
        {
            pBC.Hide();
            pBD.Hide();
            pBE.Hide();
            pBF.Hide();
            pBG.Hide();
            pBA.Hide();
            pBB.Hide();
            
        }
        //đổi màu note
        private void ShowBColor()
        {
            this.btnC.BackColor = Color.White;
            this.btnD.BackColor = Color.White;
            this.btnE.BackColor = Color.White;
            this.btnF.BackColor = Color.White;
            this.btnG.BackColor = Color.White;
            this.btnA.BackColor = Color.White;
            this.btnB.BackColor = Color.White;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        
        //Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {

            ShowNote();
            ShowBColor();
            this.btnD.BackColor = Color.FromArgb(78, 184, 206);    
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "D.WAV";
            player.controls.play();
            pBD.Show();
            this.btnC.BackColor = Color.White;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            ShowNote();
            pBE.Show();
            ShowBColor();
            this.btnE.BackColor = Color.FromArgb(78, 184, 206);    
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "E.WAV";
            player.controls.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowNote();
            pBF.Show();
            ShowBColor();
            this.btnF.BackColor = Color.FromArgb(78, 184, 206);    
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "F.WAV";
            player.controls.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowNote();
            pBG.Show();
            ShowBColor();
            this.btnG.BackColor = Color.FromArgb(78, 184, 206);    
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "G.WAV";
            player.controls.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowNote();
            pBA.Show();
            ShowBColor();
            this.btnA.BackColor = Color.FromArgb(78, 184, 206);    
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "A.WAV";
            player.controls.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowNote();
            pBB.Show();
            ShowBColor();
            this.btnB.BackColor = Color.FromArgb(78, 184, 206);    
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "B.WAV";
            player.controls.play();
        }

        int x = 710, y = 76, a = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int width = this.Width;
            if (pBC.Location.X > width - pBC.Width)
            {
                pBC.Location = new Point(1, pBC.Location.Y);
            }
            else
            {
                pBC.Location = new Point(pBC.Location.X + 100, pBC.Location.Y);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            ShowNote();
            ShowBColor();
            this.btnC.BackColor = Color.FromArgb(78, 184, 206);
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "C.WAV";
            player.controls.play();
            pBC.Show();
        }
    }
}
