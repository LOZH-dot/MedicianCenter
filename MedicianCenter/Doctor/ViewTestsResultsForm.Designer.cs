namespace MedicianCenter.Doctor
{
    partial class ViewTestsResultsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TestsComboBox = new System.Windows.Forms.ComboBox();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Анализы для пациента";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(292, 30);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.PatientNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список назначенных анализов";
            // 
            // TestsComboBox
            // 
            this.TestsComboBox.FormattingEnabled = true;
            this.TestsComboBox.Location = new System.Drawing.Point(15, 30);
            this.TestsComboBox.Name = "TestsComboBox";
            this.TestsComboBox.Size = new System.Drawing.Size(161, 21);
            this.TestsComboBox.TabIndex = 3;
            this.TestsComboBox.SelectedIndexChanged += new System.EventHandler(this.TestsComboBox_SelectedIndexChanged);
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Location = new System.Drawing.Point(12, 57);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            this.ResultsDataGridView.Size = new System.Drawing.Size(509, 370);
            this.ResultsDataGridView.TabIndex = 4;
            // 
            // ViewTestsResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 439);
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.TestsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewTestsResultsForm";
            this.Text = "Отчет по анализам";
            this.Load += new System.EventHandler(this.ViewTestsResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TestsComboBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
    }
}