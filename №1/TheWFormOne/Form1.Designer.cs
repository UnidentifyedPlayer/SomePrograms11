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
            this.NumberOfPlanets = new System.Windows.Forms.Button();
            this.StarName = new System.Windows.Forms.Button();
            this.SystemsNameInput = new System.Windows.Forms.TextBox();
            this.StarsNameInput = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.SystemsName = new System.Windows.Forms.Label();
            this.StarsName = new System.Windows.Forms.Label();
            this.PlanetsName = new System.Windows.Forms.Label();
            this.AddPlanet = new System.Windows.Forms.Button();
            this.PlanetsNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberOfPlanets
            // 
            this.NumberOfPlanets.Location = new System.Drawing.Point(12, 231);
            this.NumberOfPlanets.Name = "NumberOfPlanets";
            this.NumberOfPlanets.Size = new System.Drawing.Size(170, 85);
            this.NumberOfPlanets.TabIndex = 0;
            this.NumberOfPlanets.Text = "Number of Planets";
            this.NumberOfPlanets.UseVisualStyleBackColor = true;
            this.NumberOfPlanets.Click += new System.EventHandler(this.button1_Click);
            // 
            // StarName
            // 
            this.StarName.Location = new System.Drawing.Point(191, 47);
            this.StarName.Name = "StarName";
            this.StarName.Size = new System.Drawing.Size(170, 85);
            this.StarName.TabIndex = 1;
            this.StarName.Text = "Star\'s Name";
            this.StarName.UseVisualStyleBackColor = true;
            this.StarName.Click += new System.EventHandler(this.button2_Click);
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
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(238, 231);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.button4_Click);
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
            // AddPlanet
            // 
            this.AddPlanet.CausesValidation = false;
            this.AddPlanet.Location = new System.Drawing.Point(378, 231);
            this.AddPlanet.Name = "AddPlanet";
            this.AddPlanet.Size = new System.Drawing.Size(170, 85);
            this.AddPlanet.TabIndex = 9;
            this.AddPlanet.Text = "Add Planet";
            this.AddPlanet.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.AddPlanet);
            this.Controls.Add(this.PlanetsName);
            this.Controls.Add(this.StarsName);
            this.Controls.Add(this.SystemsName);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.StarsNameInput);
            this.Controls.Add(this.SystemsNameInput);
            this.Controls.Add(this.StarName);
            this.Controls.Add(this.NumberOfPlanets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumberOfPlanets;
        private System.Windows.Forms.Button StarName;
        private System.Windows.Forms.TextBox SystemsNameInput;
        private System.Windows.Forms.TextBox StarsNameInput;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label SystemsName;
        private System.Windows.Forms.Label StarsName;
        private System.Windows.Forms.Label PlanetsName;
        private System.Windows.Forms.Button AddPlanet;
        private System.Windows.Forms.TextBox PlanetsNameInput;
    }
}

