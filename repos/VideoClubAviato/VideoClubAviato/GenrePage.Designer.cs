namespace VideoClubAviato
{
    partial class GenrePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenrePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxGenreName = new System.Windows.Forms.TextBox();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.buttonDeleteGenre = new System.Windows.Forms.Button();
            this.buttonUpdateDirector = new System.Windows.Forms.Button();
            this.buttonInsertGenre = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxGenreSearch = new System.Windows.Forms.TextBox();
            this.buttonGenreSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxGenreName
            // 
            this.textBoxGenreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGenreName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenreName.Location = new System.Drawing.Point(650, 260);
            this.textBoxGenreName.Name = "textBoxGenreName";
            this.textBoxGenreName.Size = new System.Drawing.Size(175, 32);
            this.textBoxGenreName.TabIndex = 72;
            this.textBoxGenreName.Leave += new System.EventHandler(this.textBoxGenreName_Leave);
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.Location = new System.Drawing.Point(10, 163);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(460, 485);
            this.listBoxGenres.TabIndex = 68;
            // 
            // buttonDeleteGenre
            // 
            this.buttonDeleteGenre.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteGenre.Location = new System.Drawing.Point(296, 84);
            this.buttonDeleteGenre.Name = "buttonDeleteGenre";
            this.buttonDeleteGenre.Size = new System.Drawing.Size(137, 56);
            this.buttonDeleteGenre.TabIndex = 67;
            this.buttonDeleteGenre.Text = "Izbrisi Zanr";
            this.buttonDeleteGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteGenre.UseVisualStyleBackColor = false;
            this.buttonDeleteGenre.Click += new System.EventHandler(this.buttonDeleteGenre_Click);
            this.buttonDeleteGenre.MouseHover += new System.EventHandler(this.MouseHoverDeleteGenre);
            // 
            // buttonUpdateDirector
            // 
            this.buttonUpdateDirector.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdateDirector.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateDirector.Location = new System.Drawing.Point(153, 84);
            this.buttonUpdateDirector.Name = "buttonUpdateDirector";
            this.buttonUpdateDirector.Size = new System.Drawing.Size(137, 56);
            this.buttonUpdateDirector.TabIndex = 66;
            this.buttonUpdateDirector.Text = "Izmeni Zanr";
            this.buttonUpdateDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateDirector.UseVisualStyleBackColor = false;
            this.buttonUpdateDirector.Click += new System.EventHandler(this.buttonUpdateDirector_Click);
            this.buttonUpdateDirector.MouseHover += new System.EventHandler(this.MouseHoverUpdateGenre);
            // 
            // buttonInsertGenre
            // 
            this.buttonInsertGenre.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInsertGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertGenre.Location = new System.Drawing.Point(10, 84);
            this.buttonInsertGenre.Name = "buttonInsertGenre";
            this.buttonInsertGenre.Size = new System.Drawing.Size(137, 56);
            this.buttonInsertGenre.TabIndex = 65;
            this.buttonInsertGenre.Text = "Unesi Zanr";
            this.buttonInsertGenre.UseVisualStyleBackColor = false;
            this.buttonInsertGenre.Click += new System.EventHandler(this.buttonInsertGenre_Click);
            this.buttonInsertGenre.MouseHover += new System.EventHandler(this.MouseHoverInsertGenre);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(488, 631);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 86;
            // 
            // textBoxGenreSearch
            // 
            this.textBoxGenreSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenreSearch.Location = new System.Drawing.Point(529, 485);
            this.textBoxGenreSearch.Name = "textBoxGenreSearch";
            this.textBoxGenreSearch.Size = new System.Drawing.Size(306, 32);
            this.textBoxGenreSearch.TabIndex = 85;
            this.textBoxGenreSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGenreSearch
            // 
            this.buttonGenreSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonGenreSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenreSearch.Location = new System.Drawing.Point(488, 524);
            this.buttonGenreSearch.Name = "buttonGenreSearch";
            this.buttonGenreSearch.Size = new System.Drawing.Size(356, 56);
            this.buttonGenreSearch.TabIndex = 84;
            this.buttonGenreSearch.Text = "Pretrazi";
            this.buttonGenreSearch.UseVisualStyleBackColor = false;
            this.buttonGenreSearch.Click += new System.EventHandler(this.buttonGenreSearch_Click);
            this.buttonGenreSearch.MouseHover += new System.EventHandler(this.buttonGenreSearch_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(497, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(257, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 88;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(476, 258);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 89;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(490, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(329, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 90;
            this.pictureBox3.TabStop = false;
            // 
            // GenrePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 661);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxGenreSearch);
            this.Controls.Add(this.buttonGenreSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxGenreName);
            this.Controls.Add(this.listBoxGenres);
            this.Controls.Add(this.buttonDeleteGenre);
            this.Controls.Add(this.buttonUpdateDirector);
            this.Controls.Add(this.buttonInsertGenre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimumSize = new System.Drawing.Size(870, 700);
            this.Name = "GenrePage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxGenreName;
        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.Button buttonDeleteGenre;
        private System.Windows.Forms.Button buttonUpdateDirector;
        private System.Windows.Forms.Button buttonInsertGenre;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxGenreSearch;
        private System.Windows.Forms.Button buttonGenreSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}