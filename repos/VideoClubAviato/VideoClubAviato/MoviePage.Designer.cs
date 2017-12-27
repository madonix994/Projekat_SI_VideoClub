namespace VideoClubAviato
{
    partial class MoviePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviePage));
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.buttonInsertMovie = new System.Windows.Forms.Button();
            this.buttonUpdateMovie = new System.Windows.Forms.Button();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.textBoxMovieYear = new System.Windows.Forms.TextBox();
            this.textBoxMovieDuration = new System.Windows.Forms.TextBox();
            this.textBoxMovieIMDBRating = new System.Windows.Forms.TextBox();
            this.textBoxMovieStatus = new System.Windows.Forms.TextBox();
            this.textBoxMovieAmount = new System.Windows.Forms.TextBox();
            this.textBoxMovieRentalPrice = new System.Windows.Forms.TextBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxDirectors = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxMovieOscar = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxMovieSearch = new System.Windows.Forms.TextBox();
            this.buttonMovieSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.Location = new System.Drawing.Point(12, 160);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(460, 524);
            this.listBoxMovies.TabIndex = 0;
            // 
            // buttonInsertMovie
            // 
            this.buttonInsertMovie.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInsertMovie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertMovie.Location = new System.Drawing.Point(12, 79);
            this.buttonInsertMovie.Name = "buttonInsertMovie";
            this.buttonInsertMovie.Size = new System.Drawing.Size(137, 56);
            this.buttonInsertMovie.TabIndex = 1;
            this.buttonInsertMovie.Text = "Unesi Film";
            this.buttonInsertMovie.UseVisualStyleBackColor = false;
            this.buttonInsertMovie.Click += new System.EventHandler(this.buttonInsertMovie_Click);
            this.buttonInsertMovie.MouseHover += new System.EventHandler(this.MouseHoverInsertMovie);
            // 
            // buttonUpdateMovie
            // 
            this.buttonUpdateMovie.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdateMovie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateMovie.Location = new System.Drawing.Point(176, 79);
            this.buttonUpdateMovie.Name = "buttonUpdateMovie";
            this.buttonUpdateMovie.Size = new System.Drawing.Size(137, 56);
            this.buttonUpdateMovie.TabIndex = 2;
            this.buttonUpdateMovie.Text = "Izmeni Film";
            this.buttonUpdateMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateMovie.UseVisualStyleBackColor = false;
            this.buttonUpdateMovie.Click += new System.EventHandler(this.buttonUpdateMovie_Click);
            this.buttonUpdateMovie.MouseHover += new System.EventHandler(this.MouseHoverUpdateMovie);
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteMovie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMovie.Location = new System.Drawing.Point(335, 79);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(137, 56);
            this.buttonDeleteMovie.TabIndex = 3;
            this.buttonDeleteMovie.Text = "Izbrisi Film";
            this.buttonDeleteMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteMovie.UseVisualStyleBackColor = false;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            this.buttonDeleteMovie.MouseHover += new System.EventHandler(this.MouseHoverDeleteMovie);
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieName.Location = new System.Drawing.Point(660, 160);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieName.TabIndex = 6;
            this.textBoxMovieName.Leave += new System.EventHandler(this.textBoxMovieName_Leave);
            // 
            // textBoxMovieYear
            // 
            this.textBoxMovieYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieYear.Location = new System.Drawing.Point(660, 274);
            this.textBoxMovieYear.Name = "textBoxMovieYear";
            this.textBoxMovieYear.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieYear.TabIndex = 8;
            this.textBoxMovieYear.Leave += new System.EventHandler(this.textBoxMovieYear_Leave);
            // 
            // textBoxMovieDuration
            // 
            this.textBoxMovieDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieDuration.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieDuration.Location = new System.Drawing.Point(660, 312);
            this.textBoxMovieDuration.Name = "textBoxMovieDuration";
            this.textBoxMovieDuration.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieDuration.TabIndex = 10;
            this.textBoxMovieDuration.Leave += new System.EventHandler(this.textBoxMovieDuration_Leave);
            // 
            // textBoxMovieIMDBRating
            // 
            this.textBoxMovieIMDBRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieIMDBRating.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieIMDBRating.Location = new System.Drawing.Point(660, 350);
            this.textBoxMovieIMDBRating.Name = "textBoxMovieIMDBRating";
            this.textBoxMovieIMDBRating.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieIMDBRating.TabIndex = 12;
            this.textBoxMovieIMDBRating.Leave += new System.EventHandler(this.textBoxMovieIMDBRating_Leave);
            // 
            // textBoxMovieStatus
            // 
            this.textBoxMovieStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieStatus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieStatus.Location = new System.Drawing.Point(660, 388);
            this.textBoxMovieStatus.Name = "textBoxMovieStatus";
            this.textBoxMovieStatus.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieStatus.TabIndex = 14;
            this.textBoxMovieStatus.Leave += new System.EventHandler(this.textBoxMovieStatus_Leave);
            // 
            // textBoxMovieAmount
            // 
            this.textBoxMovieAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieAmount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieAmount.Location = new System.Drawing.Point(660, 426);
            this.textBoxMovieAmount.Name = "textBoxMovieAmount";
            this.textBoxMovieAmount.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieAmount.TabIndex = 16;
            this.textBoxMovieAmount.Leave += new System.EventHandler(this.textBoxMovieAmount_Leave);
            // 
            // textBoxMovieRentalPrice
            // 
            this.textBoxMovieRentalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieRentalPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieRentalPrice.Location = new System.Drawing.Point(660, 464);
            this.textBoxMovieRentalPrice.Name = "textBoxMovieRentalPrice";
            this.textBoxMovieRentalPrice.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieRentalPrice.TabIndex = 18;
            this.textBoxMovieRentalPrice.Leave += new System.EventHandler(this.textBoxMovieRentalPrice_Leave);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Horor",
            "Avantura",
            "Misterija"});
            this.comboBoxGenre.Location = new System.Drawing.Point(660, 196);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(175, 33);
            this.comboBoxGenre.TabIndex = 20;
            this.comboBoxGenre.Leave += new System.EventHandler(this.comboBoxGenre_Leave);
            // 
            // comboBoxDirectors
            // 
            this.comboBoxDirectors.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDirectors.FormattingEnabled = true;
            this.comboBoxDirectors.Items.AddRange(new object[] {
            "Steven Spielberg",
            "James Cameron",
            "Quentin Tarantino"});
            this.comboBoxDirectors.Location = new System.Drawing.Point(660, 235);
            this.comboBoxDirectors.Name = "comboBoxDirectors";
            this.comboBoxDirectors.Size = new System.Drawing.Size(175, 33);
            this.comboBoxDirectors.TabIndex = 22;
            this.comboBoxDirectors.Leave += new System.EventHandler(this.comboBoxDirectors_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBoxMovieOscar
            // 
            this.checkBoxMovieOscar.AutoSize = true;
            this.checkBoxMovieOscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMovieOscar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.checkBoxMovieOscar.Location = new System.Drawing.Point(552, 502);
            this.checkBoxMovieOscar.Name = "checkBoxMovieOscar";
            this.checkBoxMovieOscar.Size = new System.Drawing.Size(223, 28);
            this.checkBoxMovieOscar.TabIndex = 26;
            this.checkBoxMovieOscar.Text = "Film je dobio Oscar";
            this.checkBoxMovieOscar.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(488, 661);
            this.progressBar1.MarqueeAnimationSpeed = 108;
            this.progressBar1.Maximum = 108;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.Step = 12;
            this.progressBar1.TabIndex = 86;
            // 
            // textBoxMovieSearch
            // 
            this.textBoxMovieSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieSearch.Location = new System.Drawing.Point(520, 560);
            this.textBoxMovieSearch.Name = "textBoxMovieSearch";
            this.textBoxMovieSearch.Size = new System.Drawing.Size(320, 32);
            this.textBoxMovieSearch.TabIndex = 85;
            this.textBoxMovieSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonMovieSearch
            // 
            this.buttonMovieSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonMovieSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovieSearch.Location = new System.Drawing.Point(488, 599);
            this.buttonMovieSearch.Name = "buttonMovieSearch";
            this.buttonMovieSearch.Size = new System.Drawing.Size(352, 56);
            this.buttonMovieSearch.TabIndex = 84;
            this.buttonMovieSearch.Text = "Pretrazi";
            this.buttonMovieSearch.UseVisualStyleBackColor = false;
            this.buttonMovieSearch.Click += new System.EventHandler(this.buttonMovieSearch_Click);
            this.buttonMovieSearch.MouseHover += new System.EventHandler(this.buttonMovieSearch_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(489, 560);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(254, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 89;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(502, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(329, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 90;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(489, 158);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 91;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(489, 194);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 92;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(489, 233);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 93;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(489, 272);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 94;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(489, 310);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(168, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 95;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(489, 349);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(168, 31);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 96;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(489, 385);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(168, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 97;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(488, 424);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(169, 31);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 98;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(488, 464);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(169, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 99;
            this.pictureBox13.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(549, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 100;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 687);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxMovieSearch);
            this.Controls.Add(this.buttonMovieSearch);
            this.Controls.Add(this.checkBoxMovieOscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxDirectors);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.textBoxMovieRentalPrice);
            this.Controls.Add(this.textBoxMovieAmount);
            this.Controls.Add(this.textBoxMovieStatus);
            this.Controls.Add(this.textBoxMovieIMDBRating);
            this.Controls.Add(this.textBoxMovieDuration);
            this.Controls.Add(this.textBoxMovieYear);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.buttonDeleteMovie);
            this.Controls.Add(this.buttonUpdateMovie);
            this.Controls.Add(this.buttonInsertMovie);
            this.Controls.Add(this.listBoxMovies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 730);
            this.MinimumSize = new System.Drawing.Size(870, 726);
            this.Name = "MoviePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.Button buttonInsertMovie;
        private System.Windows.Forms.Button buttonUpdateMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.TextBox textBoxMovieYear;
        private System.Windows.Forms.TextBox textBoxMovieDuration;
        private System.Windows.Forms.TextBox textBoxMovieIMDBRating;
        private System.Windows.Forms.TextBox textBoxMovieStatus;
        private System.Windows.Forms.TextBox textBoxMovieAmount;
        private System.Windows.Forms.TextBox textBoxMovieRentalPrice;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxDirectors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxMovieOscar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxMovieSearch;
        private System.Windows.Forms.Button buttonMovieSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label3;
    }
}