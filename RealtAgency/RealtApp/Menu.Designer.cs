namespace RealtAgency
{
    partial class Menu
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
            this.AddNewFlatButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ShowCustomersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ManePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ManePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewFlatButton
            // 
            this.AddNewFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.AddNewFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewFlatButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddNewFlatButton.FlatAppearance.BorderSize = 2;
            this.AddNewFlatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddNewFlatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddNewFlatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewFlatButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewFlatButton.Location = new System.Drawing.Point(65, 433);
            this.AddNewFlatButton.Name = "AddNewFlatButton";
            this.AddNewFlatButton.Size = new System.Drawing.Size(201, 33);
            this.AddNewFlatButton.TabIndex = 11;
            this.AddNewFlatButton.Text = "Add new flat";
            this.AddNewFlatButton.UseVisualStyleBackColor = false;
            this.AddNewFlatButton.Click += new System.EventHandler(this.AddNewFlatButton_Click);
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
            this.CloseButton.Size = new System.Drawing.Size(34, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ShowCustomersButton
            // 
            this.ShowCustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.ShowCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowCustomersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ShowCustomersButton.FlatAppearance.BorderSize = 2;
            this.ShowCustomersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(187)))));
            this.ShowCustomersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ShowCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCustomersButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCustomersButton.Location = new System.Drawing.Point(573, 433);
            this.ShowCustomersButton.Name = "ShowCustomersButton";
            this.ShowCustomersButton.Size = new System.Drawing.Size(201, 33);
            this.ShowCustomersButton.TabIndex = 5;
            this.ShowCustomersButton.Text = "Show customers";
            this.ShowCustomersButton.UseVisualStyleBackColor = false;
            this.ShowCustomersButton.Click += new System.EventHandler(this.ShowCustomersButton_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManePanel
            // 
            this.ManePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ManePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManePanel.Controls.Add(this.AddNewFlatButton);
            this.ManePanel.Controls.Add(this.ShowCustomersButton);
            this.ManePanel.Controls.Add(this.panel2);
            this.ManePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManePanel.Location = new System.Drawing.Point(0, 0);
            this.ManePanel.Name = "ManePanel";
            this.ManePanel.Size = new System.Drawing.Size(841, 517);
            this.ManePanel.TabIndex = 7;
            this.ManePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManePanel_Paint);
            this.ManePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManePanel_MouseDown);
            this.ManePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ManePanel_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 58);
            this.panel2.TabIndex = 0;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 517);
            this.Controls.Add(this.ManePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Your Options";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ManePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewFlatButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button ShowCustomersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ManePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}