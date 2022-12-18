namespace course
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отфильтроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отследитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначитьДоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аннулироватьДоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётПоКурьерамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_program = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearchDate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cachedCrystalReport11 = new course.CachedCrystalReport1();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.действияToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.About_program});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import,
            this.экспортБДToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 29);
            this.toolStripMenuItem1.Text = "База данных";
            // 
            // Import
            // 
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(270, 34);
            this.Import.Text = "Импорт заказов";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // экспортБДToolStripMenuItem
            // 
            this.экспортБДToolStripMenuItem.Name = "экспортБДToolStripMenuItem";
            this.экспортБДToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.экспортБДToolStripMenuItem.Text = "Экспорт БД";
            this.экспортБДToolStripMenuItem.Click += new System.EventHandler(this.Export_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоДатеToolStripMenuItem,
            this.отфильтроватьToolStripMenuItem,
            this.отследитьToolStripMenuItem,
            this.назначитьДоставкуToolStripMenuItem,
            this.аннулироватьДоставкуToolStripMenuItem,
            this.новыеЗаказыToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // поискПоДатеToolStripMenuItem
            // 
            this.поискПоДатеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поискПоДатеToolStripMenuItem.Image")));
            this.поискПоДатеToolStripMenuItem.Name = "поискПоДатеToolStripMenuItem";
            this.поискПоДатеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.поискПоДатеToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.поискПоДатеToolStripMenuItem.Text = "Поиск по дате";
            this.поискПоДатеToolStripMenuItem.ToolTipText = "Поиск по дате.\r\nОсуществляет поиск заказа на конкретную дату.\r\nЧтобы выполнить да" +
    "нную операцию, введите интересующую дату в строку пред кнопками на форме\r\n";
            this.поискПоДатеToolStripMenuItem.Click += new System.EventHandler(this.search_date_button_Click);
            // 
            // отфильтроватьToolStripMenuItem
            // 
            this.отфильтроватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отфильтроватьToolStripMenuItem.Image")));
            this.отфильтроватьToolStripMenuItem.Name = "отфильтроватьToolStripMenuItem";
            this.отфильтроватьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.отфильтроватьToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.отфильтроватьToolStripMenuItem.Text = "Отфильтровать";
            this.отфильтроватьToolStripMenuItem.ToolTipText = "Отфильтровать.\r\nОсуществляет фильтрацию заказов по количеству вещей в них";
            this.отфильтроватьToolStripMenuItem.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // отследитьToolStripMenuItem
            // 
            this.отследитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отследитьToolStripMenuItem.Image")));
            this.отследитьToolStripMenuItem.Name = "отследитьToolStripMenuItem";
            this.отследитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.отследитьToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.отследитьToolStripMenuItem.Text = "Отследить";
            this.отследитьToolStripMenuItem.ToolTipText = "Отследить.\r\nПозволяет найти интересующий заказ по номеру.\r\nЧтобы осуществить опер" +
    "ацию, введите номер заказа в строке перед кнопками";
            this.отследитьToolStripMenuItem.Click += new System.EventHandler(this.search_button_Click);
            // 
            // назначитьДоставкуToolStripMenuItem
            // 
            this.назначитьДоставкуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("назначитьДоставкуToolStripMenuItem.Image")));
            this.назначитьДоставкуToolStripMenuItem.Name = "назначитьДоставкуToolStripMenuItem";
            this.назначитьДоставкуToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.назначитьДоставкуToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.назначитьДоставкуToolStripMenuItem.Text = "Назначить доставку";
            this.назначитьДоставкуToolStripMenuItem.ToolTipText = "Назначить доставку.\r\nПозволяет выбрать курьера, доставляющего заказ и удобную для" +
    " доставки дату\r\n";
            this.назначитьДоставкуToolStripMenuItem.Click += new System.EventHandler(this.add__button_Click);
            // 
            // аннулироватьДоставкуToolStripMenuItem
            // 
            this.аннулироватьДоставкуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("аннулироватьДоставкуToolStripMenuItem.Image")));
            this.аннулироватьДоставкуToolStripMenuItem.Name = "аннулироватьДоставкуToolStripMenuItem";
            this.аннулироватьДоставкуToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.аннулироватьДоставкуToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.аннулироватьДоставкуToolStripMenuItem.Text = "Аннулировать доставку";
            this.аннулироватьДоставкуToolStripMenuItem.ToolTipText = "Аннулировать доставку.\r\nЕсли текущий статус доставки не \"Доставлено\", назначает д" +
    "оставке новый статус \"Аннулировано\".";
            this.аннулироватьДоставкуToolStripMenuItem.Click += new System.EventHandler(this.del_button_Click);
            // 
            // новыеЗаказыToolStripMenuItem
            // 
            this.новыеЗаказыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыеЗаказыToolStripMenuItem.Image")));
            this.новыеЗаказыToolStripMenuItem.Name = "новыеЗаказыToolStripMenuItem";
            this.новыеЗаказыToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.новыеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.новыеЗаказыToolStripMenuItem.Text = "Новые заказы";
            this.новыеЗаказыToolStripMenuItem.ToolTipText = "Новые заказы.\r\nОтображает информацию о заказах, для которых не назначена доставка" +
    ".";
            this.новыеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётПоКурьерамToolStripMenuItem,
            this.общийОтчётToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // отчётПоКурьерамToolStripMenuItem
            // 
            this.отчётПоКурьерамToolStripMenuItem.Name = "отчётПоКурьерамToolStripMenuItem";
            this.отчётПоКурьерамToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.отчётПоКурьерамToolStripMenuItem.Text = "Отчёт по курьерам";
            this.отчётПоКурьерамToolStripMenuItem.Click += new System.EventHandler(this.CourierReport_Click);
            // 
            // общийОтчётToolStripMenuItem
            // 
            this.общийОтчётToolStripMenuItem.Name = "общийОтчётToolStripMenuItem";
            this.общийОтчётToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.общийОтчётToolStripMenuItem.Text = "Общий отчёт";
            this.общийОтчётToolStripMenuItem.Click += new System.EventHandler(this.GeneralReport_Click);
            // 
            // About_program
            // 
            this.About_program.Name = "About_program";
            this.About_program.Size = new System.Drawing.Size(141, 29);
            this.About_program.Text = "О программе";
            this.About_program.Click += new System.EventHandler(this.About_program_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 559);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crystalReportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(763, 559);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(763, 214);
            this.splitContainer2.SplitterDistance = 71;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 71);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripButtonSearchDate,
            this.toolStripButtonFilter,
            this.toolStripButtonSearch,
            this.toolStripSeparator2,
            this.toolStripButtonAdd,
            this.toolStripButtonDel,
            this.toolStripButtonNew,
            this.AddButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 106);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(763, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Заказы",
            "Доставки"});
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Заказы",
            "Доставки"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 33);
            // 
            // toolStripButtonSearchDate
            // 
            this.toolStripButtonSearchDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchDate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchDate.Image")));
            this.toolStripButtonSearchDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchDate.Name = "toolStripButtonSearchDate";
            this.toolStripButtonSearchDate.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonSearchDate.Text = "toolStripButton1";
            this.toolStripButtonSearchDate.ToolTipText = "Поиск по дате\r\n";
            this.toolStripButtonSearchDate.Click += new System.EventHandler(this.search_date_button_Click);
            // 
            // toolStripButtonFilter
            // 
            this.toolStripButtonFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFilter.Image")));
            this.toolStripButtonFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilter.Name = "toolStripButtonFilter";
            this.toolStripButtonFilter.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonFilter.Text = "toolStripButton2";
            this.toolStripButtonFilter.ToolTipText = "Фильтрация";
            this.toolStripButtonFilter.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonSearch.Text = "toolStripButton3";
            this.toolStripButtonSearch.ToolTipText = "Поиск по номеру";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.search_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonAdd.Text = "toolStripButton4";
            this.toolStripButtonAdd.ToolTipText = "Назначить доставку";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.add__button_Click);
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDel.Image")));
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonDel.Text = "toolStripButton5";
            this.toolStripButtonDel.ToolTipText = "Аннулировать доставку";
            this.toolStripButtonDel.Click += new System.EventHandler(this.del_button_Click);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonNew.Text = "toolStripButton6";
            this.toolStripButtonNew.ToolTipText = "Новые заказы";
            this.toolStripButtonNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(34, 28);
            this.AddButton.Text = "Добавить новый заказ";
            this.AddButton.ToolTipText = "Добавить новый заказ";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(757, 87);
            this.dataGridView2.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(763, 341);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // chart2
            // 
            chartArea2.AxisY2.Maximum = 10D;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 84.7276F;
            chartArea2.Position.Width = 90F;
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(763, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.EmptyPointStyle.MarkerSize = 10;
            series2.Legend = "Legend1";
            series2.MarkerSize = 100;
            series2.Name = "Series1";
            series2.SmartLabelStyle.MaxMovingDistance = 100D;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 559);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CachedCrystalReport1 cachedCrystalReport11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Import;
        private System.Windows.Forms.ToolStripMenuItem экспортБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_program;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem поискПоДатеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отфильтроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отследитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначитьДоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аннулироватьДоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыеЗаказыToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётПоКурьерамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общийОтчётToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton toolStripButtonSearchDate;
        public System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        public System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        public System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        public System.Windows.Forms.ToolStripButton toolStripButtonDel;
        public System.Windows.Forms.ToolStripButton toolStripButtonNew;
        public System.Windows.Forms.ToolStripButton AddButton;
    }
}