using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLBL.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateLBL.Text = DateTime.Now.ToLongDateString();
            timer.Start();
        }

        private void dateLBL_Click(object sender, EventArgs e)
        {

        }

        private void friesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCB.Checked == true)
            {
                friesTB.Enabled = true;
            }

            if (friesCB.Checked == false)
            {
                friesTB.Enabled = false;
                friesTB.Text = "0";
            }
        }

        private void burgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerCB.Checked == true)
            {
                burgerTB.Enabled = true;
            }

            if (burgerCB.Checked == false)
            {
                burgerTB.Enabled = false;
                burgerTB.Text = "0";
            }
        }

        private void saladCB_CheckedChanged(object sender, EventArgs e)
        {
            if (saladCB.Checked == true)
            {
                saladTB.Enabled = true;
            }

            if (saladCB.Checked == false)
            {
                saladTB.Enabled = false;
                saladTB.Text = "0";
            }
        }

        private void sandwitchCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sandwitchCB.Checked == true)
            {
                sandwitchTB.Enabled = true;
            }

            if (sandwitchCB.Checked == false)
            {
                sandwitchTB.Enabled = false;
                sandwitchTB.Text = "0";
            }
        }

        private void chickenCB_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenCB.Checked == true)
            {
                chickenTB.Enabled = true;
            }

            if (chickenCB.Checked == false)
            {
                chickenTB.Enabled = false;
                chickenTB.Text = "0";
            }
        }

        private void cheeseCB_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseCB.Checked == true)
            {
                cheeseTB.Enabled = true;
            }

            if (cheeseCB.Checked == false)
            {
                cheeseTB.Enabled = false;
                cheeseTB.Text = "0";
            }
        }

        private void teaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (teaCB.Checked == true)
            {
                teaTB.Enabled = true;
            }

            if (teaCB.Checked == false)
            {
                teaTB.Enabled = false;
                teaTB.Text = "0";
            }
        }

        private void colaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (colaCB.Checked == true)
            {
                colaTB.Enabled = true;
            }

            if (colaCB.Checked == false)
            {
                colaTB.Enabled = false;
                colaTB.Text = "0";
            }
        }

        private void waterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (waterCB.Checked == true)
            {
                waterTB.Enabled = true;
            }

            if (waterCB.Checked == false)
            {
                waterTB.Enabled = false;
                waterTB.Text = "0";
            }
        }

        private void chocolateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (chocolateCB.Checked == true)
            {
                chocolateTB.Enabled = true;
            }

            if (chocolateCB.Checked == false)
            {
                chocolateTB.Enabled = false;
                chocolateTB.Text = "0";
            }
        }

        private void pancakesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (pancakesCB.Checked == true)
            {
                pancakesTB.Enabled = true;
            }

            if (pancakesCB.Checked == false)
            {
                pancakesTB.Enabled = false;
                pancakesTB.Text = "0";
            }
        }

        private void orangeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeCB.Checked == true)
            {
                orangeTB.Enabled = true;
            }

            if (orangeCB.Checked == false)
            {
                orangeTB.Enabled = false;
                orangeTB.Text = "0";
            }
        }

        private void closeLBL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            friesCB.Checked = false;
            burgerCB.Checked = false;
            saladCB.Checked = false;
            sandwitchCB.Checked = false;
            cheeseCB.Checked = false;
            chickenCB.Checked = false;
            teaCB.Checked = false;
            waterCB.Checked = false;
            colaCB.Checked = false;
            chocolateCB.Checked = false;
            orangeCB.Checked = false;

            friesTB.Text = "0";
            burgerTB.Text = "0";
            saladTB.Text = "0";
            sandwitchTB.Text = "0";
            cheeseTB.Text = "0";
            chickenTB.Text = "0";
            teaTB.Text = "0";
            waterTB.Text = "0";
            colaTB.Text = "0";
            chocolateTB.Text = "0";
            pancakesTB.Text = "0";
            orangeTB.Text = "0";

            // Reset subtotal and labels
            subtotal = 0;
            subtotalLBL.Text = "0";
            taxLBL.Text = "0";
            grandtotalLBL.Text = "0";
            receiptTB.Clear();

        }
        // Declare unit price to different meal and drinks
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, cheeseup = 80, chickenup = 120;
        double waterup = 15, teaup = 15, colaup = 25, chocolateup = 25, pancakesup = 30, orangeup = 25;

        // declale variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, chickentp, cheesetp, watertp, teatp, colatp, chocolatetp, pancakestp, orangetp;
        double subtotal = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(friesTB.Text);
            burgertp = burgerup * Convert.ToDouble(burgerTB.Text);
            saladtp = saladup * Convert.ToDouble(saladTB.Text);
            sandwichtp = sandwichup * Convert.ToDouble(sandwitchTB.Text);
            chickentp = chickenup * Convert.ToDouble(chickenTB.Text);
            cheesetp = cheeseup * Convert.ToDouble(cheeseTB.Text);
            watertp = waterup * Convert.ToDouble(waterTB.Text);
            teatp = teaup * Convert.ToDouble(teaTB.Text);
            colatp = colaup * Convert.ToDouble(colaTB.Text);
            chocolatetp = chocolateup * Convert.ToDouble(chocolateTB.Text);
            pancakestp = pancakesup * Convert.ToDouble(pancakesTB.Text);
            orangetp = orangeup * Convert.ToDouble(orangeTB.Text);
            receiptTB.Clear();
            double tax = 0;
            double grdtotal = 0;

            receiptTB.AppendText(Environment.NewLine);
            receiptTB.AppendText("\t\t\tCODESPACE RESTAURENT\t\t" + dateLBL.Text + Environment.NewLine);
            receiptTB.AppendText("\t\t\t****************************" + Environment.NewLine);

            if (friesCB.Checked == true)
            {
                receiptTB.AppendText("\tFries: " + friestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + friestp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (burgerCB.Checked == true)
            {
                receiptTB.AppendText("\tBurger: " + burgertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (saladCB.Checked == true)
            {
                receiptTB.AppendText("\tSalad: " + saladtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + saladtp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (sandwitchCB.Checked == true)
            {
                receiptTB.AppendText("\tSandwitch: " + sandwichtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + sandwichtp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (chickenCB.Checked == true)
            {
                receiptTB.AppendText("\tChicken: " + chickentp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chickentp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (cheeseCB.Checked == true)
            {
                receiptTB.AppendText("\tCheese: " + cheesetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + cheesetp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (teaCB.Checked == true)
            {
                receiptTB.AppendText("\tTea: " + teatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + teatp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (waterCB.Checked == true)
            {
                receiptTB.AppendText("\tWater: " + watertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + watertp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (colaCB.Checked == true)
            {
                receiptTB.AppendText("\tCola: " + colatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + colatp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (chocolateCB.Checked == true)
            {
                receiptTB.AppendText("\tChocolate: " + chocolatetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chocolatetp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (pancakesCB.Checked == true)
            {
                receiptTB.AppendText("\tPancakes: " + pancakestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + pancakestp;
                subtotalLBL.Text = "" + subtotal;
            }
            if (orangeCB.Checked == true)
            {
                receiptTB.AppendText("\tOrange: " + orangetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + orangetp;
                subtotalLBL.Text = "" + subtotal;
            }
            tax = subtotal * 0.16;
            grdtotal = subtotal + tax;

            taxLBL.Text = "Rs" + tax;
            grandtotalLBL.Text = "Rs" + grdtotal;
        }

        private void receiptTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Draw the content you want to print
            e.Graphics.DrawString(receiptTB.Text + "\n" + " Subtotal " +subtotalLBL.Text + " " + "Tax: " + taxLBL.Text + " " + "Grand Total " + grandtotalLBL.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Create PrintDocument object
            PrintDocument printDocument = new PrintDocument();
            // Assign PrintPage event handler
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Create PrintPreviewDialog and set the document to be previewed
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            // Show PrintPreviewDialog
            printPreviewDialog.ShowDialog();
        }
    }
}