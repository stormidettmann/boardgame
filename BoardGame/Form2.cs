using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class Form2 : Form
    {
        public static int rollsFirst = 1;
        public static string p1_name, p2_name, p3_name, p4_name;
        public static bool p1_isPlaying = true;
        public static bool p2_isPlaying, p3_isPlaying, p4_isPlaying;
        public static bool soundOn;
        public static bool openForm = false;

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                p2_textbox.Enabled = true;
                checkBox3.Enabled = true;
                
            }
            else
            {
                p2_textbox.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                p3_textbox.Enabled = false;
                p4_textbox.Enabled = false;
                checkBox4.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                p2_textbox.Enabled = true;
                p3_textbox.Enabled = true;
                checkBox4.Enabled = true;
            }
            else
            {
                p4_textbox.Enabled = false;
                p3_textbox.Enabled = false;
                checkBox4.Enabled = false;
                checkBox4.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                p4_textbox.Enabled = true;
            }
            else
            {
                p4_textbox.Enabled = false;
                checkBox4.Checked = false;
            }
        }

        public static int numPlayers = 1;
       

        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grabData();
            openForm = true;
            this.Close();
        }


        private void grabData()
        {
            //set all variables
            
            //TODO Validate all this input!
            p1_name = p1_textbox.Text;
            p2_name = p2_textbox.Text;
            p3_name = p3_textbox.Text;
            p4_name = p4_textbox.Text;

            if (p1_name.Length > 8) { p1_name = p1_name.Substring(0, 8); }
            if (p2_name.Length > 8) { p2_name = p2_name.Substring(0, 8); }
            if (p3_name.Length > 8) { p3_name = p3_name.Substring(0, 8); }
            if (p4_name.Length > 8) { p4_name = p4_name.Substring(0, 8); }

            p2_isPlaying = checkBox2.Checked;
            p3_isPlaying = checkBox3.Checked;
            p4_isPlaying = checkBox4.Checked;

            if (radioButton1.Checked) { soundOn = true; }
            else { soundOn = false; } //defaults to false

            if (p2_isPlaying) { numPlayers++; }
            if (p3_isPlaying) { numPlayers++; }
            if (p4_isPlaying) { numPlayers++; }

            rollsFirst = comboBox1.SelectedIndex;
            if (rollsFirst == 0)
            {              
                Random random = new Random();
                rollsFirst = random.Next(1, numPlayers);
            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
