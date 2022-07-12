namespace ShopReceipt
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductSelectComboBox = new System.Windows.Forms.ComboBox();
            this.AddToCheckButton = new System.Windows.Forms.Button();
            this.ReceiptDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ProductsManageMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenConfigMenuItem,
            this.SaveConfigMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // OpenConfigMenuItem
            // 
            this.OpenConfigMenuItem.Name = "OpenConfigMenuItem";
            this.OpenConfigMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenConfigMenuItem.Text = "Открыть";
            // 
            // SaveConfigMenuItem
            // 
            this.SaveConfigMenuItem.Name = "SaveConfigMenuItem";
            this.SaveConfigMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveConfigMenuItem.Text = "Сохранить";
            // 
            // ProductsManageMenuItem
            // 
            this.ProductsManageMenuItem.Name = "ProductsManageMenuItem";
            this.ProductsManageMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ProductsManageMenuItem.Text = "Склад";
            this.ProductsManageMenuItem.Click += new System.EventHandler(this.ProductManageMenuItem_Click);
            // 
            // ProductSelectComboBox
            // 
            this.ProductSelectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductSelectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductSelectComboBox.DisplayMember = "Name";
            this.ProductSelectComboBox.FormattingEnabled = true;
            this.ProductSelectComboBox.Location = new System.Drawing.Point(23, 22);
            this.ProductSelectComboBox.Name = "ProductSelectComboBox";
            this.ProductSelectComboBox.Size = new System.Drawing.Size(265, 23);
            this.ProductSelectComboBox.TabIndex = 1;
            this.ProductSelectComboBox.ValueMember = "Price";
            // 
            // AddToCheckButton
            // 
            this.AddToCheckButton.Location = new System.Drawing.Point(23, 51);
            this.AddToCheckButton.Name = "AddToCheckButton";
            this.AddToCheckButton.Size = new System.Drawing.Size(265, 23);
            this.AddToCheckButton.TabIndex = 2;
            this.AddToCheckButton.Text = "Добавить";
            this.AddToCheckButton.UseVisualStyleBackColor = true;
            this.AddToCheckButton.Click += new System.EventHandler(this.AddToCheckButton_Click);
            // 
            // ReceiptDataGridView
            // 
            this.ReceiptDataGridView.AllowUserToAddRows = false;
            this.ReceiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PriceColumn});
            this.ReceiptDataGridView.Location = new System.Drawing.Point(325, 39);
            this.ReceiptDataGridView.Name = "ReceiptDataGridView";
            this.ReceiptDataGridView.ReadOnly = true;
            this.ReceiptDataGridView.RowTemplate.Height = 25;
            this.ReceiptDataGridView.Size = new System.Drawing.Size(311, 331);
            this.ReceiptDataGridView.TabIndex = 3;
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Frozen = true;
            this.PriceColumn.HeaderText = "Стоимость";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductSelectComboBox);
            this.groupBox1.Controls.Add(this.AddToCheckButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление товара в чек";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(325, 373);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(95, 15);
            this.TotalPriceLabel.TabIndex = 5;
            this.TotalPriceLabel.Text = "Итого: 0 рублей";
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(648, 397);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReceiptDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Чек";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ProductsManageMenuItem;
        private ToolStripMenuItem OpenConfigMenuItem;
        private ToolStripMenuItem SaveConfigMenuItem;
        private ComboBox ProductSelectComboBox;
        private Button AddToCheckButton;
        private DataGridView ReceiptDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private GroupBox groupBox1;
        private Label TotalPriceLabel;
    }
}