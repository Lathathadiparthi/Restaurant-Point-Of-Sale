using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Point_Of_Sale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }


        private void timer1_Tick_2(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void friescb_CheckedChanged(object sender, EventArgs e)
        {
            if (friescb.Checked == true)
                friestb.Enabled = true;
            else
            {
                friestb.Enabled = false;
                friestb.Text = "0";
            }
        }

        private void donutcb_CheckedChanged(object sender, EventArgs e)
        {
            if (donutcb.Checked == true)
                donuttb.Enabled = true;
            else
            {
                donuttb.Enabled = false;
                donuttb.Text = "0";
            }

        }

        private void sandwichcb_CheckedChanged(object sender, EventArgs e)
        {
            if (sandwichcb.Checked == true)
                sandwichtb.Enabled = true;
            else
            {
                sandwichtb.Enabled = false;
                sandwichtb.Text = "0";
            }

        }

        private void pizzacb_CheckedChanged(object sender, EventArgs e)
        {
            if (pizzacb.Checked == true)
                pizzatb.Enabled = true;
            else
            {
                pizzatb.Enabled = false;
                pizzatb.Text = "0";
            }

        }

        private void hotdogcb_CheckedChanged(object sender, EventArgs e)
        {
            if (hotdogcb.Checked == true)
                hotdogtb.Enabled = true;
            else
            {
                hotdogtb.Enabled = false;
                hotdogtb.Text = "0";
            }

        }

        private void burgercb_CheckedChanged(object sender, EventArgs e)
        {
            if (burgercb.Checked == true)
                burgertb.Enabled = true;
            else
            {
                burgertb.Enabled = false;
                burgertb.Text = "0";
            }

        }

        private void icecreamcb_CheckedChanged(object sender, EventArgs e)
        {
            if (icecreamcb.Checked == true)
                icecreamtb.Enabled = true;
            else
            {
                icecreamtb.Enabled = false;
                icecreamtb.Text = "0";
            }

        }

        private void WBcb_CheckedChanged(object sender, EventArgs e)
        {
            if (WBcb.Checked == true)
                WBtb.Enabled = true;
            else
            {
                WBtb.Enabled = false;
                WBtb.Text = "0";
            }

        }

        private void MScb_CheckedChanged(object sender, EventArgs e)
        {
            if (MScb.Checked == true)
                MStb.Enabled = true;
            else
            {
                MStb.Enabled = false;
                MStb.Text = "0";
            }

        }

        private void cakecb_CheckedChanged(object sender, EventArgs e)
        {
            if (cakecb.Checked == true)
                caketb.Enabled = true;
            else
            {
                caketb.Enabled = false;
                caketb.Text = "0";
            }

        }

        private void CCcb_CheckedChanged(object sender, EventArgs e)
        {
            if (CCcb.Checked == true)
                CCtb.Enabled = true;
            else
            {
                CCtb.Enabled = false;
                CCtb.Text = "0";
            }

        }

        private void coffeecb_CheckedChanged(object sender, EventArgs e)
        {
            if (coffeecb.Checked == true)
                coffeetb.Enabled = true;
            else
            {
                coffeetb.Enabled = false;
                coffeetb.Text = "0";
            }

        }
        double friesup = 50, donutup = 45, sandwichup = 75, pizzaup = 150, hotdogup = 45, burgerup = 80,
            icecreamup = 35, WBup = 15, MSup = 50, cakeup = 55, CCup = 30, coffeeup = 35;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipttb.Text + "Subtotal: " + STlbl.Text +"\t\t" + "Tax: " + taxlbl.Text + "\t\t" + "Total: " + totallbl.Text ,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            friescb.Checked = false;
            donutcb.Checked = false;
            sandwichcb.Checked = false;
            pizzacb.Checked = false;
            hotdogcb.Checked = false;
            burgercb.Checked = false;
            icecreamcb.Checked = false;
            WBcb.Checked = false;
            MScb.Checked = false;
            cakecb.Checked = false;
            CCcb.Checked = false;
            coffeecb.Checked = false;
            receipttb.Clear();
            STlbl.Text = "";
            taxlbl.Text = "";
            totallbl.Text = "";
        }

        double friestp, donuttp, sandwichtp, pizzatp, hotdogtp, burgertp, icecreamtp, WBtp, MStp, caketp,
            CCtp, coffeetp;
        double subtotal = 0, Tax, Total;
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(friestb.Text);
            donuttp = donutup * Convert.ToDouble(donuttb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(sandwichtb.Text);
            pizzatp = pizzaup * Convert.ToDouble(pizzatb.Text);
            hotdogtp = hotdogup * Convert.ToDouble(hotdogtb.Text);
            burgertp = burgerup * Convert.ToDouble(burgertb.Text);
            icecreamtp = icecreamup * Convert.ToDouble(icecreamtb.Text);
            WBtp = WBup * Convert.ToDouble(WBtb.Text);
            MStp = MSup * Convert.ToDouble(MStb.Text);
            caketp = cakeup * Convert.ToDouble(caketb.Text);
            CCtp = CCup * Convert.ToDouble(CCtb.Text);
            coffeetp = coffeeup * Convert.ToDouble(coffeetb.Text);

            receipttb.Clear();
            receipttb.AppendText(Environment.NewLine);
            receipttb.AppendText("\t\t\t\t Receipt" + Environment.NewLine);
            receipttb.AppendText("\t **********************************************************************" + Environment.NewLine);

            if(friescb.Checked==true)
            {
                receipttb.AppendText("\t Fries: " + friestp + "/-" + Environment.NewLine);
                subtotal = subtotal + friestp;
            }
            if(donutcb.Checked == true)
            {
                receipttb.AppendText("\t Donut: " + donuttp + "/-" + Environment.NewLine);
                subtotal = subtotal + donuttp;
            }
            if (sandwichcb.Checked == true)
            {
                receipttb.AppendText("\t Sandwich: " + sandwichtp + "/-" + Environment.NewLine);
                subtotal = subtotal + sandwichtp;
            }
            if (pizzacb.Checked == true)
            {
                receipttb.AppendText("\t Pizza: " + pizzatp + "/-" + Environment.NewLine);
                subtotal = subtotal + pizzatp;
            }
            if (hotdogcb.Checked == true)
            {
                receipttb.AppendText("\t Dotdog: " + hotdogtp + "/-" + Environment.NewLine);
                subtotal = subtotal + hotdogtp;
            }
            if (burgercb.Checked == true)
            {
                receipttb.AppendText("\t Burger: " + burgertp + "/-" + Environment.NewLine);
                subtotal = subtotal + burgertp;
            }
            if (icecreamcb.Checked == true)
            {
                receipttb.AppendText("\t Ice Cream: " + icecreamtp + "/-" + Environment.NewLine);
                subtotal = subtotal + icecreamtp;
            }
            if (WBcb.Checked == true)
            {
                receipttb.AppendText("\t Water bottle: " + WBtp + "/-" + Environment.NewLine);
                subtotal = subtotal + WBtp;
            }
            if (MScb.Checked == true)
            {
                receipttb.AppendText("\t Milkshake: " + MStp + "/-" + Environment.NewLine);
                subtotal = subtotal + MStp;
            }
            if (cakecb.Checked == true)
            {
                receipttb.AppendText("\t Cake: " + caketp + "/-" + Environment.NewLine);
                subtotal = subtotal + caketp;
            }
            if (CCcb.Checked == true)
            {
                receipttb.AppendText("\t Cupcake: " + CCtp + "/-" + Environment.NewLine);
                subtotal = subtotal + CCtp;
            }
            if (coffeecb.Checked == true)
            {
                receipttb.AppendText("\t Coffee: " + coffeetp + "/-" + Environment.NewLine);
                subtotal = subtotal + coffeetp;
            }
            STlbl.Text = Convert.ToString(subtotal)+"/-";
            Tax = subtotal * 0.16;
            Total = subtotal + Tax;
            taxlbl.Text = Convert.ToString(Tax) + "/-";
            totallbl.Text = Convert.ToString(Total) + "/-";
            
        }
    }
}

