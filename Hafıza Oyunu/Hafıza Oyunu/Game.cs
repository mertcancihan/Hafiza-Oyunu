using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    public partial class Game : Form
    {
        public static Game obj;

        public int timerNum = 5, timerTime = 0;
        public Image[] image = new Image[22];
        public Image[] shakeImage = new Image[40];
        int[] randNum = new int[40];
        public PictureBox[] arrayPic;
        public bool picCont = true, boolCont = true, equalControl = true, singleControl = false, playerCont = false, enabledControl = false, firstGame = true, firstGame2 = true;
        public Game()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createObj();
            gettingPicture();
            randomNum();
            createArray();
            setImage();
        }
        private void createObj()
        {
            if (obj == null)
                obj = this;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerNum--;
            lblSure.Text = timerNum.ToString();

            if (firstGame == true)
            {
                for (int i = 0; i < arrayPic.Length; i++)
                {
                    arrayPic[i].Image = shakeImage[i];
                }
                firstGame = false;
            }

            if (timerNum == timerTime)
            {
                timer1.Enabled = false;
                timerNum = 5;
                lblSure.Text = 5.ToString();

                if (firstGame2 == true)
                {
                    for (int i = 0; i < arrayPic.Length; i++)
                    {
                        arrayPic[i].Image = image[20];
                    }
                    firstGame2 = false;
                    disEnable();
                }
                else
                    Control.obj.afterToMatching(Control.obj.tagNumber);
            }
        }
        private void gettingPicture()
        {
            for (int i = 0; i < image.Length; i++)
            {
                image[i] = Image.FromFile(@"picture/" + i + ".jpg");
            }
        }
        private void createArray()
        {
            arrayPic = new PictureBox[] {picBox1, picBox2, picBox3, picBox4, picBox5, picBox6, picBox7, picBox8, picBox9, picBox10,
                                         picBox11, picBox12, picBox13, picBox14, picBox15, picBox16, picBox17, picBox18, picBox19, picBox20,
                                         picBox21, picBox22, picBox23, picBox24, picBox25, picBox26, picBox27, picBox28, picBox29, picBox30,
                                         picBox31, picBox32, picBox33, picBox34, picBox35, picBox36, picBox37, picBox38, picBox39, picBox40 };
        }
        private void setImage()
        {
            int j = 0;
            for (int i = 0; i < shakeImage.Length; i++)
            {
                if (i > 19)
                {
                    shakeImage[randNum[i]] = image[j];
                    arrayPic[randNum[i]].Tag = j.ToString();
                    j++;
                }
                else
                {
                    shakeImage[randNum[i]] = image[i];
                    arrayPic[randNum[i]].Tag = i.ToString();
                }
            }
        }
        private void randomNum()
        {
            Random rand = new Random();
            for (int j = 0; j < randNum.Length; j++)
            {
            etiket:
                randNum[j] = rand.Next(0, 40);
                for (int i = 0; i < j; i++)
                {
                    if (randNum[j] == randNum[i])
                    {
                        goto etiket;
                    }
                }
            }

        }
        public void disEnable()
        {
            for (int i = 0; i < arrayPic.Length; i++)
            {
                if (arrayPic[i].Enabled == false)
                    arrayPic[i].Enabled = true;
                else
                    arrayPic[i].Enabled = false;

            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
        private void picBox1_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(0);
        }
        private void picBox2_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(1);
        }
        private void picBox3_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(2);
        }
        private void picBox4_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(3);
        }
        private void picBox5_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(4);
        }
        private void picBox6_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(5);
        }
        private void picBox7_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(6);
        }
        private void picBox8_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(7);
        }
        private void picBox9_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(8);
        }
        private void picBox10_click(object sender, EventArgs e)
        {
            Control.obj.doMatch(9);
        }
        private void picBox11_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(10);
        }
        private void picBox12_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(11);
        }
        private void picBox13_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(12);
        }
        private void picBox14_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(13);
        }
        private void picBox15_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(14);
        }
        private void picBox16_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(15);
        }
        private void picBox17_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(16);
        }
        private void picBox18_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(17);
        }
        private void picBox19_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(18);
        }
        private void picBox20_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(19);
        }
        private void picBox21_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(20);
        }
        private void picBox22_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(21);
        }
        private void picBox23_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(22);
        }
        private void picBox24_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(23);
        }
        private void picBox25_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(24);
        }
        private void picBox26_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(25);
        }
        private void picBox27_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(26);
        }
        private void picBox28_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(27);
        }
        private void picBox29_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(28);
        }
        private void picBox30_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(29);
        }
        private void picBox31_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(30);
        }
        private void picBox32_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(31);
        }
        private void picBox33_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(32);
        }
        private void picBox34_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(33);
        }
        private void picBox35_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(34);
        }
        private void picBox36_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(35);
        }
        private void picBox37_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(36);
        }
        private void picBox38_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(37);
        }
        private void picBox39_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(38);
        }
        private void picBox40_Click(object sender, EventArgs e)
        {
            Control.obj.doMatch(39);
        }
    }
}
