namespace POT.GUI
{
    partial class currencyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateChaosValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.msgTxtBox = new System.Windows.Forms.TextBox();
            this.leagueLabel = new System.Windows.Forms.Label();
            this.leagueTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.potDataSet1 = new POT.Logic.POTDataSet();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chaosValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1123, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.updateChaosValuesToolStripMenuItem});
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveDataToolStripMenuItem.Text = "Data";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // updateChaosValuesToolStripMenuItem
            // 
            this.updateChaosValuesToolStripMenuItem.Name = "updateChaosValuesToolStripMenuItem";
            this.updateChaosValuesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.updateChaosValuesToolStripMenuItem.Text = "Update Chaos Values";
            this.updateChaosValuesToolStripMenuItem.Click += new System.EventHandler(this.updateChaosValuesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(746, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalTxtBox.Location = new System.Drawing.Point(746, 43);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.ReadOnly = true;
            this.totalTxtBox.Size = new System.Drawing.Size(109, 20);
            this.totalTxtBox.TabIndex = 3;
            // 
            // msgTxtBox
            // 
            this.msgTxtBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgTxtBox.Enabled = false;
            this.msgTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTxtBox.Location = new System.Drawing.Point(0, 687);
            this.msgTxtBox.Name = "msgTxtBox";
            this.msgTxtBox.ReadOnly = true;
            this.msgTxtBox.Size = new System.Drawing.Size(1123, 22);
            this.msgTxtBox.TabIndex = 4;
            // 
            // leagueLabel
            // 
            this.leagueLabel.AutoSize = true;
            this.leagueLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leagueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagueLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.leagueLabel.Location = new System.Drawing.Point(746, 143);
            this.leagueLabel.Name = "leagueLabel";
            this.leagueLabel.Size = new System.Drawing.Size(60, 16);
            this.leagueLabel.TabIndex = 5;
            this.leagueLabel.Text = "League";
            this.leagueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leagueTxtBox
            // 
            this.leagueTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leagueTxtBox.Location = new System.Drawing.Point(746, 162);
            this.leagueTxtBox.Name = "leagueTxtBox";
            this.leagueTxtBox.Size = new System.Drawing.Size(109, 20);
            this.leagueTxtBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(861, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.chaosValueDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typeTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.potDataSet1.Currency;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 700);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // potDataSet1
            // 
            this.potDataSet1.DataSetName = "POTDataSet";
            this.potDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 350;
            // 
            // chaosValueDataGridViewTextBoxColumn
            // 
            this.chaosValueDataGridViewTextBoxColumn.DataPropertyName = "ChaosValue";
            this.chaosValueDataGridViewTextBoxColumn.HeaderText = "ChaosValue";
            this.chaosValueDataGridViewTextBoxColumn.Name = "chaosValueDataGridViewTextBoxColumn";
            this.chaosValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // typeTotalDataGridViewTextBoxColumn
            // 
            this.typeTotalDataGridViewTextBoxColumn.DataPropertyName = "TypeTotal";
            this.typeTotalDataGridViewTextBoxColumn.HeaderText = "TypeTotal";
            this.typeTotalDataGridViewTextBoxColumn.Name = "typeTotalDataGridViewTextBoxColumn";
            this.typeTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeTotalDataGridViewTextBoxColumn.Width = 135;
            // 
            // currencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1123, 709);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leagueTxtBox);
            this.Controls.Add(this.leagueLabel);
            this.Controls.Add(this.msgTxtBox);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "currencyForm";
            this.Text = "Currency";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.currencyForm_FormClosing);
            this.Load += new System.EventHandler(this.currencyForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Logic.POTDataSet potDataSet1;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateChaosValuesToolStripMenuItem;
        private System.Windows.Forms.TextBox msgTxtBox;
        private System.Windows.Forms.Label leagueLabel;
        private System.Windows.Forms.TextBox leagueTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chaosValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTotalDataGridViewTextBoxColumn;
    }
}

