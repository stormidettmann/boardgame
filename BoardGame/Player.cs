using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BoardGame
{
    class Player
    {
        private int playerNum;
        public bool isPlaying;
        private string name;
        private int score;
        private int poss;
        private Color color;


        public Player(int playerNum, bool isPlaying, string name, int poss, Color color)
        {
            this.isPlaying = isPlaying;
            this.name = name;
            this.playerNum = playerNum;
            this.score = 0;
            this.poss = poss;
            this.color = color;
        }

        public int getScore()
        {
            return this.score;
        }
        public void setScore(int score)
        {
            this.score = score;
        }

        public void setPoss(int poss)
        {
            this.poss = poss;
        }
        public int getPlayerNum()
        {
            return this.playerNum;
        }
        public int getPoss()
        {
            return this.poss;
        }
        public Color getColor()
        {
            return this.color;
        }
        public string getName()
        {
            return this.name;
        }



    }
}
