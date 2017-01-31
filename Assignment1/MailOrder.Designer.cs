namespace Assignment1
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spanishbutton = new System.Windows.Forms.RadioButton();
            this.frenchbutton = new System.Windows.Forms.RadioButton();
            this.englishbutton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.id_input = new System.Windows.Forms.TextBox();
            this.hours_input = new System.Windows.Forms.TextBox();
            this.monthly_input = new System.Windows.Forms.TextBox();
            this.bonus_output = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spanishbutton);
            this.groupBox1.Controls.Add(this.frenchbutton);
            this.groupBox1.Controls.Add(this.englishbutton);
            this.groupBox1.Location = new System.Drawing.Point(204, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // spanishbutton
            // 
            this.spanishbutton.AutoSize = true;
            this.spanishbutton.Location = new System.Drawing.Point(16, 87);
            this.spanishbutton.Name = "spanishbutton";
            this.spanishbutton.Size = new System.Drawing.Size(63, 17);
            this.spanishbutton.TabIndex = 2;
            this.spanishbutton.Text = "Español";
            this.spanishbutton.UseVisualStyleBackColor = true;
            this.spanishbutton.CheckedChanged += new System.EventHandler(this.spanishbutton_CheckedChanged);
            // 
            // frenchbutton
            // 
            this.frenchbutton.AutoSize = true;
            this.frenchbutton.Location = new System.Drawing.Point(16, 58);
            this.frenchbutton.Name = "frenchbutton";
            this.frenchbutton.Size = new System.Drawing.Size(65, 17);
            this.frenchbutton.TabIndex = 1;
            this.frenchbutton.Text = "Français";
            this.frenchbutton.UseVisualStyleBackColor = true;
            this.frenchbutton.CheckedChanged += new System.EventHandler(this.frenchbutton_CheckedChanged);
            // 
            // englishbutton
            // 
            this.englishbutton.AutoSize = true;
            this.englishbutton.Checked = true;
            this.englishbutton.Location = new System.Drawing.Point(16, 30);
            this.englishbutton.Name = "englishbutton";
            this.englishbutton.Size = new System.Drawing.Size(59, 17);
            this.englishbutton.TabIndex = 0;
            this.englishbutton.TabStop = true;
            this.englishbutton.Text = "English";
            this.englishbutton.UseVisualStyleBackColor = true;
            this.englishbutton.CheckedChanged += new System.EventHandler(this.englishbutton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Hours Worked:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Monthly Sales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sales Bonus:";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(155, 196);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(142, 20);
            this.name_input.TabIndex = 7;
            this.name_input.TextChanged += new System.EventHandler(this.name_input_TextChanged);
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(155, 226);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(142, 20);
            this.id_input.TabIndex = 8;
            this.id_input.TextChanged += new System.EventHandler(this.id_input_TextChanged);
            // 
            // hours_input
            // 
            this.hours_input.Location = new System.Drawing.Point(155, 256);
            this.hours_input.Name = "hours_input";
            this.hours_input.Size = new System.Drawing.Size(142, 20);
            this.hours_input.TabIndex = 9;
            this.hours_input.TextChanged += new System.EventHandler(this.hours_input_TextChanged);
            // 
            // monthly_input
            // 
            this.monthly_input.Location = new System.Drawing.Point(155, 286);
            this.monthly_input.Name = "monthly_input";
            this.monthly_input.Size = new System.Drawing.Size(142, 20);
            this.monthly_input.TabIndex = 10;
            this.monthly_input.TextChanged += new System.EventHandler(this.monthly_input_TextChanged);
            // 
            // bonus_output
            // 
            this.bonus_output.Location = new System.Drawing.Point(155, 316);
            this.bonus_output.Name = "bonus_output";
            this.bonus_output.ReadOnly = true;
            this.bonus_output.Size = new System.Drawing.Size(142, 20);
            this.bonus_output.TabIndex = 11;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(16, 362);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 12;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(124, 361);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(75, 23);
            this.print_button.TabIndex = 13;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(232, 361);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 14;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 397);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.bonus_output);
            this.Controls.Add(this.monthly_input);
            this.Controls.Add(this.hours_input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SalesForm";
            this.Text = "Sales Bonus";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton spanishbutton;
        private System.Windows.Forms.RadioButton frenchbutton;
        private System.Windows.Forms.RadioButton englishbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.TextBox hours_input;
        private System.Windows.Forms.TextBox monthly_input;
        private System.Windows.Forms.TextBox bonus_output;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button clear_button;
    }
}

