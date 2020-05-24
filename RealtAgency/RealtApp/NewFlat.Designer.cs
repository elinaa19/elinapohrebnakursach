namespace RealtAgency
{
    partial class NewFlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFlat));
            this.buttonRegister = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ManePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adressField = new System.Windows.Forms.TextBox();
            this.coordsField = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.priceField = new System.Windows.Forms.TextBox();
            this.roomsField = new System.Windows.Forms.TextBox();
            this.conditionField = new System.Windows.Forms.TextBox();
            this.neighField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ManePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonRegister.FlatAppearance.BorderSize = 2;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(187)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(211, 306);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(148, 34);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Complete";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameField.Location = new System.Drawing.Point(31, 79);
            this.nameField.Name = "nameField";
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nameField.Size = new System.Drawing.Size(213, 24);
            this.nameField.TabIndex = 2;
            this.nameField.Text = "Name";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add flat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManePanel
            // 
            this.ManePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ManePanel.AutoScroll = true;
            this.ManePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ManePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManePanel.Controls.Add(this.pictureBox1);
            this.ManePanel.Controls.Add(this.adressField);
            this.ManePanel.Controls.Add(this.coordsField);
            this.ManePanel.Controls.Add(this.BackButton);
            this.ManePanel.Controls.Add(this.priceField);
            this.ManePanel.Controls.Add(this.roomsField);
            this.ManePanel.Controls.Add(this.conditionField);
            this.ManePanel.Controls.Add(this.neighField);
            this.ManePanel.Controls.Add(this.buttonRegister);
            this.ManePanel.Controls.Add(this.nameField);
            this.ManePanel.Controls.Add(this.panel2);
            this.ManePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManePanel.Location = new System.Drawing.Point(0, 0);
            this.ManePanel.Name = "ManePanel";
            this.ManePanel.Size = new System.Drawing.Size(631, 362);
            this.ManePanel.TabIndex = 7;
            this.ManePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManePanel_Paint);
            this.ManePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManePanel_MouseDown);
            this.ManePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ManePanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 105);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adressField
            // 
            this.adressField.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.adressField.Location = new System.Drawing.Point(31, 125);
            this.adressField.Multiline = true;
            this.adressField.Name = "adressField";
            this.adressField.Size = new System.Drawing.Size(213, 23);
            this.adressField.TabIndex = 14;
            this.adressField.Text = "Adress";
            // 
            // coordsField
            // 
            this.coordsField.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordsField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.coordsField.Location = new System.Drawing.Point(31, 221);
            this.coordsField.Multiline = true;
            this.coordsField.Name = "coordsField";
            this.coordsField.Size = new System.Drawing.Size(213, 23);
            this.coordsField.TabIndex = 12;
            this.coordsField.Text = "Your coordinates";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BackButton.FlatAppearance.BorderSize = 2;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(31, 306);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(155, 34);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // priceField
            // 
            this.priceField.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.priceField.Location = new System.Drawing.Point(338, 80);
            this.priceField.Multiline = true;
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(213, 23);
            this.priceField.TabIndex = 10;
            this.priceField.Text = "Cost ";
            // 
            // roomsField
            // 
            this.roomsField.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.roomsField.Location = new System.Drawing.Point(338, 125);
            this.roomsField.Multiline = true;
            this.roomsField.Name = "roomsField";
            this.roomsField.Size = new System.Drawing.Size(213, 23);
            this.roomsField.TabIndex = 9;
            this.roomsField.Text = "Amount of rooms";
            // 
            // conditionField
            // 
            this.conditionField.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.conditionField.Location = new System.Drawing.Point(338, 175);
            this.conditionField.Multiline = true;
            this.conditionField.Name = "conditionField";
            this.conditionField.Size = new System.Drawing.Size(213, 23);
            this.conditionField.TabIndex = 8;
            this.conditionField.Text = "Condition (range 1-10)";
            // 
            // neighField
            // 
            this.neighField.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neighField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.neighField.Location = new System.Drawing.Point(31, 175);
            this.neighField.Multiline = true;
            this.neighField.Name = "neighField";
            this.neighField.Size = new System.Drawing.Size(213, 23);
            this.neighField.TabIndex = 7;
            this.neighField.Text = "Neighbourhood";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.Close_Button);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 58);
            this.panel2.TabIndex = 0;
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close_Button.Location = new System.Drawing.Point(548, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 32);
            this.Close_Button.TabIndex = 9;
            this.Close_Button.Text = "x";
            this.Close_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(806, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // NewFlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 353);
            this.Controls.Add(this.ManePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewFlat";
            this.Text = "AddFlat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFlat_FormClosing);
            this.ManePanel.ResumeLayout(false);
            this.ManePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ManePanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox roomsField;
        private System.Windows.Forms.TextBox conditionField;
        private System.Windows.Forms.TextBox neighField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coordsField;
        private System.Windows.Forms.TextBox adressField;
        private System.Windows.Forms.Label Close_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}