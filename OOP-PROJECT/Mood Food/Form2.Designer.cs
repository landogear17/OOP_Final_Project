namespace Mood_Food
{
    partial class Form2
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
            this.Rate = new System.Windows.Forms.Label();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rate.Location = new System.Drawing.Point(249, 156);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(51, 28);
            this.Rate.TabIndex = 14;
            this.Rate.Text = "Rate";
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.Location = new System.Drawing.Point(345, 157);
            this.numericUpDownRate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownRate.TabIndex = 13;
            this.numericUpDownRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddFood.Location = new System.Drawing.Point(283, 264);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(158, 41);
            this.buttonAddFood.TabIndex = 15;
            this.buttonAddFood.Text = "Rate Food";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(249, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Food";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFood.Location = new System.Drawing.Point(345, 71);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(65, 28);
            this.labelFood.TabIndex = 20;
            this.labelFood.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(345, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "*Rate each food item";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddFood);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.numericUpDownRate);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Rate;
        private NumericUpDown numericUpDownRate;
        private Button buttonAddFood;
        private Label label2;
        private Label labelFood;
        private Label label1;
    }
}