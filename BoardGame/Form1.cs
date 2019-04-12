using System;
using System.Drawing;
using System.Windows.Forms;

/* Stormi Sprague
 * This is intended as my primary project while the tic tac toe I submitted was for EC.
 * Everything works as expected. 
 * Implemented sound, extra features (4 players, player name, etc), and design elements for ec
 */

namespace BoardGame
{    
    public partial class Form1 : Form
    {        
        Graphics formGraphics;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        bool soundOn = false;
        int[] boardArray = new int[48]; // holds index of player's square
        int[] squareXVal = new int[48];
        int[] squareYVal = new int[48];

        bool winner = false;

        Color p1_color = Color.Gold;
        Color p2_color = Color.SteelBlue;
        Color p3_color = Color.Red;
        Color p4_color = Color.White;

        Player p1, p2, p3, p4;
        Player activePlayer;

        public Form1()
        {
            InitializeComponent();
            setUp();
            fillArrays();

            soundOn = Form2.soundOn;
            if (soundOn) { playSound(); }
            else { sound_button.ImageIndex = 0; }
        }

        private void drawCircle(int x, int y, Color color)
        {
            //x and y are the coordinates for the square the piece is in
            
            int diameter = 40;
            Rectangle rec = new Rectangle(x,y,diameter, diameter);
            SolidBrush myBrush = new SolidBrush(color);
            formGraphics = CreateGraphics();
            formGraphics.FillEllipse(myBrush, rec);
            myBrush.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            drawBoard();
            drawPieces();
           

        }

        private void drawPieces()
        {
            //p1 is true coordinates
            //p2 - p4 should have an offset value of 10 for visibility
            // p2 = x+10,y+10
            // p3 = y+10
            // p4 = x+10

            if (p1.isPlaying)
            {
                if (p1.getPoss() < squareXVal.Length) { drawCircle(squareXVal[p1.getPoss()], squareYVal[p1.getPoss()], p1.getColor()); }
            }
            if (p2.isPlaying)
            {
                if (p2.getPoss() < squareXVal.Length) { drawCircle(squareXVal[p2.getPoss()] + 10, squareYVal[p2.getPoss()] + 10, p2.getColor()); }
            }
            if (p3.isPlaying)
            {
                if (p3.getPoss() < squareXVal.Length) { drawCircle(squareXVal[p3.getPoss()], squareYVal[p3.getPoss()] + 10, p3.getColor()); }
            }               
            if (p4.isPlaying)
            {
                if (p4.getPoss() < squareXVal.Length) { drawCircle(squareXVal[p4.getPoss()] + 10, squareYVal[p4.getPoss()], p4.getColor()); }
            }
        }

        private void testArrays()
        {
            fillArrays();

            for(int i = 0; i < 48; i++)
            {
                drawCircle(squareXVal[i], squareYVal[i], Color.Cyan);
            }
            drawCircle(squareXVal[5], squareYVal[5], Color.HotPink);
            drawCircle(squareXVal[42], squareYVal[42], Color.HotPink);
            drawCircle(squareXVal[34], squareYVal[34], Color.HotPink);
            drawCircle(squareXVal[18], squareYVal[18], Color.HotPink);
        }

        private void fillArrays()
        {
            // SQUARES: Start Square is index 0.
            // Lots of magic numbers here. Assuming start is 0, this fills an array
            // with the coordinates of the square. Square number corresponds to index
            // these are hard coded values and shouldn't be altered.

            //filling x and y coords
            int x = 25;
            int y = 550;

            int araPoss;

            squareXVal[0] = x;
            squareYVal[0] = y;

            //first stack
            for(araPoss = 1; araPoss < 11; araPoss++)
            {
                squareYVal[araPoss] = y - (araPoss * 50);
                squareXVal[araPoss] = x;
            }
            y = y - 500;

            //first row
            for (int i = 1; araPoss < 25; i++, araPoss++)
            {
                squareXVal[araPoss] = x + (i * 50);
                squareYVal[araPoss] = y;
            }
            x = x + 700;

            //second stack
            for (int j = 1; araPoss < 35; j++, araPoss++)
            {
                squareYVal[araPoss] = y + (j * 50);
                squareXVal[araPoss] = x;
            }
            y = y + 500;

            //second row
            for (int k = 1; araPoss < 48; k++, araPoss++)
            {
                squareXVal[araPoss] = x - (k * 50);
                squareYVal[araPoss] = y;
            }
        }

