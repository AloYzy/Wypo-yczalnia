namespace Wypozyczalnia
{
    partial class ModifyCarForm
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
            this.searchVINTextBox = new System.Windows.Forms.TextBox();
            this.searchVINLabel = new System.Windows.Forms.Label();
            this.searchLicensePlateNumberLabel = new System.Windows.Forms.Label();
            this.searchLicensePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.driveTypeLabel = new System.Windows.Forms.Label();
            this.gearboxLabel = new System.Windows.Forms.Label();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.engineLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.VINTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateNumberLabel = new System.Windows.Forms.Label();
            this.licensePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.productionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.driveTypeComboBox = new System.Windows.Forms.ComboBox();
            this.gearboxComboBox = new System.Windows.Forms.ComboBox();
            this.engineComboBox = new System.Windows.Forms.ComboBox();
            this.modificationReasonTextBox = new System.Windows.Forms.TextBox();
            this.modificationReasonLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchVINTextBox
            // 
            this.searchVINTextBox.Location = new System.Drawing.Point(44, 12);
            this.searchVINTextBox.Name = "searchVINTextBox";
            this.searchVINTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchVINTextBox.TabIndex = 0;
            this.searchVINTextBox.TextChanged += new System.EventHandler(this.VINTextBox_TextChanged);
            // 
            // searchVINLabel
            // 
            this.searchVINLabel.AutoSize = true;
            this.searchVINLabel.Location = new System.Drawing.Point(13, 15);
            this.searchVINLabel.Name = "searchVINLabel";
            this.searchVINLabel.Size = new System.Drawing.Size(25, 13);
            this.searchVINLabel.TabIndex = 1;
            this.searchVINLabel.Text = "VIN";
            // 
            // searchLicensePlateNumberLabel
            // 
            this.searchLicensePlateNumberLabel.AutoSize = true;
            this.searchLicensePlateNumberLabel.Location = new System.Drawing.Point(192, 15);
            this.searchLicensePlateNumberLabel.Name = "searchLicensePlateNumberLabel";
            this.searchLicensePlateNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.searchLicensePlateNumberLabel.TabIndex = 3;
            this.searchLicensePlateNumberLabel.Text = "Nr rejestracyjny";
            // 
            // searchLicensePlateNumberTextBox
            // 
            this.searchLicensePlateNumberTextBox.Location = new System.Drawing.Point(277, 12);
            this.searchLicensePlateNumberTextBox.Name = "searchLicensePlateNumberTextBox";
            this.searchLicensePlateNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchLicensePlateNumberTextBox.TabIndex = 2;
            this.searchLicensePlateNumberTextBox.TextChanged += new System.EventHandler(this.LicensePlateNumberTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(443, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 67);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(33, 13);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Klasa";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(13, 97);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(37, 13);
            this.manufacturerLabel.TabIndex = 8;
            this.manufacturerLabel.Text = "Marka";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(98, 94);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(120, 20);
            this.manufacturerTextBox.TabIndex = 7;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(13, 127);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 10;
            this.modelLabel.Text = "Model";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(98, 124);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(120, 20);
            this.modelTextBox.TabIndex = 9;
            // 
            // driveTypeLabel
            // 
            this.driveTypeLabel.AutoSize = true;
            this.driveTypeLabel.Location = new System.Drawing.Point(13, 157);
            this.driveTypeLabel.Name = "driveTypeLabel";
            this.driveTypeLabel.Size = new System.Drawing.Size(79, 13);
            this.driveTypeLabel.TabIndex = 12;
            this.driveTypeLabel.Text = "Rodzaj napędu";
            // 
            // gearboxLabel
            // 
            this.gearboxLabel.AutoSize = true;
            this.gearboxLabel.Location = new System.Drawing.Point(13, 187);
            this.gearboxLabel.Name = "gearboxLabel";
            this.gearboxLabel.Size = new System.Drawing.Size(84, 13);
            this.gearboxLabel.TabIndex = 14;
            this.gearboxLabel.Text = "Skrzynia biegów";
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Location = new System.Drawing.Point(13, 217);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(76, 13);
            this.productionDateLabel.TabIndex = 16;
            this.productionDateLabel.Text = "Data produkcji";
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Location = new System.Drawing.Point(13, 247);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(32, 13);
            this.engineLabel.TabIndex = 18;
            this.engineLabel.Text = "Silnik";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(13, 277);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(83, 13);
            this.costLabel.TabIndex = 20;
            this.costLabel.Text = "Koszt wynajęcia";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(98, 274);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(120, 20);
            this.costTextBox.TabIndex = 19;
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(13, 307);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(25, 13);
            this.VINLabel.TabIndex = 22;
            this.VINLabel.Text = "VIN";
            // 
            // VINTextBox
            // 
            this.VINTextBox.Location = new System.Drawing.Point(98, 304);
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.Size = new System.Drawing.Size(120, 20);
            this.VINTextBox.TabIndex = 21;
            // 
            // licensePlateNumberLabel
            // 
            this.licensePlateNumberLabel.AutoSize = true;
            this.licensePlateNumberLabel.Location = new System.Drawing.Point(13, 337);
            this.licensePlateNumberLabel.Name = "licensePlateNumberLabel";
            this.licensePlateNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.licensePlateNumberLabel.TabIndex = 24;
            this.licensePlateNumberLabel.Text = "Nr rejestracyjny";
            // 
            // licensePlateNumberTextBox
            // 
            this.licensePlateNumberTextBox.Location = new System.Drawing.Point(98, 334);
            this.licensePlateNumberTextBox.Name = "licensePlateNumberTextBox";
            this.licensePlateNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.licensePlateNumberTextBox.TabIndex = 23;
            // 
            // productionDateDateTimePicker
            // 
            this.productionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productionDateDateTimePicker.Location = new System.Drawing.Point(98, 214);
            this.productionDateDateTimePicker.Name = "productionDateDateTimePicker";
            this.productionDateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.productionDateDateTimePicker.TabIndex = 25;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(98, 64);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(120, 21);
            this.categoryComboBox.TabIndex = 26;
            // 
            // driveTypeComboBox
            // 
            this.driveTypeComboBox.FormattingEnabled = true;
            this.driveTypeComboBox.Location = new System.Drawing.Point(98, 154);
            this.driveTypeComboBox.Name = "driveTypeComboBox";
            this.driveTypeComboBox.Size = new System.Drawing.Size(120, 21);
            this.driveTypeComboBox.TabIndex = 27;
            // 
            // gearboxComboBox
            // 
            this.gearboxComboBox.FormattingEnabled = true;
            this.gearboxComboBox.Location = new System.Drawing.Point(98, 184);
            this.gearboxComboBox.Name = "gearboxComboBox";
            this.gearboxComboBox.Size = new System.Drawing.Size(120, 21);
            this.gearboxComboBox.TabIndex = 28;
            // 
            // engineComboBox
            // 
            this.engineComboBox.FormattingEnabled = true;
            this.engineComboBox.Location = new System.Drawing.Point(98, 244);
            this.engineComboBox.Name = "engineComboBox";
            this.engineComboBox.Size = new System.Drawing.Size(120, 21);
            this.engineComboBox.TabIndex = 29;
            // 
            // modificationReasonTextBox
            // 
            this.modificationReasonTextBox.Location = new System.Drawing.Point(277, 94);
            this.modificationReasonTextBox.Multiline = true;
            this.modificationReasonTextBox.Name = "modificationReasonTextBox";
            this.modificationReasonTextBox.Size = new System.Drawing.Size(241, 260);
            this.modificationReasonTextBox.TabIndex = 30;
            // 
            // modificationReasonLabel
            // 
            this.modificationReasonLabel.AutoSize = true;
            this.modificationReasonLabel.Location = new System.Drawing.Point(277, 67);
            this.modificationReasonLabel.Name = "modificationReasonLabel";
            this.modificationReasonLabel.Size = new System.Drawing.Size(98, 13);
            this.modificationReasonLabel.TabIndex = 31;
            this.modificationReasonLabel.Text = "Powód modyfikacji:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(443, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(344, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ModifyCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 422);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modificationReasonLabel);
            this.Controls.Add(this.modificationReasonTextBox);
            this.Controls.Add(this.engineComboBox);
            this.Controls.Add(this.gearboxComboBox);
            this.Controls.Add(this.driveTypeComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.productionDateDateTimePicker);
            this.Controls.Add(this.licensePlateNumberLabel);
            this.Controls.Add(this.licensePlateNumberTextBox);
            this.Controls.Add(this.VINLabel);
            this.Controls.Add(this.VINTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.engineLabel);
            this.Controls.Add(this.productionDateLabel);
            this.Controls.Add(this.gearboxLabel);
            this.Controls.Add(this.driveTypeLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLicensePlateNumberLabel);
            this.Controls.Add(this.searchLicensePlateNumberTextBox);
            this.Controls.Add(this.searchVINLabel);
            this.Controls.Add(this.searchVINTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyCarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modyfikuj samochód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchVINTextBox;
        private System.Windows.Forms.Label searchVINLabel;
        private System.Windows.Forms.Label searchLicensePlateNumberLabel;
        private System.Windows.Forms.TextBox searchLicensePlateNumberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label driveTypeLabel;
        private System.Windows.Forms.Label gearboxLabel;
        private System.Windows.Forms.Label productionDateLabel;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.TextBox VINTextBox;
        private System.Windows.Forms.Label licensePlateNumberLabel;
        private System.Windows.Forms.TextBox licensePlateNumberTextBox;
        private System.Windows.Forms.DateTimePicker productionDateDateTimePicker;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox driveTypeComboBox;
        private System.Windows.Forms.ComboBox gearboxComboBox;
        private System.Windows.Forms.ComboBox engineComboBox;
        private System.Windows.Forms.TextBox modificationReasonTextBox;
        private System.Windows.Forms.Label modificationReasonLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}