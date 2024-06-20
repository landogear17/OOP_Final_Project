namespace Mood_Food
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            labelAte = new Label();
            label6 = new Label();
            checkBoxAte = new CheckBox();
            buttonDislikes = new Button();
            checkedListBoxPreference = new CheckedListBox();
            comboBoxlistfood = new ComboBox();
            tabPageAfter = new TabPage();
            groupBox2 = new GroupBox();
            comboBoxFoodtype = new ComboBox();
            label3 = new Label();
            comboBoxTypeofFood = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            buttonMood = new Button();
            buttonAddFood = new Button();
            numericUpDownPortionSize = new NumericUpDown();
            dateTimePickerTimeofDay = new DateTimePicker();
            label2 = new Label();
            tabPageBefore = new TabPage();
            dataGridViewbefore = new DataGridView();
            labelview = new Label();
            groupBox1 = new GroupBox();
            buttonRecommend = new Button();
            label5 = new Label();
            comboBoxMoods = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPageAfter.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortionSize).BeginInit();
            tabPageBefore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewbefore).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPageAfter);
            tabControl1.Controls.Add(tabPageBefore);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1129, 507);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(labelAte);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(checkBoxAte);
            tabPage1.Controls.Add(buttonDislikes);
            tabPage1.Controls.Add(checkedListBoxPreference);
            tabPage1.Controls.Add(comboBoxlistfood);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1121, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Preferences";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(538, 261);
            button1.Name = "button1";
            button1.Size = new Size(162, 52);
            button1.TabIndex = 10;
            button1.Text = "No Allergies/Disliked food";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonDislikes_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(449, 412);
            label9.Name = "label9";
            label9.Size = new Size(81, 12);
            label9.TabIndex = 9;
            label9.Text = "*Check if you did";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(585, 63);
            label8.Name = "label8";
            label8.Size = new Size(64, 35);
            label8.TabIndex = 8;
            label8.Text = "Dish";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(357, 63);
            label7.Name = "label7";
            label7.Size = new Size(94, 35);
            label7.TabIndex = 7;
            label7.Text = "Cuisine";
            // 
            // labelAte
            // 
            labelAte.AutoSize = true;
            labelAte.Location = new Point(286, 438);
            labelAte.Name = "labelAte";
            labelAte.Size = new Size(0, 20);
            labelAte.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(357, 350);
            label6.Name = "label6";
            label6.Size = new Size(277, 20);
            label6.TabIndex = 5;
            label6.Text = "Answer after adding all your preferences";
            // 
            // checkBoxAte
            // 
            checkBoxAte.AutoSize = true;
            checkBoxAte.Location = new Point(428, 385);
            checkBoxAte.Name = "checkBoxAte";
            checkBoxAte.Size = new Size(115, 24);
            checkBoxAte.TabIndex = 4;
            checkBoxAte.Text = "Did You eat?";
            checkBoxAte.UseVisualStyleBackColor = true;
            checkBoxAte.CheckedChanged += checkBoxAte_CheckedChanged;
            // 
            // buttonDislikes
            // 
            buttonDislikes.Location = new Point(328, 261);
            buttonDislikes.Name = "buttonDislikes";
            buttonDislikes.Size = new Size(162, 52);
            buttonDislikes.TabIndex = 2;
            buttonDislikes.Text = "Add Disliked/Allergies";
            buttonDislikes.UseVisualStyleBackColor = true;
            buttonDislikes.Click += buttonDislikes_Click;
            // 
            // checkedListBoxPreference
            // 
            checkedListBoxPreference.FormattingEnabled = true;
            checkedListBoxPreference.Location = new Point(550, 112);
            checkedListBoxPreference.Name = "checkedListBoxPreference";
            checkedListBoxPreference.Size = new Size(150, 70);
            checkedListBoxPreference.TabIndex = 1;
            // 
            // comboBoxlistfood
            // 
            comboBoxlistfood.FormattingEnabled = true;
            comboBoxlistfood.Location = new Point(328, 133);
            comboBoxlistfood.Name = "comboBoxlistfood";
            comboBoxlistfood.Size = new Size(151, 28);
            comboBoxlistfood.TabIndex = 0;
            comboBoxlistfood.SelectedIndexChanged += comboBoxlistfood_SelectedIndexChanged;
            // 
            // tabPageAfter
            // 
            tabPageAfter.Controls.Add(groupBox2);
            tabPageAfter.Location = new Point(4, 29);
            tabPageAfter.Name = "tabPageAfter";
            tabPageAfter.Padding = new Padding(3);
            tabPageAfter.Size = new Size(1121, 474);
            tabPageAfter.TabIndex = 1;
            tabPageAfter.Text = "After";
            tabPageAfter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxFoodtype);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBoxTypeofFood);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(buttonMood);
            groupBox2.Controls.Add(buttonAddFood);
            groupBox2.Controls.Add(numericUpDownPortionSize);
            groupBox2.Controls.Add(dateTimePickerTimeofDay);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(206, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(700, 391);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "After Eating";
            // 
            // comboBoxFoodtype
            // 
            comboBoxFoodtype.FormattingEnabled = true;
            comboBoxFoodtype.Location = new Point(402, 53);
            comboBoxFoodtype.Name = "comboBoxFoodtype";
            comboBoxFoodtype.Size = new Size(151, 28);
            comboBoxFoodtype.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 128);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 8;
            label3.Text = "Portion size";
            // 
            // comboBoxTypeofFood
            // 
            comboBoxTypeofFood.FormattingEnabled = true;
            comboBoxTypeofFood.Location = new Point(196, 55);
            comboBoxTypeofFood.Name = "comboBoxTypeofFood";
            comboBoxTypeofFood.Size = new Size(151, 28);
            comboBoxTypeofFood.TabIndex = 1;
            comboBoxTypeofFood.SelectedIndexChanged += comboBoxTypeofFood_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(316, 317);
            label1.Name = "label1";
            label1.Size = new Size(158, 12);
            label1.TabIndex = 6;
            label1.Text = "*Click after adding all the food had";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 210);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 9;
            label4.Text = "Time of day";
            // 
            // buttonMood
            // 
            buttonMood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMood.Location = new Point(316, 273);
            buttonMood.Name = "buttonMood";
            buttonMood.Size = new Size(158, 41);
            buttonMood.TabIndex = 5;
            buttonMood.Text = "Tell Mood";
            buttonMood.UseVisualStyleBackColor = true;
            buttonMood.Click += buttonMood_Click;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddFood.Location = new Point(89, 273);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(158, 41);
            buttonAddFood.TabIndex = 4;
            buttonAddFood.Text = "Add Food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // numericUpDownPortionSize
            // 
            numericUpDownPortionSize.DecimalPlaces = 1;
            numericUpDownPortionSize.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPortionSize.Location = new Point(252, 130);
            numericUpDownPortionSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPortionSize.Name = "numericUpDownPortionSize";
            numericUpDownPortionSize.Size = new Size(150, 27);
            numericUpDownPortionSize.TabIndex = 2;
            // 
            // dateTimePickerTimeofDay
            // 
            dateTimePickerTimeofDay.CustomFormat = "\"hh:mm tt\"";
            dateTimePickerTimeofDay.Format = DateTimePickerFormat.Time;
            dateTimePickerTimeofDay.ImeMode = ImeMode.NoControl;
            dateTimePickerTimeofDay.Location = new Point(252, 212);
            dateTimePickerTimeofDay.Name = "dateTimePickerTimeofDay";
            dateTimePickerTimeofDay.ShowUpDown = true;
            dateTimePickerTimeofDay.Size = new Size(150, 27);
            dateTimePickerTimeofDay.TabIndex = 3;
            dateTimePickerTimeofDay.Value = new DateTime(2023, 11, 22, 9, 36, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 7;
            label2.Text = "Food type";
            // 
            // tabPageBefore
            // 
            tabPageBefore.Controls.Add(dataGridViewbefore);
            tabPageBefore.Controls.Add(labelview);
            tabPageBefore.Controls.Add(groupBox1);
            tabPageBefore.Location = new Point(4, 29);
            tabPageBefore.Name = "tabPageBefore";
            tabPageBefore.Padding = new Padding(3);
            tabPageBefore.Size = new Size(1121, 474);
            tabPageBefore.TabIndex = 2;
            tabPageBefore.Text = "Before";
            tabPageBefore.UseVisualStyleBackColor = true;
            // 
            // dataGridViewbefore
            // 
            dataGridViewbefore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewbefore.Location = new Point(675, 63);
            dataGridViewbefore.Name = "dataGridViewbefore";
            dataGridViewbefore.RowHeadersWidth = 80;
            dataGridViewbefore.RowTemplate.Height = 29;
            dataGridViewbefore.Size = new Size(303, 387);
            dataGridViewbefore.TabIndex = 13;
            // 
            // labelview
            // 
            labelview.AutoSize = true;
            labelview.Location = new Point(493, 13);
            labelview.Name = "labelview";
            labelview.Size = new Size(0, 20);
            labelview.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonRecommend);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxMoods);
            groupBox1.Location = new Point(39, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 352);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Before Eating";
            // 
            // buttonRecommend
            // 
            buttonRecommend.Location = new Point(163, 248);
            buttonRecommend.Name = "buttonRecommend";
            buttonRecommend.Size = new Size(119, 29);
            buttonRecommend.TabIndex = 12;
            buttonRecommend.Text = "Recommend";
            buttonRecommend.UseVisualStyleBackColor = true;
            buttonRecommend.Click += buttonRecommend_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(99, 130);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 8;
            label5.Text = "Mood";
            // 
            // comboBoxMoods
            // 
            comboBoxMoods.FormattingEnabled = true;
            comboBoxMoods.Location = new Point(222, 134);
            comboBoxMoods.Name = "comboBoxMoods";
            comboBoxMoods.Size = new Size(151, 28);
            comboBoxMoods.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 552);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Mood Food";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPageAfter.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortionSize).EndInit();
            tabPageBefore.ResumeLayout(false);
            tabPageBefore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewbefore).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPageAfter;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox comboBoxTypeofFood;
        private Label label1;
        private Label label4;
        private Button buttonMood;
        private Button buttonAddFood;
        private NumericUpDown numericUpDownPortionSize;
        private DateTimePicker dateTimePickerTimeofDay;
        private Label label2;
        private TabPage tabPageBefore;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox comboBoxMoods;
        private CheckedListBox checkedListBoxPreference;
        private ComboBox comboBoxlistfood;
        private Button buttonDislikes;
        private Label label6;
        private CheckBox checkBoxAte;
        private Label labelAte;
        private ComboBox comboBoxFoodtype;
        private Button buttonRecommend;
        private Label labelview;
        private DataGridView dataGridViewbefore;
        private Label label8;
        private Label label7;
        private Button button1;
        private Label label9;
    }
}