using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear the selected item in the group box Food
            groupBoxDelivery.Enabled = false;

            // Clear the selected item in the group box Delivery

            groupBoxDelivery.Enabled = false;

            // Clear the checked item in the groupBox Toppings
            //checkBoxToppingCheese.Checked = false;
            //checkBoxToppingBacon.Checked = false;
            //checkBoxToppingHam.Checked = false;
            //checkBoxToppingOlives.Checked = false;

            groupBoxToppings.Enabled = false;
            listBoxServiceQuality.Enabled = false;

            // Clear the checked item in the listBox

            //listBoxServiceQuality.ClearSelected();

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
            saveFileDialog1.ShowDialog();
            
        }

        private void GetFileName(out string selectedFile)
        {
            if (openFileDialog1.ShowDialog () == DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
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
            }
            else
            {
                groupBoxDelivery.Enabled = false;
                groupBoxToppings.Enabled = false;
                listBoxServiceQuality.Enabled = false;
            }
        }

        private void radioButtonFoodSpaghetti_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFoodSpaghetti.Checked)
            {
                groupBoxDelivery.Enabled = true;
                groupBoxToppings.Enabled = true;
                listBoxServiceQuality.Enabled = true;
            }
            else
            {
                groupBoxDelivery.Enabled = false;
                groupBoxToppings.Enabled = false;
                listBoxServiceQuality.Enabled = false;
            }
        }

        private void radioButtonFoodLasagna_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFoodLasagna.Checked)
            {
                groupBoxDelivery.Enabled = true;
                groupBoxToppings.Enabled = true;
                listBoxServiceQuality.Enabled = true;
            }
            else
            {
                groupBoxDelivery.Enabled = false;
                groupBoxToppings.Enabled = false;
                listBoxServiceQuality.Enabled = false;
            }
        }
    }
}
