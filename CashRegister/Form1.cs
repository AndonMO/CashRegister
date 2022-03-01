using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class CashRegisterProgram : Form
    {
        double stinkPrice = 1;
        double levitationPrice = 3;
        double speedPrice = 5;
        
        double stinkPotion = 0;
        double levitationPotion = 0;
        double speedPotion = 0;
        double tendered = 0;

        double subtotal = 0;
        double tax = 0;
        double total = 0;
        double change = 0;

       

        public CashRegisterProgram()
        {
            InitializeComponent();
            printButton.Enabled = false;
            changeButton.Enabled = false;
            newOrderButton.Enabled = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            changeButton.Enabled = true;
            
            try
            {
                stinkPrice = Convert.ToDouble(stinkInput.Text) * 1;
                levitationPrice = Convert.ToDouble(levitationInput.Text) * 3;
                speedPrice = Convert.ToDouble(speedInput.Text) * 5;

                subtotal = stinkPrice + levitationPrice + speedPrice;
                tax = subtotal * 0.13;
                total = tax + subtotal;

                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{tax.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch
            {
                stinkInput.Text = $"Only use numbers please";
                levitationInput.Text = $"";
                speedInput.Text = $"";
            }

            }

        private void tenderedButton_Click(object sender, EventArgs e)
        {
            printButton.Enabled = true;
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);

                change = tendered - total;

                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                tenderedInput.Text = $"Tendered Amount Required";
            }
           
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            newOrderButton.Enabled = true;
            
            receiptLabel.Text = $"                   The General Potion Merchant";
            receiptLabel.Text += $"\n\nPOTION ORDER 1";
            receiptLabel.Text += $"\nFEBRUARY 28, 2022";
            receiptLabel.Text += $"\n\nSTINK POTION x{stinkInput.Text}                            {stinkPrice.ToString("C")}";
            receiptLabel.Text += $"\nLEVITATION POTION x{levitationInput.Text}                {levitationPrice.ToString("C")}";
            receiptLabel.Text += $"\nSPEED POTION x{speedInput.Text}                           {speedPrice.ToString("C")}";
            receiptLabel.Text += $"\n\nSUBTOTAL:                                       {subtotal.ToString("C")}";
            receiptLabel.Text += $"\nTAX:                                                      {tax.ToString("C")}";
            receiptLabel.Text += $"\nTOTAL:                                                {total.ToString("C")}";
            receiptLabel.Text += $"\n\nTENDERED:                                       {tendered.ToString("C")}";
            receiptLabel.Text += $"\nCHANGE:                                            {change.ToString("C")}";
            receiptLabel.Text += $"\n\n\n                     HAVE AN AMAZING DAY";





        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = $"";
            stinkInput.Text = $"";
            levitationInput.Text = $"";
            speedInput.Text = $"";
            tenderedInput.Text = $"";
            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            changeOutput.Text = $"";
        }
    }
}
