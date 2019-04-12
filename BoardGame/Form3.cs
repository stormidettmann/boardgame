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
    public partial class Form3 : Form
    {
        public bool replay = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public bool getReplay()
        {
            return this.replay;
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            replay = true;
            this.Close();
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            replay = false;
            this.Close();
        }
    }
}
