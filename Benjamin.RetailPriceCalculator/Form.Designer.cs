namespace Benjamin.RetailPriceCalculator
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkupPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWholesaleCost
            // 
            this.errorProvider.SetIconPadding(this.txtWholesaleCost, 3);
            this.txtWholesaleCost.Text = "";
            this.txtWholesaleCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMarkupPercentage
            // 
            this.nudMarkupPercentage.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMarkupPercentage.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMarkupPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMarkupPercentage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(481, 281);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Retail Price Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkupPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}