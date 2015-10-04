namespace ExcludeBlaze
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
            this.button1 = new System.Windows.Forms.Button();
            this.BZpathsBox = new System.Windows.Forms.ListBox();
            this.bzListTitleLabel = new System.Windows.Forms.Label();
            this.YourPathsBox = new System.Windows.Forms.ListBox();
            this.myListTitleLabel = new System.Windows.Forms.Label();
            this.importFromBBbutton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.yourPathsCount = new System.Windows.Forms.TextBox();
            this.bzBoxCount = new System.Windows.Forms.TextBox();
            this.instructionsTextLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<< Merge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.mergeToBZbutton_Click);
            // 
            // BZpathsBox
            // 
            this.BZpathsBox.FormattingEnabled = true;
            this.BZpathsBox.Location = new System.Drawing.Point(12, 40);
            this.BZpathsBox.Name = "BZpathsBox";
            this.BZpathsBox.Size = new System.Drawing.Size(347, 199);
            this.BZpathsBox.TabIndex = 2;
            // 
            // bzListTitleLabel
            // 
            this.bzListTitleLabel.AutoSize = true;
            this.bzListTitleLabel.Location = new System.Drawing.Point(12, 13);
            this.bzListTitleLabel.Name = "bzListTitleLabel";
            this.bzListTitleLabel.Size = new System.Drawing.Size(232, 13);
            this.bzListTitleLabel.TabIndex = 3;
            this.bzListTitleLabel.Text = "BZ\'s custom exclusion list (default paths hidden)";
            // 
            // YourPathsBox
            // 
            this.YourPathsBox.FormattingEnabled = true;
            this.YourPathsBox.Location = new System.Drawing.Point(446, 40);
            this.YourPathsBox.Name = "YourPathsBox";
            this.YourPathsBox.Size = new System.Drawing.Size(363, 199);
            this.YourPathsBox.TabIndex = 4;
            // 
            // myListTitleLabel
            // 
            this.myListTitleLabel.AutoSize = true;
            this.myListTitleLabel.Location = new System.Drawing.Point(443, 13);
            this.myListTitleLabel.Name = "myListTitleLabel";
            this.myListTitleLabel.Size = new System.Drawing.Size(83, 13);
            this.myListTitleLabel.TabIndex = 5;
            this.myListTitleLabel.Text = "My exclusion list";
            // 
            // importFromBBbutton
            // 
            this.importFromBBbutton.Location = new System.Drawing.Point(365, 106);
            this.importFromBBbutton.Name = "importFromBBbutton";
            this.importFromBBbutton.Size = new System.Drawing.Size(75, 23);
            this.importFromBBbutton.TabIndex = 6;
            this.importFromBBbutton.Text = "Merge >>";
            this.importFromBBbutton.UseVisualStyleBackColor = true;
            this.importFromBBbutton.Click += new System.EventHandler(this.mergeFromBZbutton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(446, 245);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "&Add...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(527, 245);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "&Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // yourPathsCount
            // 
            this.yourPathsCount.Location = new System.Drawing.Point(765, 247);
            this.yourPathsCount.Name = "yourPathsCount";
            this.yourPathsCount.ReadOnly = true;
            this.yourPathsCount.Size = new System.Drawing.Size(44, 20);
            this.yourPathsCount.TabIndex = 10;
            // 
            // bzBoxCount
            // 
            this.bzBoxCount.Location = new System.Drawing.Point(316, 245);
            this.bzBoxCount.Name = "bzBoxCount";
            this.bzBoxCount.ReadOnly = true;
            this.bzBoxCount.Size = new System.Drawing.Size(43, 20);
            this.bzBoxCount.TabIndex = 11;
            // 
            // instructionsTextLabel
            // 
            this.instructionsTextLabel.AutoSize = true;
            this.instructionsTextLabel.Location = new System.Drawing.Point(9, 282);
            this.instructionsTextLabel.Name = "instructionsTextLabel";
            this.instructionsTextLabel.Size = new System.Drawing.Size(577, 13);
            this.instructionsTextLabel.TabIndex = 12;
            this.instructionsTextLabel.Text = "Merging left will write to BZ config. No entries will be removed from BZ, only ad" +
    "ded. Still, you use this tool at your own risk!";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(739, 294);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 329);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.instructionsTextLabel);
            this.Controls.Add(this.bzBoxCount);
            this.Controls.Add(this.yourPathsCount);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.importFromBBbutton);
            this.Controls.Add(this.myListTitleLabel);
            this.Controls.Add(this.YourPathsBox);
            this.Controls.Add(this.bzListTitleLabel);
            this.Controls.Add(this.BZpathsBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ExcludeBlaze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox BZpathsBox;
        private System.Windows.Forms.Label bzListTitleLabel;
        private System.Windows.Forms.ListBox YourPathsBox;
        private System.Windows.Forms.Label myListTitleLabel;
        private System.Windows.Forms.Button importFromBBbutton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox yourPathsCount;
        private System.Windows.Forms.TextBox bzBoxCount;
        private System.Windows.Forms.Label instructionsTextLabel;
        private System.Windows.Forms.Button closeButton;
    }
}

