namespace MedicianCenter.Doctor
{
    partial class SelectPillsForm
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
            this.PillsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PillsComboBox = new System.Windows.Forms.ComboBox();
            this.AddPillButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PillsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пациент";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(79, 16);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.PatientNameTextBox.TabIndex = 1;
            // 
            // PillsDataGridView
            // 
            this.PillsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PillsDataGridView.Location = new System.Drawing.Point(248, 35);
            this.PillsDataGridView.Name = "PillsDataGridView";
            this.PillsDataGridView.ReadOnly = true;
            this.PillsDataGridView.Size = new System.Drawing.Size(414, 455);
            this.PillsDataGridView.TabIndex = 2;
            this.PillsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PillsDataGridView_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(326, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Назначенные лекарства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Лекарство";
            // 
            // PillsComboBox
            // 
            this.PillsComboBox.FormattingEnabled = true;
            this.PillsComboBox.Location = new System.Drawing.Point(80, 71);
            this.PillsComboBox.Name = "PillsComboBox";
            this.PillsComboBox.Size = new System.Drawing.Size(121, 21);
            this.PillsComboBox.TabIndex = 5;
            // 
            // AddPillButton
            // 
            this.AddPillButton.Location = new System.Drawing.Point(100, 98);
            this.AddPillButton.Name = "AddPillButton";
            this.AddPillButton.Size = new System.Drawing.Size(75, 23);
            this.AddPillButton.TabIndex = 6;
            this.AddPillButton.Text = "Назначить";
            this.AddPillButton.UseVisualStyleBackColor = true;
            this.AddPillButton.Click += new System.EventHandler(this.AddPillButton_Click);
            // 
            // SelectPillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 504);
            this.Controls.Add(this.AddPillButton);
            this.Controls.Add(this.PillsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PillsDataGridView);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPillsForm";
            this.Text = "Назначить лекарства";
            this.Load += new System.EventHandler(this.SelectPillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PillsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.DataGridView PillsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PillsComboBox;
        private System.Windows.Forms.Button AddPillButton;
    }
}