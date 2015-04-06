namespace MultipleForms
{
    partial class BookingFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combBoxShows = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumPeople = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerShow = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxDrinksService = new System.Windows.Forms.GroupBox();
            this.rdoBtnSoftDrinks = new System.Windows.Forms.RadioButton();
            this.rdoBtnAlcohol = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkBoxLimoService = new System.Windows.Forms.CheckBox();
            this.lblOutDetails = new System.Windows.Forms.Label();
            this.lblOutCost = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPeople)).BeginInit();
            this.grpBoxDrinksService.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeABookingToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // makeABookingToolStripMenuItem
            // 
            this.makeABookingToolStripMenuItem.Name = "makeABookingToolStripMenuItem";
            this.makeABookingToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.makeABookingToolStripMenuItem.Text = "Make a Booking";
            this.makeABookingToolStripMenuItem.Click += new System.EventHandler(this.makeABookingToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.returnToolStripMenuItem.Text = "Log Out";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // combBoxShows
            // 
            this.combBoxShows.FormattingEnabled = true;
            this.combBoxShows.Location = new System.Drawing.Point(193, 134);
            this.combBoxShows.Name = "combBoxShows";
            this.combBoxShows.Size = new System.Drawing.Size(200, 21);
            this.combBoxShows.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shows";
            // 
            // numericUpDownNumPeople
            // 
            this.numericUpDownNumPeople.Location = new System.Drawing.Point(193, 183);
            this.numericUpDownNumPeople.Name = "numericUpDownNumPeople";
            this.numericUpDownNumPeople.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownNumPeople.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of People";
            // 
            // dateTimePickerShow
            // 
            this.dateTimePickerShow.Location = new System.Drawing.Point(193, 235);
            this.dateTimePickerShow.Name = "dateTimePickerShow";
            this.dateTimePickerShow.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerShow.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Show";
            // 
            // grpBoxDrinksService
            // 
            this.grpBoxDrinksService.Controls.Add(this.rdoBtnSoftDrinks);
            this.grpBoxDrinksService.Controls.Add(this.rdoBtnAlcohol);
            this.grpBoxDrinksService.Location = new System.Drawing.Point(528, 179);
            this.grpBoxDrinksService.Name = "grpBoxDrinksService";
            this.grpBoxDrinksService.Size = new System.Drawing.Size(169, 76);
            this.grpBoxDrinksService.TabIndex = 7;
            this.grpBoxDrinksService.TabStop = false;
            this.grpBoxDrinksService.Text = "Drinks service";
            // 
            // rdoBtnSoftDrinks
            // 
            this.rdoBtnSoftDrinks.AutoSize = true;
            this.rdoBtnSoftDrinks.Location = new System.Drawing.Point(7, 44);
            this.rdoBtnSoftDrinks.Name = "rdoBtnSoftDrinks";
            this.rdoBtnSoftDrinks.Size = new System.Drawing.Size(75, 17);
            this.rdoBtnSoftDrinks.TabIndex = 1;
            this.rdoBtnSoftDrinks.TabStop = true;
            this.rdoBtnSoftDrinks.Text = "Soft drinks";
            this.rdoBtnSoftDrinks.UseVisualStyleBackColor = true;
            // 
            // rdoBtnAlcohol
            // 
            this.rdoBtnAlcohol.AutoSize = true;
            this.rdoBtnAlcohol.Location = new System.Drawing.Point(7, 20);
            this.rdoBtnAlcohol.Name = "rdoBtnAlcohol";
            this.rdoBtnAlcohol.Size = new System.Drawing.Size(150, 17);
            this.rdoBtnAlcohol.TabIndex = 0;
            this.rdoBtnAlcohol.TabStop = true;
            this.rdoBtnAlcohol.Text = "Wine, malt, and soft drinks";
            this.rdoBtnAlcohol.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(237, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 37);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "ISIIA BLOCK 1 PROJECT";
            // 
            // chkBoxLimoService
            // 
            this.chkBoxLimoService.AutoSize = true;
            this.chkBoxLimoService.Location = new System.Drawing.Point(528, 130);
            this.chkBoxLimoService.Name = "chkBoxLimoService";
            this.chkBoxLimoService.Size = new System.Drawing.Size(132, 17);
            this.chkBoxLimoService.TabIndex = 9;
            this.chkBoxLimoService.Text = "Limo service required?";
            this.chkBoxLimoService.UseVisualStyleBackColor = true;
            // 
            // lblOutDetails
            // 
            this.lblOutDetails.AutoSize = true;
            this.lblOutDetails.Location = new System.Drawing.Point(41, 302);
            this.lblOutDetails.Name = "lblOutDetails";
            this.lblOutDetails.Size = new System.Drawing.Size(130, 13);
            this.lblOutDetails.TabIndex = 10;
            this.lblOutDetails.Text = "You are here. XXXXXXXX";
            // 
            // lblOutCost
            // 
            this.lblOutCost.AutoSize = true;
            this.lblOutCost.Location = new System.Drawing.Point(41, 348);
            this.lblOutCost.Name = "lblOutCost";
            this.lblOutCost.Size = new System.Drawing.Size(184, 13);
            this.lblOutCost.TabIndex = 11;
            this.lblOutCost.Text = "Here Will Be The Cost including VAT.";
            // 
            // BookingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 389);
            this.Controls.Add(this.lblOutCost);
            this.Controls.Add(this.lblOutDetails);
            this.Controls.Add(this.chkBoxLimoService);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpBoxDrinksService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNumPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combBoxShows);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookingFrm";
            this.Text = "Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPeople)).EndInit();
            this.grpBoxDrinksService.ResumeLayout(false);
            this.grpBoxDrinksService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ComboBox combBoxShows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBoxDrinksService;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkBoxLimoService;
        private System.Windows.Forms.RadioButton rdoBtnSoftDrinks;
        private System.Windows.Forms.RadioButton rdoBtnAlcohol;
        private System.Windows.Forms.Label lblOutDetails;
        private System.Windows.Forms.Label lblOutCost;
    }
}