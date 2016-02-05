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

        //Declarations
        bool takeOut;
        string bunType = " ";
        int pattyNum;
        string orderstep = " "; // kepps track of current panel

        Array[] cheeseType;
        Array[] toppings;
        Array[] sauce;
        Array[] optionsArray;

        public MidFinal()
        {
            InitializeComponent();
        }

        private void MidFinal_Load(object sender, EventArgs e)
        {
            

            pnlStart.Visible = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = false;
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            orderstep = "Start";
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
            takeOut = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPrevNext.Visible = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            takeOut = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPrevNext.Visible = true;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            switch (orderstep)
            { 
                case "OrderType":
                    pnlOrderType.Visible = false;
                    pnlOrderType.Visible = true;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }
        }

    }
}
