namespace MegaDesk_Poe1
{
    partial class AddQuote
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.ViewAllQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calcWidth = new System.Windows.Forms.TextBox();
            this.calcDepth = new System.Windows.Forms.TextBox();
            this.SACAnswer = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CalculateTSA = new System.Windows.Forms.Button();
            this.TSA = new System.Windows.Forms.Label();
            this.numOfDrawers = new System.Windows.Forms.ComboBox();
            this.priceOfDrawers = new System.Windows.Forms.Label();
            this.materialSelection = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.findTotalPrice = new System.Windows.Forms.Button();
            this.priceOfMaterials = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rushOrderPrice = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(12, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(103, 23);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.ViewAllQuotes.Location = new System.Drawing.Point(12, 41);
            this.ViewAllQuotes.Name = "ViewAllQuotes";
            this.ViewAllQuotes.Size = new System.Drawing.Size(103, 23);
            this.ViewAllQuotes.TabIndex = 1;
            this.ViewAllQuotes.Text = "View All Quotes";
            this.ViewAllQuotes.UseVisualStyleBackColor = true;
            this.ViewAllQuotes.Click += new System.EventHandler(this.ViewAllQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Location = new System.Drawing.Point(12, 70);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(103, 23);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base Desk Price (Service Charge)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desktop Surface Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(In Inches Squared)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number Of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Surface Materials";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rush Order For Available For An Additional Fee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "$200.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Surface Area Calculator";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Depth (In Feet)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Width (In Feet)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "(2 Feet Is Standard)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "(4 Feet Is Standard)";
            // 
            // calcWidth
            // 
            this.calcWidth.Location = new System.Drawing.Point(168, 313);
            this.calcWidth.Name = "calcWidth";
            this.calcWidth.Size = new System.Drawing.Size(109, 20);
            this.calcWidth.TabIndex = 16;
            this.calcWidth.UseWaitCursor = true;
            this.calcWidth.TextChanged += new System.EventHandler(this.CalcWidth_TextChanged);
            this.calcWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcWidth_KeyPress);
            // 
            // calcDepth
            // 
            this.calcDepth.Location = new System.Drawing.Point(168, 364);
            this.calcDepth.Name = "calcDepth";
            this.calcDepth.Size = new System.Drawing.Size(109, 20);
            this.calcDepth.TabIndex = 17;
            this.calcDepth.UseWaitCursor = true;
            this.calcDepth.TextChanged += new System.EventHandler(this.CalcDepth_TextChanged);
            this.calcDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcDepth_KeyPress);
            // 
            // SACAnswer
            // 
            this.SACAnswer.AutoSize = true;
            this.SACAnswer.Location = new System.Drawing.Point(174, 428);
            this.SACAnswer.Name = "SACAnswer";
            this.SACAnswer.Size = new System.Drawing.Size(99, 13);
            this.SACAnswer.TabIndex = 18;
            this.SACAnswer.Text = "Total Surface Area:";
            this.SACAnswer.TextChanged += new System.EventHandler(this.SACAnswer_TextChanged);
            this.SACAnswer.Click += new System.EventHandler(this.SACAnswer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 19;
            // 
            // CalculateTSA
            // 
            this.CalculateTSA.Location = new System.Drawing.Point(168, 390);
            this.CalculateTSA.Name = "CalculateTSA";
            this.CalculateTSA.Size = new System.Drawing.Size(109, 23);
            this.CalculateTSA.TabIndex = 20;
            this.CalculateTSA.Text = "Calculate";
            this.CalculateTSA.UseVisualStyleBackColor = true;
            this.CalculateTSA.Click += new System.EventHandler(this.CalculateTSA_Click);
            // 
            // TSA
            // 
            this.TSA.AutoSize = true;
            this.TSA.Location = new System.Drawing.Point(397, 46);
            this.TSA.Name = "TSA";
            this.TSA.Size = new System.Drawing.Size(96, 13);
            this.TSA.TabIndex = 21;
            this.TSA.Text = "Total Surface Area";
            this.TSA.Click += new System.EventHandler(this.TSA_Click);
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.FormattingEnabled = true;
            this.numOfDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.numOfDrawers.Location = new System.Drawing.Point(271, 77);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(121, 21);
            this.numOfDrawers.TabIndex = 22;
            this.numOfDrawers.Text = "Number Of Drawers";
            this.numOfDrawers.SelectedIndexChanged += new System.EventHandler(this.numOfDrawers_SelectedIndexChanged);
            // 
            // priceOfDrawers
            // 
            this.priceOfDrawers.AutoSize = true;
            this.priceOfDrawers.Location = new System.Drawing.Point(397, 80);
            this.priceOfDrawers.Name = "priceOfDrawers";
            this.priceOfDrawers.Size = new System.Drawing.Size(105, 13);
            this.priceOfDrawers.TabIndex = 23;
            this.priceOfDrawers.Text = "Price Of Drawers: $0";
            this.priceOfDrawers.TextChanged += new System.EventHandler(this.priceOfDrawers_TextChanged);
            this.priceOfDrawers.Click += new System.EventHandler(this.priceOfDrawers_Click);
            // 
            // materialSelection
            // 
            this.materialSelection.FormattingEnabled = true;
            this.materialSelection.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialSelection.Location = new System.Drawing.Point(271, 103);
            this.materialSelection.Name = "materialSelection";
            this.materialSelection.Size = new System.Drawing.Size(121, 21);
            this.materialSelection.TabIndex = 24;
            this.materialSelection.Text = "Select Materail";
            this.materialSelection.SelectedIndexChanged += new System.EventHandler(this.materialSelection_SelectedIndexChanged);
            this.materialSelection.TabIndexChanged += new System.EventHandler(this.materialSelection_TabIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(333, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total Price:";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(397, 428);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(13, 13);
            this.totalPrice.TabIndex = 26;
            this.totalPrice.Text = "0";
            this.totalPrice.Click += new System.EventHandler(this.totalPrice_Click);
            // 
            // findTotalPrice
            // 
            this.findTotalPrice.Location = new System.Drawing.Point(336, 390);
            this.findTotalPrice.Name = "findTotalPrice";
            this.findTotalPrice.Size = new System.Drawing.Size(107, 23);
            this.findTotalPrice.TabIndex = 27;
            this.findTotalPrice.Text = "Find Total Price";
            this.findTotalPrice.UseVisualStyleBackColor = true;
            this.findTotalPrice.Click += new System.EventHandler(this.findTotalPrice_Click);
            // 
            // priceOfMaterials
            // 
            this.priceOfMaterials.AutoSize = true;
            this.priceOfMaterials.Location = new System.Drawing.Point(397, 106);
            this.priceOfMaterials.Name = "priceOfMaterials";
            this.priceOfMaterials.Size = new System.Drawing.Size(108, 13);
            this.priceOfMaterials.TabIndex = 28;
            this.priceOfMaterials.Text = "Price Of Materials: $0";
            this.priceOfMaterials.Click += new System.EventHandler(this.priceOfMaterials_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Ranging From $30 - $80";
            // 
            // rushOrderPrice
            // 
            this.rushOrderPrice.AutoSize = true;
            this.rushOrderPrice.Location = new System.Drawing.Point(397, 136);
            this.rushOrderPrice.Name = "rushOrderPrice";
            this.rushOrderPrice.Size = new System.Drawing.Size(106, 13);
            this.rushOrderPrice.TabIndex = 30;
            this.rushOrderPrice.Text = "Rush Order Price: $0";
            // 
            // rushOrder
            // 
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.rushOrder.Location = new System.Drawing.Point(289, 150);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(103, 21);
            this.rushOrder.TabIndex = 31;
            this.rushOrder.Text = "Rush Order Days";
            this.rushOrder.SelectedIndexChanged += new System.EventHandler(this.rushOrder_SelectedIndexChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.rushOrderPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.priceOfMaterials);
            this.Controls.Add(this.findTotalPrice);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.materialSelection);
            this.Controls.Add(this.priceOfDrawers);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.TSA);
            this.Controls.Add(this.CalculateTSA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SACAnswer);
            this.Controls.Add(this.calcDepth);
            this.Controls.Add(this.calcWidth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewAllQuotes);
            this.Controls.Add(this.MainMenu);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button ViewAllQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox calcWidth;
        private System.Windows.Forms.TextBox calcDepth;
        private System.Windows.Forms.Label SACAnswer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button CalculateTSA;
        private System.Windows.Forms.Label TSA;
        private System.Windows.Forms.ComboBox numOfDrawers;
        private System.Windows.Forms.Label priceOfDrawers;
        private System.Windows.Forms.ComboBox materialSelection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button findTotalPrice;
        private System.Windows.Forms.Label priceOfMaterials;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label rushOrderPrice;
        private System.Windows.Forms.ComboBox rushOrder;
    }
}