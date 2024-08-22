using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel(
                    prizeNameTextBox.Text,
                    prizeNumberTextBox.Text,
                    prizeAmountTextBox.Text,
                    prizePercentageTextBox.Text);

                GlobalConfig.Connection.CreatePrize(prizeModel);
                
                callingForm.PrizeComplete(prizeModel);

                this.Close();

                //prizeNumberTextBox.Text = "";
                //prizeNameTextBox.Text = "";
                //prizeAmountTextBox.Text = "0";
                //prizePercentageTextBox.Text = "0";
            }
        }

        private bool ValidateForm()
        {
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(prizeNumberTextBox.Text, out placeNumber);

            if (!placeNumberValidNumber || placeNumber < 1)
            {
                return false;
            }
            
            if (prizeNameTextBox.Text.Length == 0)
            {
                return false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                return false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                return false;
            }

            if (prizePercentage < 0 || prizePercentage >= 100)
            {
                return false;
            }

            return true;
        }
    }
}
