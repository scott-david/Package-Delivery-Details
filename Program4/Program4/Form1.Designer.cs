namespace Program4
{
    partial class Form1
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
            this.originZipLabel = new System.Windows.Forms.Label();
            this.destZipLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.originTextbox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendUOfLButton = new System.Windows.Forms.Button();
            this.sendFromUOfL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originZipLabel
            // 
            this.originZipLabel.AutoSize = true;
            this.originZipLabel.Location = new System.Drawing.Point(24, 9);
            this.originZipLabel.Name = "originZipLabel";
            this.originZipLabel.Size = new System.Drawing.Size(74, 17);
            this.originZipLabel.TabIndex = 0;
            this.originZipLabel.Text = "Origin Zip:";
            // 
            // destZipLabel
            // 
            this.destZipLabel.AutoSize = true;
            this.destZipLabel.Location = new System.Drawing.Point(2, 52);
            this.destZipLabel.Name = "destZipLabel";
            this.destZipLabel.Size = new System.Drawing.Size(107, 17);
            this.destZipLabel.TabIndex = 1;
            this.destZipLabel.Text = "Destination Zip:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(53, 89);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(61, 125);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(56, 164);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(53, 17);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(56, 203);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(56, 17);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Weight:";
            // 
            // originTextbox
            // 
            this.originTextbox.Location = new System.Drawing.Point(123, 6);
            this.originTextbox.Name = "originTextbox";
            this.originTextbox.Size = new System.Drawing.Size(100, 22);
            this.originTextbox.TabIndex = 6;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(123, 49);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(100, 22);
            this.destinationTextBox.TabIndex = 7;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(123, 86);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.lengthTextBox.TabIndex = 8;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(123, 125);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 22);
            this.widthTextBox.TabIndex = 9;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(123, 164);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 10;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(123, 200);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightTextBox.TabIndex = 11;
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.ItemHeight = 16;
            this.packageListBox.Location = new System.Drawing.Point(249, 6);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(168, 212);
            this.packageListBox.TabIndex = 12;
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(42, 247);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(181, 39);
            this.addPackageButton.TabIndex = 13;
            this.addPackageButton.Text = "Add Ground Package:";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(438, 25);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(89, 44);
            this.detailsButton.TabIndex = 14;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // sendUOfLButton
            // 
            this.sendUOfLButton.Location = new System.Drawing.Point(438, 86);
            this.sendUOfLButton.Name = "sendUOfLButton";
            this.sendUOfLButton.Size = new System.Drawing.Size(89, 44);
            this.sendUOfLButton.TabIndex = 15;
            this.sendUOfLButton.Text = "Send To UofL";
            this.sendUOfLButton.UseVisualStyleBackColor = true;
            this.sendUOfLButton.Click += new System.EventHandler(this.sendUOfLButton_Click);
            // 
            // sendFromUOfL
            // 
            this.sendFromUOfL.Location = new System.Drawing.Point(438, 151);
            this.sendFromUOfL.Name = "sendFromUOfL";
            this.sendFromUOfL.Size = new System.Drawing.Size(89, 43);
            this.sendFromUOfL.TabIndex = 16;
            this.sendFromUOfL.Text = "Send From UofL";
            this.sendFromUOfL.UseVisualStyleBackColor = true;
            this.sendFromUOfL.Click += new System.EventHandler(this.sendFromUOfL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 298);
            this.Controls.Add(this.sendFromUOfL);
            this.Controls.Add(this.sendUOfLButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.originTextbox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destZipLabel);
            this.Controls.Add(this.originZipLabel);
            this.Name = "Form1";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originZipLabel;
        private System.Windows.Forms.Label destZipLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox originTextbox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button sendUOfLButton;
        private System.Windows.Forms.Button sendFromUOfL;
    }
}

