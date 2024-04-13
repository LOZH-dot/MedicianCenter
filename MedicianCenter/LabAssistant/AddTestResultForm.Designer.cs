namespace MedicianCenter.LabAssistant
{
    partial class AddTestResultForm
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
            this.TestResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddResultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TestResultsDataGridView
            // 
            this.TestResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestResultsDataGridView.Location = new System.Drawing.Point(268, 12);
            this.TestResultsDataGridView.Name = "TestResultsDataGridView";
            this.TestResultsDataGridView.Size = new System.Drawing.Size(416, 426);
            this.TestResultsDataGridView.TabIndex = 0;
            this.TestResultsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TestResultsDataGridView_MouseClick);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(31, 39);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(179, 20);
            this.KeyTextBox.TabIndex = 1;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(31, 88);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(179, 20);
            this.ValueTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование результата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Значение результата";
            // 
            // AddResultButton
            // 
            this.AddResultButton.Location = new System.Drawing.Point(40, 114);
            this.AddResultButton.Name = "AddResultButton";
            this.AddResultButton.Size = new System.Drawing.Size(155, 23);
            this.AddResultButton.TabIndex = 5;
            this.AddResultButton.Text = "Добавить результат";
            this.AddResultButton.UseVisualStyleBackColor = true;
            this.AddResultButton.Click += new System.EventHandler(this.AddResultButton_Click);
            // 
            // AddTestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.AddResultButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.TestResultsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTestResultForm";
            this.Text = "Добавить результаты";
            this.Load += new System.EventHandler(this.AddTestResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TestResultsDataGridView;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddResultButton;
    }
}