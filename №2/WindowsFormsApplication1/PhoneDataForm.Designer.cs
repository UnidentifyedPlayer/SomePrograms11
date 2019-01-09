namespace WindowsFormsApplication1
{
    partial class PhoneDataForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvl1PhonesGrid = new System.Windows.Forms.DataGridView();
            this.lvl2PhonesGrid = new System.Windows.Forms.DataGridView();
            this.AddLvl1phone = new System.Windows.Forms.Button();
            this.AddLvl2phone = new System.Windows.Forms.Button();
            this.brandInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.memoryInput = new System.Windows.Forms.TextBox();
            this.lvl1phonesID = new System.Windows.Forms.ComboBox();
            this.numberOfSimsInput = new System.Windows.Forms.TextBox();
            this.brandlabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.memorylabel = new System.Windows.Forms.Label();
            this.simlabel = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1PhonesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2PhonesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lvl1PhonesGrid
            // 
            this.lvl1PhonesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvl1PhonesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.Price,
            this.Memory,
            this.Q});
            this.lvl1PhonesGrid.Location = new System.Drawing.Point(12, 122);
            this.lvl1PhonesGrid.Name = "lvl1PhonesGrid";
            this.lvl1PhonesGrid.Size = new System.Drawing.Size(326, 404);
            this.lvl1PhonesGrid.TabIndex = 0;
            // 
            // lvl2PhonesGrid
            // 
            this.lvl2PhonesGrid.AllowUserToOrderColumns = true;
            this.lvl2PhonesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvl2PhonesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand1,
            this.Price1,
            this.Memory1,
            this.simNumber,
            this.QualityP});
            this.lvl2PhonesGrid.Location = new System.Drawing.Point(387, 98);
            this.lvl2PhonesGrid.Name = "lvl2PhonesGrid";
            this.lvl2PhonesGrid.Size = new System.Drawing.Size(401, 428);
            this.lvl2PhonesGrid.TabIndex = 1;
            // 
            // AddLvl1phone
            // 
            this.AddLvl1phone.Location = new System.Drawing.Point(12, 17);
            this.AddLvl1phone.Name = "AddLvl1phone";
            this.AddLvl1phone.Size = new System.Drawing.Size(137, 23);
            this.AddLvl1phone.TabIndex = 2;
            this.AddLvl1phone.Text = "Add New Level 1 Phone";
            this.AddLvl1phone.UseVisualStyleBackColor = true;
            this.AddLvl1phone.Click += new System.EventHandler(this.AddLvl1phone_Click);
            // 
            // AddLvl2phone
            // 
            this.AddLvl2phone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddLvl2phone.Location = new System.Drawing.Point(245, 17);
            this.AddLvl2phone.Name = "AddLvl2phone";
            this.AddLvl2phone.Size = new System.Drawing.Size(140, 23);
            this.AddLvl2phone.TabIndex = 3;
            this.AddLvl2phone.Text = "Add New Level 2 Phone";
            this.AddLvl2phone.UseVisualStyleBackColor = true;
            this.AddLvl2phone.Click += new System.EventHandler(this.AddLvl2phone_Click);
            // 
            // brandInput
            // 
            this.brandInput.Location = new System.Drawing.Point(12, 44);
            this.brandInput.Name = "brandInput";
            this.brandInput.Size = new System.Drawing.Size(100, 20);
            this.brandInput.TabIndex = 5;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(12, 70);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 20);
            this.priceInput.TabIndex = 6;
            // 
            // memoryInput
            // 
            this.memoryInput.Location = new System.Drawing.Point(12, 96);
            this.memoryInput.Name = "memoryInput";
            this.memoryInput.Size = new System.Drawing.Size(100, 20);
            this.memoryInput.TabIndex = 7;
            // 
            // lvl1phonesID
            // 
            this.lvl1phonesID.FormattingEnabled = true;
            this.lvl1phonesID.Location = new System.Drawing.Point(184, 17);
            this.lvl1phonesID.Name = "lvl1phonesID";
            this.lvl1phonesID.Size = new System.Drawing.Size(55, 21);
            this.lvl1phonesID.TabIndex = 9;
            // 
            // numberOfSimsInput
            // 
            this.numberOfSimsInput.Location = new System.Drawing.Point(175, 44);
            this.numberOfSimsInput.Name = "numberOfSimsInput";
            this.numberOfSimsInput.Size = new System.Drawing.Size(78, 20);
            this.numberOfSimsInput.TabIndex = 10;
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.Location = new System.Drawing.Point(118, 47);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(35, 13);
            this.brandlabel.TabIndex = 11;
            this.brandlabel.Text = "Brand";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(118, 73);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(31, 13);
            this.pricelabel.TabIndex = 12;
            this.pricelabel.Text = "Price";
            // 
            // memorylabel
            // 
            this.memorylabel.AutoSize = true;
            this.memorylabel.Location = new System.Drawing.Point(118, 98);
            this.memorylabel.Name = "memorylabel";
            this.memorylabel.Size = new System.Drawing.Size(44, 13);
            this.memorylabel.TabIndex = 13;
            this.memorylabel.Text = "Memory";
            // 
            // simlabel
            // 
            this.simlabel.AutoSize = true;
            this.simlabel.Location = new System.Drawing.Point(259, 47);
            this.simlabel.Name = "simlabel";
            this.simlabel.Size = new System.Drawing.Size(85, 13);
            this.simlabel.TabIndex = 14;
            this.simlabel.Text = "Number of SIM\'s";
            // 
            // Brand
            // 
            this.Brand.Frozen = true;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 50;
            // 
            // Memory
            // 
            this.Memory.Frozen = true;
            this.Memory.HeaderText = "Memory";
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            this.Memory.Width = 50;
            // 
            // Q
            // 
            this.Q.Frozen = true;
            this.Q.HeaderText = "Quality";
            this.Q.Name = "Q";
            this.Q.ReadOnly = true;
            this.Q.Width = 75;
            // 
            // Brand1
            // 
            this.Brand1.Frozen = true;
            this.Brand1.HeaderText = "Brand";
            this.Brand1.Name = "Brand1";
            this.Brand1.ReadOnly = true;
            // 
            // Price1
            // 
            this.Price1.Frozen = true;
            this.Price1.HeaderText = "Price";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            this.Price1.Width = 50;
            // 
            // Memory1
            // 
            this.Memory1.Frozen = true;
            this.Memory1.HeaderText = "Memory";
            this.Memory1.Name = "Memory1";
            this.Memory1.ReadOnly = true;
            this.Memory1.Width = 50;
            // 
            // simNumber
            // 
            this.simNumber.Frozen = true;
            this.simNumber.HeaderText = "Number of SIM\'s";
            this.simNumber.Name = "simNumber";
            this.simNumber.ReadOnly = true;
            this.simNumber.Width = 50;
            // 
            // QualityP
            // 
            this.QualityP.HeaderText = "QualityP";
            this.QualityP.Name = "QualityP";
            this.QualityP.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.simlabel);
            this.Controls.Add(this.memorylabel);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.brandlabel);
            this.Controls.Add(this.numberOfSimsInput);
            this.Controls.Add(this.lvl1phonesID);
            this.Controls.Add(this.memoryInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.brandInput);
            this.Controls.Add(this.AddLvl2phone);
            this.Controls.Add(this.AddLvl1phone);
            this.Controls.Add(this.lvl2PhonesGrid);
            this.Controls.Add(this.lvl1PhonesGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lvl1PhonesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2PhonesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lvl1PhonesGrid;
        private System.Windows.Forms.DataGridView lvl2PhonesGrid;
        private System.Windows.Forms.Button AddLvl1phone;
        private System.Windows.Forms.Button AddLvl2phone;
        private System.Windows.Forms.TextBox brandInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox memoryInput;
        private System.Windows.Forms.ComboBox lvl1phonesID;
        private System.Windows.Forms.TextBox numberOfSimsInput;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label memorylabel;
        private System.Windows.Forms.Label simlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory1;
        private System.Windows.Forms.DataGridViewTextBoxColumn simNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityP;
    }
}

