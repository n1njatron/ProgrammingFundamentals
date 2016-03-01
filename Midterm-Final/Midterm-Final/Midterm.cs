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
        int pattyNum;
        string orderstep = " "; // keeps track of current panel

        string bunType = "";
        string cheeseType = "";
        string[] toppings = new string[] {};
        string[] sauce = new string[] {};
        string[] optionsArray = new string[4];

        public MidFinal()
        {
            InitializeComponent();
        }

        //Panels to hide/show when application starts
        private void MidFinal_Load(object sender, EventArgs e)
        {
            

            pnlStart.Visible = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlNavigation.Visible = false;
            pnlBuildPreview.Visible = false;
            pnlSummary.Visible = false;
            pnlSpecialty.Visible = false;
            pnlComplete.Visible = false;

            lblPreview.Text = "";
           
        }

        //Panel visibility changes
        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderstep = "Start";
            }
        }

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderstep = "Location";
            }
        }

        private void pnlOrdertType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderstep = "OrderType";
            }
        }

        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible == true)
            {
                orderstep = "Bun";
                btnNext.Enabled = false;

                if (optionsArray[0] == "")
                {
                    btnNext.Enabled = false;
                }
            }
        }

        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCheese.Visible == true)
            {
                orderstep = "Cheese";
                btnNext.Enabled = false;

                if (optionsArray[1] == "")
                {
                    btnNext.Enabled = false;
                }
            }
        }

        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlToppings.Visible == true)
            {
                orderstep = "Toppings";
            }
        }


        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuild.Visible == true)
            {
                orderstep = "Build";
                
                
            }
            btnNext.Visible = false;
            
        }

        //button click events
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
                    pnlLocation.Visible = true;
                    break;
                case "Build":
                    pnlBuild.Visible = false;
                    pnlLocation.Visible = true;
                    break;
                case "Bun":
                    pnlBun.Visible = false;
                    pnlBuild.Visible = true;
                    break;
                case "Cheese":
                    pnlCheese.Visible = false;
                    pnlBun.Visible = true;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (orderstep)
            {

                case "Build":
                    pnlBuild.Visible = false;
                    pnlBun.Visible = true;
                    break;
                case "Bun":
                    pnlBun.Visible = false;
                    pnlCheese.Visible = true;
                    break;
                case "Cheese":
                    pnlCheese.Visible = false;
                    pnlToppings.Visible = true;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
        }

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
        }

        private void btnBegin_VisibleChanged(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNavigation.Visible = true;
            pnlBuildPreview.Visible = true;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "whiteBun \n";
            lblPreview.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnWheat_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "wheatBun \n";
            lblPreview.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnPotato_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "potatoBun \n";
            lblPreview.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnAmerican_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "American \n";
            lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "Cheddar \n";
            lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }

        private void btnSwiss_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "Swiss \n";
            lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "No Cheese \n";
            lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }


    }
}
