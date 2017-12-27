namespace VideoClubAviato
{
    partial class ActorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorPage));
            this.checkBoxActorOscar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonActorSearch = new System.Windows.Forms.Button();
            this.textBoxActorDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxActorSurname = new System.Windows.Forms.TextBox();
            this.textBoxActorName = new System.Windows.Forms.TextBox();
            this.listBoxActors = new System.Windows.Forms.ListBox();
            this.buttonDeleteActor = new System.Windows.Forms.Button();
            this.buttonUpdateActor = new System.Windows.Forms.Button();
            this.buttonInsertActor = new System.Windows.Forms.Button();
            this.textBoxArctorSearch = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxActorOscar
            // 
            this.checkBoxActorOscar.AutoSize = true;
            this.checkBoxActorOscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActorOscar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.checkBoxActorOscar.Location = new System.Drawing.Point(535, 375);
            this.checkBoxActorOscar.Name = "checkBoxActorOscar";
            this.checkBoxActorOscar.Size = new System.Drawing.Size(258, 28);
            this.checkBoxActorOscar.TabIndex = 79;
            this.checkBoxActorOscar.Text = "Glumac je dobio Oscar";
            this.checkBoxActorOscar.UseVisualStyleBackColor = true;
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
            // buttonActorSearch
            // 
            this.buttonActorSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonActorSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActorSearch.Location = new System.Drawing.Point(493, 536);
            this.buttonActorSearch.Name = "buttonActorSearch";
            this.buttonActorSearch.Size = new System.Drawing.Size(356, 56);
            this.buttonActorSearch.TabIndex = 77;
            this.buttonActorSearch.Text = "Pretrazi";
            this.buttonActorSearch.UseVisualStyleBackColor = false;
            this.buttonActorSearch.Click += new System.EventHandler(this.buttonActorSearch_Click);
            this.buttonActorSearch.MouseHover += new System.EventHandler(this.buttonActorSearch_MouseHover);
            // 
            // textBoxActorDateOfBirth
            // 
            this.textBoxActorDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxActorDateOfBirth.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActorDateOfBirth.Location = new System.Drawing.Point(665, 289);
            this.textBoxActorDateOfBirth.Name = "textBoxActorDateOfBirth";
            this.textBoxActorDateOfBirth.Size = new System.Drawing.Size(175, 32);
            this.textBoxActorDateOfBirth.TabIndex = 74;
            this.textBoxActorDateOfBirth.Leave += new System.EventHandler(this.FocusLeaveActorDate);
            // 
            // textBoxActorSurname
            // 
            this.textBoxActorSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxActorSurname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActorSurname.Location = new System.Drawing.Point(665, 237);
            this.textBoxActorSurname.Name = "textBoxActorSurname";
            this.textBoxActorSurname.Size = new System.Drawing.Size(175, 32);
            this.textBoxActorSurname.TabIndex = 73;
            this.textBoxActorSurname.Leave += new System.EventHandler(this.FocusLeaveActorSurname);
            // 
            // textBoxActorName
            // 
            this.textBoxActorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxActorName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActorName.Location = new System.Drawing.Point(665, 186);
            this.textBoxActorName.Name = "textBoxActorName";
            this.textBoxActorName.Size = new System.Drawing.Size(175, 32);
            this.textBoxActorName.TabIndex = 72;
            this.textBoxActorName.Leave += new System.EventHandler(this.FocusLeaveActorName);
            // 
            // listBoxActors
            // 
            this.listBoxActors.FormattingEnabled = true;
            this.listBoxActors.Location = new System.Drawing.Point(10, 163);
            this.listBoxActors.Name = "listBoxActors";
            this.listBoxActors.Size = new System.Drawing.Size(460, 485);
            this.listBoxActors.TabIndex = 68;
            // 
            // buttonDeleteActor
            // 
            this.buttonDeleteActor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteActor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteActor.Location = new System.Drawing.Point(296, 84);
            this.buttonDeleteActor.Name = "buttonDeleteActor";
            this.buttonDeleteActor.Size = new System.Drawing.Size(137, 56);
            this.buttonDeleteActor.TabIndex = 67;
            this.buttonDeleteActor.Text = "Izbrisi Glumca";
            this.buttonDeleteActor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteActor.UseVisualStyleBackColor = false;
            this.buttonDeleteActor.Click += new System.EventHandler(this.buttonDeleteActor_Click);
            this.buttonDeleteActor.MouseHover += new System.EventHandler(this.MouseHoverDeleteActor);
            // 
            // buttonUpdateActor
            // 
            this.buttonUpdateActor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdateActor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateActor.Location = new System.Drawing.Point(153, 84);
            this.buttonUpdateActor.Name = "buttonUpdateActor";
            this.buttonUpdateActor.Size = new System.Drawing.Size(137, 56);
            this.buttonUpdateActor.TabIndex = 66;
            this.buttonUpdateActor.Text = "Izmeni Glumca";
            this.buttonUpdateActor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateActor.UseVisualStyleBackColor = false;
            this.buttonUpdateActor.Click += new System.EventHandler(this.buttonUpdateActor_Click);
            this.buttonUpdateActor.MouseHover += new System.EventHandler(this.MouseHoverUpdateActor);
            // 
            // buttonInsertActor
            // 
            this.buttonInsertActor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInsertActor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertActor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonInsertActor.Location = new System.Drawing.Point(10, 84);
            this.buttonInsertActor.Name = "buttonInsertActor";
            this.buttonInsertActor.Size = new System.Drawing.Size(137, 56);
            this.buttonInsertActor.TabIndex = 65;
            this.buttonInsertActor.Text = "Unesi Glumca";
            this.buttonInsertActor.UseVisualStyleBackColor = false;
            this.buttonInsertActor.Click += new System.EventHandler(this.buttonInsertActor_Click);
            this.buttonInsertActor.MouseHover += new System.EventHandler(this.MouseHoverInsertActor);
            // 
            // textBoxArctorSearch
            // 
            this.textBoxArctorSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArctorSearch.Location = new System.Drawing.Point(529, 497);
            this.textBoxArctorSearch.Name = "textBoxArctorSearch";
            this.textBoxArctorSearch.Size = new System.Drawing.Size(311, 32);
            this.textBoxArctorSearch.TabIndex = 80;
            this.textBoxArctorSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(490, 625);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.Step = 34;
            this.progressBar1.TabIndex = 81;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(499, 497);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(540, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 83;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(495, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(329, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(495, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(247, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 86;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(476, 235);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(187, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 87;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(476, 289);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(187, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 88;
            this.pictureBox7.TabStop = false;
            // 
            // ActorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 661);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxArctorSearch);
            this.Controls.Add(this.checkBoxActorOscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonActorSearch);
            this.Controls.Add(this.textBoxActorDateOfBirth);
            this.Controls.Add(this.textBoxActorSurname);
            this.Controls.Add(this.textBoxActorName);
            this.Controls.Add(this.listBoxActors);
            this.Controls.Add(this.buttonDeleteActor);
            this.Controls.Add(this.buttonUpdateActor);
            this.Controls.Add(this.buttonInsertActor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimumSize = new System.Drawing.Size(870, 700);
            this.Name = "ActorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxActorOscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonActorSearch;
        private System.Windows.Forms.TextBox textBoxActorDateOfBirth;
        private System.Windows.Forms.TextBox textBoxActorSurname;
        private System.Windows.Forms.TextBox textBoxActorName;
        private System.Windows.Forms.ListBox listBoxActors;
        private System.Windows.Forms.Button buttonDeleteActor;
        private System.Windows.Forms.Button buttonUpdateActor;
        private System.Windows.Forms.Button buttonInsertActor;
        private System.Windows.Forms.TextBox textBoxArctorSearch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}