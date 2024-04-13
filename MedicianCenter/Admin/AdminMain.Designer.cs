namespace MedicianCenter.Admin
{
    partial class AdminMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DoctorsPage = new System.Windows.Forms.TabPage();
            this.DoctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.ContraPage = new System.Windows.Forms.TabPage();
            this.PillsDataGridView = new System.Windows.Forms.DataGridView();
            this.MedCardsPage = new System.Windows.Forms.TabPage();
            this.MedCardsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.докторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.препаратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медицинскаяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestPage = new System.Windows.Forms.TabPage();
            this.TestDataGridView = new System.Windows.Forms.DataGridView();
            this.AddTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DoctorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDataGridView)).BeginInit();
            this.ContraPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PillsDataGridView)).BeginInit();
            this.MedCardsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedCardsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TestPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 438);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DoctorsPage);
            this.tabControl1.Controls.Add(this.ContraPage);
            this.tabControl1.Controls.Add(this.MedCardsPage);
            this.tabControl1.Controls.Add(this.TestPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // DoctorsPage
            // 
            this.DoctorsPage.Controls.Add(this.DoctorsDataGridView);
            this.DoctorsPage.Location = new System.Drawing.Point(4, 22);
            this.DoctorsPage.Name = "DoctorsPage";
            this.DoctorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorsPage.Size = new System.Drawing.Size(763, 412);
            this.DoctorsPage.TabIndex = 0;
            this.DoctorsPage.Text = "Доктора";
            this.DoctorsPage.UseVisualStyleBackColor = true;
            // 
            // DoctorsDataGridView
            // 
            this.DoctorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DoctorsDataGridView.Name = "DoctorsDataGridView";
            this.DoctorsDataGridView.ReadOnly = true;
            this.DoctorsDataGridView.Size = new System.Drawing.Size(757, 406);
            this.DoctorsDataGridView.TabIndex = 0;
            this.DoctorsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DoctorsDataGridView_MouseClick);
            // 
            // ContraPage
            // 
            this.ContraPage.Controls.Add(this.PillsDataGridView);
            this.ContraPage.Location = new System.Drawing.Point(4, 22);
            this.ContraPage.Name = "ContraPage";
            this.ContraPage.Padding = new System.Windows.Forms.Padding(3);
            this.ContraPage.Size = new System.Drawing.Size(763, 412);
            this.ContraPage.TabIndex = 1;
            this.ContraPage.Text = "Препараты";
            this.ContraPage.UseVisualStyleBackColor = true;
            // 
            // PillsDataGridView
            // 
            this.PillsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PillsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PillsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PillsDataGridView.Name = "PillsDataGridView";
            this.PillsDataGridView.ReadOnly = true;
            this.PillsDataGridView.Size = new System.Drawing.Size(757, 406);
            this.PillsDataGridView.TabIndex = 0;
            this.PillsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PillsDataGridView_MouseClick);
            // 
            // MedCardsPage
            // 
            this.MedCardsPage.Controls.Add(this.MedCardsDataGridView);
            this.MedCardsPage.Location = new System.Drawing.Point(4, 22);
            this.MedCardsPage.Name = "MedCardsPage";
            this.MedCardsPage.Size = new System.Drawing.Size(763, 412);
            this.MedCardsPage.TabIndex = 2;
            this.MedCardsPage.Text = "Медицинские карты";
            this.MedCardsPage.UseVisualStyleBackColor = true;
            // 
            // MedCardsDataGridView
            // 
            this.MedCardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedCardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedCardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedCardsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MedCardsDataGridView.Name = "MedCardsDataGridView";
            this.MedCardsDataGridView.ReadOnly = true;
            this.MedCardsDataGridView.Size = new System.Drawing.Size(763, 412);
            this.MedCardsDataGridView.TabIndex = 0;
            this.MedCardsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MedCardsDataGridView_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 27);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.докторToolStripMenuItem,
            this.препаратToolStripMenuItem,
            this.медицинскаяКартаToolStripMenuItem,
            this.AddTestToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // докторToolStripMenuItem
            // 
            this.докторToolStripMenuItem.Name = "докторToolStripMenuItem";
            this.докторToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.докторToolStripMenuItem.Text = "Доктор";
            this.докторToolStripMenuItem.Click += new System.EventHandler(this.AddDoctorToolStripMenuItem_Click);
            // 
            // препаратToolStripMenuItem
            // 
            this.препаратToolStripMenuItem.Name = "препаратToolStripMenuItem";
            this.препаратToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.препаратToolStripMenuItem.Text = "Препарат";
            this.препаратToolStripMenuItem.Click += new System.EventHandler(this.PillToolStripMenuItem_Click);
            // 
            // медицинскаяКартаToolStripMenuItem
            // 
            this.медицинскаяКартаToolStripMenuItem.Name = "медицинскаяКартаToolStripMenuItem";
            this.медицинскаяКартаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.медицинскаяКартаToolStripMenuItem.Text = "Медицинская карта";
            this.медицинскаяКартаToolStripMenuItem.Click += new System.EventHandler(this.MedCardToolStripMenuItem_Click);
            // 
            // TestPage
            // 
            this.TestPage.Controls.Add(this.TestDataGridView);
            this.TestPage.Location = new System.Drawing.Point(4, 22);
            this.TestPage.Name = "TestPage";
            this.TestPage.Size = new System.Drawing.Size(763, 412);
            this.TestPage.TabIndex = 3;
            this.TestPage.Text = "Анализы";
            this.TestPage.UseVisualStyleBackColor = true;
            // 
            // TestDataGridView
            // 
            this.TestDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TestDataGridView.Name = "TestDataGridView";
            this.TestDataGridView.ReadOnly = true;
            this.TestDataGridView.Size = new System.Drawing.Size(763, 412);
            this.TestDataGridView.TabIndex = 0;
            // 
            // AddTestToolStripMenuItem
            // 
            this.AddTestToolStripMenuItem.Name = "AddTestToolStripMenuItem";
            this.AddTestToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.AddTestToolStripMenuItem.Text = "Анализ";
            this.AddTestToolStripMenuItem.Click += new System.EventHandler(this.AddTestToolStripMenuItem_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMain_FormClosed);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.DoctorsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDataGridView)).EndInit();
            this.ContraPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PillsDataGridView)).EndInit();
            this.MedCardsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedCardsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TestPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DoctorsPage;
        private System.Windows.Forms.TabPage ContraPage;
        private System.Windows.Forms.DataGridView DoctorsDataGridView;
        private System.Windows.Forms.DataGridView PillsDataGridView;
        private System.Windows.Forms.TabPage MedCardsPage;
        private System.Windows.Forms.DataGridView MedCardsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem докторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem препаратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медицинскаяКартаToolStripMenuItem;
        private System.Windows.Forms.TabPage TestPage;
        private System.Windows.Forms.DataGridView TestDataGridView;
        private System.Windows.Forms.ToolStripMenuItem AddTestToolStripMenuItem;
    }
}