using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tower_Defense
{
    class Tower
    {
        String towerName;
        int price;
        int range;
        Tower firstTower;

        public Tower()
        {

        }

        private void towerType(Tower t)
        {
        }

        private void towerRange(Tower t)
        {
            
        }

        public void makeNewTurret(PictureBox newTurret)
        {
            newTurret.Image = Properties.Resources.still_Bat;
            newTurret.Tag = "zombie";
        }

        public void inRange(PictureBox testTurret)
        {
            if (testTurret.Image != null && testTurret.Tag.Equals("zombie"))
                testTurret.Image = Properties.Resources.bat_animation_by_ghostlykazesensei_d32r0jp;
        }

        
    }
}
