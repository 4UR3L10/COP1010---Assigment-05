using System;
using System.IO;
using System.Windows.Forms;

namespace Assigment5
{
    public partial class FormPapayon : Form
    {
        // Variable declarations 
        const double PIZZA = 5.00;
        const double PASTA = 10.00;
        const double LASAGNA = 15.00;

        const double TOPPINGS = 2.00;
        String outputToFile = " ";

        double totalPrice = 0.0;


        /*
         * GUI Initiallizer
         */
        public FormPapayon()
        {
            InitializeComponent();
            // Initiallizing components to false so user must choose between one of the options.

            groupBoxDelivery.Enabled = false;
            checkBoxOlives.Checked = false;
            checkBoxPeperonni.Checked = false;
            checkBoxCheese.Checked = false;
            checkBoxCheese.Checked = false;
        }
        /*
         * Method that reset toppings 
         */
        private void resetAllTopings ()
        {
            checkBoxOlives.Checked = false;
            checkBoxPeperonni.Checked = false;
            checkBoxCheese.Checked = false;
            checkBoxCheese.Checked = false;
        }
        /*
         * Method that enables topings
         */
        private void enableTopings()
        {
            checkBoxOlives.Checked = true;
            checkBoxPeperonni.Checked = true;
            checkBoxCheese.Checked = true;
            checkBoxCheese.Checked = true;
        }
        /*
         * Yes delivery (10 more)
         */
        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked == true)
            {
                totalPrice = totalPrice + 10.00;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
        }
        /*
         * No delivery
         */
        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked == true)
            {
                totalPrice = totalPrice - 10.00;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
        }

        private void listBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
         * Button that exit the program.
         */
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*
         *  Uncheking all radio buttons. 
         */
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Food
            radioButtonLasagna.Checked = false;
            radioButtonPizza.Checked = false;
            radioButtonSpaghetti.Checked = false;
            // Extras
            resetAllTopings();
            //Delivery
            radioButtonNo.Checked = false;
            radioButtonYes.Checked = false;

            // Price reset
            totalPrice = 0.0;
            textBoxPrice.Text = null;

            // Output clear
            outputToFile = " ";
            
        }
        /*
         * Radio Button Pizza Cubana 
         */
        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            // Enabling Delivery and Topings options after user chooses "Pizza".
            groupBoxDelivery.Enabled = true;
            enableTopings();
            buttonSave.Enabled = true;

            // Reset all topings method.
            resetAllTopings();

            totalPrice = PIZZA;
            textBoxPrice.Text = '$' + PIZZA.ToString();

            // Print to File
            outputToFile = "Your pizza is $" + PIZZA.ToString();
        }

        /*
          * Radio Button Pasta  
          */
        private void radioButtonSpaghetti_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDelivery.Enabled = true;
            enableTopings();
            buttonSave.Enabled = true;

            // Reset all topings method.
            resetAllTopings();

            totalPrice = PASTA;
            textBoxPrice.Text = '$' + PASTA.ToString();

            // Print to file
            outputToFile = "Your pasta was $ " + PASTA.ToString();
        }
        /*
         * Radio Button Lasagna 
         */
        private void radioButtonLasagna_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDelivery.Enabled = true;

            enableTopings();

            buttonSave.Enabled = true;

            // Reset all topings method.
            resetAllTopings();

            totalPrice = LASAGNA;
            textBoxPrice.Text = '$' + LASAGNA.ToString();

            // Print to file
            outputToFile = "Your lasagna was $ " + LASAGNA.ToString();
        }


        /*
         * Check Box Topping Peperone 
         */
        private void checkBoxPeperonni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPeperonni.Checked == true)
            {
                totalPrice = totalPrice + TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
            else
            {
                totalPrice = totalPrice - TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
        }
        /*
         * Check Box Topping Bacon 
         */
        private void checkBoxBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBacon.Checked == true)
            {
                totalPrice = totalPrice + TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
            else
            {
                totalPrice = totalPrice - TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
        }
        /*
         * Check Box Topping Cheese 
         */
        private void checkBoxCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheese.Checked == true)
            {
                totalPrice = totalPrice + TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
            else
            {
                totalPrice = totalPrice - TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
        }

        private void FormPapayon_Load(object sender, EventArgs e)
        {

        }
        /*
         * Check Box Topping Olives 
         */
        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOlives.Checked == true)
            {
                totalPrice = totalPrice + TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
            else
            {
                totalPrice = totalPrice - TOPPINGS;
                textBoxPrice.Text = '$' + totalPrice.ToString();
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        /*
         * Button that saves file
         */
        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter output = new StreamWriter(saveFileDialog1.OpenFile());

                output.WriteLine("Your order: " + outputToFile + " for a total of: $" + totalPrice);
                output.Dispose();
                output.Close();
            }
            else
            {
                MessageBox.Show("You canceled!");
            }
        }
        /*
         * Button that open file
         * (Not sure que hice aca pero bueno)
         */
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader input;
                input = File.OpenText(openFileDialog1.FileName);

                if (!openFileDialog1.ToString().Contains(".txt")) 
                {
                    MessageBox.Show("Not a text File");

                }
                else
                {
                    MessageBox.Show("No se pq esto no funciona. :'(");
                   // MessageBox.Show(openFileDialog1.ReadLine());
                }

                //openFileDialog1.Close();

            }
            else
            {
                MessageBox.Show("You canceled");
            }

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
