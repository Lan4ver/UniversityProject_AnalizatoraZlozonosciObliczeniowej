namespace Projekt2_Podorozhnyi50402
{
    partial class AnalizatorAlgorytmowSortowania
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAkceptacjaDanych = new System.Windows.Forms.Button();
            this.btnWynikiTabelaryczne = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnWynikiWykresowe = new System.Windows.Forms.Button();
            this.btnWybierzKolorLinii = new System.Windows.Forms.Button();
            this.cmbAlgorytmSortowania = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvTabelaWynikow = new System.Windows.Forms.DataGridView();
            this.RozmiarSortTabl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KosztCzasowyZPomiaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalitycznyKosztCzasowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KosztPamieciowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMinimalnaProbaBadawcza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtMaxRozmiarSortTabl = new System.Windows.Forms.TextBox();
            this.txtGornaGranica = new System.Windows.Forms.TextBox();
            this.txtDolnaGranica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrubosc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnWybierzKolorTłaDlaWykresu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKolorTła = new System.Windows.Forms.Button();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.trcGrubosc = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaWynikow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGrubosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(441, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1051, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizator złożoności obliczeniowej algorytmów sortowania";
            // 
            // btnAkceptacjaDanych
            // 
            this.btnAkceptacjaDanych.Location = new System.Drawing.Point(15, 638);
            this.btnAkceptacjaDanych.Margin = new System.Windows.Forms.Padding(4);
            this.btnAkceptacjaDanych.Name = "btnAkceptacjaDanych";
            this.btnAkceptacjaDanych.Size = new System.Drawing.Size(184, 56);
            this.btnAkceptacjaDanych.TabIndex = 1;
            this.btnAkceptacjaDanych.Text = "Akceptacja danych dla badania eksperymentalnego";
            this.btnAkceptacjaDanych.UseVisualStyleBackColor = true;
            this.btnAkceptacjaDanych.Click += new System.EventHandler(this.btnAkceptacjaDanych_Click);
            // 
            // btnWynikiTabelaryczne
            // 
            this.btnWynikiTabelaryczne.Enabled = false;
            this.btnWynikiTabelaryczne.Location = new System.Drawing.Point(1365, 343);
            this.btnWynikiTabelaryczne.Name = "btnWynikiTabelaryczne";
            this.btnWynikiTabelaryczne.Size = new System.Drawing.Size(146, 73);
            this.btnWynikiTabelaryczne.TabIndex = 2;
            this.btnWynikiTabelaryczne.Text = "Tabelaryczna prezentacja złożoności";
            this.btnWynikiTabelaryczne.UseVisualStyleBackColor = true;
            this.btnWynikiTabelaryczne.Click += new System.EventHandler(this.btnWynikiTabelaryczne_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Enabled = false;
            this.btnResetuj.Location = new System.Drawing.Point(1365, 501);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(146, 73);
            this.btnResetuj.TabIndex = 3;
            this.btnResetuj.Text = "RESETUJ";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // btnWynikiWykresowe
            // 
            this.btnWynikiWykresowe.Enabled = false;
            this.btnWynikiWykresowe.Location = new System.Drawing.Point(1365, 422);
            this.btnWynikiWykresowe.Name = "btnWynikiWykresowe";
            this.btnWynikiWykresowe.Size = new System.Drawing.Size(146, 73);
            this.btnWynikiWykresowe.TabIndex = 4;
            this.btnWynikiWykresowe.Text = "Graficzna prezentacja złożoności";
            this.btnWynikiWykresowe.UseVisualStyleBackColor = true;
            this.btnWynikiWykresowe.Click += new System.EventHandler(this.btnWynikiWykresowe_Click);
            // 
            // btnWybierzKolorLinii
            // 
            this.btnWybierzKolorLinii.Enabled = false;
            this.btnWybierzKolorLinii.Location = new System.Drawing.Point(33, 66);
            this.btnWybierzKolorLinii.Name = "btnWybierzKolorLinii";
            this.btnWybierzKolorLinii.Size = new System.Drawing.Size(111, 56);
            this.btnWybierzKolorLinii.TabIndex = 5;
            this.btnWybierzKolorLinii.Text = "Wybierz kolor linii";
            this.btnWybierzKolorLinii.UseVisualStyleBackColor = true;
            this.btnWybierzKolorLinii.Click += new System.EventHandler(this.btnWybierzKolorLinii_Click);
            // 
            // cmbAlgorytmSortowania
            // 
            this.cmbAlgorytmSortowania.FormattingEnabled = true;
            this.cmbAlgorytmSortowania.Items.AddRange(new object[] {
            "SelectSort",
            "InsertSort",
            "ShellSort",
            "HeapSort"});
            this.cmbAlgorytmSortowania.Location = new System.Drawing.Point(15, 552);
            this.cmbAlgorytmSortowania.Name = "cmbAlgorytmSortowania";
            this.cmbAlgorytmSortowania.Size = new System.Drawing.Size(184, 28);
            this.cmbAlgorytmSortowania.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wybierz algorytm do analizu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvTabelaWynikow
            // 
            this.dgvTabelaWynikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaWynikow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RozmiarSortTabl,
            this.KosztCzasowyZPomiaru,
            this.AnalitycznyKosztCzasowy,
            this.KosztPamieciowy});
            this.dgvTabelaWynikow.Location = new System.Drawing.Point(361, 167);
            this.dgvTabelaWynikow.Name = "dgvTabelaWynikow";
            this.dgvTabelaWynikow.ReadOnly = true;
            this.dgvTabelaWynikow.RowHeadersWidth = 51;
            this.dgvTabelaWynikow.Size = new System.Drawing.Size(820, 435);
            this.dgvTabelaWynikow.TabIndex = 8;
            this.dgvTabelaWynikow.Visible = false;
            // 
            // RozmiarSortTabl
            // 
            this.RozmiarSortTabl.HeaderText = "Rozmiar sortowanej tabeli";
            this.RozmiarSortTabl.MinimumWidth = 6;
            this.RozmiarSortTabl.Name = "RozmiarSortTabl";
            this.RozmiarSortTabl.ReadOnly = true;
            this.RozmiarSortTabl.Width = 125;
            // 
            // KosztCzasowyZPomiaru
            // 
            this.KosztCzasowyZPomiaru.HeaderText = "Koszt czasowy z pomiaru";
            this.KosztCzasowyZPomiaru.MinimumWidth = 6;
            this.KosztCzasowyZPomiaru.Name = "KosztCzasowyZPomiaru";
            this.KosztCzasowyZPomiaru.ReadOnly = true;
            this.KosztCzasowyZPomiaru.Width = 250;
            // 
            // AnalitycznyKosztCzasowy
            // 
            this.AnalitycznyKosztCzasowy.HeaderText = "Analityczny koszt czasowy (na podstawie wzoru)";
            this.AnalitycznyKosztCzasowy.MinimumWidth = 6;
            this.AnalitycznyKosztCzasowy.Name = "AnalitycznyKosztCzasowy";
            this.AnalitycznyKosztCzasowy.ReadOnly = true;
            this.AnalitycznyKosztCzasowy.Width = 250;
            // 
            // KosztPamieciowy
            // 
            this.KosztPamieciowy.HeaderText = "Koszt pamięciowy";
            this.KosztPamieciowy.MinimumWidth = 6;
            this.KosztPamieciowy.Name = "KosztPamieciowy";
            this.KosztPamieciowy.ReadOnly = true;
            this.KosztPamieciowy.Width = 250;
            // 
            // txtMinimalnaProbaBadawcza
            // 
            this.txtMinimalnaProbaBadawcza.Location = new System.Drawing.Point(17, 204);
            this.txtMinimalnaProbaBadawcza.Name = "txtMinimalnaProbaBadawcza";
            this.txtMinimalnaProbaBadawcza.Size = new System.Drawing.Size(184, 26);
            this.txtMinimalnaProbaBadawcza.TabIndex = 11;
            this.txtMinimalnaProbaBadawcza.TextChanged += new System.EventHandler(this.txtMinimalnaProbaBadawcza_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 80);
            this.label3.TabIndex = 12;
            this.label3.Text = "Minimalna próba badawcza\r\n(liczba powtórzeń sortowania \r\ntablicy o tych samych ro" +
    "zmiarach, \r\nale o róznje zawartości)";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(361, 167);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Series3";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(820, 435);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chtBoxAlgorymy";
            this.chart1.Visible = false;
            // 
            // txtMaxRozmiarSortTabl
            // 
            this.txtMaxRozmiarSortTabl.Location = new System.Drawing.Point(17, 290);
            this.txtMaxRozmiarSortTabl.Name = "txtMaxRozmiarSortTabl";
            this.txtMaxRozmiarSortTabl.Size = new System.Drawing.Size(184, 26);
            this.txtMaxRozmiarSortTabl.TabIndex = 14;
            // 
            // txtGornaGranica
            // 
            this.txtGornaGranica.Location = new System.Drawing.Point(17, 462);
            this.txtGornaGranica.Name = "txtGornaGranica";
            this.txtGornaGranica.Size = new System.Drawing.Size(184, 26);
            this.txtGornaGranica.TabIndex = 15;
            // 
            // txtDolnaGranica
            // 
            this.txtDolnaGranica.Location = new System.Drawing.Point(17, 368);
            this.txtDolnaGranica.Name = "txtDolnaGranica";
            this.txtDolnaGranica.Size = new System.Drawing.Size(184, 26);
            this.txtDolnaGranica.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Maksyalny rozmiar \r\nsortowanych tablic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 60);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dolna granica przedziału \r\nwartości elementów \r\nsortowanych tablicy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 60);
            this.label6.TabIndex = 19;
            this.label6.Text = "Górna granica przedziału \r\nwartości elementów \r\nsortowanych tablicy";
            // 
            // txtGrubosc
            // 
            this.txtGrubosc.Enabled = false;
            this.txtGrubosc.Location = new System.Drawing.Point(1378, 202);
            this.txtGrubosc.Name = "txtGrubosc";
            this.txtGrubosc.Size = new System.Drawing.Size(133, 26);
            this.txtGrubosc.TabIndex = 20;
            this.txtGrubosc.TextChanged += new System.EventHandler(this.txtGrubosc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1375, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 40);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ustalona grubość linii\r\n          (liczbowo)";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Enabled = false;
            this.btnColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColor.Location = new System.Drawing.Point(250, 99);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(116, 23);
            this.btnColor.TabIndex = 22;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Wziernik koloru linii";
            // 
            // btnWybierzKolorTłaDlaWykresu
            // 
            this.btnWybierzKolorTłaDlaWykresu.Enabled = false;
            this.btnWybierzKolorTłaDlaWykresu.Location = new System.Drawing.Point(509, 66);
            this.btnWybierzKolorTłaDlaWykresu.Name = "btnWybierzKolorTłaDlaWykresu";
            this.btnWybierzKolorTłaDlaWykresu.Size = new System.Drawing.Size(111, 56);
            this.btnWybierzKolorTłaDlaWykresu.TabIndex = 24;
            this.btnWybierzKolorTłaDlaWykresu.Text = "Wybierz kolor tła dla wykresu";
            this.btnWybierzKolorTłaDlaWykresu.UseVisualStyleBackColor = true;
            this.btnWybierzKolorTłaDlaWykresu.Click += new System.EventHandler(this.btnWybierzKolorTłaDlaWykresu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(659, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 40);
            this.label9.TabIndex = 26;
            this.label9.Text = "Wziernik koloru tłą\r\ndla wykresu";
            // 
            // btnKolorTła
            // 
            this.btnKolorTła.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKolorTła.Enabled = false;
            this.btnKolorTła.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKolorTła.Location = new System.Drawing.Point(664, 99);
            this.btnKolorTła.Name = "btnKolorTła";
            this.btnKolorTła.Size = new System.Drawing.Size(116, 23);
            this.btnKolorTła.TabIndex = 25;
            this.btnKolorTła.UseVisualStyleBackColor = false;
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.Enabled = false;
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot",
            "Solid"});
            this.cmbStylLinii.Location = new System.Drawing.Point(873, 98);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(122, 28);
            this.cmbStylLinii.TabIndex = 27;
            this.cmbStylLinii.SelectedIndexChanged += new System.EventHandler(this.cmbStylLinii_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(874, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ustal styl linii";
            // 
            // trcGrubosc
            // 
            this.trcGrubosc.Enabled = false;
            this.trcGrubosc.Location = new System.Drawing.Point(1365, 98);
            this.trcGrubosc.Name = "trcGrubosc";
            this.trcGrubosc.Size = new System.Drawing.Size(146, 56);
            this.trcGrubosc.TabIndex = 29;
            this.trcGrubosc.Scroll += new System.EventHandler(this.trcGrubosc_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1375, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 40);
            this.label11.TabIndex = 30;
            this.label11.Text = "Zmień grubość linii \r\n        wykresu";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(607, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "Przed sortowaniem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(786, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 48);
            this.button2.TabIndex = 32;
            this.button2.Text = "Po sortowaniu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1225, 632);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 56);
            this.button3.TabIndex = 33;
            this.button3.Text = "Sprawdziań";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AnalizatorAlgorytmowSortowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 701);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trcGrubosc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbStylLinii);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKolorTła);
            this.Controls.Add(this.btnWybierzKolorTłaDlaWykresu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGrubosc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDolnaGranica);
            this.Controls.Add(this.txtGornaGranica);
            this.Controls.Add(this.txtMaxRozmiarSortTabl);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinimalnaProbaBadawcza);
            this.Controls.Add(this.dgvTabelaWynikow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlgorytmSortowania);
            this.Controls.Add(this.btnWybierzKolorLinii);
            this.Controls.Add(this.btnWynikiWykresowe);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnWynikiTabelaryczne);
            this.Controls.Add(this.btnAkceptacjaDanych);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnalizatorAlgorytmowSortowania";
            this.Text = "Analizator algorymów sortowania";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaWynikow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGrubosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAkceptacjaDanych;
        private System.Windows.Forms.Button btnWynikiTabelaryczne;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Button btnWynikiWykresowe;
        private System.Windows.Forms.Button btnWybierzKolorLinii;
        private System.Windows.Forms.ComboBox cmbAlgorytmSortowania;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvTabelaWynikow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinimalnaProbaBadawcza;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGrubosc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDolnaGranica;
        private System.Windows.Forms.TextBox txtGornaGranica;
        private System.Windows.Forms.TextBox txtMaxRozmiarSortTabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn RozmiarSortTabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn KosztCzasowyZPomiaru;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalitycznyKosztCzasowy;
        private System.Windows.Forms.DataGridViewTextBoxColumn KosztPamieciowy;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKolorTła;
        private System.Windows.Forms.Button btnWybierzKolorTłaDlaWykresu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trcGrubosc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

