namespace TheWFormOne
{
    partial class Form1
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
            this.NumberOfPlanetsButton = new System.Windows.Forms.Button();
            this.StarNameButton = new System.Windows.Forms.Button();
            this.SystemsNameInput = new System.Windows.Forms.TextBox();
            this.StarsNameInput = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SystemsName = new System.Windows.Forms.Label();
            this.StarsName = new System.Windows.Forms.Label();
            this.PlanetsName = new System.Windows.Forms.Label();
            this.AddPlanetButton = new System.Windows.Forms.Button();
            this.PlanetsNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberOfPlanetsButton
            // 
            this.NumberOfPlanetsButton.Location = new System.Drawing.Point(12, 231);
            this.NumberOfPlanetsButton.Name = "NumberOfPlanetsButton";
            this.NumberOfPlanetsButton.Size = new System.Drawing.Size(170, 85);
            this.NumberOfPlanetsButton.TabIndex = 0;
            this.NumberOfPlanetsButton.Text = "Number of Planets";
            this.NumberOfPlanetsButton.UseVisualStyleBackColor = true;
            this.NumberOfPlanetsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StarNameButton
            // 
            this.StarNameButton.Location = new System.Drawing.Point(191, 47);
            this.StarNameButton.Name = "StarNameButton";
            this.StarNameButton.Size = new System.Drawing.Size(170, 85);
            this.StarNameButton.TabIndex = 1;
            this.StarNameButton.Text = "Star\'s Name";
            this.StarNameButton.UseVisualStyleBackColor = true;
            this.StarNameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SystemsNameInput
            // 
            this.SystemsNameInput.Location = new System.Drawing.Point(226, 138);
            this.SystemsNameInput.Name = "SystemsNameInput";
            this.SystemsNameInput.Size = new System.Drawing.Size(100, 20);
            this.SystemsNameInput.TabIndex = 3;
            // 
            // StarsNameInput
            // 
            this.StarsNameInput.Location = new System.Drawing.Point(226, 165);
            this.StarsNameInput.Name = "StarsNameInput";
            this.StarsNameInput.Size = new System.Drawing.Size(100, 20);
            this.StarsNameInput.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(238, 231);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SystemsName
            // 
            this.SystemsName.AutoSize = true;
            this.SystemsName.Location = new System.Drawing.Point(118, 141);
            this.SystemsName.Name = "SystemsName";
            this.SystemsName.Size = new System.Drawing.Size(105, 13);
            this.SystemsName.TabIndex = 6;
            this.SystemsName.Text = "Название системы";
            // 
            // StarsName
            // 
            this.StarsName.AutoSize = true;
            this.StarsName.Location = new System.Drawing.Point(139, 168);
            this.StarsName.Name = "StarsName";
            this.StarsName.Size = new System.Drawing.Size(71, 13);
            this.StarsName.TabIndex = 7;
            this.StarsName.Text = "Имя Звезды";
            // 
            // PlanetsName
            // 
            this.PlanetsName.AutoSize = true;
            this.PlanetsName.Location = new System.Drawing.Point(139, 194);
            this.PlanetsName.Name = "PlanetsName";
            this.PlanetsName.Size = new System.Drawing.Size(77, 13);
            this.PlanetsName.TabIndex = 8;
            this.PlanetsName.Text = "Имя Планеты";
            // 
            // AddPlanetButton
            // 
            this.AddPlanetButton.CausesValidation = false;
            this.AddPlanetButton.Location = new System.Drawing.Point(378, 231);
            this.AddPlanetButton.Name = "AddPlanetButton";
            this.AddPlanetButton.Size = new System.Drawing.Size(170, 85);
            this.AddPlanetButton.TabIndex = 9;
            this.AddPlanetButton.Text = "Add Planet";
            this.AddPlanetButton.UseVisualStyleBackColor = true;
            // 
            // PlanetsNameInput
            // 
            this.PlanetsNameInput.Location = new System.Drawing.Point(226, 191);
            this.PlanetsNameInput.Name = "PlanetsNameInput";
            this.PlanetsNameInput.Size = new System.Drawing.Size(100, 20);
            this.PlanetsNameInput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 389);
            this.Controls.Add(this.PlanetsNameInput);
            this.Controls.Add(this.AddPlanetButton);
            this.Controls.Add(this.PlanetsName);
            this.Controls.Add(this.StarsName);
            this.Controls.Add(this.SystemsName);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.StarsNameInput);
            this.Controls.Add(this.SystemsNameInput);
            this.Controls.Add(this.StarNameButton);
            this.Controls.Add(this.NumberOfPlanetsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumberOfPlanetsButton;
        private System.Windows.Forms.Button StarNameButton;
        private System.Windows.Forms.TextBox SystemsNameInput;
        private System.Windows.Forms.TextBox StarsNameInput;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label SystemsName;
        private System.Windows.Forms.Label StarsName;
        private System.Windows.Forms.Label PlanetsName;
        private System.Windows.Forms.Button AddPlanetButton;
        private System.Windows.Forms.TextBox PlanetsNameInput;
    }
}

