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
    public partial class Form1 : Form
    {
        const int COST_PIZZA = 5;
        const int COST_SPAGUETTI = 10;
        const int COST_LASAGNA = 15;
        const int EXTRA_CHEESE = 2;
        const int EXTRA_HAM = 2;
        const int EXTRA_BACON = 2;
        const int EXTRA_OLIVES = 2;
        int total = 0;
        String typeFood = " ";
        public Form1()
        {
            InitializeComponent();
            
        }

        // CheckBox Topping Cheese 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxToppingCheese.Checked)
            {
                total = total + 2;
            }
            else
            {
                total = total;
            }

            
            textBoxPrice.Text = "$ " + total.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

            textBoxPrice.Text = " ";
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Displays the open file dialog box
            //openFileDialog1.ShowDialog();
            String fileName;
            GetFileName(out fileName);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Displays the safe dialog box
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

        private void GetFileName(out string selectedFile)
        {
            String display;
            StreamReader inputFile;
            if (openFileDialog1.ShowDialog () == DialogResult.OK)
            {
                //try
                //{
                    selectedFile = openFileDialog1.FileName;
                    inputFile = File.OpenText(selectedFile);
                    while (!inputFile.EndOfStream)
                    {
                        display = inputFile.ReadLine();
                        MessageBox.Show(display);

                    }

                    inputFile.Close();

                //}
                //catch   (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                    
            }
            else
            {
                selectedFile = " ";
            }
        }

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
        private void clearCheckBox()
        {
            checkBoxToppingCheese.Checked = false;
            checkBoxToppingBacon.Checked = false;
            checkBoxToppingHam.Checked = false;
            checkBoxToppingOlives.Checked = false;
        }

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
