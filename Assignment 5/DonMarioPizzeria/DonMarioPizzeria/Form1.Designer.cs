namespace DonMarioPizzeria
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonFoodPizza = new System.Windows.Forms.RadioButton();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.radioButtonFoodLasagna = new System.Windows.Forms.RadioButton();
            this.radioButtonFoodSpaghetti = new System.Windows.Forms.RadioButton();
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.radioButtonDeliveryInStore = new System.Windows.Forms.RadioButton();
            this.radioButtonDeliveryToGo = new System.Windows.Forms.RadioButton();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxToppingOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxToppingHam = new System.Windows.Forms.CheckBox();
            this.checkBoxToppingBacon = new System.Windows.Forms.CheckBox();
            this.checkBoxToppingCheese = new System.Windows.Forms.CheckBox();
            this.listBoxServiceQuality = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxFood.SuspendLayout();
            this.groupBoxDelivery.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonFoodPizza
            // 
            this.radioButtonFoodPizza.AutoSize = true;
            this.radioButtonFoodPizza.Location = new System.Drawing.Point(49, 58);
            this.radioButtonFoodPizza.Name = "radioButtonFoodPizza";
            this.radioButtonFoodPizza.Size = new System.Drawing.Size(72, 24);
            this.radioButtonFoodPizza.TabIndex = 1;
            this.radioButtonFoodPizza.TabStop = true;
            this.radioButtonFoodPizza.Text = "Pizza";
            this.radioButtonFoodPizza.UseVisualStyleBackColor = true;
            // 
            // groupBoxFood
            // 
            this.groupBoxFood.Controls.Add(this.radioButtonFoodLasagna);
            this.groupBoxFood.Controls.Add(this.radioButtonFoodSpaghetti);
            this.groupBoxFood.Controls.Add(this.radioButtonFoodPizza);
            this.groupBoxFood.Location = new System.Drawing.Point(11, 146);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(174, 246);
            this.groupBoxFood.TabIndex = 2;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Food";
            // 
            // radioButtonFoodLasagna
            // 
            this.radioButtonFoodLasagna.AutoSize = true;
            this.radioButtonFoodLasagna.Location = new System.Drawing.Point(49, 168);
            this.radioButtonFoodLasagna.Name = "radioButtonFoodLasagna";
            this.radioButtonFoodLasagna.Size = new System.Drawing.Size(96, 24);
            this.radioButtonFoodLasagna.TabIndex = 3;
            this.radioButtonFoodLasagna.TabStop = true;
            this.radioButtonFoodLasagna.Text = "Lasagna";
            this.radioButtonFoodLasagna.UseVisualStyleBackColor = true;
            // 
            // radioButtonFoodSpaghetti
            // 
            this.radioButtonFoodSpaghetti.AutoSize = true;
            this.radioButtonFoodSpaghetti.Location = new System.Drawing.Point(49, 116);
            this.radioButtonFoodSpaghetti.Name = "radioButtonFoodSpaghetti";
            this.radioButtonFoodSpaghetti.Size = new System.Drawing.Size(103, 24);
            this.radioButtonFoodSpaghetti.TabIndex = 2;
            this.radioButtonFoodSpaghetti.TabStop = true;
            this.radioButtonFoodSpaghetti.Text = "Spaghetti";
            this.radioButtonFoodSpaghetti.UseVisualStyleBackColor = true;
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Controls.Add(this.radioButtonDeliveryInStore);
            this.groupBoxDelivery.Controls.Add(this.radioButtonDeliveryToGo);
            this.groupBoxDelivery.Location = new System.Drawing.Point(232, 146);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(213, 246);
            this.groupBoxDelivery.TabIndex = 3;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "Delivery";
            // 
            // radioButtonDeliveryInStore
            // 
            this.radioButtonDeliveryInStore.AutoSize = true;
            this.radioButtonDeliveryInStore.Location = new System.Drawing.Point(6, 116);
            this.radioButtonDeliveryInStore.Name = "radioButtonDeliveryInStore";
            this.radioButtonDeliveryInStore.Size = new System.Drawing.Size(91, 24);
            this.radioButtonDeliveryInStore.TabIndex = 1;
            this.radioButtonDeliveryInStore.TabStop = true;
            this.radioButtonDeliveryInStore.Text = "In Store";
            this.radioButtonDeliveryInStore.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeliveryToGo
            // 
            this.radioButtonDeliveryToGo.AutoSize = true;
            this.radioButtonDeliveryToGo.Location = new System.Drawing.Point(6, 58);
            this.radioButtonDeliveryToGo.Name = "radioButtonDeliveryToGo";
            this.radioButtonDeliveryToGo.Size = new System.Drawing.Size(78, 24);
            this.radioButtonDeliveryToGo.TabIndex = 0;
            this.radioButtonDeliveryToGo.TabStop = true;
            this.radioButtonDeliveryToGo.Text = "To Go";
            this.radioButtonDeliveryToGo.UseVisualStyleBackColor = true;
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxToppingOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxToppingHam);
            this.groupBoxToppings.Controls.Add(this.checkBoxToppingBacon);
            this.groupBoxToppings.Controls.Add(this.checkBoxToppingCheese);
            this.groupBoxToppings.Location = new System.Drawing.Point(21, 409);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(235, 150);
            this.groupBoxToppings.TabIndex = 4;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxToppingOlives
            // 
            this.checkBoxToppingOlives.AutoSize = true;
            this.checkBoxToppingOlives.Location = new System.Drawing.Point(149, 108);
            this.checkBoxToppingOlives.Name = "checkBoxToppingOlives";
            this.checkBoxToppingOlives.Size = new System.Drawing.Size(77, 24);
            this.checkBoxToppingOlives.TabIndex = 0;
            this.checkBoxToppingOlives.Text = "Olives";
            this.checkBoxToppingOlives.UseVisualStyleBackColor = true;
            // 
            // checkBoxToppingHam
            // 
            this.checkBoxToppingHam.AutoSize = true;
            this.checkBoxToppingHam.Location = new System.Drawing.Point(149, 51);
            this.checkBoxToppingHam.Name = "checkBoxToppingHam";
            this.checkBoxToppingHam.Size = new System.Drawing.Size(69, 24);
            this.checkBoxToppingHam.TabIndex = 0;
            this.checkBoxToppingHam.Text = "Ham";
            this.checkBoxToppingHam.UseVisualStyleBackColor = true;
            // 
            // checkBoxToppingBacon
            // 
            this.checkBoxToppingBacon.AutoSize = true;
            this.checkBoxToppingBacon.Location = new System.Drawing.Point(8, 108);
            this.checkBoxToppingBacon.Name = "checkBoxToppingBacon";
            this.checkBoxToppingBacon.Size = new System.Drawing.Size(81, 24);
            this.checkBoxToppingBacon.TabIndex = 0;
            this.checkBoxToppingBacon.Text = "Bacon";
            this.checkBoxToppingBacon.UseVisualStyleBackColor = true;
            // 
            // checkBoxToppingCheese
            // 
            this.checkBoxToppingCheese.AutoSize = true;
            this.checkBoxToppingCheese.Location = new System.Drawing.Point(8, 51);
            this.checkBoxToppingCheese.Name = "checkBoxToppingCheese";
            this.checkBoxToppingCheese.Size = new System.Drawing.Size(90, 24);
            this.checkBoxToppingCheese.TabIndex = 0;
            this.checkBoxToppingCheese.Text = "Cheese";
            this.checkBoxToppingCheese.UseVisualStyleBackColor = true;
            this.checkBoxToppingCheese.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBoxServiceQuality
            // 
            this.listBoxServiceQuality.AllowDrop = true;
            this.listBoxServiceQuality.FormattingEnabled = true;
            this.listBoxServiceQuality.ItemHeight = 20;
            this.listBoxServiceQuality.Items.AddRange(new object[] {
            "Very Good",
            "Good",
            "Average"});
            this.listBoxServiceQuality.Location = new System.Drawing.Point(11, 580);
            this.listBoxServiceQuality.Name = "listBoxServiceQuality";
            this.listBoxServiceQuality.Size = new System.Drawing.Size(433, 84);
            this.listBoxServiceQuality.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(275, 460);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(334, 457);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 26);
            this.textBoxPrice.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(502, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 960);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxServiceQuality);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxDelivery);
            this.Controls.Add(this.groupBoxFood);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Don Mario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxFood.ResumeLayout(false);
            this.groupBoxFood.PerformLayout();
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonFoodPizza;
        private System.Windows.Forms.GroupBox groupBoxFood;
        private System.Windows.Forms.RadioButton radioButtonFoodLasagna;
        private System.Windows.Forms.RadioButton radioButtonFoodSpaghetti;
        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.RadioButton radioButtonDeliveryInStore;
        private System.Windows.Forms.RadioButton radioButtonDeliveryToGo;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxToppingOlives;
        private System.Windows.Forms.CheckBox checkBoxToppingHam;
        private System.Windows.Forms.CheckBox checkBoxToppingBacon;
        private System.Windows.Forms.CheckBox checkBoxToppingCheese;
        private System.Windows.Forms.ListBox listBoxServiceQuality;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

