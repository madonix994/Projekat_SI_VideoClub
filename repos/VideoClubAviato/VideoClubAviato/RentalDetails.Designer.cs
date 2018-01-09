namespace VideoClubAviato
{
    partial class RentalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalDetails));
            this.TextBoxHiddenUserCardSurname1 = new System.Windows.Forms.TextBox();
            this.TextBoxHiddenUserCardName1 = new System.Windows.Forms.TextBox();
            this.listBoxRentalDetails = new System.Windows.Forms.ListBox();
            this.TextBoxHiddenMovieName = new System.Windows.Forms.TextBox();
            this.TextBoxHiddenMovieAmount = new System.Windows.Forms.TextBox();
            this.TextBoxHiddenDateOfReturn = new System.Windows.Forms.TextBox();
            this.buttonMovieReturn = new System.Windows.Forms.Button();
            this.TextBoxHiddenMovieID = new System.Windows.Forms.TextBox();
            this.buttonShowDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxHiddenUserCardSurname1
            // 
            this.TextBoxHiddenUserCardSurname1.Location = new System.Drawing.Point(118, 12);
            this.TextBoxHiddenUserCardSurname1.Name = "TextBoxHiddenUserCardSurname1";
            this.TextBoxHiddenUserCardSurname1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHiddenUserCardSurname1.TabIndex = 0;
            this.TextBoxHiddenUserCardSurname1.Visible = false;
            // 
            // TextBoxHiddenUserCardName1
            // 
            this.TextBoxHiddenUserCardName1.Location = new System.Drawing.Point(12, 12);
            this.TextBoxHiddenUserCardName1.Name = "TextBoxHiddenUserCardName1";
            this.TextBoxHiddenUserCardName1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHiddenUserCardName1.TabIndex = 1;
            this.TextBoxHiddenUserCardName1.Visible = false;
            // 
            // listBoxRentalDetails
            // 
            this.listBoxRentalDetails.FormattingEnabled = true;
            this.listBoxRentalDetails.Location = new System.Drawing.Point(12, 81);
            this.listBoxRentalDetails.Name = "listBoxRentalDetails";
            this.listBoxRentalDetails.Size = new System.Drawing.Size(560, 368);
            this.listBoxRentalDetails.TabIndex = 2;
            this.listBoxRentalDetails.SelectedIndexChanged += new System.EventHandler(this.listBoxRentalDetails_SelectedIndexChanged);
            // 
            // TextBoxHiddenMovieName
            // 
            this.TextBoxHiddenMovieName.Location = new System.Drawing.Point(224, 12);
            this.TextBoxHiddenMovieName.Name = "TextBoxHiddenMovieName";
            this.TextBoxHiddenMovieName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHiddenMovieName.TabIndex = 3;
            this.TextBoxHiddenMovieName.Visible = false;
            // 
            // TextBoxHiddenMovieAmount
            // 
            this.TextBoxHiddenMovieAmount.Location = new System.Drawing.Point(330, 13);
            this.TextBoxHiddenMovieAmount.Name = "TextBoxHiddenMovieAmount";
            this.TextBoxHiddenMovieAmount.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHiddenMovieAmount.TabIndex = 4;
            this.TextBoxHiddenMovieAmount.Visible = false;
            // 
            // TextBoxHiddenDateOfReturn
            // 
            this.TextBoxHiddenDateOfReturn.Location = new System.Drawing.Point(436, 13);
            this.TextBoxHiddenDateOfReturn.Name = "TextBoxHiddenDateOfReturn";
            this.TextBoxHiddenDateOfReturn.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHiddenDateOfReturn.TabIndex = 5;
            this.TextBoxHiddenDateOfReturn.Visible = false;
            // 
            // buttonMovieReturn
            // 
            this.buttonMovieReturn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonMovieReturn.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonMovieReturn.Location = new System.Drawing.Point(342, 12);
            this.buttonMovieReturn.Name = "buttonMovieReturn";
            this.buttonMovieReturn.Size = new System.Drawing.Size(121, 53);
            this.buttonMovieReturn.TabIndex = 6;
            this.buttonMovieReturn.Text = "Vrati Film";
            this.buttonMovieReturn.UseVisualStyleBackColor = false;
            this.buttonMovieReturn.Click += new System.EventHandler(this.buttonMovieReturn_Click);
            // 
            // TextBoxHiddenMovieID
            // 
            this.TextBoxHiddenMovieID.Location = new System.Drawing.Point(224, 38);
            this.TextBoxHiddenMovieID.Name = "TextBoxHiddenMovieID";
            this.TextBoxHiddenMovieID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHiddenMovieID.TabIndex = 7;
            this.TextBoxHiddenMovieID.Visible = false;
            // 
            // buttonShowDetails
            // 
            this.buttonShowDetails.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonShowDetails.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonShowDetails.Location = new System.Drawing.Point(118, 13);
            this.buttonShowDetails.Name = "buttonShowDetails";
            this.buttonShowDetails.Size = new System.Drawing.Size(156, 53);
            this.buttonShowDetails.TabIndex = 8;
            this.buttonShowDetails.Text = "Prikazi Detalje";
            this.buttonShowDetails.UseVisualStyleBackColor = false;
            this.buttonShowDetails.Click += new System.EventHandler(this.buttonShowDetails_Click);
            // 
            // RentalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonShowDetails);
            this.Controls.Add(this.TextBoxHiddenMovieID);
            this.Controls.Add(this.buttonMovieReturn);
            this.Controls.Add(this.TextBoxHiddenDateOfReturn);
            this.Controls.Add(this.TextBoxHiddenMovieAmount);
            this.Controls.Add(this.TextBoxHiddenMovieName);
            this.Controls.Add(this.listBoxRentalDetails);
            this.Controls.Add(this.TextBoxHiddenUserCardName1);
            this.Controls.Add(this.TextBoxHiddenUserCardSurname1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 120);
            this.Name = "RentalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RentalDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalDetails_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextBoxHiddenUserCardSurname1;
        public System.Windows.Forms.TextBox TextBoxHiddenUserCardName1;
        private System.Windows.Forms.ListBox listBoxRentalDetails;
        public System.Windows.Forms.TextBox TextBoxHiddenMovieName;
        public System.Windows.Forms.TextBox TextBoxHiddenMovieAmount;
        public System.Windows.Forms.TextBox TextBoxHiddenDateOfReturn;
        private System.Windows.Forms.Button buttonMovieReturn;
        public System.Windows.Forms.TextBox TextBoxHiddenMovieID;
        private System.Windows.Forms.Button buttonShowDetails;
    }
}