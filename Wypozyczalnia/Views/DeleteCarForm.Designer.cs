namespace Wypozyczalnia.Views
{
    partial class DeleteCarForm
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
            this.licensePlateNumberLabel = new System.Windows.Forms.Label();
            this.licensePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.VINTextBox = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // licensePlateNumberLabel
            // 
            this.licensePlateNumberLabel.AutoSize = true;
            this.licensePlateNumberLabel.Location = new System.Drawing.Point(13, 13);
            this.licensePlateNumberLabel.Name = "licensePlateNumberLabel";
            this.licensePlateNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.licensePlateNumberLabel.TabIndex = 0;
            this.licensePlateNumberLabel.Text = "Numer rejestracyjny";
            // 
            // licensePlateNumberTextBox
            // 
            this.licensePlateNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.licensePlateNumberTextBox.Location = new System.Drawing.Point(118, 10);
            this.licensePlateNumberTextBox.Name = "licensePlateNumberTextBox";
            this.licensePlateNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.licensePlateNumberTextBox.TabIndex = 1;
            this.licensePlateNumberTextBox.TextChanged += new System.EventHandler(this.LicensePlateNumberTextBox_TextChanged);
            // 
            // VINTextBox
            // 
            this.VINTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.VINTextBox.Location = new System.Drawing.Point(118, 44);
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.Size = new System.Drawing.Size(120, 20);
            this.VINTextBox.TabIndex = 3;
            this.VINTextBox.TextChanged += new System.EventHandler(this.VINTextBox_TextChanged);
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(13, 47);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(25, 13);
            this.VINLabel.TabIndex = 2;
            this.VINLabel.Text = "VIN";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 88);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(162, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 131);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.VINTextBox);
            this.Controls.Add(this.VINLabel);
            this.Controls.Add(this.licensePlateNumberTextBox);
            this.Controls.Add(this.licensePlateNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteCarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuń samochód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label licensePlateNumberLabel;
        private System.Windows.Forms.TextBox licensePlateNumberTextBox;
        private System.Windows.Forms.TextBox VINTextBox;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
    }
}