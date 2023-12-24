
namespace Tyuiu.KosovskihVA.Sprint7.Project.V7
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxWorkSpace = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.chartSquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxStatistic = new System.Windows.Forms.GroupBox();
            this.groupBoxMax = new System.Windows.Forms.GroupBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.groupBoxMin = new System.Windows.Forms.GroupBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.groupBoxMid = new System.Windows.Forms.GroupBox();
            this.textBoxMid = new System.Windows.Forms.TextBox();
            this.groupBoxSum = new System.Windows.Forms.GroupBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.groupBoxSelectedCount = new System.Windows.Forms.GroupBox();
            this.textBoxSelectedCount = new System.Windows.Forms.TextBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonFilterCompareMode = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.FrontDoorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApartamentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsefulSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KidsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыделеннуюСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxWorkSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSquare)).BeginInit();
            this.groupBoxStatistic.SuspendLayout();
            this.groupBoxMax.SuspendLayout();
            this.groupBoxMin.SuspendLayout();
            this.groupBoxMid.SuspendLayout();
            this.groupBoxSum.SuspendLayout();
            this.groupBoxSelectedCount.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьТаблицуToolStripMenuItem,
            this.сохранитьТаблицуToolStripMenuItem,
            this.добавитьСтрокуToolStripMenuItem,
            this.удалитьВыделеннуюСтрокуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьТаблицуToolStripMenuItem
            // 
            this.открытьТаблицуToolStripMenuItem.Name = "открытьТаблицуToolStripMenuItem";
            this.открытьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.открытьТаблицуToolStripMenuItem.Text = "Открыть таблицу";
            this.открытьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.открытьТаблицуToolStripMenuItem_Click);
            // 
            // сохранитьТаблицуToolStripMenuItem
            // 
            this.сохранитьТаблицуToolStripMenuItem.Name = "сохранитьТаблицуToolStripMenuItem";
            this.сохранитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.сохранитьТаблицуToolStripMenuItem.Text = "Сохранить таблицу";
            this.сохранитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТаблицуToolStripMenuItem_Click);
            // 
            // groupBoxWorkSpace
            // 
            this.groupBoxWorkSpace.Controls.Add(this.splitContainer1);
            this.groupBoxWorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWorkSpace.Location = new System.Drawing.Point(0, 24);
            this.groupBoxWorkSpace.Name = "groupBoxWorkSpace";
            this.groupBoxWorkSpace.Size = new System.Drawing.Size(899, 487);
            this.groupBoxWorkSpace.TabIndex = 4;
            this.groupBoxWorkSpace.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxFunctions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxTable);
            this.splitContainer1.Size = new System.Drawing.Size(893, 468);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxFunctions
            // 
            this.groupBoxFunctions.Controls.Add(this.chartSquare);
            this.groupBoxFunctions.Controls.Add(this.groupBoxStatistic);
            this.groupBoxFunctions.Controls.Add(this.groupBoxFilter);
            this.groupBoxFunctions.Controls.Add(this.groupBoxSearch);
            this.groupBoxFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFunctions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Size = new System.Drawing.Size(433, 468);
            this.groupBoxFunctions.TabIndex = 4;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "Функционал";
            // 
            // chartSquare
            // 
            this.chartSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartSquare.ChartAreas.Add(chartArea2);
            this.chartSquare.Location = new System.Drawing.Point(6, 210);
            this.chartSquare.Name = "chartSquare";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartSquare.Series.Add(series2);
            this.chartSquare.Size = new System.Drawing.Size(421, 252);
            this.chartSquare.TabIndex = 2;
            this.chartSquare.Text = "chart1";
            // 
            // groupBoxStatistic
            // 
            this.groupBoxStatistic.Controls.Add(this.groupBoxMax);
            this.groupBoxStatistic.Controls.Add(this.groupBoxMin);
            this.groupBoxStatistic.Controls.Add(this.groupBoxMid);
            this.groupBoxStatistic.Controls.Add(this.groupBoxSum);
            this.groupBoxStatistic.Controls.Add(this.groupBoxSelectedCount);
            this.groupBoxStatistic.Location = new System.Drawing.Point(6, 72);
            this.groupBoxStatistic.Name = "groupBoxStatistic";
            this.groupBoxStatistic.Size = new System.Drawing.Size(418, 132);
            this.groupBoxStatistic.TabIndex = 1;
            this.groupBoxStatistic.TabStop = false;
            this.groupBoxStatistic.Text = "Статистика";
            // 
            // groupBoxMax
            // 
            this.groupBoxMax.Controls.Add(this.textBoxMax);
            this.groupBoxMax.Location = new System.Drawing.Point(118, 71);
            this.groupBoxMax.Name = "groupBoxMax";
            this.groupBoxMax.Size = new System.Drawing.Size(105, 45);
            this.groupBoxMax.TabIndex = 2;
            this.groupBoxMax.TabStop = false;
            this.groupBoxMax.Text = "Макс. значение";
            // 
            // textBoxMax
            // 
            this.textBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMax.Location = new System.Drawing.Point(3, 16);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(99, 20);
            this.textBoxMax.TabIndex = 1;
            // 
            // groupBoxMin
            // 
            this.groupBoxMin.Controls.Add(this.textBoxMin);
            this.groupBoxMin.Location = new System.Drawing.Point(7, 71);
            this.groupBoxMin.Name = "groupBoxMin";
            this.groupBoxMin.Size = new System.Drawing.Size(105, 45);
            this.groupBoxMin.TabIndex = 2;
            this.groupBoxMin.TabStop = false;
            this.groupBoxMin.Text = "Мин. значение";
            // 
            // textBoxMin
            // 
            this.textBoxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMin.Location = new System.Drawing.Point(3, 16);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(99, 20);
            this.textBoxMin.TabIndex = 1;
            // 
            // groupBoxMid
            // 
            this.groupBoxMid.Controls.Add(this.textBoxMid);
            this.groupBoxMid.Location = new System.Drawing.Point(229, 20);
            this.groupBoxMid.Name = "groupBoxMid";
            this.groupBoxMid.Size = new System.Drawing.Size(105, 45);
            this.groupBoxMid.TabIndex = 2;
            this.groupBoxMid.TabStop = false;
            this.groupBoxMid.Text = "Среднее знач.";
            // 
            // textBoxMid
            // 
            this.textBoxMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMid.Location = new System.Drawing.Point(3, 16);
            this.textBoxMid.Name = "textBoxMid";
            this.textBoxMid.ReadOnly = true;
            this.textBoxMid.Size = new System.Drawing.Size(99, 20);
            this.textBoxMid.TabIndex = 1;
            // 
            // groupBoxSum
            // 
            this.groupBoxSum.Controls.Add(this.textBoxSum);
            this.groupBoxSum.Location = new System.Drawing.Point(118, 20);
            this.groupBoxSum.Name = "groupBoxSum";
            this.groupBoxSum.Size = new System.Drawing.Size(105, 45);
            this.groupBoxSum.TabIndex = 1;
            this.groupBoxSum.TabStop = false;
            this.groupBoxSum.Text = "Сумма";
            // 
            // textBoxSum
            // 
            this.textBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSum.Location = new System.Drawing.Point(3, 16);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(99, 20);
            this.textBoxSum.TabIndex = 1;
            // 
            // groupBoxSelectedCount
            // 
            this.groupBoxSelectedCount.Controls.Add(this.textBoxSelectedCount);
            this.groupBoxSelectedCount.Location = new System.Drawing.Point(7, 20);
            this.groupBoxSelectedCount.Name = "groupBoxSelectedCount";
            this.groupBoxSelectedCount.Size = new System.Drawing.Size(105, 45);
            this.groupBoxSelectedCount.TabIndex = 0;
            this.groupBoxSelectedCount.TabStop = false;
            this.groupBoxSelectedCount.Text = "Выделено ячеек";
            // 
            // textBoxSelectedCount
            // 
            this.textBoxSelectedCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSelectedCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSelectedCount.Location = new System.Drawing.Point(3, 16);
            this.textBoxSelectedCount.Name = "textBoxSelectedCount";
            this.textBoxSelectedCount.ReadOnly = true;
            this.textBoxSelectedCount.Size = new System.Drawing.Size(99, 20);
            this.textBoxSelectedCount.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.buttonFilterCompareMode);
            this.groupBoxFilter.Controls.Add(this.comboBoxFilter);
            this.groupBoxFilter.Controls.Add(this.textBoxFilter);
            this.groupBoxFilter.Location = new System.Drawing.Point(213, 21);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(211, 45);
            this.groupBoxFilter.TabIndex = 0;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Фильтр";
            // 
            // buttonFilterCompareMode
            // 
            this.buttonFilterCompareMode.Location = new System.Drawing.Point(117, 16);
            this.buttonFilterCompareMode.Name = "buttonFilterCompareMode";
            this.buttonFilterCompareMode.Size = new System.Drawing.Size(27, 20);
            this.buttonFilterCompareMode.TabIndex = 2;
            this.buttonFilterCompareMode.Text = ">";
            this.buttonFilterCompareMode.UseVisualStyleBackColor = true;
            this.buttonFilterCompareMode.Click += new System.EventHandler(this.buttonFilterCompareMode_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Площадь, кв.м",
            "Пол. площадь, кв.м",
            "Кол-во комнат",
            "Кол-во человек",
            "Кол-во детей",
            "Задолженность"});
            this.comboBoxFilter.Location = new System.Drawing.Point(3, 16);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(108, 21);
            this.comboBoxFilter.TabIndex = 1;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxFilter.Enabled = false;
            this.textBoxFilter.Location = new System.Drawing.Point(154, 16);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(54, 20);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilter_KeyPress);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(6, 21);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(201, 45);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(3, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(195, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.dataGridViewTable);
            this.groupBoxTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTable.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(456, 468);
            this.groupBoxTable.TabIndex = 2;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Таблица";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrontDoorNumber,
            this.ApartamentNumber,
            this.Square,
            this.UsefulSquare,
            this.RoomCount,
            this.Date,
            this.PeopleCount,
            this.KidsCount,
            this.Debt,
            this.Comment});
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersVisible = false;
            this.dataGridViewTable.Size = new System.Drawing.Size(450, 449);
            this.dataGridViewTable.TabIndex = 0;
            this.dataGridViewTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellValueChanged);
            this.dataGridViewTable.SelectionChanged += new System.EventHandler(this.dataGridViewTable_SelectionChanged);
            // 
            // FrontDoorNumber
            // 
            this.FrontDoorNumber.HeaderText = "Номер подъезда";
            this.FrontDoorNumber.Name = "FrontDoorNumber";
            // 
            // ApartamentNumber
            // 
            this.ApartamentNumber.HeaderText = "Номер квартиры";
            this.ApartamentNumber.Name = "ApartamentNumber";
            // 
            // Square
            // 
            this.Square.HeaderText = "Площадь, кв.м";
            this.Square.Name = "Square";
            // 
            // UsefulSquare
            // 
            this.UsefulSquare.HeaderText = "Полезная площадь, кв.м";
            this.UsefulSquare.Name = "UsefulSquare";
            // 
            // RoomCount
            // 
            this.RoomCount.HeaderText = "Количество комнат";
            this.RoomCount.Name = "RoomCount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата прописки";
            this.Date.Name = "Date";
            // 
            // PeopleCount
            // 
            this.PeopleCount.HeaderText = "Количество членов семьи";
            this.PeopleCount.Name = "PeopleCount";
            // 
            // KidsCount
            // 
            this.KidsCount.HeaderText = "Количество детей в семье";
            this.KidsCount.Name = "KidsCount";
            // 
            // Debt
            // 
            this.Debt.HeaderText = "Задолженность";
            this.Debt.Name = "Debt";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Примечание";
            this.Comment.Name = "Comment";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            this.добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            this.добавитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.добавитьСтрокуToolStripMenuItem.Text = "Добавить строку";
            this.добавитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_Click);
            // 
            // удалитьВыделеннуюСтрокуToolStripMenuItem
            // 
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Name = "удалитьВыделеннуюСтрокуToolStripMenuItem";
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Text = "Удалить выделенную строку";
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыделеннуюСтрокуToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.groupBoxWorkSpace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(915, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домоуправление";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxWorkSpace.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSquare)).EndInit();
            this.groupBoxStatistic.ResumeLayout(false);
            this.groupBoxMax.ResumeLayout(false);
            this.groupBoxMax.PerformLayout();
            this.groupBoxMin.ResumeLayout(false);
            this.groupBoxMin.PerformLayout();
            this.groupBoxMid.ResumeLayout(false);
            this.groupBoxMid.PerformLayout();
            this.groupBoxSum.ResumeLayout(false);
            this.groupBoxSum.PerformLayout();
            this.groupBoxSelectedCount.ResumeLayout(false);
            this.groupBoxSelectedCount.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxWorkSpace;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonFilterCompareMode;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.GroupBox groupBoxStatistic;
        private System.Windows.Forms.GroupBox groupBoxSelectedCount;
        private System.Windows.Forms.TextBox textBoxSelectedCount;
        private System.Windows.Forms.GroupBox groupBoxSum;
        private System.Windows.Forms.GroupBox groupBoxMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.GroupBox groupBoxMid;
        private System.Windows.Forms.TextBox textBoxMid;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrontDoorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartamentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Square;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsefulSquare;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn KidsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.GroupBox groupBoxMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSquare;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделеннуюСтрокуToolStripMenuItem;
    }
}

