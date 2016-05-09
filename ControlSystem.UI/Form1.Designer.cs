namespace ControlSystem.UI
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.diagnosisListBox = new System.Windows.Forms.ListBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.chooseExButton = new System.Windows.Forms.Button();
            this.chooseStateLabel = new System.Windows.Forms.Label();
            this.chooseDiagnosisLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagnosisListBox
            // 
            this.diagnosisListBox.FormattingEnabled = true;
            this.diagnosisListBox.ItemHeight = 16;
            this.diagnosisListBox.Location = new System.Drawing.Point(305, 207);
            this.diagnosisListBox.Name = "diagnosisListBox";
            this.diagnosisListBox.Size = new System.Drawing.Size(264, 100);
            this.diagnosisListBox.TabIndex = 0;
            this.diagnosisListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(305, 124);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(264, 24);
            this.stateComboBox.TabIndex = 1;
            // 
            // chooseExButton
            // 
            this.chooseExButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseExButton.Location = new System.Drawing.Point(206, 336);
            this.chooseExButton.Name = "chooseExButton";
            this.chooseExButton.Size = new System.Drawing.Size(199, 47);
            this.chooseExButton.TabIndex = 2;
            this.chooseExButton.Text = "Підібрати вправи";
            this.chooseExButton.UseVisualStyleBackColor = true;
            this.chooseExButton.Click += new System.EventHandler(this.chooseExButton_Click);
            // 
            // chooseStateLabel
            // 
            this.chooseStateLabel.AutoSize = true;
            this.chooseStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseStateLabel.Location = new System.Drawing.Point(50, 124);
            this.chooseStateLabel.Name = "chooseStateLabel";
            this.chooseStateLabel.Size = new System.Drawing.Size(134, 20);
            this.chooseStateLabel.TabIndex = 3;
            this.chooseStateLabel.Text = "Стан пацієнта:";
            // 
            // chooseDiagnosisLabel
            // 
            this.chooseDiagnosisLabel.AutoSize = true;
            this.chooseDiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDiagnosisLabel.Location = new System.Drawing.Point(50, 219);
            this.chooseDiagnosisLabel.Name = "chooseDiagnosisLabel";
            this.chooseDiagnosisLabel.Size = new System.Drawing.Size(156, 20);
            this.chooseDiagnosisLabel.TabIndex = 4;
            this.chooseDiagnosisLabel.Text = "Діагноз пацієнта:";
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
            this.menuStrip1.Size = new System.Drawing.Size(662, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Будь ласка, введіть наступну інформацію:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseDiagnosisLabel);
            this.Controls.Add(this.chooseStateLabel);
            this.Controls.Add(this.chooseExButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.diagnosisListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система реабілітації";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox diagnosisListBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button chooseExButton;
        private System.Windows.Forms.Label chooseStateLabel;
        private System.Windows.Forms.Label chooseDiagnosisLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

