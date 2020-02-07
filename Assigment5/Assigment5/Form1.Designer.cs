namespace Assigment5
{
    partial class FormPapayon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPapayon));
            this.radioButtonPizza = new System.Windows.Forms.RadioButton();
            this.radioButtonSpaghetti = new System.Windows.Forms.RadioButton();
            this.radioButtonLasagna = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelService = new System.Windows.Forms.Label();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelPizzeria = new System.Windows.Forms.Label();
            this.groupBoxTopings = new System.Windows.Forms.GroupBox();
            this.checkBoxPeperonni = new System.Windows.Forms.CheckBox();
            this.checkBoxBacon = new System.Windows.Forms.CheckBox();
            this.checkBoxCheese = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxDelivery.SuspendLayout();
            this.groupBoxFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxTopings.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonPizza
            // 
            this.radioButtonPizza.AutoSize = true;
            this.radioButtonPizza.Location = new System.Drawing.Point(6, 39);
            this.radioButtonPizza.Name = "radioButtonPizza";
            this.radioButtonPizza.Size = new System.Drawing.Size(96, 29);
            this.radioButtonPizza.TabIndex = 2;
            this.radioButtonPizza.TabStop = true;
            this.radioButtonPizza.Text = "Pizza";
            this.radioButtonPizza.UseVisualStyleBackColor = true;
            this.radioButtonPizza.CheckedChanged += new System.EventHandler(this.radioButtonPizza_CheckedChanged);
            // 
            // radioButtonSpaghetti
            // 
            this.radioButtonSpaghetti.AutoSize = true;
            this.radioButtonSpaghetti.Location = new System.Drawing.Point(6, 74);
            this.radioButtonSpaghetti.Name = "radioButtonSpaghetti";
            this.radioButtonSpaghetti.Size = new System.Drawing.Size(127, 29);
            this.radioButtonSpaghetti.TabIndex = 3;
            this.radioButtonSpaghetti.TabStop = true;
            this.radioButtonSpaghetti.Text = "Espageti";
            this.radioButtonSpaghetti.UseVisualStyleBackColor = true;
            this.radioButtonSpaghetti.CheckedChanged += new System.EventHandler(this.radioButtonSpaghetti_CheckedChanged);
            // 
            // radioButtonLasagna
            // 
            this.radioButtonLasagna.AutoSize = true;
            this.radioButtonLasagna.Location = new System.Drawing.Point(6, 110);
            this.radioButtonLasagna.Name = "radioButtonLasagna";
            this.radioButtonLasagna.Size = new System.Drawing.Size(126, 29);
            this.radioButtonLasagna.TabIndex = 4;
            this.radioButtonLasagna.TabStop = true;
            this.radioButtonLasagna.Text = "Lasagna";
            this.radioButtonLasagna.UseVisualStyleBackColor = true;
            this.radioButtonLasagna.CheckedChanged += new System.EventHandler(this.radioButtonLasagna_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(6, 46);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(81, 29);
            this.radioButtonYes.TabIndex = 6;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(108, 46);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(70, 29);
            this.radioButtonNo.TabIndex = 7;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(338, 757);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(127, 25);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Total Price: ";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(471, 754);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(191, 31);
            this.textBoxPrice.TabIndex = 14;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(26, 815);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(157, 25);
            this.labelService.TabIndex = 15;
            this.labelService.Text = "Service Quality";
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.ItemHeight = 25;
            this.listBoxService.Items.AddRange(new object[] {
            "Excellent",
            "Normal",
            "Bad"});
            this.listBoxService.Location = new System.Drawing.Point(31, 843);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(231, 79);
            this.listBoxService.TabIndex = 16;
            this.listBoxService.SelectedIndexChanged += new System.EventHandler(this.listBoxService_SelectedIndexChanged);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(196, 944);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 72);
            this.buttonOpen.TabIndex = 27;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(523, 944);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 72);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(31, 944);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 72);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(682, 944);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(139, 72);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Controls.Add(this.radioButtonYes);
            this.groupBoxDelivery.Controls.Add(this.radioButtonNo);
            this.groupBoxDelivery.Location = new System.Drawing.Point(265, 445);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(200, 157);
            this.groupBoxDelivery.TabIndex = 21;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "Delivery";
            // 
            // groupBoxFood
            // 
            this.groupBoxFood.Controls.Add(this.radioButtonSpaghetti);
            this.groupBoxFood.Controls.Add(this.radioButtonPizza);
            this.groupBoxFood.Controls.Add(this.radioButtonLasagna);
            this.groupBoxFood.Location = new System.Drawing.Point(12, 426);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(235, 193);
            this.groupBoxFood.TabIndex = 22;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Food";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assigment5.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(471, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Assigment5.Properties.Resources.papayon_jpg;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(453, 398);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelPizzeria
            // 
            this.labelPizzeria.AutoSize = true;
            this.labelPizzeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzeria.Location = new System.Drawing.Point(471, 94);
            this.labelPizzeria.Name = "labelPizzeria";
            this.labelPizzeria.Size = new System.Drawing.Size(224, 51);
            this.labelPizzeria.TabIndex = 25;
            this.labelPizzeria.Text = "PIZZERIA";
            // 
            // groupBoxTopings
            // 
            this.groupBoxTopings.Controls.Add(this.checkBoxOlives);
            this.groupBoxTopings.Controls.Add(this.checkBoxBacon);
            this.groupBoxTopings.Controls.Add(this.checkBoxCheese);
            this.groupBoxTopings.Controls.Add(this.checkBoxPeperonni);
            this.groupBoxTopings.Location = new System.Drawing.Point(18, 625);
            this.groupBoxTopings.Name = "groupBoxTopings";
            this.groupBoxTopings.Size = new System.Drawing.Size(297, 157);
            this.groupBoxTopings.TabIndex = 23;
            this.groupBoxTopings.TabStop = false;
            this.groupBoxTopings.Text = "Topings";
            // 
            // checkBoxPeperonni
            // 
            this.checkBoxPeperonni.AutoSize = true;
            this.checkBoxPeperonni.Location = new System.Drawing.Point(13, 55);
            this.checkBoxPeperonni.Name = "checkBoxPeperonni";
            this.checkBoxPeperonni.Size = new System.Drawing.Size(137, 29);
            this.checkBoxPeperonni.TabIndex = 28;
            this.checkBoxPeperonni.Text = "Peperone";
            this.checkBoxPeperonni.UseVisualStyleBackColor = true;
            this.checkBoxPeperonni.CheckedChanged += new System.EventHandler(this.checkBoxPeperonni_CheckedChanged);
            // 
            // checkBoxBacon
            // 
            this.checkBoxBacon.AutoSize = true;
            this.checkBoxBacon.Location = new System.Drawing.Point(193, 55);
            this.checkBoxBacon.Name = "checkBoxBacon";
            this.checkBoxBacon.Size = new System.Drawing.Size(105, 29);
            this.checkBoxBacon.TabIndex = 29;
            this.checkBoxBacon.Text = "Bacon";
            this.checkBoxBacon.UseVisualStyleBackColor = true;
            this.checkBoxBacon.CheckedChanged += new System.EventHandler(this.checkBoxBacon_CheckedChanged);
            // 
            // checkBoxCheese
            // 
            this.checkBoxCheese.AutoSize = true;
            this.checkBoxCheese.Location = new System.Drawing.Point(13, 90);
            this.checkBoxCheese.Name = "checkBoxCheese";
            this.checkBoxCheese.Size = new System.Drawing.Size(174, 29);
            this.checkBoxCheese.TabIndex = 30;
            this.checkBoxCheese.Text = "Extra Cheese";
            this.checkBoxCheese.UseVisualStyleBackColor = true;
            this.checkBoxCheese.CheckedChanged += new System.EventHandler(this.checkBoxCheese_CheckedChanged);
            // 
            // checkBoxOlives
            // 
            this.checkBoxOlives.AutoSize = true;
            this.checkBoxOlives.Location = new System.Drawing.Point(193, 90);
            this.checkBoxOlives.Name = "checkBoxOlives";
            this.checkBoxOlives.Size = new System.Drawing.Size(104, 29);
            this.checkBoxOlives.TabIndex = 31;
            this.checkBoxOlives.Text = "Olives";
            this.checkBoxOlives.UseVisualStyleBackColor = true;
            this.checkBoxOlives.CheckedChanged += new System.EventHandler(this.checkBoxOlives_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormPapayon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(842, 1046);
            this.Controls.Add(this.labelPizzeria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxTopings);
            this.Controls.Add(this.groupBoxFood);
            this.Controls.Add(this.groupBoxDelivery);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.listBoxService);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPapayon";
            this.Text = "Papayon";
            this.Load += new System.EventHandler(this.FormPapayon_Load);
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.groupBoxFood.ResumeLayout(false);
            this.groupBoxFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxTopings.ResumeLayout(false);
            this.groupBoxTopings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton radioButtonPizza;
        private System.Windows.Forms.RadioButton radioButtonSpaghetti;
        private System.Windows.Forms.RadioButton radioButtonLasagna;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.GroupBox groupBoxFood;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPizzeria;
        private System.Windows.Forms.GroupBox groupBoxTopings;
        private System.Windows.Forms.CheckBox checkBoxPeperonni;
        private System.Windows.Forms.CheckBox checkBoxBacon;
        private System.Windows.Forms.CheckBox checkBoxCheese;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

