namespace MedicianCenter.Admin
{
    partial class AddPillForm
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
            this.PillNameTextBox = new System.Windows.Forms.TextBox();
            this.PillDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PillNameTextBox
            // 
            this.PillNameTextBox.Location = new System.Drawing.Point(157, 27);
            this.PillNameTextBox.Name = "PillNameTextBox";
            this.PillNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.PillNameTextBox.TabIndex = 0;
            // 
            // PillDescriptionTextBox
            // 
            this.PillDescriptionTextBox.Location = new System.Drawing.Point(78, 67);
            this.PillDescriptionTextBox.Name = "PillDescriptionTextBox";
            this.PillDescriptionTextBox.Size = new System.Drawing.Size(284, 151);
            this.PillDescriptionTextBox.TabIndex = 1;
            this.PillDescriptionTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование препарата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // AddPillButton
            // 
            this.AddPillButton.Location = new System.Drawing.Point(157, 229);
            this.AddPillButton.Name = "AddPillButton";
            this.AddPillButton.Size = new System.Drawing.Size(75, 23);
            this.AddPillButton.TabIndex = 4;
            this.AddPillButton.Text = "Добавить";
            this.AddPillButton.UseVisualStyleBackColor = true;
            this.AddPillButton.Click += new System.EventHandler(this.AddPillButton_Click);
            // 
            // AddPillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 264);
            this.Controls.Add(this.AddPillButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PillDescriptionTextBox);
            this.Controls.Add(this.PillNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPillForm";
            this.Text = "Добавить препарат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PillNameTextBox;
        private System.Windows.Forms.RichTextBox PillDescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddPillButton;
    }
}