namespace VideoClubAviato
{
    partial class UserCardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCardPage));
            this.buttonInsertUserCard = new System.Windows.Forms.Button();
            this.buttonUpdateUserCard = new System.Windows.Forms.Button();
            this.buttonDeleteUserCard = new System.Windows.Forms.Button();
            this.listBoxUserCards = new System.Windows.Forms.ListBox();
            this.textBoxUserCardPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxUserCardAddress = new System.Windows.Forms.TextBox();
            this.textBoxUserCardSurname = new System.Windows.Forms.TextBox();
            this.textBoxUserCardName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxUserCardSearch = new System.Windows.Forms.TextBox();
            this.buttonUserCardSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsertUserCard
            // 
            this.buttonInsertUserCard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInsertUserCard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertUserCard.Location = new System.Drawing.Point(12, 85);
            this.buttonInsertUserCard.Name = "buttonInsertUserCard";
            this.buttonInsertUserCard.Size = new System.Drawing.Size(137, 56);
            this.buttonInsertUserCard.TabIndex = 2;
            this.buttonInsertUserCard.Text = "Unesi Korisnika";
            this.buttonInsertUserCard.UseVisualStyleBackColor = false;
            this.buttonInsertUserCard.Click += new System.EventHandler(this.buttonInsertUserCard_Click);
            this.buttonInsertUserCard.MouseHover += new System.EventHandler(this.buttonInsertUserCard_MouseHover);
            // 
            // buttonUpdateUserCard
            // 
            this.buttonUpdateUserCard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdateUserCard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUserCard.Location = new System.Drawing.Point(155, 85);
            this.buttonUpdateUserCard.Name = "buttonUpdateUserCard";
            this.buttonUpdateUserCard.Size = new System.Drawing.Size(137, 56);
            this.buttonUpdateUserCard.TabIndex = 3;
            this.buttonUpdateUserCard.Text = "Izmeni Korisnika";
            this.buttonUpdateUserCard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateUserCard.UseVisualStyleBackColor = false;
            this.buttonUpdateUserCard.Click += new System.EventHandler(this.buttonUpdateUserCard_Click);
            this.buttonUpdateUserCard.MouseHover += new System.EventHandler(this.buttonUpdateUserCard_MouseHover);
            // 
            // buttonDeleteUserCard
            // 
            this.buttonDeleteUserCard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteUserCard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUserCard.Location = new System.Drawing.Point(298, 85);
            this.buttonDeleteUserCard.Name = "buttonDeleteUserCard";
            this.buttonDeleteUserCard.Size = new System.Drawing.Size(137, 56);
            this.buttonDeleteUserCard.TabIndex = 4;
            this.buttonDeleteUserCard.Text = "Izbrisi Korisnika";
            this.buttonDeleteUserCard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteUserCard.UseVisualStyleBackColor = false;
            this.buttonDeleteUserCard.Click += new System.EventHandler(this.buttonDeleteUserCard_Click);
            this.buttonDeleteUserCard.MouseHover += new System.EventHandler(this.buttonDeleteUserCard_MouseHover);
            // 
            // listBoxUserCards
            // 
            this.listBoxUserCards.FormattingEnabled = true;
            this.listBoxUserCards.Location = new System.Drawing.Point(12, 164);
            this.listBoxUserCards.Name = "listBoxUserCards";
            this.listBoxUserCards.Size = new System.Drawing.Size(460, 485);
            this.listBoxUserCards.TabIndex = 5;
            // 
            // textBoxUserCardPhoneNumber
            // 
            this.textBoxUserCardPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserCardPhoneNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCardPhoneNumber.Location = new System.Drawing.Point(667, 342);
            this.textBoxUserCardPhoneNumber.Name = "textBoxUserCardPhoneNumber";
            this.textBoxUserCardPhoneNumber.Size = new System.Drawing.Size(175, 32);
            this.textBoxUserCardPhoneNumber.TabIndex = 34;
            this.textBoxUserCardPhoneNumber.Leave += new System.EventHandler(this.FocusLeavePhone);
            // 
            // textBoxUserCardAddress
            // 
            this.textBoxUserCardAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserCardAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCardAddress.Location = new System.Drawing.Point(667, 290);
            this.textBoxUserCardAddress.Name = "textBoxUserCardAddress";
            this.textBoxUserCardAddress.Size = new System.Drawing.Size(175, 32);
            this.textBoxUserCardAddress.TabIndex = 32;
            this.textBoxUserCardAddress.Leave += new System.EventHandler(this.FocusLeaveAddress);
            // 
            // textBoxUserCardSurname
            // 
            this.textBoxUserCardSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserCardSurname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCardSurname.Location = new System.Drawing.Point(667, 238);
            this.textBoxUserCardSurname.Name = "textBoxUserCardSurname";
            this.textBoxUserCardSurname.Size = new System.Drawing.Size(175, 32);
            this.textBoxUserCardSurname.TabIndex = 30;
            this.textBoxUserCardSurname.Leave += new System.EventHandler(this.FocusLeaveSurname);
            // 
            // textBoxUserCardName
            // 
            this.textBoxUserCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserCardName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCardName.Location = new System.Drawing.Point(667, 187);
            this.textBoxUserCardName.Name = "textBoxUserCardName";
            this.textBoxUserCardName.Size = new System.Drawing.Size(175, 32);
            this.textBoxUserCardName.TabIndex = 28;
            this.textBoxUserCardName.Leave += new System.EventHandler(this.FocusLeaveName);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(490, 626);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 48;
            // 
            // textBoxUserCardSearch
            // 
            this.textBoxUserCardSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCardSearch.Location = new System.Drawing.Point(527, 493);
            this.textBoxUserCardSearch.Name = "textBoxUserCardSearch";
            this.textBoxUserCardSearch.Size = new System.Drawing.Size(306, 32);
            this.textBoxUserCardSearch.TabIndex = 83;
            this.textBoxUserCardSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUserCardSearch
            // 
            this.buttonUserCardSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUserCardSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserCardSearch.Location = new System.Drawing.Point(486, 532);
            this.buttonUserCardSearch.Name = "buttonUserCardSearch";
            this.buttonUserCardSearch.Size = new System.Drawing.Size(356, 56);
            this.buttonUserCardSearch.TabIndex = 82;
            this.buttonUserCardSearch.Text = "Pretrazi";
            this.buttonUserCardSearch.UseVisualStyleBackColor = false;
            this.buttonUserCardSearch.Click += new System.EventHandler(this.buttonUserCardSearch_Click);
            this.buttonUserCardSearch.MouseHover += new System.EventHandler(this.buttonUserCardSearch_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(494, 493);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(226, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(439, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(486, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(347, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(497, 186);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 108;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(478, 237);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(187, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(478, 289);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(187, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 110;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(478, 341);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(187, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 111;
            this.pictureBox8.TabStop = false;
            // 
            // UserCardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 661);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxUserCardSearch);
            this.Controls.Add(this.buttonUserCardSearch);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxUserCardPhoneNumber);
            this.Controls.Add(this.textBoxUserCardAddress);
            this.Controls.Add(this.textBoxUserCardSurname);
            this.Controls.Add(this.textBoxUserCardName);
            this.Controls.Add(this.listBoxUserCards);
            this.Controls.Add(this.buttonDeleteUserCard);
            this.Controls.Add(this.buttonUpdateUserCard);
            this.Controls.Add(this.buttonInsertUserCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimumSize = new System.Drawing.Size(870, 700);
            this.Name = "UserCardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserCard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertUserCard;
        private System.Windows.Forms.Button buttonUpdateUserCard;
        private System.Windows.Forms.Button buttonDeleteUserCard;
        private System.Windows.Forms.ListBox listBoxUserCards;
        private System.Windows.Forms.TextBox textBoxUserCardPhoneNumber;
        private System.Windows.Forms.TextBox textBoxUserCardAddress;
        private System.Windows.Forms.TextBox textBoxUserCardSurname;
        private System.Windows.Forms.TextBox textBoxUserCardName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxUserCardSearch;
        private System.Windows.Forms.Button buttonUserCardSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}