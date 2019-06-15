namespace Wypozyczalnia.Views
{
    partial class ReturnCarForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.licensePlateNumberLabel = new System.Windows.Forms.Label();
            this.licensePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(163, 61);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // licensePlateNumberLabel
            // 
            this.licensePlateNumberLabel.AutoSize = true;
            this.licensePlateNumberLabel.Location = new System.Drawing.Point(13, 23);
            this.licensePlateNumberLabel.Name = "licensePlateNumberLabel";
            this.licensePlateNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.licensePlateNumberLabel.TabIndex = 1;
            this.licensePlateNumberLabel.Text = "Numer rejestracyjny";
            // 
            // licensePlateNumberTextBox
            // 
            this.licensePlateNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.licensePlateNumberTextBox.Location = new System.Drawing.Point(118, 20);
            this.licensePlateNumberTextBox.Name = "licensePlateNumberTextBox";
            this.licensePlateNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.licensePlateNumberTextBox.TabIndex = 2;
            this.licensePlateNumberTextBox.TextChanged += new System.EventHandler(this.LicensePlateNumberTextBox_TextChanged);
            // 
            // ReturnCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 102);
            this.Controls.Add(this.licensePlateNumberTextBox);
            this.Controls.Add(this.licensePlateNumberLabel);
            this.Controls.Add(this.searchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnCarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Odbierz samochód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label licensePlateNumberLabel;
        private System.Windows.Forms.TextBox licensePlateNumberTextBox;
    }
}