namespace VideoClubAviato
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxMessageBody = new System.Windows.Forms.TextBox();
            this.textBoxAttachment = new System.Windows.Forms.TextBox();
            this.buttonAttachment = new System.Windows.Forms.Button();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelEmailOfSender = new System.Windows.Forms.Label();
            this.textBoxEmailOfSender = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelRandom1 = new System.Windows.Forms.Label();
            this.labelRandom2 = new System.Windows.Forms.Label();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj Fajl";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 23);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naslov Poruke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sadrzaj Poruke";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(107, 87);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(186, 20);
            this.textBoxSubject.TabIndex = 3;
            this.textBoxSubject.Leave += new System.EventHandler(this.textBoxSubject_Leave);
            // 
            // textBoxMessageBody
            // 
            this.textBoxMessageBody.Location = new System.Drawing.Point(107, 118);
            this.textBoxMessageBody.Multiline = true;
            this.textBoxMessageBody.Name = "textBoxMessageBody";
            this.textBoxMessageBody.Size = new System.Drawing.Size(465, 80);
            this.textBoxMessageBody.TabIndex = 4;
            this.textBoxMessageBody.Leave += new System.EventHandler(this.textBoxMessageBody_Leave);
            // 
            // textBoxAttachment
            // 
            this.textBoxAttachment.Enabled = false;
            this.textBoxAttachment.Location = new System.Drawing.Point(107, 216);
            this.textBoxAttachment.Name = "textBoxAttachment";
            this.textBoxAttachment.Size = new System.Drawing.Size(363, 20);
            this.textBoxAttachment.TabIndex = 6;
            // 
            // buttonAttachment
            // 
            this.buttonAttachment.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAttachment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttachment.Location = new System.Drawing.Point(477, 216);
            this.buttonAttachment.Name = "buttonAttachment";
            this.buttonAttachment.Size = new System.Drawing.Size(95, 23);
            this.buttonAttachment.TabIndex = 5;
            this.buttonAttachment.Text = "Dodaj";
            this.buttonAttachment.UseVisualStyleBackColor = false;
            this.buttonAttachment.Click += new System.EventHandler(this.buttonAttachment_Click);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSendMessage.Enabled = false;
            this.buttonSendMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSendMessage.Location = new System.Drawing.Point(158, 281);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(416, 36);
            this.buttonSendMessage.TabIndex = 8;
            this.buttonSendMessage.Text = "P O S A LJ I";
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelEmailOfSender
            // 
            this.labelEmailOfSender.AutoSize = true;
            this.labelEmailOfSender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelEmailOfSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailOfSender.Location = new System.Drawing.Point(39, 33);
            this.labelEmailOfSender.Name = "labelEmailOfSender";
            this.labelEmailOfSender.Size = new System.Drawing.Size(62, 13);
            this.labelEmailOfSender.TabIndex = 10;
            this.labelEmailOfSender.Text = "Vas Email";
            // 
            // textBoxEmailOfSender
            // 
            this.textBoxEmailOfSender.Location = new System.Drawing.Point(107, 30);
            this.textBoxEmailOfSender.Name = "textBoxEmailOfSender";
            this.textBoxEmailOfSender.Size = new System.Drawing.Size(186, 20);
            this.textBoxEmailOfSender.TabIndex = 1;
            this.textBoxEmailOfSender.Leave += new System.EventHandler(this.textBoxEmailOfSender_Leave);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Informacija",
            "Prijava greske",
            "Ostalo"});
            this.comboBoxCategory.Location = new System.Drawing.Point(107, 57);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(186, 23);
            this.comboBoxCategory.TabIndex = 2;
            this.comboBoxCategory.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kategorija";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(299, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // labelRandom1
            // 
            this.labelRandom1.AutoSize = true;
            this.labelRandom1.Location = new System.Drawing.Point(30, 291);
            this.labelRandom1.Name = "labelRandom1";
            this.labelRandom1.Size = new System.Drawing.Size(0, 13);
            this.labelRandom1.TabIndex = 15;
            this.labelRandom1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRandom2
            // 
            this.labelRandom2.AutoSize = true;
            this.labelRandom2.Location = new System.Drawing.Point(50, 291);
            this.labelRandom2.Name = "labelRandom2";
            this.labelRandom2.Size = new System.Drawing.Size(0, 13);
            this.labelRandom2.TabIndex = 16;
            this.labelRandom2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(80, 288);
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(72, 20);
            this.textBoxResponse.TabIndex = 17;
            this.textBoxResponse.Leave += new System.EventHandler(this.textBoxResponse_Leave);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 316);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.labelRandom2);
            this.Controls.Add(this.labelRandom1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxEmailOfSender);
            this.Controls.Add(this.labelEmailOfSender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.buttonAttachment);
            this.Controls.Add(this.textBoxAttachment);
            this.Controls.Add(this.textBoxMessageBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 355);
            this.MinimumSize = new System.Drawing.Size(600, 355);
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contact_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxMessageBody;
        private System.Windows.Forms.TextBox textBoxAttachment;
        private System.Windows.Forms.Button buttonAttachment;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelEmailOfSender;
        private System.Windows.Forms.TextBox textBoxEmailOfSender;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelRandom1;
        private System.Windows.Forms.Label labelRandom2;
        private System.Windows.Forms.TextBox textBoxResponse;
    }
}