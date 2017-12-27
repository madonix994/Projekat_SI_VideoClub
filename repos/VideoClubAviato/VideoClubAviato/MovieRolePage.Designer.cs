namespace VideoClubAviato
{
    partial class MovieRolePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieRolePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxMovieRoleDescription = new System.Windows.Forms.TextBox();
            this.textBoxMovieRoleName = new System.Windows.Forms.TextBox();
            this.listBoxMovieRoles = new System.Windows.Forms.ListBox();
            this.buttonDeleteMovieRole = new System.Windows.Forms.Button();
            this.buttonUpdateMovieRole = new System.Windows.Forms.Button();
            this.buttonInsertMovieRole = new System.Windows.Forms.Button();
            this.comboBoxActor = new System.Windows.Forms.ComboBox();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxMovieRoleSearch = new System.Windows.Forms.TextBox();
            this.buttonMovieRoleSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxMovieRoleDescription
            // 
            this.textBoxMovieRoleDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieRoleDescription.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieRoleDescription.Location = new System.Drawing.Point(651, 241);
            this.textBoxMovieRoleDescription.Name = "textBoxMovieRoleDescription";
            this.textBoxMovieRoleDescription.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieRoleDescription.TabIndex = 73;
            this.textBoxMovieRoleDescription.Leave += new System.EventHandler(this.textBoxMovieRoleDescription_Leave);
            // 
            // textBoxMovieRoleName
            // 
            this.textBoxMovieRoleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovieRoleName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieRoleName.Location = new System.Drawing.Point(651, 190);
            this.textBoxMovieRoleName.Name = "textBoxMovieRoleName";
            this.textBoxMovieRoleName.Size = new System.Drawing.Size(175, 32);
            this.textBoxMovieRoleName.TabIndex = 72;
            this.textBoxMovieRoleName.Leave += new System.EventHandler(this.textBoxMovieRoleName_Leave);
            // 
            // listBoxMovieRoles
            // 
            this.listBoxMovieRoles.FormattingEnabled = true;
            this.listBoxMovieRoles.Location = new System.Drawing.Point(10, 163);
            this.listBoxMovieRoles.Name = "listBoxMovieRoles";
            this.listBoxMovieRoles.Size = new System.Drawing.Size(460, 485);
            this.listBoxMovieRoles.TabIndex = 68;
            // 
            // buttonDeleteMovieRole
            // 
            this.buttonDeleteMovieRole.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteMovieRole.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteMovieRole.Location = new System.Drawing.Point(296, 84);
            this.buttonDeleteMovieRole.Name = "buttonDeleteMovieRole";
            this.buttonDeleteMovieRole.Size = new System.Drawing.Size(137, 56);
            this.buttonDeleteMovieRole.TabIndex = 67;
            this.buttonDeleteMovieRole.Text = "Izbrisi Ulogu";
            this.buttonDeleteMovieRole.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteMovieRole.UseVisualStyleBackColor = false;
            this.buttonDeleteMovieRole.Click += new System.EventHandler(this.buttonDeleteMovieRole_Click);
            this.buttonDeleteMovieRole.MouseHover += new System.EventHandler(this.buttonDeleteMovieRole_MouseHover);
            // 
            // buttonUpdateMovieRole
            // 
            this.buttonUpdateMovieRole.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdateMovieRole.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateMovieRole.Location = new System.Drawing.Point(153, 84);
            this.buttonUpdateMovieRole.Name = "buttonUpdateMovieRole";
            this.buttonUpdateMovieRole.Size = new System.Drawing.Size(137, 56);
            this.buttonUpdateMovieRole.TabIndex = 66;
            this.buttonUpdateMovieRole.Text = "Izmeni Ulogu";
            this.buttonUpdateMovieRole.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateMovieRole.UseVisualStyleBackColor = false;
            this.buttonUpdateMovieRole.Click += new System.EventHandler(this.buttonUpdateMovieRole_Click);
            this.buttonUpdateMovieRole.MouseHover += new System.EventHandler(this.buttonUpdateMovieRole_MouseHover);
            // 
            // buttonInsertMovieRole
            // 
            this.buttonInsertMovieRole.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInsertMovieRole.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.buttonInsertMovieRole.Location = new System.Drawing.Point(10, 84);
            this.buttonInsertMovieRole.Name = "buttonInsertMovieRole";
            this.buttonInsertMovieRole.Size = new System.Drawing.Size(137, 56);
            this.buttonInsertMovieRole.TabIndex = 65;
            this.buttonInsertMovieRole.Text = "Unesi Ulogu";
            this.buttonInsertMovieRole.UseVisualStyleBackColor = false;
            this.buttonInsertMovieRole.Click += new System.EventHandler(this.buttonInsertMovieRole_Click);
            this.buttonInsertMovieRole.MouseHover += new System.EventHandler(this.buttonInsertMovieRole_MouseHover);
            // 
            // comboBoxActor
            // 
            this.comboBoxActor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActor.FormattingEnabled = true;
            this.comboBoxActor.Location = new System.Drawing.Point(651, 345);
            this.comboBoxActor.Name = "comboBoxActor";
            this.comboBoxActor.Size = new System.Drawing.Size(175, 33);
            this.comboBoxActor.TabIndex = 82;
            this.comboBoxActor.Leave += new System.EventHandler(this.comboBoxActor_Leave);
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Items.AddRange(new object[] {
            "Horor",
            "Avantura",
            "Misterija"});
            this.comboBoxMovie.Location = new System.Drawing.Point(651, 291);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(175, 33);
            this.comboBoxMovie.TabIndex = 80;
            this.comboBoxMovie.Leave += new System.EventHandler(this.comboBoxMovie_Leave);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(486, 632);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 86;
            // 
            // textBoxMovieRoleSearch
            // 
            this.textBoxMovieRoleSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovieRoleSearch.Location = new System.Drawing.Point(528, 486);
            this.textBoxMovieRoleSearch.Name = "textBoxMovieRoleSearch";
            this.textBoxMovieRoleSearch.Size = new System.Drawing.Size(305, 32);
            this.textBoxMovieRoleSearch.TabIndex = 85;
            // 
            // buttonMovieRoleSearch
            // 
            this.buttonMovieRoleSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonMovieRoleSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovieRoleSearch.Location = new System.Drawing.Point(486, 525);
            this.buttonMovieRoleSearch.Name = "buttonMovieRoleSearch";
            this.buttonMovieRoleSearch.Size = new System.Drawing.Size(356, 56);
            this.buttonMovieRoleSearch.TabIndex = 84;
            this.buttonMovieRoleSearch.Text = "Pretrazi";
            this.buttonMovieRoleSearch.UseVisualStyleBackColor = false;
            this.buttonMovieRoleSearch.Click += new System.EventHandler(this.buttonMovieRoleSearch_Click);
            this.buttonMovieRoleSearch.MouseHover += new System.EventHandler(this.buttonMovieRoleSearch_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(495, 486);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(296, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(320, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 88;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(495, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(329, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(478, 344);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 90;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(478, 290);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 92;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(478, 240);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 93;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(478, 189);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 94;
            this.pictureBox8.TabStop = false;
            // 
            // MovieRolePage
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxMovieRoleSearch);
            this.Controls.Add(this.buttonMovieRoleSearch);
            this.Controls.Add(this.comboBoxActor);
            this.Controls.Add(this.comboBoxMovie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMovieRoleDescription);
            this.Controls.Add(this.textBoxMovieRoleName);
            this.Controls.Add(this.listBoxMovieRoles);
            this.Controls.Add(this.buttonDeleteMovieRole);
            this.Controls.Add(this.buttonUpdateMovieRole);
            this.Controls.Add(this.buttonInsertMovieRole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimumSize = new System.Drawing.Size(870, 700);
            this.Name = "MovieRolePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieRole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxMovieRoleDescription;
        private System.Windows.Forms.TextBox textBoxMovieRoleName;
        private System.Windows.Forms.ListBox listBoxMovieRoles;
        private System.Windows.Forms.Button buttonDeleteMovieRole;
        private System.Windows.Forms.Button buttonUpdateMovieRole;
        private System.Windows.Forms.Button buttonInsertMovieRole;
        private System.Windows.Forms.ComboBox comboBoxActor;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxMovieRoleSearch;
        private System.Windows.Forms.Button buttonMovieRoleSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}