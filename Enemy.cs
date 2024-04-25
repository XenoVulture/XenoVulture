using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AndrewRusso_CPT_185_Final_Project
{
    public class Enemy
    {
        // Enemy constructor 
        public Enemy()
        {
            EnemyName = "";
            EnemyHealth = 0;
            EnemyAttack = 0;
            EnemyChanceToAttack = 0;
            EnemyImageIndex = 0;
        }

        // EnemyName property
        public string EnemyName { get; set; } // name of enemy

        // EnemyHealth property
        public int EnemyHealth { get; set; }  // enemy's starting HP

        // EnemyAttack property
        public int EnemyAttack { get; set; } // how much damage the enemy does when attacking

        // EnemyChanceToAttack property
        public int EnemyChanceToAttack { get; set; } // likelihood of attack, the high the number to lower to chance of attack
                                                     // using as max value for random, enemies will only attack on a 0
                                                     // example: random(EnemyChanceToAttack); this would select between 0 and the value - 1 

        // ImageIndex property
        public int EnemyImageIndex { get; set; } // Index for enemay image.
    }
}
