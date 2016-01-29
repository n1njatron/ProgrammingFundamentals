using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Midterm_Final
{
    public partial class MidFinal : Form
    {
        public MidFinal()
        {
            InitializeComponent();
        }

        private void MidFinal_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            label1.Text = "Button Clicked!";
        }

    }
}
