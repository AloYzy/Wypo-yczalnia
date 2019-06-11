namespace Wypozyczalnia.Views
{
    partial class RentForm
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
            this.clientDataGroupBox = new System.Windows.Forms.GroupBox();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rentPeriodGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptRentButton = new System.Windows.Forms.Button();
            this.carDataGroupBox = new System.Windows.Forms.GroupBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.licensePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateNumberLabel = new System.Windows.Forms.Label();
            this.engineTextBox = new System.Windows.Forms.TextBox();
            this.engineLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.clientDataGroupBox.SuspendLayout();
            this.rentPeriodGroupBox.SuspendLayout();
            this.carDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientDataGroupBox
            // 
            this.clientDataGroupBox.Controls.Add(this.licenseTextBox);
            this.clientDataGroupBox.Controls.Add(this.licenseLabel);
            this.clientDataGroupBox.Controls.Add(this.surnameTextBox);
            this.clientDataGroupBox.Controls.Add(this.surnameLabel);
            this.clientDataGroupBox.Controls.Add(this.nameTextBox);
            this.clientDataGroupBox.Controls.Add(this.nameLabel);
            this.clientDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.clientDataGroupBox.Name = "clientDataGroupBox";
            this.clientDataGroupBox.Size = new System.Drawing.Size(228, 126);
            this.clientDataGroupBox.TabIndex = 0;
            this.clientDataGroupBox.TabStop = false;
            this.clientDataGroupBox.Text = "Dane klienta";
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.licenseTextBox.Location = new System.Drawing.Point(76, 90);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.Size = new System.Drawing.Size(140, 20);
            this.licenseTextBox.TabIndex = 5;
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(6, 87);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(63, 26);
            this.licenseLabel.TabIndex = 4;
            this.licenseLabel.Text = "Numer\r\nprawa jazdy";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.surnameTextBox.Location = new System.Drawing.Point(76, 55);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(140, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(6, 58);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(53, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // nameTextBox
            // 
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.Location = new System.Drawing.Point(76, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(26, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imię";
            // 
            // rentPeriodGroupBox
            // 
            this.rentPeriodGroupBox.Controls.Add(this.endDateTimePicker);
            this.rentPeriodGroupBox.Controls.Add(this.endLabel);
            this.rentPeriodGroupBox.Controls.Add(this.startDateTimePicker);
            this.rentPeriodGroupBox.Controls.Add(this.startLabel);
            this.rentPeriodGroupBox.Location = new System.Drawing.Point(12, 145);
            this.rentPeriodGroupBox.Name = "rentPeriodGroupBox";
            this.rentPeriodGroupBox.Size = new System.Drawing.Size(228, 84);
            this.rentPeriodGroupBox.TabIndex = 1;
            this.rentPeriodGroupBox.TabStop = false;
            this.rentPeriodGroupBox.Text = "Okres wypożyczenia";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(76, 49);
            this.endDateTimePicker.MinDate = new System.DateTime(2019, 6, 12, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.endDateTimePicker.TabIndex = 3;
            this.endDateTimePicker.Value = new System.DateTime(2019, 6, 12, 0, 0, 0, 0);
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.EndDateTimePicker_ValueChanged);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(9, 49);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(40, 13);
            this.endLabel.TabIndex = 2;
            this.endLabel.Text = "Koniec";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(76, 20);
            this.startDateTimePicker.MinDate = new System.DateTime(2019, 6, 11, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.startDateTimePicker.TabIndex = 1;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(9, 20);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(52, 13);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Początek";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(247, 263);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptRentButton
            // 
            this.acceptRentButton.Location = new System.Drawing.Point(399, 263);
            this.acceptRentButton.Name = "acceptRentButton";
            this.acceptRentButton.Size = new System.Drawing.Size(75, 23);
            this.acceptRentButton.TabIndex = 3;
            this.acceptRentButton.Text = "Potwierdź";
            this.acceptRentButton.UseVisualStyleBackColor = true;
            this.acceptRentButton.Click += new System.EventHandler(this.AcceptRentButton_Click);
            // 
            // carDataGroupBox
            // 
            this.carDataGroupBox.Controls.Add(this.costTextBox);
            this.carDataGroupBox.Controls.Add(this.costLabel);
            this.carDataGroupBox.Controls.Add(this.licensePlateNumberTextBox);
            this.carDataGroupBox.Controls.Add(this.licensePlateNumberLabel);
            this.carDataGroupBox.Controls.Add(this.engineTextBox);
            this.carDataGroupBox.Controls.Add(this.engineLabel);
            this.carDataGroupBox.Controls.Add(this.modelTextBox);
            this.carDataGroupBox.Controls.Add(this.modelLabel);
            this.carDataGroupBox.Controls.Add(this.manufacturerTextBox);
            this.carDataGroupBox.Controls.Add(this.manufacturerLabel);
            this.carDataGroupBox.Location = new System.Drawing.Point(247, 12);
            this.carDataGroupBox.Name = "carDataGroupBox";
            this.carDataGroupBox.Size = new System.Drawing.Size(227, 217);
            this.carDataGroupBox.TabIndex = 4;
            this.carDataGroupBox.TabStop = false;
            this.carDataGroupBox.Text = "Dane samochodu";
            // 
            // costTextBox
            // 
            this.costTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.costTextBox.Enabled = false;
            this.costTextBox.Location = new System.Drawing.Point(76, 160);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(140, 20);
            this.costTextBox.TabIndex = 11;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(6, 163);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(33, 13);
            this.costLabel.TabIndex = 10;
            this.costLabel.Text = "Koszt";
            // 
            // licensePlateNumberTextBox
            // 
            this.licensePlateNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.licensePlateNumberTextBox.Enabled = false;
            this.licensePlateNumberTextBox.Location = new System.Drawing.Point(76, 125);
            this.licensePlateNumberTextBox.Name = "licensePlateNumberTextBox";
            this.licensePlateNumberTextBox.Size = new System.Drawing.Size(140, 20);
            this.licensePlateNumberTextBox.TabIndex = 9;
            // 
            // licensePlateNumberLabel
            // 
            this.licensePlateNumberLabel.AutoSize = true;
            this.licensePlateNumberLabel.Location = new System.Drawing.Point(6, 121);
            this.licensePlateNumberLabel.Name = "licensePlateNumberLabel";
            this.licensePlateNumberLabel.Size = new System.Drawing.Size(65, 26);
            this.licensePlateNumberLabel.TabIndex = 8;
            this.licensePlateNumberLabel.Text = "Numer\r\nrejestracyjny";
            // 
            // engineTextBox
            // 
            this.engineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.engineTextBox.Enabled = false;
            this.engineTextBox.Location = new System.Drawing.Point(76, 90);
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.Size = new System.Drawing.Size(140, 20);
            this.engineTextBox.TabIndex = 7;
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Location = new System.Drawing.Point(6, 93);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(32, 13);
            this.engineLabel.TabIndex = 6;
            this.engineLabel.Text = "Silnik";
            // 
            // modelTextBox
            // 
            this.modelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.modelTextBox.Enabled = false;
            this.modelTextBox.Location = new System.Drawing.Point(76, 55);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(140, 20);
            this.modelTextBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(6, 58);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Model";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.manufacturerTextBox.Enabled = false;
            this.manufacturerTextBox.Location = new System.Drawing.Point(76, 20);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(140, 20);
            this.manufacturerTextBox.TabIndex = 3;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(6, 23);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(37, 13);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Marka";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(247, 236);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(82, 13);
            this.summaryLabel.TabIndex = 5;
            this.summaryLabel.Text = "Podsumowanie:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalCostLabel.ForeColor = System.Drawing.Color.Red;
            this.totalCostLabel.Location = new System.Drawing.Point(376, 236);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalCostLabel.Size = new System.Drawing.Size(100, 13);
            this.totalCostLabel.TabIndex = 6;
            this.totalCostLabel.Text = "0,00";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 303);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.carDataGroupBox);
            this.Controls.Add(this.acceptRentButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rentPeriodGroupBox);
            this.Controls.Add(this.clientDataGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wypożycz samochód";
            this.clientDataGroupBox.ResumeLayout(false);
            this.clientDataGroupBox.PerformLayout();
            this.rentPeriodGroupBox.ResumeLayout(false);
            this.rentPeriodGroupBox.PerformLayout();
            this.carDataGroupBox.ResumeLayout(false);
            this.carDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox clientDataGroupBox;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox rentPeriodGroupBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptRentButton;
        private System.Windows.Forms.GroupBox carDataGroupBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox licensePlateNumberTextBox;
        private System.Windows.Forms.Label licensePlateNumberLabel;
        private System.Windows.Forms.TextBox engineTextBox;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label totalCostLabel;
    }
}