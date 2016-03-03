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
    public partial class BurgerApp : Form
    {

        //Declarations
        bool takeOut;
        int pattyNum;
        string orderstep = " "; // keeps track of current panel

        string bunType = "";
        string cheeseType = "";
        string[] toppings = new string[] { };
        string[] sauce = new string[] { };
        public string[] optionsArray = new string[4];

        public BurgerApp()
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
                case "ordertype":
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
                case "Toppings":
                    pnlToppings.Visible = false;
                    pnlCheese.Visible = true;
                    break;
                case "Sauce":
                    pnlSauce.Visible = false;
                    pnlToppings.Visible = true;
                    break;
                case "Summary":
                    pnlSummary.Visible = false;
                    pnlSauce.Visible = true;
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
                case "Location":
                    pnlLocation.Visible = false;
                    pnlOrderType.Visible = true;
                    break;
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
                case "Toppings":
                    pnlToppings.Visible = false;
                    pnlSauce.Visible = true;
                    break;
                case "Sauce":
                    pnlSauce.Visible = false;
                    pnlSummary.Visible = true;
                    break;
                case "Summary":
                    pnlStart.Visible = false;
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
                    pnlComplete.Visible = true;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }
        }


        //Panel visibility changes
        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderstep = "ordertype";
            }
        }

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderstep = "Location";
            }
        }

        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderstep = "Start";
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
                btnNext.Enabled = false;

                if (optionsArray[2] == "")
                {
                    btnNext.Enabled = false;
                }
            }
        }

        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSauce.Visible == true)
            {
                orderstep = "Sauce";
                btnNext.Enabled = false;

                if (optionsArray[3] == "")
                {
                    btnNext.Enabled = false;
                }
            }
        }

        private void pnlBuildPreview_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuildPreview.Visible == true)
            {
                if (takeOut == false)
                {
                    lblPreviewLocation.Text = "Dine-In";
                }
                else
                {
                    lblPreviewLocation.Text = "Take-out";
                }
            }
        }

        private void pnlSummary_VisibleChanged(object sender, EventArgs e)
        {
            orderstep = "Summary";
            lblSummaryList.Text = lblPreview.Text;
            lblSummaryLocation.Text = lblPreviewLocation.Text;
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

        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuild.Visible == true)
            {
                orderstep = "Build";

            }
            btnNext.Visible = false;

        }

        private void btnBegin_VisibleChanged(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNavigation.Visible = true;
            pnlBuildPreview.Visible = true;
        }

        //Bun Buttons
        private void btnWhite_Click(object sender, EventArgs e)
        {
            //optionsArray[0] = "whiteBun \n";
            //lblPreview.Text = optionsArray[0];
            //btnNext.Enabled = true;

            string bunType = Bun.createBun("whiteBun \n");
            optionsArray[0] = bunType;
            build();
            //lblPreview.Text = optionsArray[0];
            btnNext.Enabled = true;

        }

        private void btnWheat_Click(object sender, EventArgs e)
        {
            //optionsArray[0] = "wheatBun \n";
            //lblPreview.Text = optionsArray[0]; 

            string bunType = Bun.createBun("wheatBun \n");
            optionsArray[0] = bunType;
            build();
            //lblPreview.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnPotato_Click(object sender, EventArgs e)
        {
            //optionsArray[0] = "potatoBun \n";
            //lblPreview.Text = optionsArray[0];
            //btnNext.Enabled = true;

            string bunType = Bun.createBun("potatoBun \n");
            optionsArray[0] = bunType;
            build();
            //lblPreview.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        //Cheese buttons
        private void btnAmerican_Click(object sender, EventArgs e)
        {
            //optionsArray[1] = "American \n";

            string cheeseType = Cheese.selectCheese("American \n");
            optionsArray[1] = cheeseType;
            build();
            //lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
            //optionsArray[1] = "Cheddar \n";

            string cheeseType = Cheese.selectCheese("Cheddar \n");
            optionsArray[1] = cheeseType;
            build();
            //lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }

        private void btnSwiss_Click(object sender, EventArgs e)
        {
            //optionsArray[1] = "Swiss \n";
            string cheeseType = Cheese.selectCheese("Swiss \n");
            optionsArray[1] = cheeseType;
            build();
            //lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            //optionsArray[1] = "No Cheese \n";
            string cheeseType = Cheese.selectCheese("No Cheese \n");
            optionsArray[1] = cheeseType;
            build();
            //lblPreview.Text += optionsArray[1];
            btnNext.Enabled = true;
        }

        //Topping buttons
        private void btnTomato_Click(object sender, EventArgs e)
        {
            string toppingChoice = Toppings.selectToppings("Tomato \n");
            AssembleToppings(toppingChoice);
        }

        private void btnOnions_Click(object sender, EventArgs e)
        {
            string toppingChoice = Toppings.selectToppings("Onions \n");
            AssembleToppings(toppingChoice);
        }

        private void btnPickles_Click(object sender, EventArgs e)
        {
            string toppingChoice = Toppings.selectToppings("Pickles \n");
            AssembleToppings(toppingChoice);
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            string toppingChoice = Toppings.selectToppings("Lettuce \n");
            AssembleToppings(toppingChoice);
        }

        private void AssembleToppings(string selectedToppings)
        {
            optionsArray[2] += selectedToppings;
            build();
            btnNext.Enabled = true;
        }

        //Sauce buttons
        private void btnKetchup_Click(object sender, EventArgs e)
        {
            string sauceChoices = Sauce.selectSauces("Ketchup \n");
            AssembleSauce(sauceChoices);
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            string sauceChoices = Sauce.selectSauces("Mustard \n");
            AssembleSauce(sauceChoices);
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            string sauceChoices = Sauce.selectSauces("Mayo \n");
            AssembleSauce(sauceChoices);
        }

        private void AssembleSauce(string chosenSauce)
        {
            optionsArray[3] += chosenSauce;
            build();
            btnNext.Enabled = true;
        }

        private void btnMacSauce_Click(object sender, EventArgs e)
        {
            //optionsArray[3] = "Big Mac Sauce \n";
            string sauceChoices = Sauce.selectSauces("Big Mac Sauce \n");
            optionsArray[3] += sauceChoices;
            build();
            //lblPreview.Text += optionsArray[3];
            btnNext.Enabled = true;
        }

        // For navigation buttons on top
        private void btnNavBun_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = true;
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlNavigation.Visible = true;
            pnlBuildPreview.Visible = true;
            pnlSummary.Visible = false;
            pnlSpecialty.Visible = false;
            pnlComplete.Visible = false;

            orderstep = "Sauce";
        }

        private void btnNavCheese_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = true;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = true;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlNavigation.Visible = true;
            pnlBuildPreview.Visible = true;
            pnlSummary.Visible = false;
            pnlSpecialty.Visible = false;
            pnlComplete.Visible = false;

            orderstep = "Sauce";
        }

        private void btnNavToppings_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = true;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = true;
            pnlSauce.Visible = false;
            pnlNavigation.Visible = true;
            pnlBuildPreview.Visible = true;
            pnlSummary.Visible = false;
            pnlSpecialty.Visible = false;
            pnlComplete.Visible = false;

            optionsArray[2] = "";
            orderstep = "Sauce";
        }

        private void btnNavSauce_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = true;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = true;
            pnlNavigation.Visible = true;
            pnlBuildPreview.Visible = true;
            pnlSummary.Visible = false;
            pnlSpecialty.Visible = false;
            pnlComplete.Visible = false;

            optionsArray[3] = "";
            orderstep = "Sauce";
        }

        private void btnSummaryLocationChange_Click(object sender, EventArgs e)
        {
            if (lblPreviewLocation.Text == "Dine-In")
            {
                lblPreviewLocation.Text = "Take-out";
                lblSummaryLocation.Text = "Take-out";
            }

            else
            {
                lblPreviewLocation.Text = "Dine-in";
                lblSummaryLocation.Text = "Dine-in";
            }

        }

        private void build()
        {
            lblPreview.Text = optionsArray[0] +
                              optionsArray[1] +
                              optionsArray[2] +
                              optionsArray[3];
        }

        private void build2()
        {
            lblPreview.Text += optionsArray[0];
        }

        private void btnComplete_Click(object sender, EventArgs e)
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

            optionsArray[0] = "";
            optionsArray[1] = "";
            optionsArray[2] = "";
            optionsArray[3] = "";
        }

        
        }
    }


