using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tower_Defense
{
    public partial class Form1 : Form
    {
        private bool wantZombie = false;
        private bool wantBat = false;
        private Tower TD = new Tower();
        private int userBrains = 100;

        public Form1()
        {
            InitializeComponent();
            label3.Text = userBrains.ToString();
            
        }

        private void wantTurret()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (converter(i).Image == null)
                    converter(i).BackColor = Color.Green;
            }
        }

        private void placeTurret(PictureBox pb)
        {
            if (pb.Image == null && wantZombie == true && userBrains >= 50)
            {
                pb.Image = Properties.Resources.tempZombie;
                pb.BackColor = Color.Empty;
                userBrains -= 50;
                label3.Text = userBrains.ToString();
            }
            if (pb.Image == null && wantBat == true && userBrains >= 20)
            {
                pb.Image = Properties.Resources.still_Bat;
                pb.BackColor = Color.Empty;
                userBrains -= 20;
                label3.Text = userBrains.ToString();
            }
            wantZombie = false;
            wantBat = false;
            for (int i = 1; i <= 20; i++)
            {
                if (converter(i).Image == null)
                    converter(i).BackColor = Color.Empty;
            }
        }

        private void testRange_MouseEnter(object sender, EventArgs e)
        {
            TD.inRange(testRange);
        }

        private void testRange_MouseLeave(object sender, EventArgs e)
        {
            if (Bat.Image != null && Bat.Image == Properties.Resources.bat_animation_by_ghostlykazesensei_d32r0jp)
            Bat.Image = Properties.Resources.still_Bat;
        }

        public PictureBox converter(int x)
        {
            if (x == 1)
                return pictureBox1;
            else if (x == 2)
                return pictureBox2;
            else if (x == 3)
                return pictureBox3;
            else if (x == 4)
                return pictureBox4;
            else if (x == 5)
                return pictureBox5;
            else if (x == 6)
                return pictureBox6;
            else if (x == 7)
                return pictureBox7;
            else if (x == 8)
                return pictureBox8;
            else if (x == 9)
                return pictureBox9;
            else if (x == 10)
                return pictureBox10;
            else if (x == 11)
                return pictureBox11;
            else if (x == 12)
                return pictureBox12;
            else if (x == 13)
                return pictureBox13;
            else if (x == 14)
                return pictureBox14;
            else if (x == 15)
                return pictureBox15;
            else if (x == 16)
                return pictureBox16;
            else if (x == 17)
                return pictureBox17;
            else if (x == 18)
                return pictureBox18;
            else if (x == 19)
                return pictureBox19;
            else if (x == 20)
                return pictureBox20;
       /*     else if (x == 21)
                return pictureBox21;
            else if (x == 22)
                return pictureBox22;
            else if (x == 23)
                return pictureBox23;
            else if (x == 24)
                return pictureBox24;
            else if (x == 25)
                return pictureBox25;
            else if (x == 26)
                return pictureBox26;
            else if (x == 27)
                return pictureBox27;
            else if (x == 28)
                return pictureBox28;
            else if (x == 29)
                return pictureBox29;
            else if (x == 30)
                return pictureBox30;
            else if (x == 31)
                return pictureBox31;
            else if (x == 32)
                return pictureBox32;
            else if (x == 33)
                return pictureBox33;
            else if (x == 34)
                return pictureBox34;
            else if (x == 35)
                return pictureBox35;
            else if (x == 36)
                return pictureBox36;
            else if (x == 37)
                return pictureBox37;
            else if (x == 38)
                return pictureBox38;
            else if (x == 39)
                return pictureBox39;
            else if (x == 40)
                return pictureBox40;
            else if (x == 41)
                return pictureBox41;
            else if (x == 42)
                return pictureBox42;
            else if (x == 43)
                return pictureBox43;
            else if (x == 44)
                return pictureBox44;
            else if (x == 45)
                return pictureBox45;
            else if (x == 46)
                return pictureBox46;
            else if (x == 47)
                return pictureBox47;
            else if (x == 48)
                return pictureBox48;
            else if (x == 49)
                return pictureBox49;
            else if (x == 50)
                return pictureBox50;
            else if (x == 51)
                return pictureBox51;
            else if (x == 52)
                return pictureBox52;
            else if (x == 53)
                return pictureBox53;
            else if (x == 54)
                return pictureBox54;
            else if (x == 55)
                return pictureBox55;
            else if (x == 56)
                return pictureBox56;
            else if (x == 57)
                return pictureBox57;
            else if (x == 58)
                return pictureBox58;
            else if (x == 59)
                return pictureBox59;
            else if (x == 60)
                return pictureBox60;
            else if (x == 61)
                return pictureBox61;
            else if (x == 62)
                return pictureBox62;
            else if (x == 63)
                return pictureBox63;
            else if (x == 64)
                return pictureBox64;
            else if (x == 65)
                return pictureBox65;
            else if (x == 66)
                return pictureBox66;
            else if (x == 67)
                return pictureBox67;
            else if (x == 68)
                return pictureBox68;
            else if (x == 69)
                return pictureBox69;
            else if (x == 70)
                return pictureBox70;
            else if (x == 71)
                return pictureBox71;
            else if (x == 72)
                return pictureBox72;
            else if (x == 73)
                return pictureBox73;
            else if (x == 74)
                return pictureBox74;
            else if (x == 75)
                return pictureBox75;
            else if (x == 76)
                return pictureBox76;
            else if (x == 77)
                return pictureBox77;
            else if (x == 78)
                return pictureBox78;
            else if (x == 79)
                return pictureBox79;
            else if (x == 80)
                return pictureBox80;
            else if (x == 81)
                return pictureBox81;
            else if (x == 82)
                return pictureBox82;
            else if (x == 83)
                return pictureBox83;
            else if (x == 84)
                return pictureBox84;
            else if (x == 85)
                return pictureBox85;
            else if (x == 86)
                return pictureBox86;
            else if (x == 87)
                return pictureBox87;
            else if (x == 88)
                return pictureBox88;
            else if (x == 89)
                return pictureBox89;
            else if (x == 90)
                return pictureBox90;
            else if (x == 91)
                return pictureBox91;
            else if (x == 92)
                return pictureBox92;
            else if (x == 93)
                return pictureBox93;
            else if (x == 94)
                return pictureBox94;
            else if (x == 95)
                return pictureBox95;
            else if (x == 96)
                return pictureBox96;
            else if (x == 97)
                return pictureBox97;
            else if (x == 98)
                return pictureBox98;
            else if (x == 99)
                return pictureBox99;
            else if (x == 100)
                return pictureBox100;
            */


            return null;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox2);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox3);
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox4);
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox9);
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox10);
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox11);
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox12);
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox13);
        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox14);
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox15);
        }

        private void pictureBox16_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox16);
        }

        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox19);
        }

        private void pictureBox20_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox20);
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox5);
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox6);
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox7);
        }

        private void pictureBox18_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox18);
        }

        private void pictureBox17_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox17);
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            placeTurret(pictureBox8);
        }

        private void Zombie_Click(object sender, EventArgs e)
        {
            wantZombie = true;
            wantTurret();
        }

        private void Bat_Click(object sender, EventArgs e)
        {
            wantBat = true;
            wantTurret();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            placeTurret(pictureBox1);
        }

        
    }
}
