namespace VideoClubAviato
{
    partial class RentalPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDateOfRental = new System.Windows.Forms.TextBox();
            this.listBoxRentals = new System.Windows.Forms.ListBox();
            this.buttonUpdateRental = new System.Windows.Forms.Button();
            this.buttonInsertRental = new System.Windows.Forms.Button();
            this.Printer = new System.Windows.Forms.PictureBox();
            this.Document = new System.Drawing.Printing.PrintDocument();
            this.Preview = new System.Windows.Forms.PrintPreviewDialog();
            this.textBoxDateOfReturn = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxRentalSearch = new System.Windows.Forms.TextBox();
            this.buttonRentalSearch = new System.Windows.Forms.Button();
            this.comboBoxUserCardName = new System.Windows.Forms.ComboBox();
            this.comboBoxMovieName = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxDateOfRental
            // 
            this.textBoxDateOfRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateOfRental.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateOfRental.Location = new System.Drawing.Point(665, 289);
            this.textBoxDateOfRental.Name = "textBoxDateOfRental";
            this.textBoxDateOfRental.Size = new System.Drawing.Size(175, 32);
            this.textBoxDateOfRental.TabIndex = 89;
            this.textBoxDateOfRental.Leave += new System.EventHandler(this.textBoxDateOfRental_Leave);
            // 
            // listBoxRentals
            // 
            this.listBoxRentals.FormattingEnabled = true;
            this.listBoxRentals.Location = new System.Drawing.Point(10, 163);
            this.listBoxRentals.Name = "listBoxRentals";
            this.listBoxRentals.Size = new System.Drawing.Size(460, 485);
            this.listBoxRentals.TabIndex = 83;
            // 
            // buttonUpdateRental
            // 
            this.buttonUpdateRental.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdateRental.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRental.Location = new System.Drawing.Point(243, 84);
            this.buttonUpdateRental.Name = "buttonUpdateRental";
            this.buttonUpdateRental.Size = new System.Drawing.Size(137, 56);
            this.buttonUpdateRental.TabIndex = 81;
            this.buttonUpdateRental.Text = "Izmeni Rezervaciju";
            this.buttonUpdateRental.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateRental.UseVisualStyleBackColor = false;
            this.buttonUpdateRental.Click += new System.EventHandler(this.buttonUpdateRental_Click);
            this.buttonUpdateRental.MouseHover += new System.EventHandler(this.buttonUpdateRental_MouseHover);
            // 
            // buttonInsertRental
            // 
            this.buttonInsertRental.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInsertRental.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertRental.Location = new System.Drawing.Point(69, 84);
            this.buttonInsertRental.Name = "buttonInsertRental";
            this.buttonInsertRental.Size = new System.Drawing.Size(137, 56);
            this.buttonInsertRental.TabIndex = 80;
            this.buttonInsertRental.Text = "Unesi Rezervaciju";
            this.buttonInsertRental.UseVisualStyleBackColor = false;
            this.buttonInsertRental.Click += new System.EventHandler(this.buttonInsertRental_Click);
            this.buttonInsertRental.MouseHover += new System.EventHandler(this.buttonInsertRental_MouseHover);
            // 
            // Printer
            // 
            this.Printer.Image = ((System.Drawing.Image)(resources.GetObject("Printer.Image")));
            this.Printer.Location = new System.Drawing.Point(800, 12);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(40, 40);
            this.Printer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Printer.TabIndex = 95;
            this.Printer.TabStop = false;
            this.Printer.Click += new System.EventHandler(this.Printer_Click);
            // 
            // Document
            // 
            this.Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Document_PrintPage);
            // 
            // Preview
            // 
            this.Preview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Preview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Preview.ClientSize = new System.Drawing.Size(400, 300);
            this.Preview.Document = this.Document;
            this.Preview.Enabled = true;
            this.Preview.Icon = ((System.Drawing.Icon)(resources.GetObject("Preview.Icon")));
            this.Preview.Name = "Preview";
            this.Preview.Visible = false;
            // 
            // textBoxDateOfReturn
            // 
            this.textBoxDateOfReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateOfReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateOfReturn.Location = new System.Drawing.Point(665, 341);
            this.textBoxDateOfReturn.Name = "textBoxDateOfReturn";
            this.textBoxDateOfReturn.Size = new System.Drawing.Size(175, 32);
            this.textBoxDateOfReturn.TabIndex = 96;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(488, 510);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(490, 626);
            this.progressBar1.MarqueeAnimationSpeed = 99;
            this.progressBar1.Maximum = 99;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.Step = 33;
            this.progressBar1.TabIndex = 100;
            // 
            // textBoxRentalSearch
            // 
            this.textBoxRentalSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRentalSearch.Location = new System.Drawing.Point(522, 510);
            this.textBoxRentalSearch.Name = "textBoxRentalSearch";
            this.textBoxRentalSearch.Size = new System.Drawing.Size(311, 32);
            this.textBoxRentalSearch.TabIndex = 99;
            this.textBoxRentalSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRentalSearch
            // 
            this.buttonRentalSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRentalSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRentalSearch.Location = new System.Drawing.Point(486, 549);
            this.buttonRentalSearch.Name = "buttonRentalSearch";
            this.buttonRentalSearch.Size = new System.Drawing.Size(356, 56);
            this.buttonRentalSearch.TabIndex = 98;
            this.buttonRentalSearch.Text = "Pretrazi";
            this.buttonRentalSearch.UseVisualStyleBackColor = false;
            this.buttonRentalSearch.Click += new System.EventHandler(this.buttonRentalSearch_Click);
            this.buttonRentalSearch.MouseHover += new System.EventHandler(this.buttonRentalSearch_MouseHover);
            // 
            // comboBoxUserCardName
            // 
            this.comboBoxUserCardName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserCardName.FormattingEnabled = true;
            this.comboBoxUserCardName.Location = new System.Drawing.Point(665, 184);
            this.comboBoxUserCardName.Name = "comboBoxUserCardName";
            this.comboBoxUserCardName.Size = new System.Drawing.Size(175, 32);
            this.comboBoxUserCardName.TabIndex = 102;
            this.comboBoxUserCardName.Leave += new System.EventHandler(this.comboBoxUserCardName_Leave);
            // 
            // comboBoxMovieName
            // 
            this.comboBoxMovieName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMovieName.FormattingEnabled = true;
            this.comboBoxMovieName.Location = new System.Drawing.Point(665, 239);
            this.comboBoxMovieName.Name = "comboBoxMovieName";
            this.comboBoxMovieName.Size = new System.Drawing.Size(175, 32);
            this.comboBoxMovieName.TabIndex = 103;
            this.comboBoxMovieName.Leave += new System.EventHandler(this.comboBoxMovieName_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(202, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(501, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 104;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(481, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(359, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 105;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(495, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 106;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(495, 183);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 107;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(495, 288);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 108;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(495, 340);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 109;
            this.pictureBox8.TabStop = false;
            // 
            // RentalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 661);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.comboBoxMovieName);
            this.Controls.Add(this.comboBoxUserCardName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxRentalSearch);
            this.Controls.Add(this.buttonRentalSearch);
            this.Controls.Add(this.textBoxDateOfReturn);
            this.Controls.Add(this.Printer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDateOfRental);
            this.Controls.Add(this.listBoxRentals);
            this.Controls.Add(this.buttonUpdateRental);
            this.Controls.Add(this.buttonInsertRental);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimumSize = new System.Drawing.Size(870, 700);
            this.Name = "RentalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDateOfRental;
        private System.Windows.Forms.ListBox listBoxRentals;
        private System.Windows.Forms.Button buttonUpdateRental;
        private System.Windows.Forms.Button buttonInsertRental;
        private System.Windows.Forms.PictureBox Printer;
        private System.Drawing.Printing.PrintDocument Document;
        private System.Windows.Forms.PrintPreviewDialog Preview;
        private System.Windows.Forms.TextBox textBoxDateOfReturn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxRentalSearch;
        private System.Windows.Forms.Button buttonRentalSearch;
        private System.Windows.Forms.ComboBox comboBoxUserCardName;
        private System.Windows.Forms.ComboBox comboBoxMovieName;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}