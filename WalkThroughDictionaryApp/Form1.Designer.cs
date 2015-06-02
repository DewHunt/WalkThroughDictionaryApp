namespace WalkThroughDictionaryApp
{
    partial class DictionaryUI
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
            this.saveIdTextBox = new System.Windows.Forms.TextBox();
            this.saveIdLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.searchIdTextBox = new System.Windows.Forms.TextBox();
            this.searchIdLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.showAllListBox = new System.Windows.Forms.ListBox();
            this.showAllLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveIdTextBox
            // 
            this.saveIdTextBox.Location = new System.Drawing.Point(215, 40);
            this.saveIdTextBox.Name = "saveIdTextBox";
            this.saveIdTextBox.Size = new System.Drawing.Size(269, 20);
            this.saveIdTextBox.TabIndex = 0;
            // 
            // saveIdLabel
            // 
            this.saveIdLabel.AutoSize = true;
            this.saveIdLabel.Location = new System.Drawing.Point(179, 43);
            this.saveIdLabel.Name = "saveIdLabel";
            this.saveIdLabel.Size = new System.Drawing.Size(16, 13);
            this.saveIdLabel.TabIndex = 1;
            this.saveIdLabel.Text = "Id";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(160, 66);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLabel.TabIndex = 3;
            this.detailsLabel.Text = "Deatils";
            // 
            // searchIdTextBox
            // 
            this.searchIdTextBox.Location = new System.Drawing.Point(215, 204);
            this.searchIdTextBox.Name = "searchIdTextBox";
            this.searchIdTextBox.Size = new System.Drawing.Size(269, 20);
            this.searchIdTextBox.TabIndex = 3;
            // 
            // searchIdLabel
            // 
            this.searchIdLabel.AutoSize = true;
            this.searchIdLabel.Location = new System.Drawing.Point(177, 207);
            this.searchIdLabel.Name = "searchIdLabel";
            this.searchIdLabel.Size = new System.Drawing.Size(18, 13);
            this.searchIdLabel.TabIndex = 5;
            this.searchIdLabel.Text = "ID";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(502, 138);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(502, 201);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(215, 239);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(136, 31);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(215, 66);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(269, 95);
            this.detailsTextBox.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(357, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 31);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showAllListBox
            // 
            this.showAllListBox.FormattingEnabled = true;
            this.showAllListBox.Location = new System.Drawing.Point(215, 287);
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(269, 121);
            this.showAllListBox.TabIndex = 7;
            // 
            // showAllLabel
            // 
            this.showAllLabel.AutoSize = true;
            this.showAllLabel.Location = new System.Drawing.Point(122, 287);
            this.showAllLabel.Name = "showAllLabel";
            this.showAllLabel.Size = new System.Drawing.Size(73, 13);
            this.showAllLabel.TabIndex = 8;
            this.showAllLabel.Text = "All Citizen Info";
            // 
            // DictionaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 427);
            this.Controls.Add(this.showAllLabel);
            this.Controls.Add(this.showAllListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchIdLabel);
            this.Controls.Add(this.searchIdTextBox);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.saveIdLabel);
            this.Controls.Add(this.saveIdTextBox);
            this.Name = "DictionaryUI";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saveIdTextBox;
        private System.Windows.Forms.Label saveIdLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox searchIdTextBox;
        private System.Windows.Forms.Label searchIdLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox showAllListBox;
        private System.Windows.Forms.Label showAllLabel;
    }
}

