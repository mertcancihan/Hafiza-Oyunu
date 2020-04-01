using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    class Control
    {
        public static Control obj = new Control();
        public int tagNum2 = 10, tagNumber, playerA = 0, playerB = 0;
        public bool picCont = true, boolCont = true, equalControl = true, singleControl = false, playerCont = false, enabledControl = false;
        
        public void afterToMatching(int tagNum)
        {
            if (Game.obj.arrayPic[tagNum2].Tag.ToString() == Game.obj.arrayPic[tagNum].Tag.ToString() && singleControl == true)
            {
                Game.obj.arrayPic[tagNum2].Image = Game.obj.image[21];
                Game.obj.arrayPic[tagNum].Image = Game.obj.image[21];
                equalControl = true;
                boolCont = false;
                singleControl = false;
                picCont = true;
                Game.obj.disEnable();
                if (playerCont == false)
                {
                    playerA += 1;
                    Game.obj.lblAscore.Text = playerA.ToString();
                }
                else
                {
                    playerB += 1;
                    Game.obj.lblBscore.Text = playerB.ToString();
                }
            }
            else
            {
                Game.obj.arrayPic[tagNum2].Image = Game.obj.image[20];
                Game.obj.arrayPic[tagNum].Image = Game.obj.image[20];
                Game.obj.arrayPic[tagNum].Enabled = true;
                Game.obj.arrayPic[tagNum2].Enabled = true;
                equalControl = true;
                boolCont = false;
                picCont = true;
                singleControl = false;
                if (enabledControl == true)
                {
                    Game.obj.arrayPic[tagNum].Enabled = false;
                    Game.obj.arrayPic[tagNum2].Enabled = false;
                    Game.obj.disEnable();
                }
                if (playerCont == false)
                {
                    Game.obj.lblIsim.Text = "Oyun Sırası : B Oyuncusu";
                    playerCont = true;
                }
                else
                {
                    Game.obj.lblIsim.Text = "Oyun Sırası : A Oyuncusu";
                    playerCont = false;
                }
            }
            if (playerA > 10)
            {
                DialogResult option = MessageBox.Show("A oyuncusu Kazandı!", "Oyun Bitti", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (option == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else if (option == DialogResult.Cancel)
                {
                    Game.obj.Close();
                }
                else
                    Game.obj.Close();
            }
            else if (playerB > 10)
            {
                DialogResult option = MessageBox.Show("B oyuncusu Kazandı!", "Oyun Bitti", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (option == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else if (option == DialogResult.Cancel)
                {
                    Game.obj.Close();
                }
                else
                    Game.obj.Close();
            }
            else if (playerA == 10 && playerB == 10)
            {
                DialogResult option = MessageBox.Show("Kazanan Çıkmadı. Berabere!", "Oyun Bitti", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (option == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else if (option == DialogResult.Cancel)
                {
                    Game.obj.Close();
                }
                else
                    Game.obj.Close();
            }
        }
        public void doMatch(int tagNum)
        {
            tagNumber = tagNum;
            Game.obj.timer1.Enabled = true;

            if (picCont == true)
            {
                Game.obj.arrayPic[tagNum].Enabled = false;
                Game.obj.arrayPic[tagNum].Image = Game.obj.shakeImage[tagNum];
                picCont = false;
                boolCont = true;
                Game.obj.timerNum = 5;
                Game.obj.timerTime = 0;
                enabledControl = false;

                if (equalControl == true)
                    tagNum2 = tagNum;
                if (boolCont == true)
                    equalControl = false;
            }
            else
            {
                Game.obj.arrayPic[tagNum].Enabled = false;
                Game.obj.arrayPic[tagNum].Image = Game.obj.shakeImage[tagNum];
                picCont = true;
                singleControl = true;
                enabledControl = true;
                Game.obj.disEnable();
                Game.obj.timerTime = Game.obj.timerNum - 2;

            }
        }
    }
}
