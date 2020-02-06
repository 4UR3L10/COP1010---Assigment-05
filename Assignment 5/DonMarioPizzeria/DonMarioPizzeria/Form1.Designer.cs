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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.radioButtonFoodPizza.Text = "Pizza";
            this.radioButtonFoodPizza.UseVisualStyleBackColor = true;
            this.radioButtonFoodPizza.CheckedChanged += new System.EventHandler(this.radioButtonFoodPizza_CheckedChanged);
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
            this.groupBoxFood.Enter += new System.EventHandler(this.groupBoxFood_Enter);
            // 
            // radioButtonFoodLasagna
            // 
            this.radioButtonFoodLasagna.AutoSize = true;
            this.radioButtonFoodLasagna.Location = new System.Drawing.Point(49, 168);
            this.radioButtonFoodLasagna.Name = "radioButtonFoodLasagna";
            this.radioButtonFoodLasagna.Size = new System.Drawing.Size(96, 24);
            this.radioButtonFoodLasagna.TabIndex = 3;
            this.radioButtonFoodLasagna.Text = "Lasagna";
            this.radioButtonFoodLasagna.UseVisualStyleBackColor = true;
            this.radioButtonFoodLasagna.CheckedChanged += new System.EventHandler(this.radioButtonFoodLasagna_CheckedChanged);
            // 
            // radioButtonFoodSpaghetti
            // 
            this.radioButtonFoodSpaghetti.AutoSize = true;
            this.radioButtonFoodSpaghetti.Location = new System.Drawing.Point(49, 116);
            this.radioButtonFoodSpaghetti.Name = "radioButtonFoodSpaghetti";
            this.radioButtonFoodSpaghetti.Size = new System.Drawing.Size(103, 24);
            this.radioButtonFoodSpaghetti.TabIndex = 2;
            this.radioButtonFoodSpaghetti.Text = "Spaghetti";
            this.radioButtonFoodSpaghetti.UseVisualStyleBackColor = true;
            this.radioButtonFoodSpaghetti.CheckedChanged += new System.EventHandler(this.radioButtonFoodSpaghetti_CheckedChanged);
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Controls.Add(this.radioButtonDeliveryInStore);
            this.groupBoxDelivery.Controls.Add(this.radioButtonDeliveryToGo);
            this.groupBoxDelivery.Enabled = false;
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
            this.groupBoxToppings.Enabled = false;
            this.groupBoxToppings.Location = new System.Drawing.Point(21, 409);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(235, 150);
            this.groupBoxToppings.TabIndex = 1;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            this.groupBoxToppings.Enter += new System.EventHandler(this.groupBoxToppings_Enter);
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
            this.checkBoxToppingOlives.CheckedChanged += new System.EventHandler(this.checkBoxToppingOlives_CheckedChanged);
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
            this.checkBoxToppingHam.CheckedChanged += new System.EventHandler(this.checkBoxToppingHam_CheckedChanged);
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
            this.checkBoxToppingBacon.CheckedChanged += new System.EventHandler(this.checkBoxToppingBacon_CheckedChanged);
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
            this.listBoxServiceQuality.Enabled = false;
            this.listBoxServiceQuality.FormattingEnabled = true;
            this.listBoxServiceQuality.ItemHeight = 20;
            this.listBoxServiceQuality.Items.AddRange(new object[] {
            "Very Good",
            "Good",
            "Average",
            "Poor",
            "Very Poor"});
            this.listBoxServiceQuality.Location = new System.Drawing.Point(11, 580);
            this.listBoxServiceQuality.Name = "listBoxServiceQuality";
            this.listBoxServiceQuality.Size = new System.Drawing.Size(444, 104);
            this.listBoxServiceQuality.TabIndex = 5;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(502, 350);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(86, 42);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "&Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(275, 460);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(334, 457);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 26);
            this.textBoxPrice.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(502, 438);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 42);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(502, 517);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 42);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(502, 593);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 42);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "order1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(675, 960);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
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
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

