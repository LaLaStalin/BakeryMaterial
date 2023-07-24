using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryMaterial_1620707057
{
    public partial class UserControl_Order : UserControl
    {
        public UserControl_Order()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ImageIndex = 1;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ImageIndex = 0;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ImageIndex = 1;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ImageIndex = 0;
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ImageIndex = 1;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ImageIndex = 0;
        }
    }
}
