using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benjamin.RetailPriceCalculator
{
    public partial class Form : ADEV.ACE.RRC.Forms.ActivityFiveForm
    {
        public Form()
        {
            InitializeComponent();

            this.txtWholesaleCost.TextChanged += TxtWholesaleCost_TextChanged;
            this.nudMarkupPercentage.ValueChanged += NudMarkupPercentage_ValueChanged;
            this.btnCalculate.Click += BtnCalculate_Click;
            this.btnClear.Click += BtnClear_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuEditClear.Click += MnuEditClear_Click;
            this.mnuToolsCalculate.Click += MnuToolsCalculate_Click;
            
        }

        private void MnuToolsCalculate_Click(object sender, EventArgs e)
        {
           this.BtnCalculate_Click(sender, e);
        }

        /// <summary>
        /// handles the clear evnt of the menu button clear
        /// </summary>
        private void MnuEditClear_Click(object sender, EventArgs e)
        {
            this.BtnClear_Click(sender, e);
        }

        /// <summary>
        /// handles the menu exit event of the menu exit button
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// handle the clear event of the form
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to clear the form?", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                // Reset the form to its initial state
                txtWholesaleCost.Text = "";
                nudMarkupPercentage.Value = 5;
                lblRetailPrice.Text = "";
            }
            else
            {
                txtWholesaleCost.Focus();
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           
            bool input = decimal.TryParse(txtWholesaleCost.Text, out decimal cost);

            if (!input)
            {
                this.errorProvider.SetError(txtWholesaleCost, "The wholesale cost must be a numeric value");
                this.txtWholesaleCost.Focus();
                this.txtWholesaleCost.SelectAll();
                return;
            }
            if (cost <= 0)
            {
                this.errorProvider.SetError(txtWholesaleCost, "The wholesale cost must be a value grater than zero");
                this.txtWholesaleCost.Focus();
                this.txtWholesaleCost.SelectAll();
                return;

            }
            else
            {
                decimal markupPercentage = nudMarkupPercentage.Value;
                decimal retailPrice = CalculateRetailPrice(cost, markupPercentage);
                lblRetailPrice.Text = retailPrice.ToString("C");
                this.txtWholesaleCost.Focus();
            }
            
        }

        
        /// <summary>
        /// handles when the markup percentage changes 
        /// </summary>
        private void NudMarkupPercentage_ValueChanged(object sender, EventArgs e)
        {
            var input = decimal.TryParse(txtWholesaleCost.Text, out decimal cost);
            decimal markupPercentage = nudMarkupPercentage.Value;
            decimal retailPrice = CalculateRetailPrice(cost, markupPercentage);
            lblRetailPrice.Text = retailPrice.ToString("C");
             

        }

        /// <summary>
        /// method to calculate the retail price
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="markupPercentage"></param>
        /// <returns></returns>
        private decimal CalculateRetailPrice(decimal cost, decimal markupPercentage)
        {
            return cost * (1 + markupPercentage / 100);
        }


        /// <summary>
        /// handles when the whoilesale cost textbox text changes.
        /// </summary>
        private void TxtWholesaleCost_TextChanged(object sender, EventArgs e)
        {
            this.lblRetailPrice.Text = string.Empty;
            this.errorProvider.SetError(this.txtWholesaleCost, string.Empty);
            this.txtWholesaleCost.Focus();
            this.txtWholesaleCost.SelectAll();
        }
    }
}
