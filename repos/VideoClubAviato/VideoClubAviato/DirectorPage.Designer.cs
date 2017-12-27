namespace VideoClubAviato
{
    partial class DirectorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDirectorDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxDirectorSurname = new System.Windows.Forms.TextBox();
            this.textBoxDirectorName = new System.Windows.Forms.TextBox();
            this.listBoxDirectors = new System.Windows.Forms.ListBox();
            this.buttonDeleteDirector = new System.Windows.Forms.Button();
            this.buttonUpdateDirector = new System.Windows.Forms.Button();
            this.buttonInsertDirector = new System.Windows.Forms.Button();
            this.checkBoxDirectorOscar = new System.Windows.Forms.CheckBox();
            this.textBoxDirectorSearch = new System.Windows.Forms.TextBox();
            this.buttonDirectorSearch = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxDirectorDateOfBirth
            // 
            this.textBoxDirectorDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirectorDateOfBirth.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirectorDateOfBirth.Location = new System.Drawing.Point(665, 289);
            this.textBoxDirectorDateOfBirth.Name = "textBoxDirectorDateOfBirth";
            this.textBoxDirectorDateOfBirth.Size = new System.Drawing.Size(175, 32);
            this.textBoxDirectorDateOfBirth.TabIndex = 58;
            this.textBoxDirectorDateOfBirth.Leave += new System.EventHandler(this.textBoxDirectorDateOfBirth_Leave);
            // 
            // textBoxDirectorSurname
            // 
            this.textBoxDirectorSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirectorSurname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirectorSurname.Location = new System.Drawing.Point(665, 237);
            this.textBoxDirectorSurname.Name = "textBoxDirectorSurname";
            this.textBoxDirectorSurname.Size = new System.Drawing.Size(175, 32);
            this.textBoxDirectorSurname.TabIndex = 57;
            this.textBoxDirectorSurname.Leave += new System.EventHandler(this.textBoxDirectorSurname_Leave);
            // 
            // textBoxDirectorName
            // 
            this.textBoxDirectorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirectorName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirectorName.Location = new System.Drawing.Point(665, 186);
            this.textBoxDirectorName.Name = "textBoxDirectorName";
            this.textBoxDirectorName.Size = new System.Drawing.Size(175, 32);
            this.textBoxDirectorName.TabIndex = 55;
            this.textBoxDirectorName.Leave += new System.EventHandler(this.FocusLeaveDirectorName);
            // 
            // listBoxDirectors
            // 
            this.listBoxDirectors.FormattingEnabled = true;
            this.listBoxDirectors.Location = new System.Drawing.Point(10, 163);
            this.listBoxDirectors.Name = "listBoxDirectors";
            this.listBoxDirectors.Size = new System.Drawing.Size(460, 485);
            this.listBoxDirectors.TabIndex = 51;
            // 
            // buttonDeleteDirector
            // 
            this.buttonDeleteDirector.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteDirector.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteDirector.Location = new System.Drawing.Point(296, 84);
            this.buttonDeleteDirector.Name = "buttonDeleteDirector";
            this.buttonDeleteDirector.Size = new System.Drawing.Size(137, 56);
            this.buttonDeleteDirector.TabIndex = 50;
            this.buttonDeleteDirector.Text = "Izbrisi Rezisera";
            this.buttonDeleteDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteDirector.UseVisualStyleBackColor = false;
            this.buttonDeleteDirector.Click += new System.EventHandler(this.buttonDeleteDirector_Click);
            this.buttonDeleteDirector.MouseHover += new System.EventHandler(this.MouseHoverDeleteDirector);
            // 
            // buttonUpdateDirector
            // 
            this.buttonUpdateDirector.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdateDirector.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateDirector.Location = new System.Drawing.Point(153, 84);
            this.buttonUpdateDirector.Name = "buttonUpdateDirector";
            this.buttonUpdateDirector.Size = new System.Drawing.Size(137, 56);
            this.buttonUpdateDirector.TabIndex = 49;
            this.buttonUpdateDirector.Text = "Izmeni Rezisera";
            this.buttonUpdateDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateDirector.UseVisualStyleBackColor = false;
            this.buttonUpdateDirector.Click += new System.EventHandler(this.buttonUpdateDirector_Click);
            this.buttonUpdateDirector.MouseHover += new System.EventHandler(this.MouseHoverUpdateDirector);
            // 
            // buttonInsertDirector
            // 
            this.buttonInsertDirector.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInsertDirector.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertDirector.Location = new System.Drawing.Point(10, 84);
            this.buttonInsertDirector.Name = "buttonInsertDirector";
            this.buttonInsertDirector.Size = new System.Drawing.Size(137, 56);
            this.buttonInsertDirector.TabIndex = 48;
            this.buttonInsertDirector.Text = "Unesi Rezisera";
            this.buttonInsertDirector.UseVisualStyleBackColor = false;
            this.buttonInsertDirector.Click += new System.EventHandler(this.buttonInsertDirector_Click);
            this.buttonInsertDirector.MouseHover += new System.EventHandler(this.MouseHoverInsertDirector);
            // 
            // checkBoxDirectorOscar
            // 
            this.checkBoxDirectorOscar.AutoSize = true;
            this.checkBoxDirectorOscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDirectorOscar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.checkBoxDirectorOscar.Location = new System.Drawing.Point(545, 371);
            this.checkBoxDirectorOscar.Name = "checkBoxDirectorOscar";
            this.checkBoxDirectorOscar.Size = new System.Drawing.Size(256, 28);
            this.checkBoxDirectorOscar.TabIndex = 64;
            this.checkBoxDirectorOscar.Text = "Reziser je dobio Oscar";
            this.checkBoxDirectorOscar.UseVisualStyleBackColor = true;
            // 
            // textBoxDirectorSearch
            // 
            this.textBoxDirectorSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirectorSearch.Location = new System.Drawing.Point(525, 480);
            this.textBoxDirectorSearch.Name = "textBoxDirectorSearch";
            this.textBoxDirectorSearch.Size = new System.Drawing.Size(310, 32);
            this.textBoxDirectorSearch.TabIndex = 82;
            this.textBoxDirectorSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDirectorSearch
            // 
            this.buttonDirectorSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDirectorSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirectorSearch.Location = new System.Drawing.Point(488, 519);
            this.buttonDirectorSearch.Name = "buttonDirectorSearch";
            this.buttonDirectorSearch.Size = new System.Drawing.Size(356, 56);
            this.buttonDirectorSearch.TabIndex = 81;
            this.buttonDirectorSearch.Text = "Pretrazi";
            this.buttonDirectorSearch.UseVisualStyleBackColor = false;
            this.buttonDirectorSearch.Click += new System.EventHandler(this.buttonDirectorSearch_Click);
            this.buttonDirectorSearch.MouseHover += new System.EventHandler(this.buttonDirectorSearch_MouseHover);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(488, 626);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.Step = 34;
            this.progressBar1.TabIndex = 83;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(495, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(250, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(490, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(340, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(476, 287);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(187, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 89;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(495, 185);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 90;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(476, 235);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(187, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 91;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(538, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 92;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DirectorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxDirectorSearch);
            this.Controls.Add(this.buttonDirectorSearch);
            this.Controls.Add(this.checkBoxDirectorOscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDirectorDateOfBirth);
            this.Controls.Add(this.textBoxDirectorSurname);
            this.Controls.Add(this.textBoxDirectorName);
            this.Controls.Add(this.listBoxDirectors);
            this.Controls.Add(this.buttonDeleteDirector);
            this.Controls.Add(this.buttonUpdateDirector);
            this.Controls.Add(this.buttonInsertDirector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimumSize = new System.Drawing.Size(870, 700);
            this.Name = "DirectorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDirectorDateOfBirth;
        private System.Windows.Forms.TextBox textBoxDirectorSurname;
        private System.Windows.Forms.TextBox textBoxDirectorName;
        private System.Windows.Forms.ListBox listBoxDirectors;
        private System.Windows.Forms.Button buttonDeleteDirector;
        private System.Windows.Forms.Button buttonUpdateDirector;
        private System.Windows.Forms.Button buttonInsertDirector;
        private System.Windows.Forms.CheckBox checkBoxDirectorOscar;
        private System.Windows.Forms.TextBox textBoxDirectorSearch;
        private System.Windows.Forms.Button buttonDirectorSearch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
    }
}