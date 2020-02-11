using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DonMarioPizzeria
{
    public partial class FormMain : Form
    {
        // Constant variables that store the values of the cost of the foods and extras
        const int COST_PIZZA = 5;
        const int COST_SPAGUETTI = 10;
        const int COST_LASAGNA = 15;
        
        int total = 0;
        String typeFood = " ";
        public FormMain()
        {
            InitializeComponent();
            
        }

        // CheckBox Topping Cheese 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //If topping is selected adds 2 to the total
            if (checkBoxToppingCheese.Checked)
            {
                total = total + 2;
            }
            else
            {
                total = total;
            }

            //Displays the value of total in the texteBoxPRice
            textBoxPrice.Text = "$ " + total.ToString();
        }
        /*
         * 1.- Exits the program
         */
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * 1.- Clears all the data input or clicked
         */
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear the selected item in the group box Food
            groupBoxDelivery.Enabled = false;
            radioButtonFoodPizza.Checked = false;
            radioButtonFoodLasagna.Checked = false;
            radioButtonFoodSpaghetti.Checked = false;

            // Clear the selected item in the group box Delivery

            groupBoxDelivery.Enabled = false;

            // Clear the checked item in the groupBox Toppings
            checkBoxToppingCheese.Checked = false;
            checkBoxToppingBacon.Checked = false;
            checkBoxToppingHam.Checked = false;
            checkBoxToppingOlives.Checked = false;

            groupBoxToppings.Enabled = false;
            listBoxServiceQuality.Enabled = false;

            // Clear the checked item in the listBox

            listBoxServiceQuality.ClearSelected();

            buttonSave.Enabled = false;
            textBoxPrice.Text = " ";
        }

        /*
         * 1.- The button opens a selected file
         * 
         */
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Displays the open file dialog box
            //openFileDialog1.ShowDialog();
            String fileName;
            GetFileName(out fileName);
        }

        /*
         * 1. The button save stores the values of a string in a txt file
         */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Displays the save dialog box
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog1.ShowDialog();
            String filename = " ";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {
                filename = saveFileDialog1.FileName;
                StreamWriter outputFile;
                outputFile = File.CreateText(filename);
                outputFile.WriteLine("Order Information : Your " + typeFood + " , your total is : " + total.ToString());
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Operation Cancelled ");
            }

        }
        /*
         * 1. Get the file name pre-stablished by the user
         */
        private void GetFileName(out string selectedFile)
        {
            String display;
            StreamReader inputFile;
            if (openFileDialog1.ShowDialog () == DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
                string check =  openFileDialog1.ToString();
                try
                {
                    
                    inputFile = File.OpenText(selectedFile);
                    if (check.Contains(".txt"))
                    {
                        while (!inputFile.EndOfStream )
                        {
                        display = inputFile.ReadLine();
                        MessageBox.Show(display);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong File....");
                    }

                    inputFile.Close();

                }
                catch
                {
                    MessageBox.Show("Wrong File....");
                }
                    
            }
            else
            {
                selectedFile = " ";
            }
        }
        /*
         * 1.- If any element of the group box is click, the group box delivery is enabled
         */
        private void groupBoxFood_Enter(object sender, EventArgs e)
        {
            if (radioButtonFoodPizza.Checked == true || radioButtonFoodLasagna.Checked == true || radioButtonFoodLasagna.Checked == true)
            {
                groupBoxDelivery.Enabled = true;
                
            }
            else
            {
                groupBoxDelivery.Enabled = false;
            }

            

        }
        /*
         * 1.- Determines if the radio button pizza is clicked
         * 2.- Enables certain group of boxes , listboxes, and the button save
         * 3.- Displays the value of the pizza
         * 4.- Adds the value to the total
         */
        private void radioButtonFoodPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFoodPizza.Checked)
            {
                groupBoxDelivery.Enabled = true;
                groupBoxToppings.Enabled = true;
                listBoxServiceQuality.Enabled = true;
                buttonSave.Enabled = true;
                typeFood = " Pizza is $ 5";

                textBoxPrice.Text = "$ " + COST_PIZZA.ToString();
                total = total + COST_PIZZA;
            }
            else
            {
                groupBoxDelivery.Enabled = false;
                groupBoxToppings.Enabled = false;
                listBoxServiceQuality.Enabled = false;

                textBoxPrice.Text = " ";
                total = 0;
            }

            // Clear the checkBoxes when the user changes a radiobutton
            clearCheckBox();
        }
        /*
         * 1.- Determines if the radio button spaguetti is clicked
         * 2.- Enables certain group of boxes , listboxes, and the button save
         * 3.- Displays the value of the pizza
         * 4.- Adds the value to the total
         */
        private void radioButtonFoodSpaghetti_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFoodSpaghetti.Checked)
            {
                groupBoxDelivery.Enabled = true;
                groupBoxToppings.Enabled = true;
                listBoxServiceQuality.Enabled = true;
                buttonSave.Enabled = true;

                typeFood = " Spaguetti is $ 10";

                textBoxPrice.Text = "$ " + COST_SPAGUETTI.ToString();
                total = total + COST_SPAGUETTI;
            }
            else
            {
                groupBoxDelivery.Enabled = false;
                groupBoxToppings.Enabled = false;
                listBoxServiceQuality.Enabled = false;
                textBoxPrice.Text = " ";
                total = 0;
            }

            // Clear the checkBoxes when the user changes a radiobutton
            clearCheckBox();
        }
        /*
         * 1.- Determines if the radio button lasagna is clicked
         * 2.- Enables certain group of boxes , listboxes, and the button save
         * 3.- Displays the value of the pizza
         * 4.- Adds the value to the total
         */
        private void radioButtonFoodLasagna_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFoodLasagna.Checked)
            {
                groupBoxDelivery.Enabled = true;
                groupBoxToppings.Enabled = true;
                listBoxServiceQuality.Enabled = true;
                buttonSave.Enabled = true;

                typeFood = " Lasagna is $ 15";

                textBoxPrice.Text = "$ " + COST_LASAGNA.ToString();
                total = total + COST_LASAGNA;
            }
            else
            {
                groupBoxDelivery.Enabled = false;
                groupBoxToppings.Enabled = false;
                listBoxServiceQuality.Enabled = false;

                textBoxPrice.Text = " ";
                total = 0;
            }

            // Clear the checkBoxes when the user changes a radiobutton
            clearCheckBox();
        }

        private void groupBoxToppings_Enter(object sender, EventArgs e)
        {
            
        }
        /*
         * 1.- Determines if the checkbox bacon is clicked
         * 2.- Adds the value assigned to the total
         * 3.- Displays the total value
         */
        private void checkBoxToppingBacon_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxToppingBacon.Checked)
            {
                total = total + 2;
            }
            else
            {
                total = total;
            }


            textBoxPrice.Text = "$ " + total.ToString();
        }

        /*
         * 1.- Method that clears the bellow mentioned checkboxes
         */
        private void clearCheckBox()
        {
            checkBoxToppingCheese.Checked = false;
            checkBoxToppingBacon.Checked = false;
            checkBoxToppingHam.Checked = false;
            checkBoxToppingOlives.Checked = false;
        }

        /*
         * 1.- Determines if the checkbox ham is clicked
         * 2.- Adds the value assigned to the total
         * 3.- Displays the total value
         */
        private void checkBoxToppingHam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxToppingHam.Checked)
            {
                total = total + 2;
            }
            else
            {
                total = total;
            }


            textBoxPrice.Text = "$ " + total.ToString();
        }

        /*
         * 1.- Determines if the checkbox olives is clicked
         * 2.- Adds the value assigned to the total
         * 3.- Displays the total value
         */
        private void checkBoxToppingOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxToppingOlives.Checked)
            {
                total = total + 2;
            }
            else
            {
                total = total;
            }


            textBoxPrice.Text = "$ " + total.ToString();
        }
    }
}
