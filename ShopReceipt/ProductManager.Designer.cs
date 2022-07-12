namespace ShopReceipt
{
    partial class ProductManager
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCostNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(25, 80);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(204, 23);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Добавить товар";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(25, 22);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(204, 23);
            this.ProductNameTextBox.TabIndex = 1;
            // 
            // ProductCostNumericUpDown
            // 
            this.ProductCostNumericUpDown.DecimalPlaces = 2;
            this.ProductCostNumericUpDown.Location = new System.Drawing.Point(25, 51);
            this.ProductCostNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.ProductCostNumericUpDown.Name = "ProductCostNumericUpDown";
            this.ProductCostNumericUpDown.Size = new System.Drawing.Size(204, 23);
            this.ProductCostNumericUpDown.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddProductButton);
            this.groupBox1.Controls.Add(this.ProductCostNumericUpDown);
            this.groupBox1.Controls.Add(this.ProductNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(539, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление товара";
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PriceColumn});
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowTemplate.Height = 25;
            this.ProductsDataGridView.Size = new System.Drawing.Size(521, 426);
            this.ProductsDataGridView.TabIndex = 5;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 250;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Стоимость";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 150;
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ProductManager";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.ProductCostNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddProductButton;
        private TextBox ProductNameTextBox;
        private NumericUpDown ProductCostNumericUpDown;
        private GroupBox groupBox1;
        private DataGridView ProductsDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PriceColumn;
    }
}