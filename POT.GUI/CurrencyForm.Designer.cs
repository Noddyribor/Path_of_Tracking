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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mapStrategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStrategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.calculateProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.chaosValueTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalUnitTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mapStrategyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCurrencyToolStripMenuItem});
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.currencyToolStripMenuItem.Text = "Currency";
            // 
            // addCurrencyToolStripMenuItem
            // 
            this.addCurrencyToolStripMenuItem.Name = "addCurrencyToolStripMenuItem";
            this.addCurrencyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCurrencyToolStripMenuItem.Text = "Add Currency";
            this.addCurrencyToolStripMenuItem.Click += new System.EventHandler(this.addCurrencyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSaleToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // newSaleToolStripMenuItem
            // 
            this.newSaleToolStripMenuItem.Name = "newSaleToolStripMenuItem";
            this.newSaleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.newSaleToolStripMenuItem.Text = "New Sale";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // mapStrategyToolStripMenuItem
            // 
            this.mapStrategyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStrategyToolStripMenuItem,
            this.toolStripMenuItem3,
            this.calculateProfitToolStripMenuItem});
            this.mapStrategyToolStripMenuItem.Name = "mapStrategyToolStripMenuItem";
            this.mapStrategyToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.mapStrategyToolStripMenuItem.Text = "Map Strategy";
            // 
            // newStrategyToolStripMenuItem
            // 
            this.newStrategyToolStripMenuItem.Name = "newStrategyToolStripMenuItem";
            this.newStrategyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newStrategyToolStripMenuItem.Text = "New Strategy";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 6);
            // 
            // calculateProfitToolStripMenuItem
            // 
            this.calculateProfitToolStripMenuItem.Name = "calculateProfitToolStripMenuItem";
            this.calculateProfitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.calculateProfitToolStripMenuItem.Text = "Calculate Profit";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameTxtBox.Enabled = false;
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nameTxtBox.Location = new System.Drawing.Point(12, 46);
            this.nameTxtBox.Multiline = true;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(269, 476);
            this.nameTxtBox.TabIndex = 1;
            // 
            // chaosValueTxtBox
            // 
            this.chaosValueTxtBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chaosValueTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chaosValueTxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.chaosValueTxtBox.Enabled = false;
            this.chaosValueTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaosValueTxtBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chaosValueTxtBox.Location = new System.Drawing.Point(287, 46);
            this.chaosValueTxtBox.Multiline = true;
            this.chaosValueTxtBox.Name = "chaosValueTxtBox";
            this.chaosValueTxtBox.Size = new System.Drawing.Size(70, 476);
            this.chaosValueTxtBox.TabIndex = 2;
            this.chaosValueTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Currency Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(287, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chaos";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.quantityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityTxtBox.Enabled = false;
            this.quantityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtBox.Location = new System.Drawing.Point(364, 46);
            this.quantityTxtBox.Multiline = true;
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.ReadOnly = true;
            this.quantityTxtBox.Size = new System.Drawing.Size(75, 476);
            this.quantityTxtBox.TabIndex = 5;
            this.quantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(364, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // totalUnitTxtBox
            // 
            this.totalUnitTxtBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalUnitTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalUnitTxtBox.Enabled = false;
            this.totalUnitTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUnitTxtBox.Location = new System.Drawing.Point(446, 46);
            this.totalUnitTxtBox.Multiline = true;
            this.totalUnitTxtBox.Name = "totalUnitTxtBox";
            this.totalUnitTxtBox.ReadOnly = true;
            this.totalUnitTxtBox.Size = new System.Drawing.Size(113, 476);
            this.totalUnitTxtBox.TabIndex = 7;
            this.totalUnitTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(446, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total per Type";
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalTxtBox.Enabled = false;
            this.totalTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtBox.Location = new System.Drawing.Point(565, 45);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.ReadOnly = true;
            this.totalTxtBox.Size = new System.Drawing.Size(100, 22);
            this.totalTxtBox.TabIndex = 9;
            this.totalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(565, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshBtn.Location = new System.Drawing.Point(722, 46);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseMnemonic = false;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // currencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(858, 525);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalUnitTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chaosValueTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "currencyForm";
            this.Text = "Currency";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.currencyForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mapStrategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStrategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateProfitToolStripMenuItem;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.TextBox chaosValueTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalUnitTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem addCurrencyToolStripMenuItem;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshBtn;
    }
}

