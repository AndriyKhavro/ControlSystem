namespace ControlSystem.UI
{
    partial class Form2
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
            this.exerciseGridView = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.morningGridView = new System.Windows.Forms.DataGridView();
            this.exNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedRepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayGridView = new System.Windows.Forms.DataGridView();
            this.eveningGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedSetsDayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedSetsEveningColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morningGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveningGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exerciseGridView
            // 
            this.exerciseGridView.AllowDrop = true;
            this.exerciseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exerciseGridView.Location = new System.Drawing.Point(21, 122);
            this.exerciseGridView.Margin = new System.Windows.Forms.Padding(2);
            this.exerciseGridView.Name = "exerciseGridView";
            this.exerciseGridView.RowTemplate.Height = 24;
            this.exerciseGridView.Size = new System.Drawing.Size(344, 376);
            this.exerciseGridView.TabIndex = 0;
            this.exerciseGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.exerciseGridView_CellMouseDown);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 513);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(2, 24);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 513);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "На основі введеної інформації, було підібрано наступні вправи:";
            // 
            // morningGridView
            // 
            this.morningGridView.AllowDrop = true;
            this.morningGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.morningGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exNameColumn,
            this.expectedRepsColumn,
            this.repeatColumn});
            this.morningGridView.Location = new System.Drawing.Point(424, 122);
            this.morningGridView.Margin = new System.Windows.Forms.Padding(2);
            this.morningGridView.Name = "morningGridView";
            this.morningGridView.RowTemplate.Height = 24;
            this.morningGridView.Size = new System.Drawing.Size(344, 106);
            this.morningGridView.TabIndex = 4;
            this.morningGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.morningGridView_DragDrop);
            this.morningGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.morningGridView_DragEnter);
            // 
            // exNameColumn
            // 
            this.exNameColumn.HeaderText = "Вправа";
            this.exNameColumn.Name = "exNameColumn";
            // 
            // expectedRepsColumn
            // 
            this.expectedRepsColumn.HeaderText = "Кількість підходів";
            this.expectedRepsColumn.Name = "expectedRepsColumn";
            // 
            // repeatColumn
            // 
            this.repeatColumn.HeaderText = "Кількість повторювань";
            this.repeatColumn.Name = "repeatColumn";
            // 
            // dayGridView
            // 
            this.dayGridView.AllowDrop = true;
            this.dayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.expectedSetsDayColumn,
            this.dataGridViewTextBoxColumn2});
            this.dayGridView.Location = new System.Drawing.Point(424, 263);
            this.dayGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dayGridView.Name = "dayGridView";
            this.dayGridView.RowTemplate.Height = 24;
            this.dayGridView.Size = new System.Drawing.Size(344, 106);
            this.dayGridView.TabIndex = 5;
            this.dayGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.dayGridView_DragDrop);
            this.dayGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.dayGridView_DragEnter);
            // 
            // eveningGridView
            // 
            this.eveningGridView.AllowDrop = true;
            this.eveningGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eveningGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.expectedSetsEveningColumn,
            this.dataGridViewTextBoxColumn4});
            this.eveningGridView.Location = new System.Drawing.Point(424, 392);
            this.eveningGridView.Margin = new System.Windows.Forms.Padding(2);
            this.eveningGridView.Name = "eveningGridView";
            this.eveningGridView.RowTemplate.Height = 24;
            this.eveningGridView.Size = new System.Drawing.Size(344, 106);
            this.eveningGridView.TabIndex = 6;
            this.eveningGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.eveningGridView_DragDrop);
            this.eveningGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.eveningGridView_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ранок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "День";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(424, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вечір";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 66);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Будь ласка, заповніть розклад справа запропонованими вправами";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(484, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Оберіть день:";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(509, 507);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 24);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.допомогаToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Вправа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // expectedSetsDayColumn
            // 
            this.expectedSetsDayColumn.HeaderText = "Кількість підходів";
            this.expectedSetsDayColumn.Name = "expectedSetsDayColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Кількість повторювань";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Вправа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // expectedSetsEveningColumn
            // 
            this.expectedSetsEveningColumn.HeaderText = "Кількість підходів";
            this.expectedSetsEveningColumn.Name = "expectedSetsEveningColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Кількість повторювань";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 537);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eveningGridView);
            this.Controls.Add(this.dayGridView);
            this.Controls.Add(this.morningGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.exerciseGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система реабілітації";
            ((System.ComponentModel.ISupportInitialize)(this.exerciseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morningGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveningGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView exerciseGridView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView morningGridView;
        private System.Windows.Forms.DataGridView dayGridView;
        private System.Windows.Forms.DataGridView eveningGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn exNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedRepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedSetsDayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedSetsEveningColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}