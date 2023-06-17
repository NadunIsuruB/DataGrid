namespace DataGrid
{
    partial class MainForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criteriaDropDown = new System.Windows.Forms.ComboBox();
            this.operatorsDropDown = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.addNewFilterButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterEditor = new System.Windows.Forms.RichTextBox();
            this.andOrDropDow = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 315);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1049, 347);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(158, 32);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // criteriaDropDown
            // 
            this.criteriaDropDown.FormattingEnabled = true;
            this.criteriaDropDown.Location = new System.Drawing.Point(113, 21);
            this.criteriaDropDown.Name = "criteriaDropDown";
            this.criteriaDropDown.Size = new System.Drawing.Size(121, 24);
            this.criteriaDropDown.TabIndex = 2;
            this.criteriaDropDown.Text = "Criteria";
            this.criteriaDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // operatorsDropDown
            // 
            this.operatorsDropDown.Enabled = false;
            this.operatorsDropDown.FormattingEnabled = true;
            this.operatorsDropDown.Items.AddRange(new object[] {
            "Operators",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "!="});
            this.operatorsDropDown.Location = new System.Drawing.Point(240, 21);
            this.operatorsDropDown.Name = "operatorsDropDown";
            this.operatorsDropDown.Size = new System.Drawing.Size(122, 24);
            this.operatorsDropDown.TabIndex = 3;
            this.operatorsDropDown.Text = "Operators";
            this.operatorsDropDown.SelectedIndexChanged += new System.EventHandler(this.operatorsDropDown_SelectedIndexChanged);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Enabled = false;
            this.filterTextBox.Location = new System.Drawing.Point(368, 22);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 22);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // addNewFilterButton
            // 
            this.addNewFilterButton.Location = new System.Drawing.Point(497, 22);
            this.addNewFilterButton.Name = "addNewFilterButton";
            this.addNewFilterButton.Size = new System.Drawing.Size(126, 24);
            this.addNewFilterButton.TabIndex = 5;
            this.addNewFilterButton.Text = "Add Filter";
            this.addNewFilterButton.UseVisualStyleBackColor = true;
            this.addNewFilterButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.filterEditor);
            this.groupBox1.Controls.Add(this.andOrDropDow);
            this.groupBox1.Controls.Add(this.criteriaDropDown);
            this.groupBox1.Controls.Add(this.addNewFilterButton);
            this.groupBox1.Controls.Add(this.operatorsDropDown);
            this.groupBox1.Controls.Add(this.filterTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 270);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Criterias";
            // 
            // filterEditor
            // 
            this.filterEditor.Location = new System.Drawing.Point(6, 51);
            this.filterEditor.Name = "filterEditor";
            this.filterEditor.Size = new System.Drawing.Size(617, 213);
            this.filterEditor.TabIndex = 7;
            this.filterEditor.Text = "";
            // 
            // andOrDropDow
            // 
            this.andOrDropDow.AutoCompleteCustomSource.AddRange(new string[] {
            "AND",
            "OR"});
            this.andOrDropDow.Enabled = false;
            this.andOrDropDow.FormattingEnabled = true;
            this.andOrDropDow.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.andOrDropDow.Location = new System.Drawing.Point(6, 21);
            this.andOrDropDow.Name = "andOrDropDow";
            this.andOrDropDow.Size = new System.Drawing.Size(101, 24);
            this.andOrDropDow.TabIndex = 6;
            this.andOrDropDow.Text = "AND/OR";
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.Location = new System.Drawing.Point(834, 52);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(227, 68);
            this.filterButton.TabIndex = 7;
            this.filterButton.TabStop = false;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(834, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 68);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "Reset Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1073, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Data Grid - Nadun Isuru B";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox criteriaDropDown;
        private System.Windows.Forms.ComboBox operatorsDropDown;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button addNewFilterButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox andOrDropDow;
        private System.Windows.Forms.RichTextBox filterEditor;
        private System.Windows.Forms.Button button1;
    }
}

