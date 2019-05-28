namespace Wypozyczalnia
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.zarzadzajSamochodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazSamochodyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wypozyczSamochodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odbierzSamochodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSamochodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCarsPanel = new System.Windows.Forms.Panel();
            this.allCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.samochodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczalniaDataSet = new Wypozyczalnia.WypozyczalniaDataSet();
            this.searchCarsPanel = new System.Windows.Forms.Panel();
            this.searchCarsTabControl = new System.Windows.Forms.TabControl();
            this.simpleSearchTabPage = new System.Windows.Forms.TabPage();
            this.availableCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.advancedSearchTabPage = new System.Windows.Forms.TabPage();
            this.productionYearGroupBox = new System.Windows.Forms.GroupBox();
            this.prodYearFromLabel = new System.Windows.Forms.Label();
            this.prodYearToLabel = new System.Windows.Forms.Label();
            this.productionYearFromTextBox = new System.Windows.Forms.TextBox();
            this.productionYearToTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.categoryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.driveTypeLabel = new System.Windows.Forms.Label();
            this.engineCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.driveTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.engineLabel = new System.Windows.Forms.Label();
            this.manufacturerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.modelCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.costGroupBox = new System.Windows.Forms.GroupBox();
            this.costFromLabel = new System.Windows.Forms.Label();
            this.costToLabel = new System.Windows.Forms.Label();
            this.costFromTextBox = new System.Windows.Forms.TextBox();
            this.costToTextBox = new System.Windows.Forms.TextBox();
            this.gearboxGroupBox = new System.Windows.Forms.GroupBox();
            this.gearboxRadioButton2 = new System.Windows.Forms.RadioButton();
            this.gearboxRadioButton1 = new System.Windows.Forms.RadioButton();
            this.samochodyTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.SamochodyTableAdapter();
            this.edytujSamochodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunSamochodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.showCarsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCarsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).BeginInit();
            this.searchCarsPanel.SuspendLayout();
            this.searchCarsTabControl.SuspendLayout();
            this.simpleSearchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableCarsDataGridView)).BeginInit();
            this.advancedSearchTabPage.SuspendLayout();
            this.productionYearGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.costGroupBox.SuspendLayout();
            this.gearboxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zarzadzajSamochodyToolStripMenuItem,
            this.terminarzToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1019, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // zarzadzajSamochodyToolStripMenuItem
            // 
            this.zarzadzajSamochodyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokazSamochodyToolStripMenuItem1,
            this.wypozyczSamochodToolStripMenuItem,
            this.odbierzSamochodToolStripMenuItem,
            this.dodajSamochodToolStripMenuItem,
            this.edytujSamochodToolStripMenuItem,
            this.usunSamochodToolStripMenuItem});
            this.zarzadzajSamochodyToolStripMenuItem.Name = "zarzadzajSamochodyToolStripMenuItem";
            this.zarzadzajSamochodyToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.zarzadzajSamochodyToolStripMenuItem.Text = "Zarządzaj samochodami";
            // 
            // pokazSamochodyToolStripMenuItem1
            // 
            this.pokazSamochodyToolStripMenuItem1.Name = "pokazSamochodyToolStripMenuItem1";
            this.pokazSamochodyToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.pokazSamochodyToolStripMenuItem1.Text = "Pokaż samochody";
            this.pokazSamochodyToolStripMenuItem1.Click += new System.EventHandler(this.pokazSamochodyToolStripMenuItem1_Click);
            // 
            // wypozyczSamochodToolStripMenuItem
            // 
            this.wypozyczSamochodToolStripMenuItem.Name = "wypozyczSamochodToolStripMenuItem";
            this.wypozyczSamochodToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wypozyczSamochodToolStripMenuItem.Text = "Wypożycz samochód";
            this.wypozyczSamochodToolStripMenuItem.Click += new System.EventHandler(this.wypozyczSamochodToolStripMenuItem_Click);
            // 
            // odbierzSamochodToolStripMenuItem
            // 
            this.odbierzSamochodToolStripMenuItem.Name = "odbierzSamochodToolStripMenuItem";
            this.odbierzSamochodToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.odbierzSamochodToolStripMenuItem.Text = "Odbierz samochód";
            // 
            // dodajSamochodToolStripMenuItem
            // 
            this.dodajSamochodToolStripMenuItem.Name = "dodajSamochodToolStripMenuItem";
            this.dodajSamochodToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.dodajSamochodToolStripMenuItem.Text = "Dodaj samochód";
            this.dodajSamochodToolStripMenuItem.Click += new System.EventHandler(this.dodajSamochodToolStripMenuItem_Click);
            // 
            // terminarzToolStripMenuItem
            // 
            this.terminarzToolStripMenuItem.Name = "terminarzToolStripMenuItem";
            this.terminarzToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.terminarzToolStripMenuItem.Text = "Terminarz";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // showCarsPanel
            // 
            this.showCarsPanel.Controls.Add(this.allCarsDataGridView);
            this.showCarsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showCarsPanel.Location = new System.Drawing.Point(0, 24);
            this.showCarsPanel.Name = "showCarsPanel";
            this.showCarsPanel.Size = new System.Drawing.Size(1019, 548);
            this.showCarsPanel.TabIndex = 3;
            this.showCarsPanel.Visible = false;
            // 
            // allCarsDataGridView
            // 
            this.allCarsDataGridView.AllowUserToAddRows = false;
            this.allCarsDataGridView.AllowUserToDeleteRows = false;
            this.allCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCarsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCarsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.allCarsDataGridView.Name = "allCarsDataGridView";
            this.allCarsDataGridView.ReadOnly = true;
            this.allCarsDataGridView.Size = new System.Drawing.Size(1019, 548);
            this.allCarsDataGridView.TabIndex = 0;
            // 
            // samochodyBindingSource
            // 
            this.samochodyBindingSource.DataMember = "Samochody";
            this.samochodyBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczalniaDataSet
            // 
            this.wypozyczalniaDataSet.DataSetName = "WypozyczalniaDataSet";
            this.wypozyczalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchCarsPanel
            // 
            this.searchCarsPanel.Controls.Add(this.searchCarsTabControl);
            this.searchCarsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCarsPanel.Location = new System.Drawing.Point(0, 24);
            this.searchCarsPanel.Name = "searchCarsPanel";
            this.searchCarsPanel.Size = new System.Drawing.Size(1019, 548);
            this.searchCarsPanel.TabIndex = 1;
            this.searchCarsPanel.Visible = false;
            // 
            // searchCarsTabControl
            // 
            this.searchCarsTabControl.Controls.Add(this.simpleSearchTabPage);
            this.searchCarsTabControl.Controls.Add(this.advancedSearchTabPage);
            this.searchCarsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCarsTabControl.Location = new System.Drawing.Point(0, 0);
            this.searchCarsTabControl.Name = "searchCarsTabControl";
            this.searchCarsTabControl.SelectedIndex = 0;
            this.searchCarsTabControl.Size = new System.Drawing.Size(1019, 548);
            this.searchCarsTabControl.TabIndex = 4;
            // 
            // simpleSearchTabPage
            // 
            this.simpleSearchTabPage.Controls.Add(this.availableCarsDataGridView);
            this.simpleSearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.simpleSearchTabPage.Name = "simpleSearchTabPage";
            this.simpleSearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.simpleSearchTabPage.Size = new System.Drawing.Size(1011, 522);
            this.simpleSearchTabPage.TabIndex = 0;
            this.simpleSearchTabPage.Text = "Dostępne samochody";
            this.simpleSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // availableCarsDataGridView
            // 
            this.availableCarsDataGridView.AllowUserToDeleteRows = false;
            this.availableCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableCarsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableCarsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.availableCarsDataGridView.Name = "availableCarsDataGridView";
            this.availableCarsDataGridView.ReadOnly = true;
            this.availableCarsDataGridView.Size = new System.Drawing.Size(1005, 516);
            this.availableCarsDataGridView.TabIndex = 0;
            this.availableCarsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableCarsDataGridView_CellContentClick);
            // 
            // advancedSearchTabPage
            // 
            this.advancedSearchTabPage.Controls.Add(this.productionYearGroupBox);
            this.advancedSearchTabPage.Controls.Add(this.dataGridView1);
            this.advancedSearchTabPage.Controls.Add(this.searchButton);
            this.advancedSearchTabPage.Controls.Add(this.categoryCheckedListBox);
            this.advancedSearchTabPage.Controls.Add(this.categoryLabel);
            this.advancedSearchTabPage.Controls.Add(this.modelLabel);
            this.advancedSearchTabPage.Controls.Add(this.driveTypeLabel);
            this.advancedSearchTabPage.Controls.Add(this.engineCheckedListBox);
            this.advancedSearchTabPage.Controls.Add(this.manufacturerLabel);
            this.advancedSearchTabPage.Controls.Add(this.driveTypeCheckedListBox);
            this.advancedSearchTabPage.Controls.Add(this.engineLabel);
            this.advancedSearchTabPage.Controls.Add(this.manufacturerCheckedListBox);
            this.advancedSearchTabPage.Controls.Add(this.modelCheckedListBox);
            this.advancedSearchTabPage.Controls.Add(this.costGroupBox);
            this.advancedSearchTabPage.Controls.Add(this.gearboxGroupBox);
            this.advancedSearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.advancedSearchTabPage.Name = "advancedSearchTabPage";
            this.advancedSearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.advancedSearchTabPage.Size = new System.Drawing.Size(1011, 522);
            this.advancedSearchTabPage.TabIndex = 1;
            this.advancedSearchTabPage.Text = "Wyszukiwanie szczegółowe";
            this.advancedSearchTabPage.UseVisualStyleBackColor = true;
            this.advancedSearchTabPage.Click += new System.EventHandler(this.advancedSearchTabPage_Click);
            // 
            // productionYearGroupBox
            // 
            this.productionYearGroupBox.Controls.Add(this.prodYearFromLabel);
            this.productionYearGroupBox.Controls.Add(this.prodYearToLabel);
            this.productionYearGroupBox.Controls.Add(this.productionYearFromTextBox);
            this.productionYearGroupBox.Controls.Add(this.productionYearToTextBox);
            this.productionYearGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productionYearGroupBox.Location = new System.Drawing.Point(17, 97);
            this.productionYearGroupBox.Name = "productionYearGroupBox";
            this.productionYearGroupBox.Size = new System.Drawing.Size(175, 75);
            this.productionYearGroupBox.TabIndex = 11;
            this.productionYearGroupBox.TabStop = false;
            this.productionYearGroupBox.Text = "Rok produkcji";
            // 
            // prodYearFromLabel
            // 
            this.prodYearFromLabel.AutoSize = true;
            this.prodYearFromLabel.Location = new System.Drawing.Point(6, 25);
            this.prodYearFromLabel.Name = "prodYearFromLabel";
            this.prodYearFromLabel.Size = new System.Drawing.Size(19, 13);
            this.prodYearFromLabel.TabIndex = 0;
            this.prodYearFromLabel.Text = "od";
            this.prodYearFromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prodYearToLabel
            // 
            this.prodYearToLabel.AutoSize = true;
            this.prodYearToLabel.Location = new System.Drawing.Point(6, 51);
            this.prodYearToLabel.Name = "prodYearToLabel";
            this.prodYearToLabel.Size = new System.Drawing.Size(19, 13);
            this.prodYearToLabel.TabIndex = 1;
            this.prodYearToLabel.Text = "do";
            this.prodYearToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productionYearFromTextBox
            // 
            this.productionYearFromTextBox.Location = new System.Drawing.Point(31, 22);
            this.productionYearFromTextBox.Name = "productionYearFromTextBox";
            this.productionYearFromTextBox.Size = new System.Drawing.Size(113, 20);
            this.productionYearFromTextBox.TabIndex = 2;
            // 
            // productionYearToTextBox
            // 
            this.productionYearToTextBox.Location = new System.Drawing.Point(31, 48);
            this.productionYearToTextBox.Name = "productionYearToTextBox";
            this.productionYearToTextBox.Size = new System.Drawing.Size(113, 20);
            this.productionYearToTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(917, 143);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.UseWaitCursor = true;
            // 
            // categoryCheckedListBox
            // 
            this.categoryCheckedListBox.CheckOnClick = true;
            this.categoryCheckedListBox.FormattingEnabled = true;
            this.categoryCheckedListBox.Location = new System.Drawing.Point(17, 33);
            this.categoryCheckedListBox.Name = "categoryCheckedListBox";
            this.categoryCheckedListBox.Size = new System.Drawing.Size(175, 49);
            this.categoryCheckedListBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(14, 17);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(33, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Klasa";
            this.categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(414, 17);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model";
            // 
            // driveTypeLabel
            // 
            this.driveTypeLabel.AutoSize = true;
            this.driveTypeLabel.Location = new System.Drawing.Point(614, 4);
            this.driveTypeLabel.Name = "driveTypeLabel";
            this.driveTypeLabel.Size = new System.Drawing.Size(43, 26);
            this.driveTypeLabel.TabIndex = 1;
            this.driveTypeLabel.Text = "Rodzaj\r\nnapędu";
            this.driveTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // engineCheckedListBox
            // 
            this.engineCheckedListBox.CheckOnClick = true;
            this.engineCheckedListBox.FormattingEnabled = true;
            this.engineCheckedListBox.Location = new System.Drawing.Point(817, 33);
            this.engineCheckedListBox.Name = "engineCheckedListBox";
            this.engineCheckedListBox.Size = new System.Drawing.Size(175, 49);
            this.engineCheckedListBox.TabIndex = 8;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(214, 17);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(37, 13);
            this.manufacturerLabel.TabIndex = 1;
            this.manufacturerLabel.Text = "Marka";
            this.manufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driveTypeCheckedListBox
            // 
            this.driveTypeCheckedListBox.CheckOnClick = true;
            this.driveTypeCheckedListBox.FormattingEnabled = true;
            this.driveTypeCheckedListBox.Location = new System.Drawing.Point(617, 33);
            this.driveTypeCheckedListBox.Name = "driveTypeCheckedListBox";
            this.driveTypeCheckedListBox.Size = new System.Drawing.Size(175, 49);
            this.driveTypeCheckedListBox.TabIndex = 8;
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Location = new System.Drawing.Point(814, 17);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(32, 13);
            this.engineLabel.TabIndex = 1;
            this.engineLabel.Text = "Silnik";
            // 
            // manufacturerCheckedListBox
            // 
            this.manufacturerCheckedListBox.CheckOnClick = true;
            this.manufacturerCheckedListBox.FormattingEnabled = true;
            this.manufacturerCheckedListBox.Location = new System.Drawing.Point(217, 33);
            this.manufacturerCheckedListBox.Name = "manufacturerCheckedListBox";
            this.manufacturerCheckedListBox.Size = new System.Drawing.Size(175, 49);
            this.manufacturerCheckedListBox.TabIndex = 8;
            // 
            // modelCheckedListBox
            // 
            this.modelCheckedListBox.CheckOnClick = true;
            this.modelCheckedListBox.FormattingEnabled = true;
            this.modelCheckedListBox.Location = new System.Drawing.Point(417, 33);
            this.modelCheckedListBox.Name = "modelCheckedListBox";
            this.modelCheckedListBox.Size = new System.Drawing.Size(175, 49);
            this.modelCheckedListBox.TabIndex = 8;
            // 
            // costGroupBox
            // 
            this.costGroupBox.Controls.Add(this.costFromLabel);
            this.costGroupBox.Controls.Add(this.costToLabel);
            this.costGroupBox.Controls.Add(this.costFromTextBox);
            this.costGroupBox.Controls.Add(this.costToTextBox);
            this.costGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costGroupBox.Location = new System.Drawing.Point(217, 97);
            this.costGroupBox.Name = "costGroupBox";
            this.costGroupBox.Size = new System.Drawing.Size(175, 75);
            this.costGroupBox.TabIndex = 10;
            this.costGroupBox.TabStop = false;
            this.costGroupBox.Text = "Koszt wynajęcia";
            // 
            // costFromLabel
            // 
            this.costFromLabel.AutoSize = true;
            this.costFromLabel.Location = new System.Drawing.Point(6, 26);
            this.costFromLabel.Name = "costFromLabel";
            this.costFromLabel.Size = new System.Drawing.Size(19, 13);
            this.costFromLabel.TabIndex = 0;
            this.costFromLabel.Text = "od";
            this.costFromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // costToLabel
            // 
            this.costToLabel.AutoSize = true;
            this.costToLabel.Location = new System.Drawing.Point(6, 52);
            this.costToLabel.Name = "costToLabel";
            this.costToLabel.Size = new System.Drawing.Size(19, 13);
            this.costToLabel.TabIndex = 1;
            this.costToLabel.Text = "do";
            this.costToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // costFromTextBox
            // 
            this.costFromTextBox.Location = new System.Drawing.Point(31, 23);
            this.costFromTextBox.Name = "costFromTextBox";
            this.costFromTextBox.Size = new System.Drawing.Size(113, 20);
            this.costFromTextBox.TabIndex = 2;
            // 
            // costToTextBox
            // 
            this.costToTextBox.Location = new System.Drawing.Point(31, 49);
            this.costToTextBox.Name = "costToTextBox";
            this.costToTextBox.Size = new System.Drawing.Size(113, 20);
            this.costToTextBox.TabIndex = 3;
            // 
            // gearboxGroupBox
            // 
            this.gearboxGroupBox.Controls.Add(this.gearboxRadioButton2);
            this.gearboxGroupBox.Controls.Add(this.gearboxRadioButton1);
            this.gearboxGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gearboxGroupBox.Location = new System.Drawing.Point(417, 97);
            this.gearboxGroupBox.Name = "gearboxGroupBox";
            this.gearboxGroupBox.Size = new System.Drawing.Size(175, 50);
            this.gearboxGroupBox.TabIndex = 12;
            this.gearboxGroupBox.TabStop = false;
            this.gearboxGroupBox.Text = "Skrzynia biegów";
            // 
            // gearboxRadioButton2
            // 
            this.gearboxRadioButton2.AutoSize = true;
            this.gearboxRadioButton2.Location = new System.Drawing.Point(6, 23);
            this.gearboxRadioButton2.Name = "gearboxRadioButton2";
            this.gearboxRadioButton2.Size = new System.Drawing.Size(92, 17);
            this.gearboxRadioButton2.TabIndex = 1;
            this.gearboxRadioButton2.TabStop = true;
            this.gearboxRadioButton2.Text = "Automatyczna";
            this.gearboxRadioButton2.UseVisualStyleBackColor = true;
            // 
            // gearboxRadioButton1
            // 
            this.gearboxRadioButton1.AutoSize = true;
            this.gearboxRadioButton1.Location = new System.Drawing.Point(104, 23);
            this.gearboxRadioButton1.Name = "gearboxRadioButton1";
            this.gearboxRadioButton1.Size = new System.Drawing.Size(72, 17);
            this.gearboxRadioButton1.TabIndex = 0;
            this.gearboxRadioButton1.TabStop = true;
            this.gearboxRadioButton1.Text = "Manualna";
            this.gearboxRadioButton1.UseVisualStyleBackColor = true;
            // 
            // samochodyTableAdapter
            // 
            this.samochodyTableAdapter.ClearBeforeFill = true;
            // 
            // edytujSamochodToolStripMenuItem
            // 
            this.edytujSamochodToolStripMenuItem.Name = "edytujSamochodToolStripMenuItem";
            this.edytujSamochodToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.edytujSamochodToolStripMenuItem.Text = "Edytuj samochód";
            this.edytujSamochodToolStripMenuItem.Click += new System.EventHandler(this.EdytujSamochodToolStripMenuItem_Click);
            // 
            // usunSamochodToolStripMenuItem
            // 
            this.usunSamochodToolStripMenuItem.Name = "usunSamochodToolStripMenuItem";
            this.usunSamochodToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.usunSamochodToolStripMenuItem.Text = "Usuń samochód";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 572);
            this.Controls.Add(this.searchCarsPanel);
            this.Controls.Add(this.showCarsPanel);
            this.Controls.Add(this.MainMenu);
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wypożyczalnia";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.showCarsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allCarsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).EndInit();
            this.searchCarsPanel.ResumeLayout(false);
            this.searchCarsTabControl.ResumeLayout(false);
            this.simpleSearchTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availableCarsDataGridView)).EndInit();
            this.advancedSearchTabPage.ResumeLayout(false);
            this.advancedSearchTabPage.PerformLayout();
            this.productionYearGroupBox.ResumeLayout(false);
            this.productionYearGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.costGroupBox.ResumeLayout(false);
            this.costGroupBox.PerformLayout();
            this.gearboxGroupBox.ResumeLayout(false);
            this.gearboxGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem zarzadzajSamochodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokazSamochodyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wypozyczSamochodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odbierzSamochodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.Panel showCarsPanel;
        private System.Windows.Forms.DataGridView allCarsDataGridView;
        private WypozyczalniaDataSet wypozyczalniaDataSet;
        private System.Windows.Forms.BindingSource samochodyBindingSource;
        private WypozyczalniaDataSetTableAdapters.SamochodyTableAdapter samochodyTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem dodajSamochodToolStripMenuItem;
        private System.Windows.Forms.Panel searchCarsPanel;
        private System.Windows.Forms.TabControl searchCarsTabControl;
        private System.Windows.Forms.TabPage simpleSearchTabPage;
        private System.Windows.Forms.DataGridView availableCarsDataGridView;
        private System.Windows.Forms.TabPage advancedSearchTabPage;
        private System.Windows.Forms.GroupBox productionYearGroupBox;
        private System.Windows.Forms.Label prodYearFromLabel;
        private System.Windows.Forms.Label prodYearToLabel;
        private System.Windows.Forms.TextBox productionYearFromTextBox;
        private System.Windows.Forms.TextBox productionYearToTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckedListBox categoryCheckedListBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label driveTypeLabel;
        private System.Windows.Forms.CheckedListBox engineCheckedListBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.CheckedListBox driveTypeCheckedListBox;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.CheckedListBox manufacturerCheckedListBox;
        private System.Windows.Forms.CheckedListBox modelCheckedListBox;
        private System.Windows.Forms.GroupBox costGroupBox;
        private System.Windows.Forms.Label costFromLabel;
        private System.Windows.Forms.Label costToLabel;
        private System.Windows.Forms.TextBox costFromTextBox;
        private System.Windows.Forms.TextBox costToTextBox;
        private System.Windows.Forms.GroupBox gearboxGroupBox;
        private System.Windows.Forms.RadioButton gearboxRadioButton2;
        private System.Windows.Forms.RadioButton gearboxRadioButton1;
        private System.Windows.Forms.ToolStripMenuItem edytujSamochodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunSamochodToolStripMenuItem;
    }
}