        private void setUp()
        {               
            p1 = new Player(1,Form2.p1_isPlaying, Form2.p1_name, 0, p1_color);
            p2 = new Player(2,Form2.p2_isPlaying, Form2.p2_name, 0, p2_color);
            p3 = new Player(3,Form2.p3_isPlaying, Form2.p3_name, 0, p3_color);
            p4 = new Player(4,Form2.p4_isPlaying, Form2.p4_name, 0, p4_color);

            p1_name_score.Text = p1.getName();
            p1_score.Text = "0";

            if (p2.isPlaying) { p2_name_score.Text = p2.getName(); p2_score.Text = "0"; }
            else { p2_name_score.Visible = false; p2_score.Visible = false; }

            if (p3.isPlaying) { p3_name_score.Text = p3.getName(); p3_score.Text = "0"; }
            else { p3_name_score.Visible = false; p3_score.Visible = false; }

            if (p4.isPlaying) { p4_name_score.Text = p4.getName(); p4_score.Text = "0"; }
            else { p4_name_score.Visible = false; p4_score.Visible = false; }

            if(Form2.rollsFirst == 1) { activePlayer = p1; }
            else if (Form2.rollsFirst == 2) { activePlayer = p2; }
            else if (Form2.rollsFirst == 3) { activePlayer = p3; }
            else if (Form2.rollsFirst == 4) { activePlayer = p4; }

            active_player_label.Text = activePlayer.getName() + "'s Turn";

        }

        private void nextPlayer()
        {
            if(activePlayer.getPlayerNum() == Form2.numPlayers)
            {
                activePlayer = p1;
                //hit max, start over/
            }
            else
            {
                if(activePlayer.getPlayerNum() == 1){ activePlayer = p2; }
                else if(activePlayer.getPlayerNum() == 2) { activePlayer = p3; }
                else if (activePlayer.getPlayerNum() == 3) { activePlayer = p4; }
            }
            active_player_label.Text = activePlayer.getName() + "'s Turn";
        }

        private void playSound()
        {
            player.SoundLocation = "Panic_8_bit.wav";
            player.PlayLooping();
            //player.SoundLocation = "Blink_8_bit.wav";
            //player.Play();
        }

        private void roll_button_Click(object sender, EventArgs e)
        {
            Roll();
            roll_prompt.Visible = false;
        }

        private void Roll()
        {
            int die;
            Random random = new Random();
            die = random.Next(1, 6);
            roll_button.ImageIndex = die;

            plus_score_label.Visible = false;

            activePlayer.setPoss(activePlayer.getPoss() + die);
            givePoints();
            if (activePlayer.getPoss() >= squareXVal.Length)
            {
                activePlayer.setPoss(0);
                
                winner = true;
                win();
            }
            else
            {
                nextPlayer();
                this.Invalidate();
            }
        }

        private void givePoints()
        {
            int poss = activePlayer.getPoss();

            if(poss % 3 == 0)
            {
                activePlayer.setScore(activePlayer.getScore() + 3);
                plus_score_label.ForeColor = activePlayer.getColor();
                plus_score_label.Text = "+3";
                plus_score_label.Visible = true;
            }
            if (poss % 5 == 0)
            {
                activePlayer.setScore(activePlayer.getScore() + 5);
                plus_score_label.ForeColor = activePlayer.getColor();
                plus_score_label.Text = "+5";
                plus_score_label.Visible = true;
            }

            if 
                (activePlayer.getPlayerNum() == 1) { p1_score.Text = activePlayer.getScore() + ""; }
            else if (activePlayer.getPlayerNum() == 2) { p2_score.Text = activePlayer.getScore() + ""; }
            else if (activePlayer.getPlayerNum() == 3) { p3_score.Text = activePlayer.getScore() + ""; }
            else if (activePlayer.getPlayerNum() == 4) { p4_score.Text = activePlayer.getScore() + ""; }
        }

