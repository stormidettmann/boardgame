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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The following were used in the project are the property of other organizations: \n\n'Space Quest' image from Florence Baptist: TN.\n\nMusic Track:\n'I Write Sins Not Tragedies' Panic! At the Disco,\ntranslated to 8 bit by 8 Bit Universe", "Credits");
        }
    }
}
