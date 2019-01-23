namespace TheWFormOne
{
    partial class StarSystemForm
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
            this.ShowNumberOfPlanetsButton = new System.Windows.Forms.Button();
            this.ShowStarNameButton = new System.Windows.Forms.Button();
            this.SystemsNameInputBox = new System.Windows.Forms.TextBox();
            this.StarsNameInputBox = new System.Windows.Forms.TextBox();
            this.ConfirmChangesButton = new System.Windows.Forms.Button();
            this.InputSystemsNameLabel = new System.Windows.Forms.Label();
            this.InputStarsNameLabel = new System.Windows.Forms.Label();
            this.InputPlanetsNameLabel = new System.Windows.Forms.Label();
            this.AddPlanetButton = new System.Windows.Forms.Button();
            this.PlanetsNameInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowNumberOfPlanetsButton
            // 
            this.ShowNumberOfPlanetsButton.Location = new System.Drawing.Point(12, 231);
            this.ShowNumberOfPlanetsButton.Name = "ShowNumberOfPlanetsButton";
            this.ShowNumberOfPlanetsButton.Size = new System.Drawing.Size(170, 85);
            this.ShowNumberOfPlanetsButton.TabIndex = 0;
            this.ShowNumberOfPlanetsButton.Text = "Number of Planets";
            this.ShowNumberOfPlanetsButton.UseVisualStyleBackColor = true;
            this.ShowNumberOfPlanetsButton.Click += new System.EventHandler(this.NumberOfPlanetsButton_Click);
            // 
            // ShowStarNameButton
            // 
            this.ShowStarNameButton.Location = new System.Drawing.Point(191, 47);
            this.ShowStarNameButton.Name = "ShowStarNameButton";
            this.ShowStarNameButton.Size = new System.Drawing.Size(170, 85);
            this.ShowStarNameButton.TabIndex = 1;
            this.ShowStarNameButton.Text = "Star\'s Name";
            this.ShowStarNameButton.UseVisualStyleBackColor = true;
            this.ShowStarNameButton.Click += new System.EventHandler(this.StarNameButton_Click);
            // 
            // SystemsNameInputBox
            // 
            this.SystemsNameInputBox.Location = new System.Drawing.Point(226, 138);
            this.SystemsNameInputBox.Name = "SystemsNameInputBox";
            this.SystemsNameInputBox.Size = new System.Drawing.Size(100, 20);
            this.SystemsNameInputBox.TabIndex = 3;
            // 
            // StarsNameInputBox
            // 
            this.StarsNameInputBox.Location = new System.Drawing.Point(226, 165);
            this.StarsNameInputBox.Name = "StarsNameInputBox";
            this.StarsNameInputBox.Size = new System.Drawing.Size(100, 20);
            this.StarsNameInputBox.TabIndex = 4;
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.Location = new System.Drawing.Point(238, 231);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmChangesButton.TabIndex = 5;
            this.ConfirmChangesButton.Text = "OK";
            this.ConfirmChangesButton.UseVisualStyleBackColor = true;
            this.ConfirmChangesButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InputSystemsNameLabel
            // 
            this.InputSystemsNameLabel.AutoSize = true;
            this.InputSystemsNameLabel.Location = new System.Drawing.Point(118, 141);
            this.InputSystemsNameLabel.Name = "InputSystemsNameLabel";
            this.InputSystemsNameLabel.Size = new System.Drawing.Size(105, 13);
            this.InputSystemsNameLabel.TabIndex = 6;
            this.InputSystemsNameLabel.Text = "Название системы";
            // 
            // InputStarsNameLabel
            // 
            this.InputStarsNameLabel.AutoSize = true;
            this.InputStarsNameLabel.Location = new System.Drawing.Point(139, 168);
            this.InputStarsNameLabel.Name = "InputStarsNameLabel";
            this.InputStarsNameLabel.Size = new System.Drawing.Size(71, 13);
            this.InputStarsNameLabel.TabIndex = 7;
            this.InputStarsNameLabel.Text = "Имя Звезды";
            // 
            // InputPlanetsNameLabel
            // 
            this.InputPlanetsNameLabel.AutoSize = true;
            this.InputPlanetsNameLabel.Location = new System.Drawing.Point(139, 194);
            this.InputPlanetsNameLabel.Name = "InputPlanetsNameLabel";
            this.InputPlanetsNameLabel.Size = new System.Drawing.Size(77, 13);
            this.InputPlanetsNameLabel.TabIndex = 8;
            this.InputPlanetsNameLabel.Text = "Имя Планеты";
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
            this.AddPlanetButton.Click += new System.EventHandler(this.AddPlanetButton_Click);
            // 
            // PlanetsNameInputBox
            // 
            this.PlanetsNameInputBox.Location = new System.Drawing.Point(226, 191);
            this.PlanetsNameInputBox.Name = "PlanetsNameInputBox";
            this.PlanetsNameInputBox.Size = new System.Drawing.Size(100, 20);
            this.PlanetsNameInputBox.TabIndex = 10;
            // 
            // StarSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 389);
            this.Controls.Add(this.PlanetsNameInputBox);
            this.Controls.Add(this.AddPlanetButton);
            this.Controls.Add(this.InputPlanetsNameLabel);
            this.Controls.Add(this.InputStarsNameLabel);
            this.Controls.Add(this.InputSystemsNameLabel);
            this.Controls.Add(this.ConfirmChangesButton);
            this.Controls.Add(this.StarsNameInputBox);
            this.Controls.Add(this.SystemsNameInputBox);
            this.Controls.Add(this.ShowStarNameButton);
            this.Controls.Add(this.ShowNumberOfPlanetsButton);
            this.Name = "StarSystemForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowNumberOfPlanetsButton;
        private System.Windows.Forms.Button ShowStarNameButton;
        private System.Windows.Forms.TextBox SystemsNameInputBox;
        private System.Windows.Forms.TextBox StarsNameInputBox;
        private System.Windows.Forms.Button ConfirmChangesButton;
        private System.Windows.Forms.Label InputSystemsNameLabel;
        private System.Windows.Forms.Label InputStarsNameLabel;
        private System.Windows.Forms.Label InputPlanetsNameLabel;
        private System.Windows.Forms.Button AddPlanetButton;
        private System.Windows.Forms.TextBox PlanetsNameInputBox;
    }
}