        private void win()
        {
            int s1, s2, s3, s4;
            Player winner = p1;
            bool tie = false;

            s1 = p1.getScore();
            s2 = p2.getScore();
            s3 = p3.getScore();
            s4 = p4.getScore();

            if (s1 > s2 && s1 > s3 && s1 > s4)
            {                
                winner = p1;
            }
            else if (s2 > s1 && s2 > s3 && s2 > s4)
            {
                winner = p2;
            }
            else if (s3 > s1 && s3 > s2 && s3 > s4)
            {
                winner = p3;
            }
            else if (s4 > s1 && s4 > s2 && s4 > s3)
            {
                winner = p4;
            }
            else
            {
                tie = true;
            }

            if (!tie)
            {
                active_player_label.Text = winner.getName() + " is the winner!";
            }
            else
            {
                active_player_label.Text = "Tie game!";
            }

            bool replay = false;
            using (Form3 f3 = new Form3())
            {
                f3.ShowDialog();
                replay = f3.replay;
            }

            if (replay)
            {
                setUp();
                plus_score_label.Visible = false;
                this.Invalidate();
            }
            else
            {
                this.Close();
            }
            
        }

        private void drawBoard()
        {
            Color c1 = Color.Black;
            Color c2 = Color.DarkGray;
            Color border = Color.Black;
            
            // Width, Height

            drawStack(11, 25, 50, c1, c2);
            drawRow(14, 75, 50, c2, c1);
            drawStack(10, 725, 100, c2, c1);
            drawRow(14, 75, 550, c2, c1);
            //drawBorder(75,75,550,400,Color.Magenta, false); //inner
            drawBorder(25, 50, 750, 550,border, false); //outer
        }

        private void drawBorder(int x, int y, int w, int h, Color color, bool solid)
        {
            SolidBrush myBrush = new SolidBrush(color);
            Pen myPen = new Pen(color);
            myPen.Width = 6;
            formGraphics = CreateGraphics();
            Rectangle myRec = new Rectangle(x, y, w, h);

            if (solid)
            {
                formGraphics.FillRectangle(myBrush, myRec);
            }
            else
            {
                formGraphics.DrawRectangle(myPen, myRec);
            }          

            myBrush.Dispose();
        }

        private void drawRow(int numSquares, int loc1, int loc2, Color c1, Color c2)
        {
            for (int i = 0; i < numSquares; i++)
            {
                if (i % 2 == 0)
                {
                    drawSquare(c1, loc1, loc2, 50, 50);
                }
                else
                {
                    drawSquare(c2, loc1, loc2, 50, 50);
                }
                loc1 += 50;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void soundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sound_button.ImageIndex.Equals(1)) //sound on
            {
                sound_button.ImageIndex = 0;
                player.Stop();
            }
            else //sound off
            {
                sound_button.ImageIndex = 1;
                playSound();
            }
        }

        private void rollDieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            roll_prompt.Visible = false;
            Roll();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setUp();
            this.Invalidate();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void drawStack(int numSquares, int loc1, int loc2, Color c1, Color c2)
        {
            for (int i = 0; i < numSquares; i++)
            {
                if (i % 2 == 0)
                {
                    drawSquare(c1, loc1, loc2, 50, 50);
                }
                else
                {
                    drawSquare(c2, loc1, loc2, 50, 50);
                }
                loc2 += 50;
            }
        }

        private void drawSquare(Color color, int x, int y, int w, int h)
        {
            SolidBrush myBrush = new SolidBrush(color);
            formGraphics = CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(x,y,w,h));
            myBrush.Dispose();
        }

        private void sound_button_Click(object sender, EventArgs e)
        {
            if (sound_button.ImageIndex.Equals(1)) //sound on
            {
                sound_button.ImageIndex = 0;
                player.Stop();
            }
            else //sound off
            {
                sound_button.ImageIndex = 1;
                playSound();
            }
        }
    }
}
