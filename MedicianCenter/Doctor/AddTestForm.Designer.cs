namespace MedicianCenter.Doctor
{
    partial class AddTestForm
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
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TestDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddTestButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид анализа:";
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Location = new System.Drawing.Point(86, 22);
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.TestNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание:";
            // 
            // TestDescriptionTextBox
            // 
            this.TestDescriptionTextBox.Location = new System.Drawing.Point(9, 66);
            this.TestDescriptionTextBox.Name = "TestDescriptionTextBox";
            this.TestDescriptionTextBox.Size = new System.Drawing.Size(219, 125);
            this.TestDescriptionTextBox.TabIndex = 5;
            this.TestDescriptionTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TestNameTextBox);
            this.groupBox2.Controls.Add(this.TestDescriptionTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 203);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об анализе";
            // 
            // AddTestButton
            // 
            this.AddTestButton.Location = new System.Drawing.Point(15, 229);
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(237, 35);
            this.AddTestButton.TabIndex = 10;
            this.AddTestButton.Text = "Добавить анализ";
            this.AddTestButton.UseVisualStyleBackColor = true;
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 272);
            this.Controls.Add(this.AddTestButton);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTestForm";
            this.Text = "Добавить анализ";
            this.Load += new System.EventHandler(this.AddTestForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TestNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TestDescriptionTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddTestButton;
    }
}